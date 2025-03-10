using System.Diagnostics;
using StatsTracker.Classes;
using StatsTracker.Enums;
using StatsTracker.Events;

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

    private bool _isHomeTeamInPossession = false;

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

    public Match(Team homeTeam, Team awayTeam)
    {
        _matchName = Guid.NewGuid().ToString();
        _matchEvents = new List<MatchEvent>();
        _matchTimer = new Stopwatch();
        _homeTeam = homeTeam;
        _awayTeam = awayTeam;
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

    public void AddEvent(InputStatEventArgs statArgs)
    {
        var matchEvent = new MatchEvent(statArgs.Location, statArgs.Player, _matchTimer.ElapsedMilliseconds, 
            statArgs.EventType, statArgs.ActionType, statArgs.Team.TeamName);
        _matchEvents.Add(matchEvent);
    }

    public Team GetTeamForEvent(EventType eventType)
    {
        switch(eventType)
        {
            case EventType.TurnoverLost:
            case EventType.OutFor45:
            case EventType.Point:
            case EventType.Goal:
            case EventType.DoublePoint:
            case EventType.Short:
            case EventType.OffPosts:
            case EventType.KickOutWon:
            case EventType.KickOutWonMark:
            case EventType.Saved:
            case EventType.SavedOutFor45:
            case EventType.Wide:
                return GetInPossessionTeam();
            default:
                return GetDefendingTeam();
        }
    }

    public Team GetInPossessionTeam()
    {
        if (_isHomeTeamInPossession)
        {
            return _homeTeam;
        }
        
        return _awayTeam;
    }

    public Team GetDefendingTeam()
    {
        if (_isHomeTeamInPossession)
        {
            return _awayTeam;
        }
        
        return _homeTeam;
    }
    #endregion
}