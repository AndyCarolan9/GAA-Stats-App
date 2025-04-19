using StatsTracker.Classes;
using StatsTracker.Enums;
using StatsTracker.Model;
using StatsTracker.View_Elements;
using StatsTracker.Views;
using StatsTracker.Views.Statistics;

namespace StatsTracker.Controller;

public class AllStatsController : IStatsController
{
    private readonly AllStatsView _view;
    private readonly Match _match;

    public AllStatsController(Match match)
    {
        _match = match;
        _view = new AllStatsView();
        SetupInitialViewData();
        InitialiseStatisticBars();
        BindViewEvents();
        UpdateViewData();
    }
    
    public IStatsView GetView()
    {
        return _view;
    }

    public DialogResult ShowDialog()
    {
        return _view.GetForm().ShowDialog();
    }

    private void BindViewEvents()
    {
        _view.OnTeamChanged += SelectedTeamChanged;
    }
    
    #region View Event Methods
    private void SelectedTeamChanged(object? sender, EventArgs e)
    {
        
    }
    #endregion
    
    #region View Display Methods
    private void SetupInitialViewData()
    {
        ComboBox teamSelector = _view.GetTeamSelector();
        teamSelector.Items.Add(_match.HomeTeam.TeamName);
        teamSelector.Items.Add(_match.AwayTeam.TeamName);
        teamSelector.SelectedIndex = 0;
    }

    private void UpdateViewData()
    {
        // TODO Get the selected team and update the view with it's data.
        SetKickOutStatBarsValues();
        SetScoreCardValues();
        SetShootingStatBarValues();
    }

    private void InitialiseStatisticBars()
    {
        StatisticBar[] statBars = _view.GetAllStatisticsBars();

        foreach (var bar in statBars)
        {
            bar.InitialiseValues();
            bar.SetTeamColors(_match.HomeTeam.TeamColor,  _match.AwayTeam.TeamColor);
        }
    }

    private void SetKickOutStatBarsValues()
    {
        StatisticBar totalKickoutsStatsBar = _view.GetTotalKickoutsStatsBar();
        StatisticPair totalKoPair = _match.GetStatisticForEvent(EventType.KickOut);
        if (!totalKoPair.IsStatisticsEmpty())
        {
            totalKickoutsStatsBar.UpdateValues(totalKoPair.HomeTeamValue, totalKoPair.AwayTeamValue);
        }
        
        StatisticBar[] statBars = _view.GetAllStatisticsBars().Where(bar =>
        {
            string name = bar.StatName.Replace(" ", "");
            return Enum.IsDefined(typeof(KickOutResultType), name);
        }).ToArray();

        foreach (var bar in statBars)
        {
            Enum.TryParse(bar.StatName.Replace(" ", ""), out KickOutResultType resultType);
            StatisticPair statsPair = _match.GetStatisticPairForKickOutResult(resultType);
            if (!statsPair.IsStatisticsEmpty())
            {
                bar.UpdateValues(statsPair.HomeTeamValue, statsPair.AwayTeamValue);
            }
        }
    }

    private void SetScoreCardValues()
    {
        string homeTeamName = _match.HomeTeam.TeamName[new Range(0, 4)];
        string awayTeamName = _match.AwayTeam.TeamName[new Range(0, 4)];

        _match.GetTeamScoreStrings(out var homeTeamScore, out var awayTeamScore);
        
        _view.GetHomeTeamLabel().Text = homeTeamName;
        _view.GetAwayTeamLabel().Text = awayTeamName;
        _view.GetHomeTeamScore().Text = homeTeamScore;
        _view.GetAwayTeamScore().Text = awayTeamScore;
    }

    private void SetShootingStatBarValues()
    {
        StatisticPair pointShots = _match.GetStatisticForEvent(EventType.PointShot);
        StatisticPair doublePointShots = _match.GetStatisticForEvent(EventType.DoublePointShot);
        StatisticPair goalShots = _match.GetStatisticForEvent(EventType.GoalShot);
        
        _view.GetTotalShotsBar().UpdateValues(
            pointShots.HomeTeamValue + doublePointShots.HomeTeamValue + goalShots.HomeTeamValue, 
            pointShots.AwayTeamValue + doublePointShots.AwayTeamValue + goalShots.AwayTeamValue);
        _view.GetTotalPointShotBar().UpdateValues(pointShots.HomeTeamValue, pointShots.AwayTeamValue);
        _view.GetTotal2PointShotBar().UpdateValues(doublePointShots.HomeTeamValue, doublePointShots.AwayTeamValue);
        _view.GetTotalGoalShotBar().UpdateValues(goalShots.HomeTeamValue, goalShots.AwayTeamValue);

        StatisticPair pointsScored = _match.GetStatisticForShotResult(ShotResultType.Point);
        StatisticPair doublePointsScored = _match.GetStatisticForShotResult(ShotResultType.DoublePoint);
        StatisticPair goalScored = _match.GetStatisticForShotResult(ShotResultType.Goal);
        
        _view.GetPointsScoredBar().UpdateValues(pointsScored.HomeTeamValue, pointsScored.AwayTeamValue);
        _view.GetTotal2PointScoredBar().UpdateValues(doublePointsScored.HomeTeamValue, doublePointsScored.AwayTeamValue);
        _view.GetTotalGoalScoredBar().UpdateValues(goalScored.HomeTeamValue, goalScored.AwayTeamValue);
    }
    #endregion
}