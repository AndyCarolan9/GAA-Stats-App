using StatsTracker.Classes;
using StatsTracker.Events;
using StatsTracker.Model;
using StatsTracker.Views;

namespace StatsTracker.Controller;

/// <summary>
/// Controller class used when inputting stats into a match.
/// </summary>
public class MatchController : IStatsController
{
    private Match _match;
    private MatchView _view;
    private ActionSelectWindow? _actionSelectWindow = null;

    public MatchController(Match match)
    {
        _match = match;
        _view = new MatchView();
        
        BindViewEvents();
    }

    public IStatsView GetView()
    {
        return _view;
    }

    /// <summary>
    /// Binds events from the match view.
    /// </summary>
    private void BindViewEvents()
    {
        _view.OnStatEntered += OnStatEntered;
    }

    /// <summary>
    /// Called when a stat is entered on the pitch input of the match view.
    /// </summary>
    /// <param name="sender">The object which sent the event.</param>
    /// <param name="inputStatEventArgs">The input arguments for the statistic.</param>
    private void OnStatEntered(object? sender, InputStatEventArgs inputStatEventArgs)
    {
        Team team = new Team("Glen Emmets", Color.Green, new []{"Ian O'Reilly", "Emmet Delaney", "Keith Boylan",
            "Jamie Farnan", "Callum Wogan", "Evan English", "Brien Maguire", "Cian Talbot", "Darragh Russel", "Paddy McHugh",
            "Kealan O'Neill", "James Butler", "Eoin Maguire", "Alex Carolan", "Lorcan Lynch"});
        _actionSelectWindow = new ActionSelectWindow(team, inputStatEventArgs);
        BindActionViewEvents();
        _actionSelectWindow.ShowDialog();
    }

    /// <summary>
    /// Binds events for the action input view.
    /// </summary>
    private void BindActionViewEvents()
    {
        if (_actionSelectWindow != null)
        {
            _actionSelectWindow.OnEnterStatClicked += OnEnterStatClicked;
            _actionSelectWindow.OnCancelled += OnEnterStatCancelled;
        }
    }

    /// <summary>
    /// Unbinds the events from the action input view.
    /// </summary>
    private void UnbindActionViewEvents()
    {
        if (_actionSelectWindow != null)
        {
            _actionSelectWindow.OnEnterStatClicked -= OnEnterStatClicked;
            _actionSelectWindow.OnCancelled -= OnEnterStatCancelled;
            _actionSelectWindow.Close();
            _actionSelectWindow = null;
        }
    }

    /// <summary>
    /// Adds a match event to the match when fired.
    /// Unbinds the events from the action input view.
    /// </summary>
    /// <param name="sender">The object which sends the event.</param>
    /// <param name="inputStatEventArgs">The input stat event arguments as part of the fired event.</param>
    private void OnEnterStatClicked(object? sender, InputStatEventArgs inputStatEventArgs)
    {
        _match.AddEvent(inputStatEventArgs);
        UnbindActionViewEvents();
    }

    /// <summary>
    /// Closes and unbinds the events from the action input view.
    /// </summary>
    /// <param name="sender">The object which sends the event.</param>
    /// <param name="eventArgs">The event arguments of the event.</param>
    private void OnEnterStatCancelled(object? sender, EventArgs eventArgs)
    {
        UnbindActionViewEvents();
    }
}