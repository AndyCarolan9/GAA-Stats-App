using StatsTracker.Enums;

namespace StatsTracker.Events;

public class KickOutEventArgs : InputStatEventArgs
{
    public KickOutResultType ResultType { get; set; }
}