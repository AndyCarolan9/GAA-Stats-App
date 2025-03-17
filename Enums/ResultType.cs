namespace StatsTracker.Enums;

/// <summary>
/// Result type of kick out.
/// </summary>
public enum KickOutResultType
{
    Won,
    WonMark,
    Lost,
    LostMark,
}

/// <summary>
/// Result type of shot.
/// </summary>
public enum ShotResultType
{
    Wide,
    Point,
    Goal,
    DoublePoint,
    Blocked,
    Saved,
    OutFor45,
    SavedOutFor45,
    OffPosts,
    Short
}