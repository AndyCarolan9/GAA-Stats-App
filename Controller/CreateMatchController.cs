using StatsTracker.Views;

namespace StatsTracker.Controller;

public class CreateMatchController : IStatsController
{
    private CreateMatchView _view;
    
    public IStatsView GetView()
    {
        return _view;
    }
}