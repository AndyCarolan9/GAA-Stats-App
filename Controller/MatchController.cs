using System.ComponentModel;
using StatsTracker.Classes;
using StatsTracker.Enums;
using StatsTracker.Events;
using StatsTracker.Model;
using StatsTracker.Utils;
using StatsTracker.View_Elements;
using StatsTracker.Views;
using StatsTracker.Views.Graphs;
using StatsTracker.Views.PlayerSelectViews;
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
    private static Timer _autosaveTimer;

    private Timer? _timeDisplayTimer;

    private string? _filePath;

    public MatchController()
    {
        _match = new Match();
        _view = new MatchView();
        _view.Text = "GAA Intelligence";
        
        BindViewEvents();
        BindTimerButtons();
        SetTeamDataInView();
        SetupStatisticBars();
    }
    
    public MatchController(Match match)
    {
        _match = match;
        _view = new MatchView();
        _view.Text = "GAA Intelligence";
        
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
        _view.OnNewGamePressed += OpenCreateMatchMenu;
        _view.OnSaveGamePressed += SaveGame;
        _view.OnSaveAsGamePressed += SaveGameAsJson;
        _view.OnOpenGamePressed += OpenGame;
        _view.OnContextMenuOpened += ContextMenuOpened;
        _view.OnOpenSubsButtonPressed += OpenSubMenu;
        _view.OnCopySelectedEvent += CopySelectedEvent;
        _view.GetHomeCardsButton().Click += OpenCardsMenu;
        _view.GetAwayCardsButton().Click += OpenCardsMenu;

        _view.GetEventListBox().MouseDoubleClick += RightClickEventBox;
        _view.GetEventListContextMenu().Opening += EventListContextMenuOnOpening;
        
        #region Stats view Events
        _view.OnAllStatsPressed += OpenAllStatsView;
        _view.OnScorersButtonPressed += ScorersButtonPressed;
        _view.OnScoreTimeLinePressed += ScoreTimeLinePressed;
        _view.OnEventTimeLinePressed += EventTimeLinePressed;
        _view.GetPlayerPerformanceButton().Click += PlayerPerformanceClicked;
        #endregion

        #region Export Events
        _view.OnExportJournalistData += ExportJournalistData;
        #endregion
    }

    #region Context Menu
    private void ContextMenuOpened(object? sender, EventArgs e)
    {
        if (!_match.IsMatchValid() || !_match.IsMatchPlaying())
        {
            return;
        }
        
        ContextMenuStrip eventInputMenu = _view.GetEventContextMenu();
        eventInputMenu.Items.Clear();
        
        ToolStripMenuItem pointShot = new ToolStripMenuItem("Point Shot");
        pointShot.Name = "PointShot";
        AddSubMenuItemsForShots(pointShot);
        eventInputMenu.Items.Add(pointShot);
        
        ToolStripMenuItem goalShot = new ToolStripMenuItem("Goal Shot");
        goalShot.Name = "GoalShot";
        AddSubMenuItemsForShots(goalShot);
        eventInputMenu.Items.Add(goalShot);
        
        ToolStripMenuItem longShot = new ToolStripMenuItem("Double Point Shot");
        longShot.Name = "DoublePointShot";
        AddSubMenuItemsForShots(longShot);
        eventInputMenu.Items.Add(longShot);

        ToolStripMenuItem turnOverWon = new ToolStripMenuItem("Turnover Won");
        turnOverWon.Name = "TurnOverWon";
        AddSubMenuItemsForTurnovers(turnOverWon);
        eventInputMenu.Items.Add(turnOverWon);

        ToolStripMenuItem turnOverLost = new ToolStripMenuItem("Turnover Lost");
        turnOverLost.Name = "TurnOverLost";
        AddSubMenuItemsForTurnovers(turnOverLost);
        eventInputMenu.Items.Add(turnOverLost);
        
        ToolStripMenuItem kickout = new ToolStripMenuItem("Kick Out");
        eventInputMenu.Items.Add(kickout);
        
        ToolStripMenuItem kickoutWon = new ToolStripMenuItem("Won");
        kickoutWon.Name = "Won";
        kickoutWon.MouseDown += KickOutItemClicked;
        kickout.DropDownItems.Add(kickoutWon);
        
        ToolStripMenuItem kickoutWonMark = new ToolStripMenuItem("Won Mark");
        kickoutWonMark.Name = "WonMark";
        kickoutWonMark.MouseDown += KickOutItemClicked;
        kickout.DropDownItems.Add(kickoutWonMark);
        
        ToolStripMenuItem kickoutWonBreak = new ToolStripMenuItem("Won Break");
        kickoutWonBreak.Name = "WonBreak";
        kickoutWonBreak.MouseDown += KickOutItemClicked;
        kickout.DropDownItems.Add(kickoutWonBreak);
        
        ToolStripMenuItem kickoutLost = new ToolStripMenuItem("Lost");
        kickoutLost.Name = "Lost";
        kickoutLost.MouseDown += KickOutItemClicked;
        kickout.DropDownItems.Add(kickoutLost);
        
        ToolStripMenuItem kickoutLostMark = new ToolStripMenuItem("Lost Mark");
        kickoutLostMark.Name = "LostMark";
        kickoutLostMark.MouseDown += KickOutItemClicked;
        kickout.DropDownItems.Add(kickoutLostMark);
        
        ToolStripMenuItem kickoutLostBreak = new ToolStripMenuItem("Lost Break");
        kickoutLostBreak.Name = "LostBreak";
        kickoutLostBreak.MouseDown += KickOutItemClicked;
        kickout.DropDownItems.Add(kickoutLostBreak);
        
        ToolStripMenuItem freeConceded = new ToolStripMenuItem("Free Conceded");
        freeConceded.Name = "FreeConceded";
        freeConceded.MouseDown += EventInputMenu_ItemClicked;
        eventInputMenu.Items.Add(freeConceded);

        ToolStripMenuItem throwInWon = new ToolStripMenuItem("Throw In Won");
        throwInWon.Name = "ThrowInWon";
        eventInputMenu.Items.Add(throwInWon);
        
        ToolStripMenuItem throwInWonHome = new ToolStripMenuItem(_match.HomeTeam.TeamName);
        throwInWonHome.Name = _match.HomeTeam.TeamName;
        throwInWonHome.MouseDown += ThrowInWonItemClicked;
        throwInWon.DropDownItems.Add(throwInWonHome);
        
        ToolStripMenuItem throwInWonAway = new ToolStripMenuItem(_match.AwayTeam.TeamName);
        throwInWonAway.Name = _match.AwayTeam.TeamName;
        throwInWonAway.MouseDown += ThrowInWonItemClicked;
        throwInWon.DropDownItems.Add(throwInWonAway);
    }

    private void ThrowInWonItemClicked(object? sender, EventArgs e)
    {
        if (sender is null)
        {
            return;
        }
        
        Team team = _match.HomeTeam.TeamName == ((ToolStripMenuItem)sender).Name ? _match.HomeTeam : _match.AwayTeam;
        
        OnStatEntered(new InputStatEventArgs()
        {
            EventType = EventType.ThrowInWon,
            Location = _view.GetInputLocation(),
            Team = team
        });
    }
    
    /// <summary>
    /// Called when a button of the context menu is clicked.
    /// </summary>
    /// <param name="sender">The object which sent the event.</param>
    /// <param name="mouseEventArgs">The mouse event arguments of the fired event.</param>
    private void EventInputMenu_ItemClicked(object? sender, MouseEventArgs mouseEventArgs)
    {
        if (sender is null)
        {
            return;
        }
        
        string? eventName = ((ToolStripMenuItem)sender).Name;
        if (eventName == null)
        {
            return;
        }
        
        Enum.TryParse(eventName, out EventType eventType);
        OnStatEntered(new InputStatEventArgs() { EventType = eventType, Location = _view.GetInputLocation() });
    }

    private void ShotItemClicked(object? sender, MouseEventArgs mouseEventArgs)
    {
        if (sender is null)
        {
            return;
        }
        
        ToolStripMenuItem item = (ToolStripMenuItem)sender;
        ToolStrip? toolStrip = item.GetCurrentParent();
        if (toolStrip is null)
        {
            return;
        }
        
        string? name = toolStrip.AccessibilityObject.Name;
        if (name is null)
        {
            return;
        }
        
        Enum.TryParse(name.Replace(" ", ""), out EventType eventType);
        Enum.TryParse(item.Name, out ShotResultType resultType);
        ShotEventArgs shotEventArgs = new ShotEventArgs() { Location = _view.GetInputLocation(), EventType = eventType, 
            ResultType = resultType };
        OnStatEntered(shotEventArgs);
    }

    private void TurnoverItemClick(object? sender, MouseEventArgs mouseEventArgs)
    {
        if (sender is null)
        {
            return;
        }
        
        ToolStripMenuItem item = (ToolStripMenuItem)sender;
        ToolStrip? toolStrip = item.GetCurrentParent();
        if (toolStrip is null)
        {
            return;
        }
        
        string? name = toolStrip.AccessibilityObject.Name;
        if (name is null)
        {
            return;
        }
        
        Enum.TryParse(name.Replace(" ", ""), out EventType eventType);
        Enum.TryParse(item.Name, out TurnoverType turnoverType);
        TurnoverEventArgs turnOverEventArgs = new TurnoverEventArgs()
        {
            Location = _view.GetInputLocation(), EventType = eventType,
            TurnoverType = turnoverType
        };
        OnStatEntered(turnOverEventArgs);
    }

    private void KickOutItemClicked(object? sender, MouseEventArgs mouseEventArgs)
    {
        if (sender is null)
        {
            return;
        }
        
        ToolStripMenuItem item = (ToolStripMenuItem)sender;
        ToolStrip? toolStrip = item.GetCurrentParent();
        if (toolStrip is null)
        {
            return;
        }
        
        string? name = toolStrip.AccessibilityObject.Name;
        if (name is null)
        {
            return;
        }
        
        Enum.TryParse(name.Replace(" ", ""), out EventType eventType);
        Enum.TryParse(item.Name, out KickOutResultType resultType);
        KickOutEventArgs kickOutEventArgs = new KickOutEventArgs() { EventType = eventType, Location = _view.GetInputLocation(), 
            ResultType = resultType };
        OnStatEntered(kickOutEventArgs);
    }

    private void AddSubMenuItemsForShots(ToolStripMenuItem parent)
    {
        if (parent.Name == "PointShot")
        {
            ToolStripMenuItem pointScored = new ToolStripMenuItem("Point Scored");
            pointScored.Name = "Point";
            pointScored.MouseDown += ShotItemClicked;
            parent.DropDownItems.Add(pointScored);
            
            ToolStripMenuItem shortShot = new ToolStripMenuItem("Short");
            shortShot.Name = "Short";
            shortShot.MouseDown += ShotItemClicked;
            parent.DropDownItems.Add(shortShot);
        }

        if (parent.Name == "GoalShot")
        {
            ToolStripMenuItem pointScored = new ToolStripMenuItem("Point Scored");
            pointScored.Name = "Point";
            pointScored.MouseDown += ShotItemClicked;
            parent.DropDownItems.Add(pointScored);
            
            ToolStripMenuItem goalScored = new ToolStripMenuItem("Goal Scored");
            goalScored.Name = "Goal";
            goalScored.MouseDown += ShotItemClicked;
            parent.DropDownItems.Add(goalScored);
            
            ToolStripMenuItem saved = new ToolStripMenuItem("Saved");
            saved.Name = "Saved";
            saved.MouseDown += ShotItemClicked;
            parent.DropDownItems.Add(saved);
            
            ToolStripMenuItem saved45 = new ToolStripMenuItem("Saved out for 45");
            saved45.Name = "SavedOutFor45";
            saved45.MouseDown += ShotItemClicked;
            parent.DropDownItems.Add(saved45);
        }

        if (parent.Name == "DoublePointShot")
        {
            ToolStripMenuItem doublePointScored = new ToolStripMenuItem("2 Pointer Scored");
            doublePointScored.Name = "DoublePoint";
            doublePointScored.MouseDown += ShotItemClicked;
            parent.DropDownItems.Add(doublePointScored);
            
            ToolStripMenuItem shortShot = new ToolStripMenuItem("Short");
            shortShot.Name = "Short";
            shortShot.MouseDown += ShotItemClicked;
            parent.DropDownItems.Add(shortShot);
        }
        
        ToolStripMenuItem wideShot = new ToolStripMenuItem("Wide");
        wideShot.Name = "Wide";
        wideShot.MouseDown += ShotItemClicked;
        parent.DropDownItems.Add(wideShot);
        
        ToolStripMenuItem postsShot = new ToolStripMenuItem("Off Posts");
        postsShot.Name = "OffPosts";
        postsShot.MouseDown += ShotItemClicked;
        parent.DropDownItems.Add(postsShot);
        
        ToolStripMenuItem blockedShot = new ToolStripMenuItem("Blocked");
        blockedShot.Name = "Blocked";
        blockedShot.MouseDown += ShotItemClicked;
        parent.DropDownItems.Add(blockedShot);
        
        ToolStripMenuItem outFor45 = new ToolStripMenuItem("Out for 45");
        outFor45.Name = "OutFor45";
        outFor45.MouseDown += ShotItemClicked;
        parent.DropDownItems.Add(outFor45);
    }

    private void AddSubMenuItemsForTurnovers(ToolStripMenuItem parent)
    {
        ToolStripMenuItem tackled = new ToolStripMenuItem("Tackled");
        tackled.Name = "Tackle";
        tackled.MouseDown += TurnoverItemClick;
        parent.DropDownItems.Add(tackled);

        ToolStripMenuItem free = new ToolStripMenuItem("Free");
        free.Name = "Free";
        free.MouseDown += TurnoverItemClick;
        parent.DropDownItems.Add(free);

        ToolStripMenuItem intercept = new ToolStripMenuItem("Intercept");
        intercept.Name = "Intercept";
        intercept.MouseDown += TurnoverItemClick;
        parent.DropDownItems.Add(intercept);
    }
    
    private void EventListContextMenuOnOpening(object? sender, CancelEventArgs e)
    {
        ContextMenuStrip eventListContextMenu = _view.GetEventListContextMenu();
        eventListContextMenu.Items.Clear();
        
        ToolStripMenuItem edit = new ToolStripMenuItem("Edit");
        edit.Name = "Edit";
        edit.Click += OnEditClick;
        eventListContextMenu.Items.Add(edit);
        
        ToolStripMenuItem delete = new ToolStripMenuItem("Delete");
        delete.Name = "Delete";
        delete.Click += OnDeleteClick;
        eventListContextMenu.Items.Add(delete);
    }

    private void OnEditClick(object? sender, EventArgs e)
    {
        MatchEvent? selectedEvent = (MatchEvent?)_view.GetEventListBox().SelectedItem;
        if (selectedEvent is null)
        {
            return;
        }

        Team selectedTeam = _match.HomeTeam.TeamName == selectedEvent.TeamName ? _match.HomeTeam : _match.AwayTeam;

        if (selectedEvent is ShotEvent shotEvent)
        {
            _selectWindow = new ActionSelectWindow(selectedTeam, shotEvent);
            _selectWindow.OnEnterStatClicked += OnStatEdited;
            _selectWindow.OnCancelled += OnEnterStatCancelled;
            _selectWindow.Show();
            return;
        }

        if (selectedEvent is SubstitutionEvent subsEvent)
        {
            _selectWindow = new SubstituteSelectWindow(selectedTeam, subsEvent);
            _selectWindow.OnEnterStatClicked += OnStatEdited;
            _selectWindow.OnCancelled += OnEnterStatCancelled;
            _selectWindow.Show();
            return;
        }

        if (selectedEvent.Type.IsCardEvent())
        {
            _selectWindow = new PlayerCardSelectWindow(selectedTeam, selectedEvent);
            _selectWindow.OnEnterStatClicked += OnStatEdited;
            _selectWindow.OnCancelled += OnEnterStatCancelled;
            _selectWindow.Show();
            return;
        }
        
        _selectWindow = new PlayerSelectWindow(selectedTeam, selectedEvent);
        _selectWindow.OnEnterStatClicked += OnStatEdited;
        _selectWindow.OnCancelled += OnEnterStatCancelled;
        _selectWindow.Show();
    }

    private void OnStatEdited(object? sender, InputStatEventArgs e)
    {
        UpdateView();
        UnbindActionViewEvents();
    }

    private void OnDeleteClick(object? sender, EventArgs e)
    {
        MatchEvent? selectedEvent = (MatchEvent?)_view.GetEventListBox().SelectedItem;
        if (selectedEvent is null)
        {
            return;
        }

        List<MatchEvent> matchEvents = _match.MatchEvents;

        int index = matchEvents.IndexOf(selectedEvent);
        if (index == matchEvents.Count - 1)
        {
            // This is only done if the last event is deleted as changing possession for a much earlier event will cause issues
            if (selectedEvent is ShotEvent || selectedEvent is TurnoverEvent)
            {
                _match.SetIsHomeTeamInPossession(_match.HomeTeam.TeamName == selectedEvent.TeamName);
            }
        }
        
        matchEvents.Remove(selectedEvent);
        UpdateView();
    }
    #endregion

    private void RightClickEventBox(object? sender, MouseEventArgs e)
    {
        ListBox eventBox = _view.GetEventListBox();
        if (eventBox.Items.Count == 0)
        {
            return;
        }
        
        eventBox.SelectedIndex = eventBox.IndexFromPoint(e.Location);
        
        _view.GetEventListContextMenu().Show(eventBox, e.Location);
    }
    
    private void CopySelectedEvent(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.C)
        {
            string? s = _view.GetEventListBox().SelectedItem?.ToString();
            if(s != null)
                Clipboard.SetData(DataFormats.StringFormat, s);
        }
    }

    private void OpenSubMenu(object? sender, EventArgs e)
    {
        Button? subsButton = sender as Button;
        if (subsButton == null)
        {
            return;
        }
        
        bool isHomeTeam = subsButton.Name.Contains("Home");
        Team selectedTeam = isHomeTeam ? _match.HomeTeam : _match.AwayTeam;

        SubstitutionEventArgs eventArgs = new SubstitutionEventArgs();
        eventArgs.Team = selectedTeam;
        eventArgs.EventType = EventType.Substitution;

        _selectWindow = new SubstituteSelectWindow(eventArgs);
        BindActionViewEvents();
        _selectWindow.ShowDialog();
    }

    private void OpenCardsMenu(object? sender, EventArgs e)
    {
        Button? subsButton = sender as Button;
        if (subsButton == null)
        {
            return;
        }
        
        bool isHomeTeam = subsButton.Name.Contains("Home");
        Team selectedTeam = isHomeTeam ? _match.HomeTeam : _match.AwayTeam;
        InputStatEventArgs eventArgs = new InputStatEventArgs
        {
            Team = selectedTeam
        };
        
        _selectWindow = new PlayerCardSelectWindow(eventArgs);
        BindActionViewEvents();
        _selectWindow.ShowDialog();
    }

    /// <summary>
    /// Called when a stat is entered on the pitch input of the match view.
    /// </summary>
    /// <param name="inputStatEventArgs">The input arguments for the statistic.</param>
    private void OnStatEntered(InputStatEventArgs inputStatEventArgs)
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
        else if (inputStatEventArgs.EventType == EventType.ThrowInWon)
        {
            _selectWindow = new PlayerSelectWindow(inputStatEventArgs.Team, inputStatEventArgs);
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
        UpdateEventList();
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
        
        UpdateCardedPlayersLists();
    }

    private void UpdateCardedPlayersLists()
    {
        Dictionary<string, long> cardedPlayers = _match.GetBlackCardedPlayers();
        if (cardedPlayers.Count == 0)
        {
            return;
        }
        
        _match.RefreshCardList();
        
        ListBox homeBox = _view.GetHomeTeamCardedPlayers();
        ListBox awayBox = _view.GetAwayTeamCardedPlayers();
        
        homeBox.BeginUpdate();
        awayBox.BeginUpdate();
        homeBox.Items.Clear();
        awayBox.Items.Clear();
        
        foreach (var cardedPlayer in cardedPlayers)
        {
            bool isHomeTeam = _match.HomeTeam.CurrentTeam.Contains(cardedPlayer.Key);

            TimeSpan elaspedTime = TimeSpan.FromMilliseconds(_match.GetElapsedTimeInMilliseconds() - cardedPlayer.Value);
            string displayText = cardedPlayer.Key + " : " + GetTimeValue(elaspedTime.Minutes) + ":" + GetTimeValue(elaspedTime.Seconds);
            if (isHomeTeam)
            {
                homeBox.Items.Add(displayText);
            }
            else
            {
                awayBox.Items.Add(displayText);
            }
        }
        
        homeBox.EndUpdate();
        awayBox.EndUpdate();
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

    private void SetupTeamPitchLabels()
    {
        PictureBox parent = _view.GetPitchInput();
        
        Label homeLabel = _view.GetHomePitchLabel();
        homeLabel.Parent = parent;
        int homePosX = homeLabel.Location.X - parent.Location.X;
        int homePosY = homeLabel.Location.Y - parent.Location.Y;
        homeLabel.Location = new Point(homePosX, homePosY);
        homeLabel.BackColor = Color.Transparent;
        homeLabel.Text = _match.HomeTeam.TeamName[new Range(0, 4)];
        _view.GetHomePitchHighlight().Visible = false;
        
        Label awayLabel = _view.GetAwayPitchLabel();
        awayLabel.Parent = _view.GetPitchInput();
        int awayPosX = awayLabel.Location.X - parent.Location.X;
        int awayPosY = awayLabel.Location.Y - parent.Location.Y;
        awayLabel.Location = new Point(awayPosX, awayPosY);
        awayLabel.BackColor = Color.Transparent;
        awayLabel.Text = _match.AwayTeam.TeamName[new Range(0, 4)];
        _view.GetAwayPitchHighlight().Visible = false;
    }

    private void UpdateScoreCard()
    {
        _match.GetTeamScoreStrings(out var homeTeamScore, out var awayTeamScore);
        _view.GetHomeTeamScoreLabel().Text = homeTeamScore;
        _view.GetAwayTeamScoreLabel().Text = awayTeamScore;
    }
    
    /// <summary>
    /// Updates the scorecard and the statistic bars in the view.
    /// </summary>
    private void UpdateView()
    {
        UpdateLastMatchEvent();
        UpdateScoreCard();
        UpdateTeamInPossessionHighlight();
        UpdateEventList();
        UpdateTurnOversBar();
        UpdateKickOutsWonBar();
        UpdatePointShotsBar();
        UpdateGoalShotsBar();
        UpdateWidesBar();
        UpdateFreesBar();
    }

    private void UpdateLastMatchEvent()
    {
        MatchEvent? lastEvent = _match.GetLastMatchEvent();
        if (lastEvent == null)
        {
            return;
        }
        
        _view.SetLastMatchEvent(lastEvent);
    }

    private void UpdateTeamInPossessionHighlight()
    {
        _view.GetHomePitchHighlight().Visible = _match.IsHomeTeamInPossession();
        _view.GetAwayPitchHighlight().Visible = !_match.IsHomeTeamInPossession();
    }

    private void UpdateEventList()
    {
        ListBox eventList = _view.GetEventListBox();
        eventList.BeginUpdate();
        eventList.Items.Clear();
        List<MatchEvent> events = _match.MatchEvents;
        eventList.Items.AddRange(events.OrderByDescending(x => x.HalfIndex).ThenByDescending(x => x.Time).ToArray());
        eventList.EndUpdate();
    }

    private void UpdateTurnOversBar()
    {
        StatisticPair turnOvers = _match.GetTurnOvers();
        if (turnOvers.IsStatisticsEmpty())
        {
            return;
        }
        
        StatisticBar bar = _view.GetTurnoverStatisticBar();
        
        bar.UpdateValues(turnOvers);
    }

    private void UpdateKickOutsWonBar()
    {
        StatisticPair kickOutsWon = _match.GetKickOutsWon();
        if (kickOutsWon.IsStatisticsEmpty())
        {
            return;
        }
        
        _view.GetKickoutStatisticBar().UpdateValues(kickOutsWon);
    }

    private void UpdatePointShotsBar()
    {
        StatisticPair pointShots = _match.GetStatisticPairForShots();
        if (pointShots.IsStatisticsEmpty())
        {
            return;
        }
        
        _view.GetShotsStatisticBar().UpdateValues(pointShots);
    }

    private void UpdateGoalShotsBar()
    {
        StatisticPair goalShots = _match.GetStatisticForEvent(EventType.GoalShot);
        if (goalShots.IsStatisticsEmpty())
        {
            return;
        }
        
        _view.GetGoalShotsStatisticBar().UpdateValues(goalShots);
    }

    private void UpdateWidesBar()
    {
        StatisticPair wides = _match.GetStatisticForShotResult(ShotResultType.Wide);
        if (wides.IsStatisticsEmpty())
        {
            return;
        }
        
        _view.GetWidesStatisticBar().UpdateValues(wides);
    }

    private void UpdateFreesBar()
    {
        StatisticPair frees = _match.GetFrees();
        if (frees.IsStatisticsEmpty())
        {
            return;
        }
        
        _view.GetFreeStatisticBar().UpdateValues(frees);
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
        _view.Text = "GAA Intelligence" + " - " + _match.HomeTeam.TeamName + " vs " + _match.AwayTeam.TeamName;
        SetTeamDataInView();
        _filePath = null;
        UpdateScoreCard();
        SetupStatisticBars();
        SetupTeamPitchLabels();
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
        StartAutoSaveTimer();
    }

    private void StartAutoSaveTimer()
    {
        if (_autosaveTimer != null && _autosaveTimer.Enabled)
        {
            return;
        }
        
        _autosaveTimer = new Timer();
        _autosaveTimer.Interval = 120000; // 2 minutes
        _autosaveTimer.Tick += SaveGame;
        _autosaveTimer.Enabled = true;
        _autosaveTimer.Start(); 
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
            StartAutoSaveTimer();
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
            _view.Text = "GAA Intelligence" + " - " + _match.HomeTeam.TeamName + " vs " + _match.AwayTeam.TeamName;
            SetTeamDataInView();
            SetupStatisticBars();
            SetupTeamPitchLabels();
            UpdateView();
        }
    }
    #endregion
    
    #region Stats Views
    private void OpenAllStatsView(object? sender, EventArgs e)
    {
        if (!_match.IsMatchValid())
        {
            return;
        }
        
        _openStatsController = new AllStatsController(_match);
        _openStatsController.ShowDialog();
    }

    private void ScorersButtonPressed(object? sender, EventArgs e)
    {
        if (!_match.IsMatchValid())
        {
            return;
        }

        _openStatsController = new ScorersController(_match, true);
        _openStatsController.ShowDialog();
    }

    private void ScoreTimeLinePressed(object? sender, EventArgs e)
    {
        if (!_match.IsMatchValid())
        {
            return;
        }

        ScoreTimeLineView view = new ScoreTimeLineView(_match);
        view.ShowDialog();
    }

    private void EventTimeLinePressed(object? sender, EventArgs e)
    {
        if (!_match.IsMatchValid())
        {
            return;
        }
        
        _openStatsController = new EventTimeLineController(_match);
        _openStatsController.ShowDialog();
    }

    private void PlayerPerformanceClicked(object? sender, EventArgs e)
    {
        if (!_match.IsMatchValid())
        {
            return;
        }

        _openStatsController = new PlayerPerformanceChartController(_match);
        _openStatsController.ShowDialog();
    }
    #endregion
    
    #region Export Methods
    private void ExportJournalistData(object? sender, EventArgs e)
    {
        //_match.GetTeamAndSubsString();
        Clipboard.SetText(_match.GetTeamAndSubsString());
    }
    #endregion
}