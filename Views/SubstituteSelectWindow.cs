using StatsTracker.Classes;
using StatsTracker.Events;
using StatsTracker.Utils;

namespace StatsTracker.Views;

public partial class SubstituteSelectWindow : PlayerSelectWindow
{
    public SubstituteSelectWindow(InputStatEventArgs eventArgs)
    : base(eventArgs.Team, eventArgs)
    {
        InitializeComponent();
        LoadSubsitutes();
    }

    private void LoadSubsitutes()
    {
        if (InputStatEventArgs == null)
        {
            return;
        }
        
        Team[]? teams = JSONHelper.LoadFromJsonFile<Team[]>(JSONHelper.GetFilePath("Teams.json"));
        if (teams == null)
        {
            return;
        }
        
        Team? selectedTeam = GetTeam(teams);
        if (selectedTeam == null)
        {
            return;
        }
        
        List<string> availablePlayers = new List<string>();
        foreach (string player in selectedTeam.TeamSheet)
        {
            if (!InputStatEventArgs.Team.CurrentTeam.Contains(player))
            {
                availablePlayers.Add(player);
            }
        }
        
        PlayerListbox.BeginUpdate();
        PlayerListbox.Items.Clear();
        PlayerListbox.Items.AddRange(availablePlayers.ToArray());
        PlayerListbox.EndUpdate();
    }

    private Team? GetTeam(Team[] teams)
    {
        if (InputStatEventArgs == null)
        {
            return null;
        }
        
        foreach (var team in teams)
        {
            if (team.TeamName == InputStatEventArgs?.Team.TeamName)
                return team;
        }
        
        return null;
    }

    protected override void EnterStat_Click(object? sender, EventArgs eventArgs)
    {
        string? selectedSub = (string)PlayerListbox.SelectedItem;
        if (selectedSub == null)
        {
            return;
        }
        
        SubstitutionEventArgs? subsitutionEventArgs = (SubstitutionEventArgs)InputStatEventArgs;
        if (subsitutionEventArgs == null)
        {
            return;
        }
        
        subsitutionEventArgs.Team = SelectedTeam;
        subsitutionEventArgs.SubstitutePlayer = selectedSub;
        subsitutionEventArgs.Player = GetSelectedPlayerName();
        OnEnterStatInvoked(subsitutionEventArgs);
    }
}