using StatsTracker.Classes;
using StatsTracker.Enums;

namespace StatsTracker.Events;

public class InputStatEventArgs
{
    public EventType EventType { get; set; }
    
    public Team Team { get; set; }
    
    public PointF Location { get; set; }
    
    public string Player { get; set; }
}