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
        string selectedString = _view.GetTeamComboBox().SelectedText;
        
        Team selectedTeam = _match.HomeTeam.TeamName == selectedString ? _match.HomeTeam : _match.AwayTeam;
        
        UpdateTeamConcededFreesGrid(selectedTeam);
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
        
        AddColumnsToTable(teamConcededGrid);
        AddColumnsToTable(playerConcededGrid);
        AddColumnsToTable(teamWonGrid);
        AddColumnsToTable(playerWonGrid);
    }

    private void AddColumnsToTable(DataGridView dataGridView)
    {
        dataGridView.DefaultCellStyle.Font = new Font("Segoe UI Emoji", 12);
        
        DataGridViewColumn typeColumn = new DataGridViewTextBoxColumn();
        typeColumn.HeaderText = "Type";
        typeColumn.MinimumWidth = 300;
        
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

    private void UpdateTeamConcededFreesGrid(Team team)
    {
        DataGridView dataGrid = _view.GetTeamConcededFreesDataGrid();
        
        MatchEvent[] freeConcededEvent = _match.GetMatchEventsOfType(EventType.FreeConceded).Where(me => me.TeamName == team.TeamName).ToArray();
        MatchEvent[] turnoverFree = _match.GetTurnoverEventsOfType(TurnoverType.Free)
            .Where(me => me.Type == EventType.TurnoverLost && me.TeamName == team.TeamName).ToArray();
        
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
        
        bool isHomeTeamAttacking = _match.HomeTeam.TeamName != team.TeamName;

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
        dataGrid.Rows.Add("Total Frees Conceded", totalConceded, concededFirstHalf, concededSecondHalf);
        dataGrid.Rows.Add("Turnover Frees", turnoverFree.Length, turnoverFirstHalf, turnoverSecondHalf);
        dataGrid.Rows.Add("Free conceded without possession", freeConcededEvent.Length, freeConcededFirstHalf, freeConcededSecondHalf);
        dataGrid.Rows.Add("Scoreable Frees Conceded", firstHalfScoreableFrees+secondHalfScoreableFrees, firstHalfScoreableFrees, secondHalfScoreableFrees);
    }
}