using StatsTracker.Classes;
using StatsTracker.Enums;
using StatsTracker.Model;
using StatsTracker.Views;
using StatsTracker.Views.Statistics;

namespace StatsTracker.Controller;

public class DisciplineReportController : IStatsController
{
    private readonly DisciplineReportView _view;
    private readonly Match _match;

    public DisciplineReportController(Match match)
    {
        _match = match;
        _view = new DisciplineReportView();
        
        InitialiseTeamSelect();
        InitialiseTables();
        
        UpdateViewData();
    }
    
    public IStatsView GetView()
    {
        return _view;
    }

    public DialogResult ShowDialog()
    {
        return _view.ShowDialog();
    }

    private void InitialiseTeamSelect()
    {
        string[] teams = new []{_match.HomeTeam.TeamName, _match.AwayTeam.TeamName};
        _view.GetTeamComboBox().Items.Clear();
        _view.GetTeamComboBox().Items.AddRange(teams);
        _view.GetTeamComboBox().SelectedIndex = 0;
    }

    private void UpdateViewData()
    {
        var selectedItem = _view.GetTeamComboBox().SelectedItem;
        if (selectedItem != null)
        {
            string? selectedString = selectedItem.ToString();
        
            Team selectedTeam = _match.HomeTeam.TeamName == selectedString ? _match.HomeTeam : _match.AwayTeam;
            Team opposition = _match.HomeTeam.TeamName != selectedString ? _match.HomeTeam : _match.AwayTeam;
        
            bool isHomeTeamAttacking = _match.HomeTeam.TeamName != selectedTeam.TeamName;
        
            UpdateTeamFreesGrid(_view.GetTeamConcededFreesDataGrid(), selectedTeam, isHomeTeamAttacking);
            UpdateTeamFreesGrid(_view.GetTeamWonFreesDataGrid(), opposition, !isHomeTeamAttacking);
            UpdatePlayerFreesGrid(_view.GetPlayerConcededFreesDataGrid(), selectedTeam, true);
            UpdatePlayerFreesGrid(_view.GetPlayerWonFreesDataGrid(), selectedTeam, false);
        }
    }

    private void InitialiseTables()
    {
        DataGridView teamConcededGrid = _view.GetTeamConcededFreesDataGrid();
        teamConcededGrid.AutoGenerateColumns = false;
        
        DataGridView playerConcededGrid = _view.GetPlayerConcededFreesDataGrid();
        playerConcededGrid.AutoGenerateColumns = false;
        
        DataGridView teamWonGrid = _view.GetTeamWonFreesDataGrid();
        teamWonGrid.AutoGenerateColumns = false;
        
        DataGridView playerWonGrid = _view.GetPlayerWonFreesDataGrid();
        playerWonGrid.AutoGenerateColumns = false;
        
        AddColumnsToTeamTable(teamConcededGrid);
        AddColumnsToPlayerTable(playerConcededGrid);
        AddColumnsToTeamTable(teamWonGrid);
        AddColumnsToPlayerTable(playerWonGrid);
    }

    private void AddColumnsToTeamTable(DataGridView dataGridView)
    {
        dataGridView.DefaultCellStyle.Font = new Font("Segoe UI Emoji", 12);
        
        DataGridViewColumn typeColumn = new DataGridViewTextBoxColumn();
        typeColumn.HeaderText = "Type";
        typeColumn.MinimumWidth = 200;
        
        DataGridViewColumn totalColumn = new DataGridViewTextBoxColumn();
        totalColumn.HeaderText = "Total";
        
        DataGridViewColumn firstHalfColumn = new DataGridViewTextBoxColumn();
        firstHalfColumn.HeaderText = "First Half";
        
        DataGridViewColumn secondHalfColumn = new DataGridViewTextBoxColumn();
        secondHalfColumn.HeaderText = "Second Half";
        
        dataGridView.Columns.Add(typeColumn);
        dataGridView.Columns.Add(totalColumn);
        dataGridView.Columns.Add(firstHalfColumn);
        dataGridView.Columns.Add(secondHalfColumn);
    }

    private void AddColumnsToPlayerTable(DataGridView dataGridView)
    {
        dataGridView.DefaultCellStyle.Font = new Font("Segoe UI Emoji", 12);
        
        DataGridViewColumn typeColumn = new DataGridViewTextBoxColumn();
        typeColumn.HeaderText = "Player";
        typeColumn.MinimumWidth = 200;
        
        DataGridViewColumn totalColumn = new DataGridViewTextBoxColumn();
        totalColumn.HeaderText = "Total";
        
        dataGridView.Columns.Add(typeColumn);
        dataGridView.Columns.Add(totalColumn);
    }

    private void UpdateTeamFreesGrid(DataGridView dataGrid, Team team, bool isHomeTeamAttacking)
    {
        MatchEvent[] freeConcededEvent = _match.GetMatchEventsOfType(EventType.FreeConceded).Where(me => me.TeamName == team.TeamName).ToArray();
        MatchEvent[] turnoverFree = _match.GetTurnoverEventsOfType(TurnoverType.Free)
            .Where(me => (me.Type == EventType.TurnoverLost && me.TeamName == team.TeamName) || 
                         (me.Type == EventType.TurnoverWon && me.TeamName != team.TeamName)).ToArray();
        
        // Total Frees
        int totalConceded = freeConcededEvent.Length + turnoverFree.Length;
        int concededFirstHalf = freeConcededEvent.Count(me => me.HalfIndex == 1) + turnoverFree.Count(me => me.HalfIndex == 1);
        int concededSecondHalf = freeConcededEvent.Count(me => me.HalfIndex == 2) + turnoverFree.Count(me => me.HalfIndex == 2);
        
        // Turnovers
        int turnoverFirstHalf = turnoverFree.Count(me => me.HalfIndex == 1);
        int turnoverSecondHalf = turnoverFree.Count(me => me.HalfIndex == 2);

        // Frees conceded without possession
        int freeConcededFirstHalf = freeConcededEvent.Count(me => me.HalfIndex == 1);
        int freeConcededSecondHalf = freeConcededEvent.Count(me => me.HalfIndex == 2);
        
        // Score-able frees
        int firstHalfScoreableFrees = 0;
        int secondHalfScoreableFrees = 0;

        foreach (MatchEvent e in freeConcededEvent)
        {
            if (_match.GetDistanceFromGoal(isHomeTeamAttacking, e.Location) < 50)
            {
                if (e.HalfIndex == 1)
                {
                    firstHalfScoreableFrees++;
                }
                else
                {
                    secondHalfScoreableFrees++;
                }
            }
        }

        foreach (MatchEvent e in turnoverFree)
        {
            if (_match.GetDistanceFromGoal(isHomeTeamAttacking, e.Location) < 50)
            {
                if (e.HalfIndex == 1)
                {
                    firstHalfScoreableFrees++;
                }
                else
                {
                    secondHalfScoreableFrees++;
                }
            }
        }
        
        dataGrid.Rows.Clear();
        dataGrid.Rows.Add("Total Frees", totalConceded, concededFirstHalf, concededSecondHalf);
        dataGrid.Rows.Add("Turnover Frees", turnoverFree.Length, turnoverFirstHalf, turnoverSecondHalf);
        dataGrid.Rows.Add("In Play Frees", freeConcededEvent.Length, freeConcededFirstHalf, freeConcededSecondHalf);
        dataGrid.Rows.Add("Scoreable Frees", firstHalfScoreableFrees+secondHalfScoreableFrees, firstHalfScoreableFrees, secondHalfScoreableFrees);
    }

    private void UpdatePlayerFreesGrid(DataGridView dataGrid, Team team, bool isConcededFrees)
    {
        List<MatchEvent> allEvents =  new List<MatchEvent>();
        if (isConcededFrees)
        {
            MatchEvent[] freeConcededEvent = _match.GetMatchEventsOfType(EventType.FreeConceded).Where(me => me.TeamName == team.TeamName).ToArray();
            MatchEvent[] turnoverFree = _match.GetTurnoverEventsOfType(TurnoverType.Free)
                .Where(me => me.Type == EventType.TurnoverLost && me.TeamName == team.TeamName).ToArray();
            allEvents.AddRange(freeConcededEvent);
            allEvents.AddRange(turnoverFree);
        }
        else
        {
            MatchEvent[] turnovers = _match.GetTurnoverEventsOfType(TurnoverType.Free)
                .Where(me => me.Type == EventType.TurnoverWon && me.TeamName == team.TeamName).ToArray();
            allEvents.AddRange(turnovers);
        }
        
        Dictionary<string, List<MatchEvent>> matchEvents = new Dictionary<string, List<MatchEvent>>();
        foreach (var matchEvent in allEvents)
        {
            if (!matchEvents.ContainsKey(matchEvent.Player))
            {
                matchEvents.Add(matchEvent.Player, new List<MatchEvent>());
                matchEvents[matchEvent.Player].Add(matchEvent);
                continue;
            }
            
            matchEvents[matchEvent.Player].Add(matchEvent);
        }

        dataGrid.Rows.Clear();
        foreach (var playerEvents in matchEvents)
        {
            dataGrid.Rows.Add(playerEvents.Key, playerEvents.Value.Count);
        }
    }
}