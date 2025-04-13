using StatsTracker.Model;
using StatsTracker.Views;
using StatsTracker.Views.Statistics;

namespace StatsTracker.Controller;

public class AllStatsController : IStatsController
{
    AllStatsView _view;
    Match _match;

    public AllStatsController(Match match)
    {
        _match = match;
        _view = new AllStatsView();
    }
    
    public IStatsView GetView()
    {
        return _view;
    }

    public DialogResult ShowDialog()
    {
        return _view.GetForm().ShowDialog();
    }
}