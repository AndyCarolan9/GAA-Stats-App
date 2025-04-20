using StatsTracker.Enums;

namespace StatsTracker.Events;

public class TurnoverEventArgs : InputStatEventArgs
{
    public TurnoverType TurnoverType { get; set; }
}