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
    #endregion
}