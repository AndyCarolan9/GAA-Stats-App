using StatsTracker.Enums;

namespace StatsTracker.Classes;

public class TurnoverEvent : MatchEvent
{
    #region Constructors
    public TurnoverEvent() : base()
    {
        
    }

    public TurnoverEvent(Point location, string player, long time, EventType eventType, string teamName, int halfIndex,
        TurnoverType turnoverType) : base(location, player, time, eventType, teamName, halfIndex)
    {
        TurnoverType = turnoverType;
    }
    #endregion
    
    #region Properties
    public TurnoverType TurnoverType { get; set; }
    #endregion
}