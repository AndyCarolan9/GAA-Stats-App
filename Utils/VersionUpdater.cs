using StatsTracker.Model;
using StatsTracker.Singletons;

namespace StatsTracker.Utils;

public static class VersionUpdater
{
    public static bool UpdateMatchData(Match match)
    {
        if (string.IsNullOrEmpty(match.AppVersion))
        {
            foreach (var matchEvent in match.MatchEvents)
            {
                // Find percentage values based on previous picture box size.
                float x = matchEvent.Location.X / 700;
                float y = matchEvent.Location.Y / 964;
            
                matchEvent.Location = new PointF(x, y);
            }
        }

        if (match.AppVersion != StatTrackerSettings.Settings.Version)
        {
            match.AppVersion = StatTrackerSettings.Settings.Version;
            return true;
        }
        
        return false;
    }
}