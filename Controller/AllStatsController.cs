using StatsTracker.Model;
using StatsTracker.View_Elements;
using StatsTracker.Views;
using StatsTracker.Views.Statistics;

namespace StatsTracker.Controller;

public class AllStatsController : IStatsController
{
    private AllStatsView _view;
    private Match _match;

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
    #endregion
}