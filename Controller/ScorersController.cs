using StatsTracker.Classes;
using StatsTracker.Enums;
using StatsTracker.Model;
using StatsTracker.Views;
using StatsTracker.Views.Statistics;

namespace StatsTracker.Controller;

public class ScorersController : IStatsController
{
    private readonly ScorersView _scorersView;
    private readonly Match _match;
    private readonly bool _isHomeTeam;
    private readonly string _teamName;

    public ScorersController(Match match, bool isHomeTeam)
    {
        _match = match;
        _teamName = isHomeTeam ? match.HomeTeam.TeamName :  match.AwayTeam.TeamName;
        _scorersView = new ScorersView();
        Initialize();
        PopulateScorersGrid();
    }
    
    public IStatsView GetView()
    {
        return _scorersView;
    }

    public DialogResult ShowDialog()
    {
        return _scorersView.ShowDialog();
    }

    private void Initialize()
    {
        DataGridView grid = _scorersView.GetScorersGrid();
        
        grid.AutoGenerateColumns = false;
        
        DataGridViewColumn player = new DataGridViewTextBoxColumn();
        player.HeaderText = "Player";
        player.Name = "Player";
        player.MinimumWidth = 150;
        
        DataGridViewColumn goals = new DataGridViewTextBoxColumn();
        goals.HeaderText = "Goals";
        goals.Name = "Goals";
        
        DataGridViewColumn points = new DataGridViewTextBoxColumn();
        points.HeaderText = "Points";
        points.Name = "Points";
        
        DataGridViewColumn pointShots = new DataGridViewTextBoxColumn();
        pointShots.HeaderText = "Point Shots";
        pointShots.Name = "PointShots";
        
        DataGridViewColumn goalShots = new DataGridViewTextBoxColumn();
        goalShots.HeaderText = "Goal Shots";
        goalShots.Name = "GoalShots";
        
        DataGridViewColumn doublePointShots = new DataGridViewTextBoxColumn();
        doublePointShots.HeaderText = "2 Point Shots";
        doublePointShots.Name = "DoublePointShots";
        
        DataGridViewColumn misses =  new DataGridViewTextBoxColumn();
        misses.HeaderText = "Missed Shots";
        misses.Name = "Misses";
        
        DataGridViewColumn placedBallShots =  new DataGridViewTextBoxColumn();
        placedBallShots.HeaderText = "Placed Ball Shots";
        placedBallShots.Name = "PlacedBallShots";
        
        DataGridViewColumn placedBallMisses =  new DataGridViewTextBoxColumn();
        placedBallMisses.HeaderText = "Placed Ball Misses";
        placedBallMisses.Name = "PlacedBallMisses";
        
        DataGridViewColumn pointPerShot =  new DataGridViewTextBoxColumn();
        pointPerShot.HeaderText = "Point Per Shot";
        pointPerShot.Name = "PointPerShot";
        
        // name, goals, points, pointShots(accuracy), goalsShots(accuracy), doublePointShots(accuracy), missesTotal, placedBallShots(accuracy), misses
        grid.Columns.Add(player);
        grid.Columns.Add(goals);
        grid.Columns.Add(points);
        grid.Columns.Add(pointShots);
        grid.Columns.Add(goalShots);
        grid.Columns.Add(doublePointShots);
        grid.Columns.Add(misses);
        grid.Columns.Add(placedBallShots);
        grid.Columns.Add(placedBallMisses);
        grid.Columns.Add(pointPerShot);
    }

    private void PopulateScorersGrid()
    {
        // Get all shot events for team
        // Organise by player
        // Do calculations
        // Add rows for each player
        // Order by highest scorer
        
        MatchEvent[] shotEvents = _match.MatchEvents.FindAll(me => me.TeamName == _teamName && me is ShotEvent).ToArray();
        if (shotEvents.Length == 0)
        {
            return;
        }

        Dictionary<string, List<ShotEvent>> playerScores = new Dictionary<string, List<ShotEvent>>();
        foreach (var shot in shotEvents)
        {
            ShotEvent scoreEvent = (ShotEvent)shot;
            if (playerScores.ContainsKey(scoreEvent.Player))
            {
                playerScores[scoreEvent.Player].Add(scoreEvent);
            }
            else
            {
                playerScores.Add(scoreEvent.Player, [scoreEvent]);
            }
        }
        
        DataGridView grid = _scorersView.GetScorersGrid();

        foreach (var playerScore in playerScores)
        {
            int goals = 0;
            int points = 0;
            int pointShots = 0;
            int doublePointShots = 0;
            int goalShots = 0;
            int missesFromPointShot = 0;
            int missesFromGoalShot = 0;
            int missesFromDoublePointShot = 0;
            int shotsFromPlacedBalls = 0;
            int missesFromPlacedBalls = 0;

            foreach (var shotEvent in playerScore.Value)
            {
                if (shotEvent.ActionType.IsPlacedBallAction())
                {
                    shotsFromPlacedBalls++;
                }
                
                if (shotEvent.Type == EventType.GoalShot)
                {
                    goalShots++;
                    if (shotEvent.ResultType == ShotResultType.Goal)
                    {
                        goals++;
                    }
                    else if (shotEvent.ResultType == ShotResultType.Point)
                    {
                        points++;
                    }
                    else
                    {
                        if (shotEvent.ActionType.IsPlacedBallAction())
                        {
                            missesFromPlacedBalls++;
                        }
                        
                        missesFromGoalShot++;
                    }
                    
                    continue;
                }

                if (shotEvent.Type == EventType.DoublePointShot)
                {
                    doublePointShots++;
                    if (shotEvent.ResultType == ShotResultType.DoublePoint)
                    {
                        points += 2;
                    }
                    else if (shotEvent.ResultType == ShotResultType.Point)
                    {
                        points++;
                    }
                    else
                    {
                        if (shotEvent.ActionType.IsPlacedBallAction())
                        {
                            missesFromPlacedBalls++;
                        }

                        missesFromDoublePointShot++;
                    }

                    continue;
                }

                pointShots++;
                if (shotEvent.ResultType == ShotResultType.Point)
                {
                    points++;
                }
                else
                {
                    if (shotEvent.ActionType.IsPlacedBallAction())
                    {
                        missesFromPlacedBalls++;
                    }

                    missesFromPointShot++;
                }
            }
            
            // name, goals, points, pointShots(accuracy), goalsShots(accuracy), doublePointShots(accuracy), missesTotal, placedBallShots(accuracy), misses
            string pointShotString = pointShots + " (" + CalculateAccuracy(pointShots, missesFromPointShot) + "%)";
            string goalShotString = goalShots + " (" + CalculateAccuracy(goalShots, missesFromGoalShot) + "%)";
            string doublePointShotString = doublePointShots + " (" + CalculateAccuracy(doublePointShots, missesFromDoublePointShot) + "%)";
            string placedBallString = shotsFromPlacedBalls + " (" + CalculateAccuracy(shotsFromPlacedBalls, missesFromPlacedBalls) + "%)";
            int totalMisses = missesFromGoalShot + missesFromPointShot + missesFromDoublePointShot;
            int totalPointsScored = points + (goals * 3);
            int totalShots = goalShots + pointShots + doublePointShots;
            double pointsPerShot = (double)totalPointsScored / (double)totalShots;
            grid.Rows.Add(playerScore.Key, goals, points, pointShotString, goalShotString, doublePointShotString, totalMisses, placedBallString, missesFromPlacedBalls, pointsPerShot);
        }
    }

    private double CalculateAccuracy(int totalShots, int misses)
    {
        if (totalShots == 0)
        {
            return 0;
        }

        if (misses == totalShots)
        {
            return 0;
        }
        
        double accuracy = (double)misses / (double)totalShots;
        
        accuracy = accuracy * 100;
        
        return Math.Round(100 - accuracy, 2);
    }
}