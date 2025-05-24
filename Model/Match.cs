using System.Diagnostics;
using StatsTracker.Classes;
using StatsTracker.Enums;
using StatsTracker.Events;

namespace StatsTracker.Model;

public class Match
{
    #region Fields

    private Stopwatch _matchTimer;

    private int _half = 0;

    private bool _isHomeTeamInPossession = false;
    
    private bool _isPlayStarted = false;

    #endregion
    
    #region Constructors

    public Match()
    {
        MatchName = Guid.NewGuid().ToString();
        MatchEvents = new List<MatchEvent>();
        _matchTimer = new Stopwatch();
        HomeTeam = new Team();
        AwayTeam = new Team();
    }

    public Match(Team homeTeam, Team awayTeam)
    {
        MatchName = Guid.NewGuid().ToString();
        MatchEvents = new List<MatchEvent>();
        _matchTimer = new Stopwatch();
        HomeTeam = homeTeam;
        AwayTeam = awayTeam;
    }

    public Match(Team homeTeam, Team awayTeam, string matchName, List<MatchEvent> matchEvents)
    {
        HomeTeam = homeTeam;
        AwayTeam = awayTeam;
        MatchName = matchName;
        MatchEvents = matchEvents;
        _matchTimer = new Stopwatch();
    }
    #endregion
    
    #region Properties
    public string MatchName { get; set; }

    public List<MatchEvent> MatchEvents { get; set; }

    public Team HomeTeam { get; set; }

    public Team AwayTeam { get; set; }

    #endregion
    
    #region Methods
    public bool IsHomeTeamInPossession()
    {
        return _isHomeTeamInPossession;
    }
    
    public bool IsMatchValid()
    {
        return HomeTeam.IsTeamValid() && AwayTeam.IsTeamValid();
    }

    public MatchEvent? GetLastMatchEvent()
    {
        if (MatchEvents.Count == 0)
        {
            return null;
        }
        
        return MatchEvents[MatchEvents.Count - 1];
    }
    
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
        AddEvent(new MatchEvent(new Point(), "", 0, EventType.HalfStart, "", _half));
    }

    /// <summary>
    /// Stops the match timer.
    /// </summary>
    private void StopHalf()
    {
        _matchTimer.Stop();
        _isPlayStarted = false;
        AddEvent(new MatchEvent(new Point(), "", _matchTimer.ElapsedMilliseconds, EventType.HalfEnd, "", _half));
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
        MatchEvents.Add(matchEvent);
        if (matchEvent.Type.IsTurnoverEvent())
        {
            _isHomeTeamInPossession = !_isHomeTeamInPossession;
        }
    }

    public void RemoveEvent(MatchEvent matchEvent)
    {
        MatchEvents.Remove(matchEvent);
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

        if (statArgs is TurnoverEventArgs turnOverArgs)
        {
            AddEvent(turnOverArgs);
            return;
        }

        if (statArgs is SubstitutionEventArgs subEventArgs)
        {
            AddEvent(subEventArgs);
            return;
        }
        
        var matchEvent = new MatchEvent(statArgs.Location, statArgs.Player, _matchTimer.ElapsedMilliseconds, 
            statArgs.EventType, statArgs.Team.TeamName, _half);
        MatchEvents.Add(matchEvent);

        if (statArgs.EventType.IsTurnoverEvent())
        {
            _isHomeTeamInPossession = !_isHomeTeamInPossession;
        }

        if (statArgs.EventType == EventType.ThrowInWon)
        {
            if (GetInPossessionTeam().TeamName != statArgs.Team.TeamName)
            {
                _isHomeTeamInPossession = !_isHomeTeamInPossession;
            }
        }
    }

    private void AddEvent(ShotEventArgs shotArgs)
    {
        var matchEvent = new ShotEvent(shotArgs.Location, shotArgs.Player, _matchTimer.ElapsedMilliseconds,
            shotArgs.EventType, shotArgs.Team.TeamName, _half, shotArgs.ActionType, shotArgs.ResultType);
        MatchEvents.Add(matchEvent);

        if (shotArgs.IsTurnedOver)
        {
            _isHomeTeamInPossession = !_isHomeTeamInPossession;
        }
    }

    private void AddEvent(KickOutEventArgs kickOutEventArgs)
    {
        var matchEvent = new KickOutEvent(kickOutEventArgs.Location, kickOutEventArgs.Player, _matchTimer.ElapsedMilliseconds,
            kickOutEventArgs.EventType, kickOutEventArgs.Team.TeamName, _half, kickOutEventArgs.ResultType);
        MatchEvents.Add(matchEvent);

        if (!kickOutEventArgs.ResultType.IsKickOutWon())
        {
            _isHomeTeamInPossession = !_isHomeTeamInPossession;
        }
    }

    private void AddEvent(TurnoverEventArgs turnoverEventArgs)
    {
        var matchEvent = new TurnoverEvent(turnoverEventArgs.Location, turnoverEventArgs.Player,
            _matchTimer.ElapsedMilliseconds,
            turnoverEventArgs.EventType, turnoverEventArgs.Team.TeamName, _half, turnoverEventArgs.TurnoverType);
        MatchEvents.Add(matchEvent);

        _isHomeTeamInPossession = !_isHomeTeamInPossession;
    }

    private void AddEvent(SubstitutionEventArgs substitutionEventArgs)
    {
        var matchEvent = new SubstitutionEvent(substitutionEventArgs.Player, substitutionEventArgs.SubstitutePlayer,
            _matchTimer.ElapsedMilliseconds, EventType.Substitution, substitutionEventArgs.Team.TeamName,
            _half);
        MatchEvents.Add(matchEvent);

        substitutionEventArgs.Team.MakeSubstitution(substitutionEventArgs.SubstitutePlayer,
            substitutionEventArgs.Player);
    }

    public MatchEvent[] GetMatchEventsOfType<T>()
    {
        return MatchEvents.FindAll(me => me is T).ToArray();
    }

    public MatchEvent[] GetMatchEventsOfType(EventType eventType)
    {
        return MatchEvents.FindAll(me => me.Type == eventType).ToArray();
    }

    public MatchEvent[] GetKickOutEventsOfType(KickOutResultType resultType)
    {
        return MatchEvents.FindAll(me =>
        {
            if (me is KickOutEvent kickOutEvent)
            {
                return kickOutEvent.ResultType == resultType;
            }

            return false;
        }).ToArray();
    }

    public MatchEvent[] GetTurnoverEventsOfType(TurnoverType turnoverType)
    {
        return MatchEvents.FindAll(me =>
        {
            if (me is TurnoverEvent turnoverEvent)
            {
                return turnoverEvent.TurnoverType == turnoverType;
            }

            return false;
        }).ToArray();
    }

    public MatchEvent[] GetShotEventsOfType(ShotResultType resultType)
    {
        return MatchEvents.FindAll(me =>
        {
            if (me is ShotEvent shotEvent)
            {
                return shotEvent.ResultType == resultType;
            }

            return false;
        }).ToArray();
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
            return HomeTeam;
        }
        
        return AwayTeam;
    }

    public Team GetDefendingTeam()
    {
        if (_isHomeTeamInPossession)
        {
            return AwayTeam;
        }
        
        return HomeTeam;
    }

    public string GetTeamAndSubsString()
    {
        string returnString = "";
        string[] team = HomeTeam.TeamSheet.ToArray();
        MatchEvent[] subs = MatchEvents.FindAll(me => me.Type == EventType.Substitution && me.TeamName == HomeTeam.TeamName).ToArray();
        MatchEvent[] scores = MatchEvents.FindAll(me => me.TeamName == HomeTeam.TeamName && me is ShotEvent).ToArray();
        
        for(int i = 0; i < team.Length; i++)
        {
            int playerNum = i + 1;
            returnString += playerNum + " " + team[i] + "\n";
        }

        returnString += "\n";

        foreach (var sub in subs)
        {
            SubstitutionEvent subEvent = (SubstitutionEvent)sub;
            returnString += "Sub Off: " + subEvent.Player + " : Sub On: " + subEvent.PlayerOnName + "\n";
        }

        returnString += "\n";
        returnString += "Scorers:\n";

        Dictionary<string, List<ShotEvent>> playerScores = new Dictionary<string, List<ShotEvent>>();
        foreach (var score in scores)
        {
            ShotEvent scoreEvent = (ShotEvent)score;
            if (scoreEvent.ResultType.IsScore())
            {
                if (playerScores.ContainsKey(scoreEvent.Player))
                {
                    playerScores[scoreEvent.Player].Add(scoreEvent);
                }
                else
                {
                    playerScores.Add(scoreEvent.Player, [scoreEvent]);
                }
            }
        }

        foreach (var playerScore in playerScores)
        {
            int frees = 0;
            int doublePoints = 0;
            int doublePointFree = 0;
            int goals = 0;
            int points = 0;

            foreach (var shot in playerScore.Value)
            {
                if (shot.ResultType == ShotResultType.Goal)
                {
                    goals += 1;
                }
                else if (shot.ResultType == ShotResultType.Point)
                {
                    points += 1;

                    if (shot.ActionType == ActionType.Free)
                    {
                        frees += 1;
                    }
                }
                else if (shot.ResultType == ShotResultType.DoublePoint)
                {
                    points += 2;
                    
                    if (shot.ActionType == ActionType.Free)
                    {
                        doublePointFree += 1;
                    }
                    else
                    {
                        doublePoints += 1;
                    }
                }
            }

            returnString += playerScore.Key + ": " + goals + "-" + points + " ";
            if (frees > 0)
            {
                returnString += frees + "f ";
            }

            if (doublePointFree > 0)
            {
                returnString += doublePointFree + "x2pf ";
            }

            if (doublePoints > 0)
            {
                returnString += doublePoints + "x2p";
            }

            returnString += "\n";
        }

        return returnString;
    }
    #endregion
    
    #region Statistic Methods
    public StatisticPair GetStatisticForEvent(EventType eventType)
    {
        List<MatchEvent> events = MatchEvents.FindAll(matchEvent => matchEvent.Type == eventType);
        return GetStatisticPairForEvent(events);
    }

    public StatisticPair GetStatisticForShotResult(ShotResultType resultType)
    {
        List<MatchEvent> events = MatchEvents.FindAll(matchEvent =>
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
        List<MatchEvent> events = MatchEvents.FindAll(matchEvent =>
        {
            if (matchEvent is KickOutEvent kickOutEvent)
            {
                return kickOutEvent.ResultType == resultType;
            }

            return false;
        });
        
        return GetStatisticPairForEvent(events);
    }

    public StatisticPair GetStatisticPairForTurnoverType(TurnoverType turnoverType, string homeTeamName)
    {
        List<MatchEvent> turnOvers = MatchEvents.FindAll(matchEvent =>
        {
            if (matchEvent is TurnoverEvent turnoverEvent)
            {
                return turnoverEvent.TurnoverType == turnoverType;
            }

            return false;
        });

        int homeTeamWonCount = turnOvers.Count(matchEvent =>
        {
            if (matchEvent.TeamName == homeTeamName && matchEvent.Type == EventType.TurnoverWon)
            {
                return true;
            }
            else if (matchEvent.TeamName != homeTeamName && matchEvent.Type == EventType.TurnoverLost)
            {
                return true;
            }

            return false;
        });
        int awayTeamWonCount = turnOvers.Count(matchEvent =>
        {
            if (matchEvent.TeamName != homeTeamName && matchEvent.Type == EventType.TurnoverWon)
            {
                return true;
            }
            else if (matchEvent.TeamName == homeTeamName && matchEvent.Type == EventType.TurnoverLost)
            {
                return true;
            }

            return false;
        });

        return new StatisticPair(homeTeamWonCount, awayTeamWonCount);
    }

    private StatisticPair GetStatisticPairByPredicate(Predicate<MatchEvent> predicate)
    {
        List<MatchEvent> events = MatchEvents.FindAll(predicate);
        return GetStatisticPairForEvent(events);
    }

    private StatisticPair GetStatisticPairForEvent(List<MatchEvent> matchEvents)
    {
        int homeCount = matchEvents.Count(matchEvent => matchEvent.TeamName == HomeTeam.TeamName);
        int awayCount = matchEvents.Count(matchEvent => matchEvent.TeamName == AwayTeam.TeamName);

        return new StatisticPair(homeCount, awayCount);
    }

    public StatisticPair GetStatisticPairForShots()
    {
        StatisticPair pointShots = GetStatisticForEvent(EventType.PointShot);
        StatisticPair doublePointShots = GetStatisticForEvent(EventType.DoublePointShot);
        StatisticPair goalShots = GetStatisticForEvent(EventType.GoalShot);
        
        return new StatisticPair(pointShots.HomeTeamValue + doublePointShots.HomeTeamValue + goalShots.HomeTeamValue,
            pointShots.AwayTeamValue + doublePointShots.AwayTeamValue +  goalShots.AwayTeamValue);
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

    public void GetTeamScoreStrings(out string homeTeamScore, out string awayTeamScore)
    {
        StatisticPair goals = GetStatisticForShotResult(ShotResultType.Goal);
        StatisticPair points = GetStatisticForShotResult(ShotResultType.Point);
        StatisticPair doublePoints = GetStatisticForShotResult(ShotResultType.DoublePoint);

        int homeTotalPoints = points.HomeTeamValue + (doublePoints.HomeTeamValue * 2);
        int awayTotalPoints = points.AwayTeamValue + (doublePoints.AwayTeamValue * 2);

        homeTeamScore = goals.HomeTeamValue.ToString() + "-" + homeTotalPoints.ToString();
        awayTeamScore = goals.AwayTeamValue.ToString() + "-" + awayTotalPoints.ToString();
    }
    #endregion
    #endregion
}