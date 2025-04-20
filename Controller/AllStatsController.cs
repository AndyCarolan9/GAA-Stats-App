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
            totalKickoutsStatsBar.UpdateValues(totalKoPair);
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
            bar.UpdateValues(statsPair);
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
        
        _view.GetTotalShotsBar().UpdateValues(new StatisticPair(
            pointShots.HomeTeamValue + doublePointShots.HomeTeamValue + goalShots.HomeTeamValue, 
            pointShots.AwayTeamValue + doublePointShots.AwayTeamValue + goalShots.AwayTeamValue));
        _view.GetTotalPointShotBar().UpdateValues(pointShots);
        _view.GetTotal2PointShotBar().UpdateValues(doublePointShots);
        _view.GetTotalGoalShotBar().UpdateValues(goalShots);

        StatisticPair pointsScored = _match.GetStatisticForShotResult(ShotResultType.Point);
        StatisticPair doublePointsScored = _match.GetStatisticForShotResult(ShotResultType.DoublePoint);
        StatisticPair goalScored = _match.GetStatisticForShotResult(ShotResultType.Goal);
        
        _view.GetPointsScoredBar().UpdateValues(pointsScored);
        _view.GetTotal2PointScoredBar().UpdateValues(doublePointsScored);
        _view.GetTotalGoalScoredBar().UpdateValues(goalScored);
        
        StatisticPair wides = _match.GetStatisticForShotResult(ShotResultType.Wide);
        StatisticPair outFor45 = _match.GetStatisticForShotResult(ShotResultType.OutFor45);
        StatisticPair saved45 = _match.GetStatisticForShotResult(ShotResultType.SavedOutFor45);
        StatisticPair saved = _match.GetStatisticForShotResult(ShotResultType.Saved);
        StatisticPair shortShots = _match.GetStatisticForShotResult(ShotResultType.Short);
        
        _view.GetTotalWidesBar().UpdateValues(wides);
        _view.GetTotalOutFor45Bar().UpdateValues(new StatisticPair(outFor45.HomeTeamValue + saved45.HomeTeamValue,
            outFor45.AwayTeamValue + saved45.AwayTeamValue));
        _view.GetTotalSavedShotsBar().UpdateValues(new StatisticPair(saved.HomeTeamValue + saved45.HomeTeamValue, 
            saved.AwayTeamValue + saved45.AwayTeamValue));
        _view.GetTotalShortShotsBar().UpdateValues(shortShots);
    }
    #endregion
}