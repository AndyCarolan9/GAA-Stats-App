using StatsTracker.View_Elements;

namespace StatsTracker.Views.Statistics;

public partial class AllStatsView : Form, IStatsView
{
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

    public StatisticBar[] GetAllStatisticsBars()
    {
        return Controls.OfType<StatisticBar>().ToArray();
    }
    #endregion
}