﻿namespace StatsTracker.Enums;

/// <summary>
/// Result type of kick out.
/// </summary>
public enum KickOutResultType
{
    WonClean,
    WonMark,
    LostClean,
    LostMark,
    WonBreak,
    LostBreak
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

static class ShotResultTyeExtensions
{
    /// <summary>
    /// Returns true if possession has been turned over as a result of the shot type.
    /// This will not be used to alter the turnover count and will be used purely for tracking
    /// which team is in possession.
    /// </summary>
    /// <param name="resultType"></param>
    /// <returns>True is possession changes because of the result type.</returns>
    public static bool IsPossessionTurnedOver(this ShotResultType resultType)
    {
        switch (resultType)
        {
            case ShotResultType.Wide:
            case ShotResultType.Point:
            case ShotResultType.Goal:
            case ShotResultType.DoublePoint:
                return true;
            default:
                return false;
        }
    }

    /// <summary>
    /// Returns true if the shot has gone out for a 45.
    /// </summary>
    /// <param name="resultType"></param>
    /// <returns>True if the shot has gone out for a 45.</returns>
    public static bool IsOutFor45(this ShotResultType resultType)
    {
        switch (resultType)
        {
            case ShotResultType.OutFor45:
            case ShotResultType.SavedOutFor45:
                return true;
            default:
                return false;
        }
    }
}

static class KickOutResultExtensions
{
    /// <summary>
    /// Returns true if the kick out is won.
    /// Will not affect the turnover count.
    /// </summary>
    /// <param name="kickOutResult"></param>
    /// <returns>True if the kick out is won.</returns>
    public static bool IsKickOutWon(this KickOutResultType kickOutResult)
    {
        switch (kickOutResult)
        {
            case KickOutResultType.LostClean:
            case KickOutResultType.LostMark:
            case KickOutResultType.LostBreak:
                return false;
            default:
                return true;
        }
    }
}