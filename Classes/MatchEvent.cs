using StatsTracker.Enums;

namespace StatsTracker.Classes;

/// <summary>
/// Match Event class which is used to define when a relevant statistic is recorded.
/// </summary>
public class MatchEvent
{
    #region Constructors
    public MatchEvent()
    {
        Player = string.Empty;
        TeamName = string.Empty;
    }

    public MatchEvent(Point location, string player, long time, EventType eventType, string teamName, int halfIndex)
    {
        Location = location;
        Player = player;
        Time = time;
        Type = eventType;
        TeamName = teamName;
        HalfIndex = halfIndex;
    }
    #endregion
    
    #region Properties

    public Point Location { get; set; }

    public string Player { get; set; }

    public long Time { get; set; }

    public EventType Type { get; set; }
    
    public string TeamName { get; set; }
    
    public int HalfIndex { get; set; }

    #endregion

    public override string ToString()
    {
        string formattedTime = FormatTime();
        string eventTypeString = Type.GetEventName();
        return formattedTime + " " + TeamName + " " + eventTypeString + " " + Player;
    }

    protected string FormatTime()
    {
        TimeSpan time = TimeSpan.FromMilliseconds(Time);
        string half = HalfIndex == 1 ? "1st" : "2nd";
        string seconds = time.Seconds < 10 ? "0" + time.Seconds.ToString() : time.Seconds.ToString();
        return time.Minutes + ":" + seconds + " mins " + half + " half"; 
    }
}