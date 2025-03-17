using StatsTracker.Enums;

namespace StatsTracker.Events;

public class ShotEventArgs : InputStatEventArgs
{
    public ActionType ActionType { get; set; }
    
    public ShotResultType ResultType { get; set; }
}