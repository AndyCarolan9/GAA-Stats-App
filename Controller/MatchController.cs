using StatsTracker.Classes;
using StatsTracker.Events;
using StatsTracker.Model;
using StatsTracker.Views;

namespace StatsTracker.Controller;

public class MatchController : IStatsController
{
    private Match _match;
    private MatchView _view;

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
        var ActionForm = new ActionSelectWindow(team, e);
        ActionForm.ShowDialog();
    }
}