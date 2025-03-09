namespace StatsTracker.Enums;

/// <summary>
/// Event type used to describe the match event.
/// </summary>
public enum EventType
{
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
    Wide,
    Default
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
    /// <param name="eventType"></param>
    /// <returns></returns>
    public static bool IsInPossessionTeamEvent(this EventType eventType)
    {
        switch (eventType)
        {
            case EventType.TurnoverWon:
                return false;
            default:
                return true;
        }
    }
}