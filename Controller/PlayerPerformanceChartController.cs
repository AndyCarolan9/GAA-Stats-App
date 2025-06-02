using System.Windows.Forms.DataVisualization.Charting;
using StatsTracker.Classes;
using StatsTracker.Enums;
using StatsTracker.Model;
using StatsTracker.Views;
using StatsTracker.Views.Graphs;

namespace StatsTracker.Controller;

public class PlayerPerformanceChartController : IStatsController
{
    private PlayerPerformanceChart _view;
    private readonly Match _match;

    public PlayerPerformanceChartController(Match match)
    {
        _view = new PlayerPerformanceChart();
        _match = match;

        ComboBox teams = _view.GetTeamsComboBox();
        teams.SelectedValueChanged += SelectedTeamChanged;
        teams.Items.AddRange(_match.HomeTeam.TeamName, _match.AwayTeam.TeamName);
        _view.GetPlayersComboBox().SelectedValueChanged += SelectedPlayerChanged;
    }
    
    public IStatsView GetView()
    {
        return _view;
    }

    public DialogResult ShowDialog()
    {
        return _view.ShowDialog();
    }

    private void SelectedTeamChanged(object? sender, EventArgs e)
    {
        PopulatePlayersComboBox();
    }

    private void SelectedPlayerChanged(object? sender, EventArgs e)
    {
        _view.GetChart().Series.Clear();

        string? player = _view.GetPlayersComboBox().SelectedItem?.ToString();
        if (player == null)
        {
            return;
        }
        
        PopulatePositiveEvents(player);
        PopulateNegativeEvents(player);
    }

    private void PopulatePositiveEvents(string player)
    {
        MatchEvent[] positiveEvents = _match.GetPositiveMatchEvents(player);
        DrawLineForEvents(positiveEvents, Color.Green, "Positive");

        int firstHalfTOWon = positiveEvents.Count(me => me is { HalfIndex: 1, Type: EventType.TurnoverWon });
        int SecondHalfTOWon = positiveEvents.Count(me => me is { HalfIndex: 2, Type: EventType.TurnoverWon });
        int firstHalfKOWon = positiveEvents.Count(me => me is { HalfIndex: 1, Type: EventType.KickOut });
        int secondHalfKOWon = positiveEvents.Count(me => me is { HalfIndex: 2, Type: EventType.KickOut });
        int firstHalfPoints = 0;
        int secondHalfPoints = 0;
        int firstHalfGoals = 0;
        int secondHalfGoals = 0;
        int firstHalf2Points = 0;
        int secondHalf2Points = 0;

        foreach (var matchEvent in positiveEvents)
        {
            if (matchEvent is ShotEvent shotEvent)
            {
                if (shotEvent.HalfIndex == 1)
                {
                    switch (shotEvent.ResultType)
                    {
                        case ShotResultType.Goal:
                            firstHalfGoals++;
                            break;
                        case ShotResultType.Point:
                            firstHalfPoints++;
                            break;
                        case ShotResultType.DoublePoint:
                            firstHalf2Points++;
                            break;
                    }

                    continue;
                }
                
                switch (shotEvent.ResultType)
                {
                    case ShotResultType.Goal:
                        secondHalfGoals++;
                        break;
                    case ShotResultType.Point:
                        secondHalfPoints++;
                        break;
                    case ShotResultType.DoublePoint:
                        secondHalf2Points++;
                        break;
                }
            }
        }

        _view.GetFHTOWonLabel().Text = firstHalfTOWon.ToString();
        _view.GetSHTOWonLabel().Text = SecondHalfTOWon.ToString();
        _view.GetTOTTOWonLabel().Text = (firstHalfTOWon + SecondHalfTOWon).ToString();
        
        _view.GetFHKOWonLabel().Text = firstHalfKOWon.ToString();
        _view.GetSHKOWonLabel().Text = secondHalfKOWon.ToString();
        _view.GetTOTKOWonLabel().Text = (secondHalfKOWon + firstHalfKOWon).ToString();
        
        _view.GetFHPointLabel().Text = firstHalfPoints.ToString();
        _view.GetSHPointLabel().Text = secondHalfPoints.ToString();
        _view.GetTOTPointLabel().Text = (firstHalfPoints + secondHalfPoints).ToString();
        
        _view.GetFH2PointLabel().Text = firstHalf2Points.ToString();
        _view.GetSH2PointLabel().Text = secondHalf2Points.ToString();
        _view.GetTOT2PointLabel().Text = (firstHalf2Points + secondHalf2Points).ToString();
        
        _view.GetFHGoalLabel().Text = firstHalfGoals.ToString();
        _view.GetSHGoalLabel().Text = secondHalfGoals.ToString();
        _view.GetTOTGoalLabel().Text = (secondHalfGoals + firstHalfGoals).ToString();
    }

    private void PopulateNegativeEvents(string player)
    {
        MatchEvent[] negativeEvents = _match.GetNegativeMatchEvents(player);
        DrawLineForEvents(negativeEvents, Color.Red, "Negative");
        
        int firstHalfTOLost = negativeEvents.Count(me => me is { HalfIndex: 1, Type: EventType.TurnoverLost });
        int SecondHalfTOLost = negativeEvents.Count(me => me is { HalfIndex: 2, Type: EventType.TurnoverLost });
        int firstHalfMisses = negativeEvents.Count(me => me is ShotEvent && me.HalfIndex == 1);
        int secondHalfMisses = negativeEvents.Count(me => me is ShotEvent && me.HalfIndex == 1);
        int firstHalfFrees = 0;
        int secondHalfFrees = 0;
        int firstHalfScoreableFrees = 0;
        int secondHalfScoreableFrees = 0;

        bool isHomeTeam = _match.HomeTeam.TeamName == _view.GetTeamsComboBox().SelectedItem?.ToString();
        foreach (var matchEvent in negativeEvents)
        {
            if (matchEvent.HalfIndex == 1 && matchEvent.Type == EventType.FreeConceded)
            {
                if (_match.GetDistanceFromGoal(isHomeTeam, matchEvent.Location) < 50)
                {
                    firstHalfScoreableFrees++;
                    continue;
                }

                firstHalfFrees++;
                continue;
            }

            if (matchEvent.Type == EventType.FreeConceded)
            {
                if (_match.GetDistanceFromGoal(isHomeTeam, matchEvent.Location) < 50)
                {
                    secondHalfScoreableFrees++;
                    continue;
                }

                secondHalfFrees++;
            }
        }
        
        _view.GetFHTOLostLabel().Text = firstHalfTOLost.ToString();
        _view.GetSHTOLostLabel().Text = SecondHalfTOLost.ToString();
        _view.GetTOTTOLostLabel().Text = (firstHalfTOLost + SecondHalfTOLost).ToString();
        
        _view.GetFHMissesLabel().Text = firstHalfMisses.ToString();
        _view.GetSHMissesLabel().Text = secondHalfMisses.ToString();
        _view.GetTOTMissesLabel().Text = (secondHalfMisses + firstHalfMisses).ToString();
        
        _view.GetFHFreesLabel().Text = firstHalfFrees.ToString();
        _view.GetSHFreesLabel().Text = secondHalfFrees.ToString();
        _view.GetTOTFreesLabel().Text = (firstHalfFrees + secondHalfFrees).ToString();
        
        _view.GetFHScoreableFreesLabel().Text = firstHalfScoreableFrees.ToString();
        _view.GetSHScoreableFreesLabel().Text = secondHalfScoreableFrees.ToString();
        _view.GetTOTScoreableFreesLabel().Text = (firstHalfScoreableFrees + secondHalfScoreableFrees).ToString();
    }
    
    private void PopulatePlayersComboBox()
    {
        ComboBox playersBox = _view.GetPlayersComboBox();
        playersBox.Items.Clear();
        string? selectedTeam = _view.GetTeamsComboBox().SelectedItem?.ToString();
        if (selectedTeam == null)
        {
            return;
        }
        
        Team team = selectedTeam == _match.HomeTeam.TeamName ? _match.HomeTeam : _match.AwayTeam;
        if (team.TeamSheet.Count == 0)
        {
            return;
        }

        foreach (var player in team.TeamSheet)
        {
            playersBox.Items.Add(player);
        }
    }

    private void DrawLineForEvents(MatchEvent[] events, Color lineColor, string seriesName)
    {
        Series series = new Series(seriesName)
        {
            ChartType = SeriesChartType.Line,
            Color = lineColor,
            IsValueShownAsLabel = true,
            BorderWidth = 3,
            Font = new Font("Verdana", 9, FontStyle.Bold)
        };

        series.Points.AddXY(0, 0);
        int eventCount = 1;
        foreach (var matchEvent in events)
        {
            int x = 0;
            if (matchEvent.HalfIndex == 2)
            {
                TimeSpan time = TimeSpan.FromMilliseconds(matchEvent.Time);
                x = 30 + time.Minutes;
            }
            else
            {
                TimeSpan time = TimeSpan.FromMilliseconds(matchEvent.Time);
                x = time.Minutes;
            }
            
            series.Points.AddXY(x, eventCount);
            eventCount++;
        }
        
        _view.GetChart().Series.Add(series);
    }
}