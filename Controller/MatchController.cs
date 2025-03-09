using StatsTracker.Classes;
using StatsTracker.Events;
using StatsTracker.Model;
using StatsTracker.Views;

namespace StatsTracker.Controller;

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

    private void BindViewEvents()
    {
        _view.OnStatEntered += OnStatEntered;
    }

    private void OnStatEntered(object? sender, InputStatEventArgs e)
    {
        Team team = new Team("Glen Emmets", Color.Green, new []{"Ian O'Reilly", "Emmet Delaney", "Keith Boylan",
            "Jamie Farnan", "Callum Wogan", "Evan English", "Brien Maguire", "Cian Talbot", "Darragh Russel", "Paddy McHugh",
            "Kealan O'Neill", "James Butler", "Eoin Maguire", "Alex Carolan", "Lorcan Lynch"});
        _actionSelectWindow = new ActionSelectWindow(team, e);
        BindActionViewEvents();
        _actionSelectWindow.ShowDialog();
    }

    private void BindActionViewEvents()
    {
        if (_actionSelectWindow != null)
        {
            _actionSelectWindow.OnEnterStatClicked += OnEnterStatClicked;
            _actionSelectWindow.OnCancelled += OnEnterStatCancelled;
        }
    }

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

    private void OnEnterStatClicked(object? sender, InputStatEventArgs e)
    {
        _match.AddEvent(e);
        UnbindActionViewEvents();
    }

    private void OnEnterStatCancelled(object? sender, EventArgs e)
    {
        UnbindActionViewEvents();
    }
}