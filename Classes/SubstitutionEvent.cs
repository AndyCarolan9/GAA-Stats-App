using StatsTracker.Enums;

namespace StatsTracker.Classes;

public class SubstitutionEvent : MatchEvent
{
    #region Constructors
    public SubstitutionEvent()
    {
        
    }

    public SubstitutionEvent(string playerOffName, string playerOnName, long time, EventType eventType, string TeamName,
        int halfIndex) : base(new Point(), playerOffName, time, eventType, TeamName, halfIndex)
    {
        PlayerOnName = playerOnName;
    }
    #endregion
    
    #region Properties
    public string PlayerOnName { get; set; }
    #endregion

    public override string ToString()
    {
        string formattedTime = FormatTime();
        string eventTypeString = Type.GetEventName();
        
        return formattedTime + " " + TeamName + " " + eventTypeString + "-On: "
            + PlayerOnName + "- Off: " + Player;
    }
}
