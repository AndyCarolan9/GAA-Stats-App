namespace StatsTracker.Enums;

/// <summary>
/// Event type used to describe the match event.
/// </summary>
public enum EventType
{
    Default,
    PointShot,
    KickOut,
    KickOutWon,
    KickOutWonMark,
    KickOutLost,
    KickOutLostMark,
    Saved,
    SavedOutFor45,
    OutFor45,
    Short,
    Point,
    DoublePoint,
    Goal,
    OffPosts,
    FreeConceded,
    PenaltyConceded,
    BlackCard,
    RedCard,
    RedCard2Y,
    YellowCard,
    TurnoverWon,
    TurnoverLost,
    Wide
}

/// <summary>
/// Extension class which adds some methods to the event type enum.
/// </summary>
static class EventTypeExtensions
{
    /// <summary>
    /// Checks if the event is relevant to the team in possession.
    /// Some events like turnover won we want to pick a player from the opposing team.
    /// </summary>
    /// <param name="eventType">The event type to check</param>
    /// <returns></returns>
    public static bool IsInPossessionTeamEvent(this EventType eventType)
    {
        switch (eventType)
        {
            case EventType.TurnoverLost:
            case EventType.OutFor45:
            case EventType.Point:
            case EventType.Goal:
            case EventType.DoublePoint:
            case EventType.Short:
            case EventType.OffPosts:
            case EventType.KickOutWon:
            case EventType.KickOutWonMark:
            case EventType.Saved:
            case EventType.SavedOutFor45:
            case EventType.Wide:
                return true;
            default:
                return false;
        }
    }

    /// <summary>
    /// Returns true if possession is turned over as a result of the event.
    /// </summary>
    /// <param name="eventType">The event type to check.</param>
    /// <returns>True if the possession is turned over as a result of the event.</returns>
    public static bool IsTurnoverEvent(this EventType eventType)
    {
        switch (eventType)
        {
            case EventType.TurnoverLost:
            case EventType.Point:
            case EventType.Goal:
            case EventType.DoublePoint:
            case EventType.Short:
            case EventType.OffPosts:
            case EventType.KickOutLost:
            case EventType.KickOutLostMark:
            case EventType.Saved:
            case EventType.Wide:
            case EventType.TurnoverWon:
            case EventType.FreeConceded:
                return true;
            default:
                return false;
        }
    }
}