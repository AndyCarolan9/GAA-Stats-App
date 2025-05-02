using StatsTracker.Classes;
using StatsTracker.Enums;
using StatsTracker.View_Elements;

namespace StatsTracker.Views.Statistics;

public partial class AllStatsView : Form, IStatsView
{
    private MatchEvent[] _selectedEvents = new MatchEvent[0];
    
    public event EventHandler? OnStatBarSelected; 
    
    public AllStatsView()
    {
        InitializeComponent();
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
            
            if (selectedEvent.TeamName[new Range(0, 4)] == HomeTeamLabel.Text)
            {
                e.Graphics.FillRectangle(brush,
                    selectedEvent.Location.X - 5,
                    selectedEvent.Location.Y - 5,
                    10, 10);
            }
            else
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
}