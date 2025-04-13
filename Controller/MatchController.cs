using StatsTracker.Classes;
using StatsTracker.Enums;
using StatsTracker.Events;
using StatsTracker.Model;
using StatsTracker.Utils;
using StatsTracker.View_Elements;
using StatsTracker.Views;
using Timer = System.Windows.Forms.Timer;

namespace StatsTracker.Controller;

/// <summary>
/// Controller class used when inputting stats into a match.
/// </summary>
public class MatchController : IStatsController
{
    private Match _match;
    private MatchView _view;
    private PlayerSelectWindow? _selectWindow = null;
    private CreateMatchController? _createMatchController = null;
    private IStatsController? _openStatsController = null;

    private Timer? _timeDisplayTimer;

    private string? _filePath;

    public MatchController()
    {
        _match = new Match();
        _view = new MatchView();
        
        BindViewEvents();
        BindTimerButtons();
        SetTeamDataInView();
        SetupStatisticBars();
    }
    
    public MatchController(Match match)
    {
        _match = match;
        _view = new MatchView();
        
        BindViewEvents();
        BindTimerButtons();
        SetTeamDataInView();
        SetupStatisticBars();
    }

    public IStatsView GetView()
    {
        return _view;
    }

    public DialogResult ShowDialog()
    {
        return _view.GetForm().ShowDialog();
    }

    /// <summary>
    /// Binds events from the match view.
    /// </summary>
    private void BindViewEvents()
    {
        _view.OnStatEntered += OnStatEntered;
        _view.OnNewGamePressed += OpenCreateMatchMenu;
        _view.OnSaveGamePressed += SaveGame;
        _view.OnSaveAsGamePressed += SaveGameAsJson;
        _view.OnOpenGamePressed += OpenGame;
        _view.OnAllStatsPressed += OpenAllStatsView;
    }

    /// <summary>
    /// Called when a stat is entered on the pitch input of the match view.
    /// </summary>
    /// <param name="sender">The object which sent the event.</param>
    /// <param name="inputStatEventArgs">The input arguments for the statistic.</param>
    private void OnStatEntered(object? sender, InputStatEventArgs inputStatEventArgs)
    {
        if (inputStatEventArgs is KickOutEventArgs kickOutEventArgs)
        {
            if (kickOutEventArgs.ResultType == KickOutResultType.Lost 
                || kickOutEventArgs.ResultType == KickOutResultType.LostMark
                || kickOutEventArgs.ResultType == KickOutResultType.LostBreak)
            {
                // If the kick out is lost, don't show a player select window.
                kickOutEventArgs.Team = _match.GetInPossessionTeam();
                _match.AddEvent(kickOutEventArgs);
                UpdateView();
                return;
            }
        }
        
        if (inputStatEventArgs is ShotEventArgs shotEventArgs)
        {
            _selectWindow = new ActionSelectWindow(_match.GetTeamForEvent(inputStatEventArgs.EventType), shotEventArgs);
            BindActionViewEvents();
            _selectWindow.ShowDialog();
        }
        else
        {
            _selectWindow = new PlayerSelectWindow(_match.GetTeamForEvent(inputStatEventArgs.EventType), inputStatEventArgs);
            BindActionViewEvents();
            _selectWindow.ShowDialog();
        }
    }

    /// <summary>
    /// Binds events for the action input view.
    /// </summary>
    private void BindActionViewEvents()
    {
        if (_selectWindow != null)
        {
            _selectWindow.OnEnterStatClicked += OnEnterStatClicked;
            _selectWindow.OnCancelled += OnEnterStatCancelled;
        }
    }

    /// <summary>
    /// Unbinds the events from the action input view.
    /// </summary>
    private void UnbindActionViewEvents()
    {
        if (_selectWindow != null)
        {
            _selectWindow.OnEnterStatClicked -= OnEnterStatClicked;
            _selectWindow.OnCancelled -= OnEnterStatCancelled;
            _selectWindow.Close();
            _selectWindow = null;
        }
    }

    /// <summary>
    /// Adds a match event to the match when fired.
    /// Unbinds the events from the action input view.
    /// </summary>
    /// <param name="sender">The object which sends the event.</param>
    /// <param name="inputStatEventArgs">The input stat event arguments as part of the fired event.</param>
    private void OnEnterStatClicked(object? sender, InputStatEventArgs inputStatEventArgs)
    {
        _match.AddEvent(inputStatEventArgs);
        UpdateView();
        UnbindActionViewEvents();
    }

    /// <summary>
    /// Closes and unbinds the events from the action input view.
    /// </summary>
    /// <param name="sender">The object which sends the event.</param>
    /// <param name="eventArgs">The event arguments of the event.</param>
    private void OnEnterStatCancelled(object? sender, EventArgs eventArgs)
    {
        UnbindActionViewEvents();
    }

    /// <summary>
    /// Binds the timer events of the view.
    /// </summary>
    private void BindTimerButtons()
    {
        _view.OnTimerStartStopPressed += OnStartStopButtonClicked;
        _view.OnTimerPausePressed += OnTimerPausePressed;
    }

    /// <summary>
    /// Starts the match and display timer. If they are already started they are stopped.
    /// </summary>
    /// <param name="sender">The sender of the event.</param>
    /// <param name="e">The event args passed with the event.</param>
    private void OnStartStopButtonClicked(object? sender, EventArgs e)
    {
        _match.StartHalf();
        SetHalfLabelText();
        _view.GetStartStopButton().Text = !_match.IsMatchPlaying() ? "Start" : "Stop";

        if (_timeDisplayTimer is null)
        {
            _timeDisplayTimer = new Timer();
            _timeDisplayTimer.Interval = 1000;
            _timeDisplayTimer.Tick += UpdateTimeDisplay;
            _timeDisplayTimer.Start();
        }
    }

    private void SetHalfLabelText()
    {
        int half = _match.GetHalf();
        if (half == 1)
        {
            _view.GetHalfLabel().Text = "First Half";
        }
        else if (half == 2)
        {
            _view.GetHalfLabel().Text = "Second Half";
        }
    }

    /// <summary>
    /// Called when the pause button is pressed. If the timer is enabled it pauses it and pauses the display timer.
    /// If the timer is paused, it will be resumed.
    /// </summary>
    /// <param name="sender">The sender of the event.</param>
    /// <param name="e">The event args passed with the event.</param>
    private void OnTimerPausePressed(object? sender, EventArgs e)
    {
        if (_timeDisplayTimer is null)
        {
            return;
        }
        
        _match.PauseTimer();

        if (_timeDisplayTimer.Enabled)
        {
            _timeDisplayTimer.Stop();
            _view.GetPauseButton().Text = "Resume";
        }
        else
        {
            _timeDisplayTimer.Start();
            _view.GetPauseButton().Text = "Pause";
        }
        
    }

    private void UpdateTimeDisplay(object? sender, EventArgs e)
    {
        TimeSpan elapsedTime = _match.GetElapsedTime();
        _view.GetMinutesLabel().Text = GetTimeValue(elapsedTime.Minutes);
        _view.GetSecondsLabel().Text = GetTimeValue(elapsedTime.Seconds);
    }

    /// <summary>
    /// Returns the time value as a string. If the value is 1 second, it will return 01 for clearer display in the view.
    /// </summary>
    /// <param name="timeValue">The int value of the time.</param>
    /// <returns>The time value as formatted string.</returns>
    private string GetTimeValue(int timeValue)
    {
        if (timeValue < 10)
        {
            return "0" + timeValue;
        }
        
        return timeValue.ToString();
    }
    
    #region View Displays
    private void SetTeamDataInView()
    {
        string homeTeamName = string.IsNullOrEmpty(_match.HomeTeam.TeamName)
            ? "Home Team"
            : _match.HomeTeam.TeamName;
        
        string awayTeamName = string.IsNullOrEmpty(_match.AwayTeam.TeamName) 
            ? "Away Team" 
            : _match.AwayTeam.TeamName;
        
        _view.GetHomeTeamNameLabel().Text = homeTeamName;
        _view.GetAwayTeamNameLabel().Text = awayTeamName;
    }

    private void SetupStatisticBars()
    {
        StatisticBar[] bars = _view.GetAllStatisticBars();
        foreach (var statsBar in bars)
        {
            SetupStatisticBar(statsBar);
        }
    }

    private void SetupStatisticBar(StatisticBar statisticBar)
    {
        statisticBar.InitialiseValues();
        statisticBar.SetTeamColors(_match.HomeTeam.TeamColor, _match.AwayTeam.TeamColor);
    }
    
    private void UpdateView()
    {
        UpdateTurnOversBar();
        UpdateKickOutsWonBar();
        UpdatePointShotsBar();
        UpdateGoalShotsBar();
        UpdateWidesBar();
        UpdateFreesBar();
    }

    private void UpdateTurnOversBar()
    {
        StatisticPair turnOvers = _match.GetTurnOvers();
        if (turnOvers.IsStatisticsEmpty())
        {
            return;
        }
        
        StatisticBar bar = _view.GetTurnoverStatisticBar();
        
        bar.UpdateValues(turnOvers.HomeTeamValue, turnOvers.AwayTeamValue);
    }

    private void UpdateKickOutsWonBar()
    {
        StatisticPair kickOutsWon = _match.GetKickOutsWon();
        if (kickOutsWon.IsStatisticsEmpty())
        {
            return;
        }
        
        _view.GetKickoutStatisticBar().UpdateValues(kickOutsWon.HomeTeamValue, kickOutsWon.AwayTeamValue);
    }

    private void UpdatePointShotsBar()
    {
        StatisticPair pointShots = _match.GetStatisticForEvent(EventType.PointShot);
        if (pointShots.IsStatisticsEmpty())
        {
            return;
        }
        
        _view.GetShotsStatisticBar().UpdateValues(pointShots.HomeTeamValue, pointShots.AwayTeamValue);
    }

    private void UpdateGoalShotsBar()
    {
        StatisticPair goalShots = _match.GetStatisticForEvent(EventType.GoalShot);
        if (goalShots.IsStatisticsEmpty())
        {
            return;
        }
        
        _view.GetGoalShotsStatisticBar().UpdateValues(goalShots.HomeTeamValue, goalShots.AwayTeamValue);
    }

    private void UpdateWidesBar()
    {
        StatisticPair wides = _match.GetStatisticForShotResult(ShotResultType.Wide);
        if (wides.IsStatisticsEmpty())
        {
            return;
        }
        
        _view.GetWidesStatisticBar().UpdateValues(wides.HomeTeamValue, wides.AwayTeamValue);
    }

    private void UpdateFreesBar()
    {
        StatisticPair frees = _match.GetFrees();
        if (frees.IsStatisticsEmpty())
        {
            return;
        }
        
        _view.GetFreeStatisticBar().UpdateValues(frees.HomeTeamValue, frees.AwayTeamValue);
    }
    #endregion
    
    #region Create Match
    private void OpenCreateMatchMenu(object? sender, EventArgs e)
    {
        _createMatchController = new CreateMatchController();
        _createMatchController.OnTeamSelected += CreateNewMatch;
        _createMatchController.OnCancelBtnClick += CloseCreateMatchMenu;

        _createMatchController.ShowDialog();
    }

    private void CreateNewMatch(object? sender, TeamSelectedEventArgs e)
    {
        _match =  new Match(new Team(e.HomeTeamName, e.HomeTeamColor, e.HomePlayers.ToList()), new Team(e.AwayTeamName, e.AwayTeamColor, e.AwayPlayers.ToList()));
        SetTeamDataInView();
        _filePath = null;
        SetupStatisticBars();
        CloseCreateMatchMenu(sender, e);
    }

    private void CloseCreateMatchMenu(object? sender, EventArgs e)
    {
        _createMatchController?.GetView().GetForm().Close();
    }
    #endregion
    
    #region Save/Open Game
    private void SaveGame(object? sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(_filePath))
        {
            SaveGameAsJson(sender, e);
            return;
        }
        
        JSONHelper.SaveToJsonFile(_filePath, _match);
    }

    private void SaveGameAsJson(object? sender, EventArgs e)
    {
        SaveFileDialog saveDialog = _view.GetSaveFileDialog();
        saveDialog.Filter = "JSON files (*.json)|*.json";
        saveDialog.Title = "Save Game As JSON";

        if (saveDialog.ShowDialog() == DialogResult.OK)
        {
            if (string.IsNullOrEmpty(saveDialog.FileName))
            {
                return;
            }
            
            _filePath = saveDialog.FileName;
            
            JSONHelper.SaveToJsonFile(_filePath, _match);
        }
    }

    private void OpenGame(object? sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = _view.GetOpenFileDialog();
        openFileDialog.Filter = "JSON files (*.json)|*.json";
        openFileDialog.Title = "Open Game";

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            if (string.IsNullOrEmpty(openFileDialog.FileName))
            {
                return;
            }
            
            _filePath = openFileDialog.FileName;
            
            Match? loadedMatch = JSONHelper.LoadFromJsonFile<Match>(_filePath);
            if (loadedMatch == null)
            {
                return;
            }
            
            _match = loadedMatch;
            SetTeamDataInView();
            SetupStatisticBars();
        }
    }
    #endregion
    
    #region Stats Views
    private void OpenAllStatsView(object? sender, EventArgs e)
    {
        // TODO create new view here
        _openStatsController = new AllStatsController(_match);
        _openStatsController.ShowDialog();
    }
    #endregion
}