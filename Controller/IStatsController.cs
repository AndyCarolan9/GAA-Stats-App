using StatsTracker.Views;

namespace StatsTracker.Controller;

public interface IStatsController
{
    public IStatsView GetView();
}