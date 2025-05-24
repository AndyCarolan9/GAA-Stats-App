using StatsTracker.Classes;
using StatsTracker.Enums;
using StatsTracker.View_Elements;

namespace StatsTracker.Views.Statistics;

public partial class AllStatsView : Form, IStatsView
{
    private MatchEvent[] _selectedEvents = new MatchEvent[0];

    private bool _showOnlyHomeEvents = false;
    private bool _showBothTeamEvents = true;
    
    public event EventHandler? OnStatBarSelected; 
    
    public AllStatsView()
    {
        InitializeComponent();

        foreach (var statBar in GetAllStatisticsBars())
        {
            statBar.StatBarClicked += OnStatBarClicked;
        }
    }

    public Form GetForm()
    {
        return this;
    }
    
    #region Control Getters
    #region Kickouts
    public StatisticBar GetTotalKickoutsStatsBar()
    {
        return TotalKickoutsBar;
    }

    public StatisticBar GetKoWonCleanStatsBar()
    {
        return KOWonCleanBar;
    }

    public StatisticBar GetKoWonMarkStatsBar()
    {
        return KOWonMarkBar;
    }

    public StatisticBar GetKoWonBreakStatsBar()
    {
        return KOWonBreak;
    }

    public StatisticBar GetKoLostCleanStatsBar()
    {
        return KOLostCleanBar;
    }

    public StatisticBar GetKoLostMarkStatsBar()
    {
        return KOLostMarkBar;
    }

    public StatisticBar GetKoLostBreakStatsBar()
    {
        return KOLostBreakBar;
    }
    #endregion
    
    #region Shooting
    public Label GetHomeTeamLabel()
    {
        return HomeTeamLabel;
    }

    public Label GetAwayTeamLabel()
    {
        return AwayTeamLabel;
    }

    public Label GetHomeTeamScore()
    {
        return HomeTeamScore;
    }

    public Label GetAwayTeamScore()
    {
        return AwayTeamScore;
    }

    public StatisticBar GetTotalShotsBar()
    {
        return TotalShots;
    }

    public StatisticBar GetTotalPointShotBar()
    {
        return TotalPointShots;
    }

    public StatisticBar GetTotal2PointShotBar()
    {
        return Total2PointShots;
    }

    public StatisticBar GetTotalGoalShotBar()
    {
        return TotalGoalShots;
    }

    public StatisticBar GetPointsScoredBar()
    {
        return TotalPointsScored;
    }

    public StatisticBar GetTotal2PointScoredBar()
    {
        return Total2PointScored;
    }

    public StatisticBar GetTotalGoalScoredBar()
    {
        return TotalGoalsScored;
    }

    public StatisticBar GetTotalWidesBar()
    {
        return TotalWides;
    }

    public StatisticBar GetTotalBlockedShotsBar()
    {
        return TotalBlockedShots;
    }

    public StatisticBar GetTotalShortShotsBar()
    {
        return TotalShortShots;
    }

    public StatisticBar GetTotalSavedShotsBar()
    {
        return TotalSavedShots;
    }

    public StatisticBar GetTotalOutFor45Bar()
    {
        return TotalOutFor45;
    }
    #endregion

    #region Turnovers
    public StatisticBar GetTotalTurnoversWonBar()
    {
        return TurnoversWon;
    }

    public StatisticBar GetTurnoverFreeWonBar()
    {
        return Free;
    }

    public StatisticBar GetTurnoverTackleWonBar()
    {
        return Tackle;
    }

    public StatisticBar GetTurnoverInterceptWonBar()
    {
        return Intercept;
    }
    #endregion

    public Label GetHomeTeamName()
    {
        return HomeTeamName;
    }

    public Label GetAwayTeamName()
    {
        return AwayTeamName;
    }

    public StatisticBar[] GetAllStatisticsBars()
    {
        return Controls.OfType<StatisticBar>().ToArray();
    }
    #endregion

    private void OnStatBarClicked(object? sender, EventArgs e)
    {
        OnStatBarSelected?.Invoke(sender, e);
    }

    public void SetSelectedEvents(MatchEvent[] selectedEvents)
    {
        _selectedEvents = selectedEvents;
        Refresh();
    }

    private void DisplayPitch_Paint(object sender, PaintEventArgs e)
    {
        if (_selectedEvents.Length == 0)
            return;

        foreach (var selectedEvent in _selectedEvents)
        {
            Brush brush = IsPositiveEvent(selectedEvent) ? Brushes.Green : Brushes.Red;
            
            if (CanShowHomeEvent() && selectedEvent.TeamName[new Range(0, 4)] == HomeTeamLabel.Text)
            {
                e.Graphics.FillRectangle(brush,
                    selectedEvent.Location.X - 5,
                    selectedEvent.Location.Y - 5,
                    10, 10);
            }
            else if(CanShowAwayEvent() && selectedEvent.TeamName[new Range(0, 4)] == AwayTeamLabel.Text)
            {
                e.Graphics.FillEllipse(
                    brush,
                    selectedEvent.Location.X - 5,
                    selectedEvent.Location.Y - 5,
                    10, 10);
            }
        }
    }

    private bool IsPositiveEvent(MatchEvent matchEvent)
    {
        if (matchEvent is KickOutEvent KOEvent)
        {
            return KOEvent.ResultType.IsKickOutWon();
        }

        if (matchEvent is ShotEvent shotEvent)
        {
            return shotEvent.ResultType.IsScore();
        }

        if (matchEvent is TurnoverEvent turnoverEvent)
        {
            return turnoverEvent.Type == EventType.TurnoverWon;
        }
        
        return false;
    }

    private bool CanShowHomeEvent()
    {
        return _showBothTeamEvents || _showOnlyHomeEvents;
    }

    private bool CanShowAwayEvent()
    {
        return _showBothTeamEvents || !_showOnlyHomeEvents;
    }

    private void HomeTeam_Click(object sender, EventArgs e)
    {
        if (_showBothTeamEvents)
        {
            _showBothTeamEvents = false;
            _showOnlyHomeEvents = true;
            UpdateTextBackColor();
            Refresh();
            return;
        }

        if (_showOnlyHomeEvents && !_showBothTeamEvents)
        {
            _showBothTeamEvents = true;
            UpdateTextBackColor();
            Refresh();
            return;
        }
        
        _showOnlyHomeEvents = true;
        UpdateTextBackColor();
        Refresh();
    }

    private void AwayTeam_Click(object? sender, EventArgs e)
    {
        if (_showBothTeamEvents)
        {
            _showBothTeamEvents = false;
            _showOnlyHomeEvents = false;
            UpdateTextBackColor();
            Refresh();
            return;
        }

        if (!_showOnlyHomeEvents && !_showBothTeamEvents)
        {
            _showBothTeamEvents = true;
            UpdateTextBackColor();
            Refresh();
            return;
        }
        
        _showOnlyHomeEvents = false;
        UpdateTextBackColor();
        Refresh();
    }

    private void UpdateTextBackColor()
    {
        HomeTeamLabel.BackColor = !_showBothTeamEvents && _showOnlyHomeEvents ? Color.Green : SystemColors.Control;
        HomeTeamName. BackColor = !_showBothTeamEvents && _showOnlyHomeEvents ? Color.Green : SystemColors.Control;
        AwayTeamLabel.BackColor = !_showBothTeamEvents && !_showOnlyHomeEvents ? Color.Green : SystemColors.Control;
        AwayTeamName.BackColor = !_showBothTeamEvents && !_showOnlyHomeEvents ? Color.Green : SystemColors.Control;
    }

    public void SetupStatBarNames()
    {
        #region Turnovers
        TurnoversWon.StatName = "Total Turnovers Won";
        Tackle.StatName = "Won in the Tackle";
        Free.StatName = "Won By Free";
        Intercept.StatName = "Won By Intercept";
        #endregion

        #region Kickouts
        TotalKickoutsBar.StatName = "Total Kickouts";

        KOWonCleanBar.StatName = KickOutResultType.Won.GetEventName();
        KOWonMarkBar.StatName = KickOutResultType.WonMark.GetEventName();
        KOWonBreak.StatName = KickOutResultType.WonBreak.GetEventName();
        KOLostCleanBar.StatName = KickOutResultType.Lost.GetEventName();
        KOLostMarkBar.StatName = KickOutResultType.LostMark.GetEventName();
        KOLostBreakBar.StatName = KickOutResultType.LostBreak.GetEventName();
        #endregion
        
        #region Shots
        TotalShots.StatName = "# Shots";
        TotalPointShots.StatName = "# Of Point Shots";
        Total2PointShots.StatName = "# Of 2 Point Shots";
        TotalGoalShots.StatName = "# Of Goal Shots";
        TotalPointsScored.StatName = "# Of Points Scored";
        Total2PointScored.StatName = "# Of 2 Points Scored";
        TotalGoalsScored.StatName = "# Of Goals Scored";
        TotalWides.StatName = "# Wides";
        TotalBlockedShots.StatName = "# Of Blocked Shots";
        TotalSavedShots.StatName = "# Of Saved Shots";
        TotalShortShots.StatName = "# Of Short Shots";
        TotalOutFor45.StatName = "# Out For 45";
        #endregion
    }
}