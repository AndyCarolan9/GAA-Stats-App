using System.Windows.Forms.DataVisualization.Charting;
using StatsTracker.Classes;
using StatsTracker.Enums;
using StatsTracker.Model;

namespace StatsTracker.Views.Graphs;

public partial class ScoreTimeLineView : Form, IStatsView
{
    private Chart _firstHalfChart = new Chart();
    private Chart _secondHalfChart = new Chart();

    private readonly Match _match;
    
    public ScoreTimeLineView(Match match)
    {
        InitializeComponent();
        
        _match = match;
    }

    public Form GetForm()
    {
        return this;
    }

    private void ScoreTimeLineView_Load(object sender, EventArgs e)
    {
        _firstHalfChart.Size =  new Size(930, 550);
        _firstHalfChart.Location = new Point(15, 30);
        _firstHalfChart.ChartAreas.Clear();
        _firstHalfChart.Series.Clear();
        
        ChartArea chartArea = new ChartArea("GraphArea");
        chartArea.AxisX.Title = "Time";
        chartArea.AxisY.Title = "Score";
        chartArea.AxisX.Interval = 5;
        chartArea.BackColor = Color.Silver;
        
        _firstHalfChart.ChartAreas.Add(chartArea);

        Series homeTeamLine = CreateLineForTeam(_match.HomeTeam, 1);
        Series awayTeamLine = CreateLineForTeam(_match.AwayTeam, 1);
        _firstHalfChart.Series.Add(homeTeamLine);
        _firstHalfChart.Series.Add(awayTeamLine);
        Controls.Add(_firstHalfChart);
        
        _secondHalfChart.Size =  new Size(930, 550);
        _secondHalfChart.Location = new Point(950, 30);
        _secondHalfChart.ChartAreas.Clear();
        _secondHalfChart.Series.Clear();
        
        ChartArea secondHalfChartArea = new ChartArea("GraphArea");
        secondHalfChartArea.AxisX.Title = "Time";
        secondHalfChartArea.AxisY.Title = "Score";
        secondHalfChartArea.AxisX.Interval = 5;
        secondHalfChartArea.BackColor = Color.Silver;
        
        _secondHalfChart.ChartAreas.Add(secondHalfChartArea);

        Series secondHalfHomeTeamLine = CreateLineForTeam(_match.HomeTeam, 2);
        Series secondHalfAwayTeamLine = CreateLineForTeam(_match.AwayTeam, 2);
        _secondHalfChart.Series.Add(secondHalfHomeTeamLine);
        _secondHalfChart.Series.Add(secondHalfAwayTeamLine);
        Controls.Add(_secondHalfChart);
    }

    private Series CreateLineForTeam(Team team, int halfIndex)
    {
        Series series = new Series(team.TeamName)
        {
            ChartType = SeriesChartType.Line,
            IsValueShownAsLabel = true,
            Color = team.TeamColor
        };
        series.Font = new Font("Verdana", 9, FontStyle.Bold);
        series.LabelForeColor = team.TeamColor;
        series.BorderWidth = 3;

        MatchEvent[] events = _match.GetMatchEventsOfType<ShotEvent>().Where(me => me.TeamName == team.TeamName).ToArray();
        
        int totalScore = 0;
        if (halfIndex == 2)
        {
            MatchEvent[] firstHalfEvents = events.Where(me => me.HalfIndex == 1).ToArray();
            foreach (var shot in firstHalfEvents)
            {
                ShotEvent shotEvent = (ShotEvent)shot;
                if (shotEvent.ResultType.IsScore())
                {
                    switch (shotEvent.ResultType)
                    {
                        case ShotResultType.Goal:
                            totalScore += 3;
                            break;
                        case ShotResultType.DoublePoint:
                            totalScore += 2;
                            break;
                        case ShotResultType.Point:
                            totalScore += 1;
                            break;
                    }
                }
            }
        }
        
        series.Points.AddXY(0, totalScore);
        MatchEvent[] shotEvents = events.Where(me => me.HalfIndex == halfIndex).ToArray();
        foreach (var shot in shotEvents)
        {
            ShotEvent shotEvent = (ShotEvent)shot;
            if (shotEvent.ResultType.IsScore())
            {
                switch (shotEvent.ResultType)
                {
                    case ShotResultType.Goal:
                        totalScore += 3;
                        break;
                    case ShotResultType.DoublePoint:
                        totalScore += 2;
                        break;
                    case ShotResultType.Point:
                        totalScore += 1;
                        break;
                }

                TimeSpan time = TimeSpan.FromMilliseconds(shotEvent.Time);
                series.Points.AddXY(time.Minutes, totalScore);
            }
        }

        MatchEvent? halfEndEvent = _match.GetMatchEventsOfType(EventType.HalfEnd).FirstOrDefault(me => me.HalfIndex == halfIndex);
        if (halfEndEvent != null)
        {
            TimeSpan time = TimeSpan.FromMilliseconds(halfEndEvent.Time);
            series.Points.AddXY(time.Minutes, totalScore);
        }

        return series;
    }
}