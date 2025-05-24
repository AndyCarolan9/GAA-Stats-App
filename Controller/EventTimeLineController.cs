using System.Numerics;
using StatsTracker.Classes;
using StatsTracker.Enums;
using StatsTracker.Model;
using StatsTracker.Views;
using StatsTracker.Views.Graphs;

namespace StatsTracker.Controller;

public class EventTimeLineController : IStatsController
{
    private readonly EventTimeLine _view;
    private readonly Match _match;

    public EventTimeLineController(Match match)
    {
        _view = new EventTimeLine();
        _match = match;
        
        InitialiseTimeLine();
        _view.GetHomeTeamLabel().Text = _match.HomeTeam.TeamName;
        _view.GetAwayTeamLabel().Text = _match.AwayTeam.TeamName;
    }
    
    public IStatsView GetView()
    {
        return _view;
    }

    public DialogResult ShowDialog()
    {
        return _view.ShowDialog();
    }

    private void InitialiseTimeLine()
    {
        var panelTimeline = _view.GetEventPanel();
        int y = 10;
        
        List<MatchEvent> matchEvents = _match.MatchEvents.FindAll(me => me is ShotEvent);

        int homeTotalScore = 0;
        int awayTotalScore = 0;
        foreach (var timelineEvent in matchEvents.OrderBy(x => x.HalfIndex).ThenBy(x => x.Time).ToArray())
        {
            ShotEvent? shotEvent = timelineEvent as ShotEvent;
            if (shotEvent == null)
                continue;
            
            bool isHomeTeam = shotEvent.TeamName == _match.HomeTeam.TeamName;
            
            TimeSpan time = TimeSpan.FromMilliseconds(shotEvent.Time);
            
            UpdateScoreForEvent(shotEvent, isHomeTeam, ref homeTotalScore, ref awayTotalScore);
            
            Panel eventPanel = new Panel
            {
                Width = 200,
                Height = 165,
                Top = y,
                Left = isHomeTeam ? 10 : 240,
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lblHalf = new Label
            {
                Text = shotEvent.HalfIndex == 1 ? "1st Half" : "2nd Half",
                Top = 50,
                Left = 10,
                Width = 100,
                Font = new Font("Segoe UI", 12)
            };
            
            Label lblTime = new Label
            {
                Text = time.ToString(@"mm\:ss"),
                Top = 50,
                Left = 110,
                Width = 80,
                Font = new Font("Segoe UI", 12)
            };

            Label lblName = new Label
            {
                BackColor = isHomeTeam ? _match.HomeTeam.TeamColor : _match.AwayTeam.TeamColor,
                Text = shotEvent.TeamName,
                Top = 10,
                Left = 10,
                Width = 180,
                Height = 35,
                Font = new Font("Segoe UI", 15, FontStyle.Bold)
            };

            Label lblDescription = new Label
            {
                Text = shotEvent.ResultType.GetEventName() + " By " + shotEvent.Player,
                Top = 80,
                Left = 10,
                Width = 180,
                Font = new Font("Segoe UI", 10)
            };
            
            Label lblScoreDiff = new Label
            {
                Text = MakeScoreDifferenceString(isHomeTeam, homeTotalScore, awayTotalScore),
                Top = 105,
                Left = 10,
                Width = 100,
                Font = new Font("Segoe UI", 10)
            };

            Label lblShotDistance = new Label
            {
                Text = GetDistanceFromGoal(isHomeTeam, shotEvent.Location) + "* metres from goal.",
                Top = 130,
                Left = 10,
                Width = 180,
                Font = new Font("Segoe UI", 10)
            };

            eventPanel.Controls.Add(lblHalf);
            eventPanel.Controls.Add(lblTime);
            eventPanel.Controls.Add(lblName);
            eventPanel.Controls.Add(lblDescription);
            eventPanel.Controls.Add(lblScoreDiff);
            eventPanel.Controls.Add(lblShotDistance);

            panelTimeline.Controls.Add(eventPanel);
            y += eventPanel.Height + 10;
        }
    }

    private void UpdateScoreForEvent(ShotEvent shotEvent, bool isHomeTeam, ref int homeTotalScore, ref int awayTotalScore)
    {
        if (shotEvent.ResultType.IsScore())
        {
            switch (shotEvent.ResultType)
            {
                case ShotResultType.Goal:
                    if (isHomeTeam)
                        homeTotalScore += 3;
                    else
                        awayTotalScore += 3;
                    break;
                case ShotResultType.DoublePoint:
                    if (isHomeTeam)
                        homeTotalScore += 2;
                    else
                        awayTotalScore += 2;
                    break;
                case ShotResultType.Point:
                    if (isHomeTeam)
                        homeTotalScore += 1;
                    else
                        awayTotalScore += 1;
                    break;
            }
        }
    }

    private string MakeScoreDifferenceString(bool isForHomeTeam, int homeScore, int awayScore)
    {
        string result = "";
        int scoreDifference = 0;
        
        if (isForHomeTeam)
        {
             scoreDifference = homeScore - awayScore;
        }
        else
        {
            scoreDifference = awayScore - homeScore;
        }
        
        if (scoreDifference == 0)
            return "Drawn";
            
        result += scoreDifference > 0 ? "Up by: " : "Down by: ";
            
        return result + Math.Abs(scoreDifference);
    }

    private int GetDistanceFromGoal(bool isHomeEvent, Point shotLocation)
    {
        Vector2 realWorldHomeGoal = new Vector2(45, 0);
        Vector2 realWorldAwayGoal = new Vector2(45, 145);
        
        int width = 700;
        int height = 964;

        float xPercent = (float)shotLocation.X / width;
        float yPercent = (float)shotLocation.Y / height;
        
        float realWorldX = 90 * xPercent;
        float realWorldY = 145 * yPercent;

        float distance = 0.0f;
        if (isHomeEvent)
            distance = Vector2.Distance(new Vector2(realWorldX, realWorldY), realWorldAwayGoal);
        else
            distance = Vector2.Distance(new Vector2(realWorldX, realWorldY), realWorldHomeGoal);
        
        return Convert.ToInt32(distance);
    }
}