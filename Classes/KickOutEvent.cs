using StatsTracker.Enums;

namespace StatsTracker.Classes;

public class KickOutEvent : MatchEvent
{
    #region Constructors
    public KickOutEvent() : base()
    {
        
    }

    public KickOutEvent(Point location, string player, long time, EventType eventType, string teamName, int halfIndex,
        KickOutResultType resultType) : base(location, player, time, eventType, teamName, halfIndex)
    {
        ResultType = resultType;
    }
    #endregion
    
    #region Properties
    public KickOutResultType  ResultType { get; set; }
    #endregion

    public override string ToString()
    {
        string formattedTime = FormatTime();
        string eventTypeString = Type.GetEventName();
        string resultTypeString = ResultType.GetEventName();
        
        return formattedTime + " " + TeamName + " " + eventTypeString + "-" + resultTypeString + " by " + Player;
    }
}