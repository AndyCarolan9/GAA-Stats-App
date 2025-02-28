using StatsTracker.Model;
using StatsTracker.Views;

namespace StatsTracker.Controller;

public class MatchController : IStatsController
{
    private Match _match;
    private MatchView _view;

    public MatchController(Match match)
    {
        _match = match;
        _view = new MatchView();
    }

    public IStatsView GetView()
    {
        return _view;
    }
}