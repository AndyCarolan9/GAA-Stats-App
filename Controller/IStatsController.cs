using StatsTracker.Views;

namespace StatsTracker.Controller;

/// <summary>
/// Interface for all controllers in the application.
/// </summary>
public interface IStatsController
{
    /// <summary>
    /// Returns the view used by this controller.
    /// </summary>
    /// <returns>The view used by this controller.</returns>
    public IStatsView GetView();
    
    /// <summary>
    /// Calls the ShowDialog method on the view object.
    /// </summary>
    /// <returns>The dialog result of the view.</returns>
    public DialogResult ShowDialog();
}