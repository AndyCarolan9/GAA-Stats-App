namespace StatsTracker.Enums;

/// <summary>
/// Event type used to describe the match event.
/// </summary>
public enum EventType
{
    Default,
    PointShot,
    GoalShot,
    DoublePointShot,
    KickOut,
    FreeConceded,
    FouledFree,
    PenaltyConceded,
    BlackCard,
    RedCard,
    RedCard2Y,
    YellowCard,
    TurnoverWon,
    TurnoverLost,
    ThrowInWon,
    Substitution
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
            case EventType.PointShot:
            case EventType.DoublePointShot:
            case EventType.GoalShot:
            case EventType.KickOut:
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
            case EventType.TurnoverWon:
            case EventType.FreeConceded:
                return true;
            default:
                return false;
        }
    }

    public static string GetEventName(this EventType eventType)
    {
        return string.Concat(eventType.ToString().Select(x => Char.IsUpper(x) ? " " + x : x.ToString())).TrimStart(' ');
    }
}