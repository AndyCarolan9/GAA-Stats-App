using System.Diagnostics;
using StatsTracker.Classes;

namespace StatsTracker.Model;

public class Match
{
    #region Fields

    private Stopwatch _matchTimer;

    private List<MatchEvent> _matchEvents;

    private string _matchName;
    
    private Team _homeTeam;
    
    private Team _awayTeam;

    private int _half = 1;

    #endregion
    
    #region Constructors

    public Match()
    {
        _matchName = Guid.NewGuid().ToString();
        _matchEvents = new List<MatchEvent>();
        _matchTimer = new Stopwatch();
        _homeTeam = new Team();
        _awayTeam = new Team();
    }

    public Match(Team homeTeam, Team awayTeam, string matchName, List<MatchEvent> matchEvents)
    {
        _homeTeam = homeTeam;
        _awayTeam = awayTeam;
        _matchName = matchName;
        _matchEvents = matchEvents;
        _matchTimer = new Stopwatch();
    }
    #endregion
    
    #region Methods

    public void StartHalf()
    {
        _matchTimer = Stopwatch.StartNew();
    }

    public void StopHalf()
    {
        _matchTimer.Stop();
    }

    public void PauseTimer()
    {
        _matchTimer.Stop();
    }

    public void ResumeTimer()
    {
        _matchTimer.Start();
    }

    public void AddEvent(MatchEvent matchEvent)
    {
        _matchEvents.Add(matchEvent);
    }

    public void RemoveEvent(MatchEvent matchEvent)
    {
        _matchEvents.Remove(matchEvent);
    }
    #endregion
}