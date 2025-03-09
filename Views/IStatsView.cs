using StatsTracker.Controller;

namespace StatsTracker.Views;

/// <summary>
/// Interface for all views in the application.
/// </summary>
public interface IStatsView
{
    /// <summary>
    /// Returns the form of this view.
    /// </summary>
    /// <returns>The form being used by the view.</returns>
    public Form GetForm();
}