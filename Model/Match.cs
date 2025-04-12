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

    private int _half = 0;

    private bool _isHomeTeamInPossession = false;
    
    private bool _isPlayStarted = false;

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
    
    #region Properties
    public string MatchName => _matchName;
    
    public List<MatchEvent> MatchEvents => _matchEvents;
    
    public Team HomeTeam => _homeTeam;

    public Team AwayTeam => _awayTeam;
    #endregion
    
    #region Methods
    #region Timer Methods
    /// <summary>
    /// Starts the match timer and increments the half number.
    /// </summary>
    public void StartHalf()
    {
        if (_isPlayStarted)
        {
            StopHalf();
            return;
        }
        
        _matchTimer = Stopwatch.StartNew();
        _half += 1;
        _isPlayStarted = true;
    }

    /// <summary>
    /// Stops the match timer.
    /// </summary>
    private void StopHalf()
    {
        _matchTimer.Stop();
        _isPlayStarted = false;
    }

    /// <summary>
    /// Pauses the match timer.
    /// </summary>
    public void PauseTimer()
    {
        if (_isPlayStarted && !_matchTimer.IsRunning)
        {
            ResumeTimer();
            return;
        }
        _matchTimer.Stop();
    }

    /// <summary>
    /// Resumes the match timer.
    /// </summary>
    private void ResumeTimer()
    {
        _matchTimer.Start();
    }

    public TimeSpan GetElapsedTime()
    {
        return _matchTimer.Elapsed;
    }

    public int GetHalf()
    {
        return _half;
    }

    public bool IsMatchPlaying()
    {
        return _isPlayStarted;
    }
    #endregion

    #region Event Methods
    public void AddEvent(MatchEvent matchEvent)
    {
        _matchEvents.Add(matchEvent);
        if (matchEvent.Type.IsTurnoverEvent())
        {
            _isHomeTeamInPossession = !_isHomeTeamInPossession;
        }
    }

    public void RemoveEvent(MatchEvent matchEvent)
    {
        _matchEvents.Remove(matchEvent);
    }

    public void AddEvent(InputStatEventArgs statArgs)
    {
        if (statArgs is ShotEventArgs shotArgs)
        {
            AddEvent(shotArgs);
            return;
        }

        if (statArgs is KickOutEventArgs kickOutArgs)
        {
            AddEvent(kickOutArgs);
            return;
        }
        
        var matchEvent = new MatchEvent(statArgs.Location, statArgs.Player, _matchTimer.ElapsedMilliseconds, 
            statArgs.EventType, statArgs.Team.TeamName, _half);
        _matchEvents.Add(matchEvent);

        if (statArgs.EventType.IsTurnoverEvent())
        {
            _isHomeTeamInPossession = !_isHomeTeamInPossession;
        }
    }

    private void AddEvent(ShotEventArgs shotArgs)
    {
        var matchEvent = new ShotEvent(shotArgs.Location, shotArgs.Player, _matchTimer.ElapsedMilliseconds,
            shotArgs.EventType, shotArgs.Team.TeamName, _half, shotArgs.ActionType, shotArgs.ResultType);
        _matchEvents.Add(matchEvent);

        if (shotArgs.IsTurnedOver)
        {
            _isHomeTeamInPossession = !_isHomeTeamInPossession;
        }
    }

    private void AddEvent(KickOutEventArgs kickOutEventArgs)
    {
        var matchEvent = new KickOutEvent(kickOutEventArgs.Location, kickOutEventArgs.Player, _matchTimer.ElapsedMilliseconds,
            kickOutEventArgs.EventType, kickOutEventArgs.Team.TeamName, _half, kickOutEventArgs.ResultType);
        _matchEvents.Add(matchEvent);

        if (!kickOutEventArgs.ResultType.IsKickOutWon())
        {
            _isHomeTeamInPossession = !_isHomeTeamInPossession;
        }
    }
    #endregion
    
    #region Team Methods
    public Team GetTeamForEvent(EventType eventType)
    {
        if (eventType.IsInPossessionTeamEvent())
        {
            return GetInPossessionTeam();
        }

        return GetDefendingTeam();
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
    
    #region Statistic Methods
    public StatisticPair GetStatisticForEvent(EventType eventType)
    {
        List<MatchEvent> events = _matchEvents.FindAll(matchEvent => matchEvent.Type == eventType);
        return GetStatisticPairForEvent(events);
    }

    public StatisticPair GetStatisticForShotResult(ShotResultType resultType)
    {
        List<MatchEvent> events = _matchEvents.FindAll(matchEvent =>
        {
            if (matchEvent is ShotEvent shotEvent)
            {
                return shotEvent.ResultType == resultType;
            }
            
            return false;
        });
        return GetStatisticPairForEvent(events);
    }

    public StatisticPair GetStatisticPairForKickOutResult(KickOutResultType resultType)
    {
        List<MatchEvent> events = _matchEvents.FindAll(matchEvent =>
        {
            if (matchEvent is KickOutEvent kickOutEvent)
            {
                return kickOutEvent.ResultType == resultType;
            }

            return false;
        });
        
        return GetStatisticPairForEvent(events);
    }

    private StatisticPair GetStatisticPairByPredicate(Predicate<MatchEvent> predicate)
    {
        List<MatchEvent> events = _matchEvents.FindAll(predicate);
        return GetStatisticPairForEvent(events);
    }

    private StatisticPair GetStatisticPairForEvent(List<MatchEvent> matchEvents)
    {
        int homeCount = matchEvents.Count(matchEvent => matchEvent.TeamName == _homeTeam.TeamName);
        int awayCount = matchEvents.Count(matchEvent => matchEvent.TeamName == _awayTeam.TeamName);

        return new StatisticPair(homeCount, awayCount);
    }

    public StatisticPair GetTurnOvers()
    {
        StatisticPair turnOversWon = GetStatisticForEvent(EventType.TurnoverWon); 
        StatisticPair turnOversLost = GetStatisticForEvent(EventType.TurnoverLost);
        
        return new StatisticPair(turnOversWon.HomeTeamValue + turnOversLost.AwayTeamValue, 
            turnOversWon.AwayTeamValue + turnOversLost.HomeTeamValue);
    }

    public StatisticPair GetKickOutsWon()
    {
        StatisticPair kickOutsWon = GetStatisticPairByPredicate(matchEvent =>
        {
            if (matchEvent is KickOutEvent kickOutEvent)
            {
                return kickOutEvent.ResultType.IsKickOutWon();
            }

            return false;
        });
        
        return kickOutsWon;
    }

    public StatisticPair GetFrees()
    {
        StatisticPair freesConceded = GetStatisticForEvent(EventType.FreeConceded);
        StatisticPair fouledFrees = GetStatisticForEvent(EventType.FouledFree);
        
        return new StatisticPair(freesConceded.HomeTeamValue + fouledFrees.AwayTeamValue,
            freesConceded.AwayTeamValue + fouledFrees.HomeTeamValue);
    }
    #endregion
    #endregion
}