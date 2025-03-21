﻿using System.Diagnostics;
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
    
    #region Getters

    public Team GetHomeTeam()
    {
        return _homeTeam;
    }

    public Team GetAwayTeam()
    {
        return _awayTeam;
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
            statArgs.EventType, statArgs.Team.TeamName);
        _matchEvents.Add(matchEvent);

        if (statArgs.EventType.IsTurnoverEvent())
        {
            _isHomeTeamInPossession = !_isHomeTeamInPossession;
        }
    }

    private void AddEvent(ShotEventArgs shotArgs)
    {
        var matchEvent = new ShotEvent(shotArgs.Location, shotArgs.Player, _matchTimer.ElapsedMilliseconds,
            shotArgs.EventType, shotArgs.Team.TeamName, shotArgs.ActionType, shotArgs.ResultType);
        _matchEvents.Add(matchEvent);

        if (shotArgs.IsTurnedOver)
        {
            _isHomeTeamInPossession = !_isHomeTeamInPossession;
        }
    }

    private void AddEvent(KickOutEventArgs kickOutEventArgs)
    {
        var matchEvent = new KickOutEvent(kickOutEventArgs.Location, kickOutEventArgs.Player, _matchTimer.ElapsedMilliseconds,
            kickOutEventArgs.EventType, kickOutEventArgs.Team.TeamName, kickOutEventArgs.ResultType);
        _matchEvents.Add(matchEvent);

        if (kickOutEventArgs.ResultType.IsPossessionTurnedOver())
        {
            _isHomeTeamInPossession = !_isHomeTeamInPossession;
        }
    }

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
}