using StatsTracker.Classes;
using StatsTracker.Enums;
using StatsTracker.Model;
using StatsTracker.View_Elements;
using StatsTracker.Views;
using StatsTracker.Views.Statistics;

namespace StatsTracker.Controller;

public class AllStatsController : IStatsController
{
    private readonly AllStatsView _view;
    private readonly Match _match;
    private MatchEvent[] selectedEvents;

    public AllStatsController(Match match)
    {
        _match = match;
        _view = new AllStatsView();
        InitialiseHalfSelectBox();
        InitialiseStatisticBars();
        UpdateViewData();
        _view.OnStatBarSelected += StatBarSelected;
        _view.GetHalfSelectBox().SelectedIndexChanged += SelectedHalfChanged;
    }
    
    public IStatsView GetView()
    {
        return _view;
    }

    public DialogResult ShowDialog()
    {
        return _view.GetForm().ShowDialog();
    }
    
    #region View Event Methods

    private void SelectedHalfChanged(object? sender, EventArgs e)
    {
        UpdateViewData();
    }
    
    private void StatBarSelected(object? sender, EventArgs e)
    {
        if (sender == null)
        {
            return;
        }
        
        var selectedBar = (StatisticBar)sender;
        if (selectedBar == null)
        {
            return;
        }
        
        string statName = selectedBar.Name;

        switch (statName)
        {
            case "TotalKickoutsBar":
                HighlightMatchEventsOfType<KickOutEvent>();
                break;
            case "KOWonCleanBar":
                HighlightKickOutEventsOfType(KickOutResultType.Won);
                break;
            case "KOWonMarkBar":
                HighlightKickOutEventsOfType(KickOutResultType.WonMark);
                break;
            case "KOWonBreak":
                HighlightKickOutEventsOfType(KickOutResultType.WonBreak);
                break;
            case "KOLostCleanBar":
                HighlightKickOutEventsOfType(KickOutResultType.Lost);
                break;
            case "KOLostMarkBar":
                HighlightKickOutEventsOfType(KickOutResultType.LostMark);
                break;
            case "KOLostBreakBar":
                HighlightKickOutEventsOfType(KickOutResultType.LostBreak);
                break;
            case "TurnoversWon":
                HighlightMatchEventsOfType<TurnoverEvent>();
                break;
            case "Free":
                HighlightTurnoverEventsOfType(TurnoverType.Free);
                break;
            case "Tackle":
                HighlightTurnoverEventsOfType(TurnoverType.Tackle);
                break;
            case "Intercept":
                HighlightTurnoverEventsOfType(TurnoverType.Intercept);
                break;
            case "TotalShots":
                HighlightMatchEventsOfType<ShotEvent>();
                break;
            case "TotalPointShots":
                HighlightMatchEventsOfType(EventType.PointShot);
                break;
            case "Total2PointShots":
                HighlightMatchEventsOfType(EventType.DoublePointShot);
                break;
            case "TotalGoalShots":
                HighlightMatchEventsOfType(EventType.GoalShot);
                break;
            case "TotalPointsScored":
                HighlightShotEventsOfResultType(ShotResultType.Point);
                break;
            case "Total2PointScored":
                HighlightShotEventsOfResultType(ShotResultType.DoublePoint);
                break;
            case "TotalGoalScored":
                HighlightShotEventsOfResultType(ShotResultType.Goal);
                break;
            case "TotalWides":
                HighlightShotEventsOfResultType(ShotResultType.Wide);
                break;
            case "TotalBlockedShots":
                HighlightShotEventsOfResultType(ShotResultType.Blocked);
                break;
            case "TotalSavedShots":
                HighlightShotEventsOfResultType(ShotResultType.Saved);
                break;
            case "TotalShortShots":
                HighlightShotEventsOfResultType(ShotResultType.Short);
                break;
            case "TotalOutFor45":
                HighlightShotEventsOfResultType(ShotResultType.OutFor45);
                break;
            default:
                _view.SetSelectedEvents(new MatchEvent[] {});
                break;
        }
    }

    private void HighlightMatchEventsOfType<T>()
    {
        _view.SetSelectedEvents(_match.GetMatchEventsOfType<T>());
    }

    private void HighlightKickOutEventsOfType(KickOutResultType resultType)
    {
        _view.SetSelectedEvents(_match.GetKickOutEventsOfType(resultType));
    }

    private void HighlightTurnoverEventsOfType(TurnoverType turnoverType)
    {
        _view.SetSelectedEvents(_match.GetTurnoverEventsOfType(turnoverType));
    }

    private void HighlightShotEventsOfResultType(ShotResultType resultType)
    {
        _view.SetSelectedEvents(_match.GetShotEventsOfType(resultType));
    }

    private void HighlightMatchEventsOfType(EventType eventType)
    {
        _view.SetSelectedEvents(_match.GetMatchEventsOfType(eventType));
    }
    #endregion
    
    #region View Display Methods
    private void UpdateViewData()
    {
        // TODO Get the selected team and update the view with it's data.
        SetKickOutStatBarsValues();
        SetScoreCardValues();
        SetShootingStatBarValues();
        SetTurnoverStatBarValues();
    }

    private void InitialiseHalfSelectBox()
    {
        ComboBox halfSelectBox = _view.GetHalfSelectBox();
        halfSelectBox.BeginUpdate();
        halfSelectBox.Items.Clear();
        halfSelectBox.Items.AddRange(Enum.GetNames(typeof(HalfTime)));
        halfSelectBox.EndUpdate();
        halfSelectBox.SelectedIndex = 0;
    }
    
    private void InitialiseStatisticBars()
    {
        _view.SetupStatBarNames();
        
        StatisticBar[] statBars = _view.GetAllStatisticsBars();

        foreach (var bar in statBars)
        {
            bar.InitialiseValues();
            bar.SetTeamColors(_match.HomeTeam.TeamColor,  _match.AwayTeam.TeamColor);
        }
    }

    private void SetKickOutStatBarsValues()
    {
        HalfTime selectedType = GetHalfTime();
        
        StatisticBar totalKickoutsStatsBar = _view.GetTotalKickoutsStatsBar();
        StatisticPair totalKoPair = _match.GetStatisticForEvent(EventType.KickOut, selectedType);
        if (!totalKoPair.IsStatisticsEmpty())
        {
            totalKickoutsStatsBar.UpdateValues(totalKoPair);
        }
        
        StatisticBar[] statBars = _view.GetAllStatisticsBars().Where(bar =>
        {
            string name = bar.StatName.Replace(" ", "");
            return Enum.IsDefined(typeof(KickOutResultType), name);
        }).ToArray();

        foreach (var bar in statBars)
        {
            Enum.TryParse(bar.StatName.Replace(" ", ""), out KickOutResultType resultType);
            StatisticPair statsPair = _match.GetStatisticPairForKickOutResult(resultType, selectedType);
            bar.UpdateValues(statsPair);
        }
    }

    private void SetScoreCardValues()
    {
        string homeTeamName = _match.HomeTeam.TeamName[new Range(0, 4)];
        string awayTeamName = _match.AwayTeam.TeamName[new Range(0, 4)];

        _match.GetTeamScoreStrings(out var homeTeamScore, out var awayTeamScore);
        
        _view.GetHomeTeamLabel().Text = homeTeamName;
        _view.GetAwayTeamLabel().Text = awayTeamName;
        _view.GetHomeTeamScore().Text = homeTeamScore;
        _view.GetAwayTeamScore().Text = awayTeamScore;
        _view.GetHomeTeamName().Text = homeTeamName;
        _view.GetAwayTeamName().Text = awayTeamName;
    }

    private void SetShootingStatBarValues()
    {
        HalfTime halfTime = GetHalfTime();
        
        StatisticPair pointShots = _match.GetStatisticForEvent(EventType.PointShot, halfTime);
        StatisticPair doublePointShots = _match.GetStatisticForEvent(EventType.DoublePointShot, halfTime);
        StatisticPair goalShots = _match.GetStatisticForEvent(EventType.GoalShot, halfTime);
        
        _view.GetTotalShotsBar().UpdateValues(new StatisticPair(
            pointShots.HomeTeamValue + doublePointShots.HomeTeamValue + goalShots.HomeTeamValue, 
            pointShots.AwayTeamValue + doublePointShots.AwayTeamValue + goalShots.AwayTeamValue));
        _view.GetTotalPointShotBar().UpdateValues(pointShots);
        _view.GetTotal2PointShotBar().UpdateValues(doublePointShots);
        _view.GetTotalGoalShotBar().UpdateValues(goalShots);

        StatisticPair pointsScored = _match.GetStatisticForShotResult(ShotResultType.Point, halfTime);
        StatisticPair doublePointsScored = _match.GetStatisticForShotResult(ShotResultType.DoublePoint, halfTime);
        StatisticPair goalScored = _match.GetStatisticForShotResult(ShotResultType.Goal, halfTime);
        
        _view.GetPointsScoredBar().UpdateValues(pointsScored);
        _view.GetTotal2PointScoredBar().UpdateValues(doublePointsScored);
        _view.GetTotalGoalScoredBar().UpdateValues(goalScored);
        
        StatisticPair wides = _match.GetStatisticForShotResult(ShotResultType.Wide, halfTime);
        StatisticPair outFor45 = _match.GetStatisticForShotResult(ShotResultType.OutFor45, halfTime);
        StatisticPair saved45 = _match.GetStatisticForShotResult(ShotResultType.SavedOutFor45, halfTime);
        StatisticPair saved = _match.GetStatisticForShotResult(ShotResultType.Saved, halfTime);
        StatisticPair shortShots = _match.GetStatisticForShotResult(ShotResultType.Short, halfTime);
        
        _view.GetTotalWidesBar().UpdateValues(wides);
        _view.GetTotalOutFor45Bar().UpdateValues(new StatisticPair(outFor45.HomeTeamValue + saved45.HomeTeamValue,
            outFor45.AwayTeamValue + saved45.AwayTeamValue));
        _view.GetTotalSavedShotsBar().UpdateValues(new StatisticPair(saved.HomeTeamValue + saved45.HomeTeamValue, 
            saved.AwayTeamValue + saved45.AwayTeamValue));
        _view.GetTotalShortShotsBar().UpdateValues(shortShots);
        
        StatisticPair blocked = _match.GetStatisticForShotResult(ShotResultType.Blocked, halfTime);
        _view.GetTotalBlockedShotsBar().UpdateValues(blocked);
    }

    private void SetTurnoverStatBarValues()
    {
        HalfTime selectedHalf = GetHalfTime();
        
        StatisticBar totalTurnoversBar = _view.GetTotalTurnoversWonBar();
        StatisticPair turnoversWon = _match.GetStatisticForEvent(EventType.TurnoverWon, selectedHalf);
        StatisticPair turnoversLost = _match.GetStatisticForEvent(EventType.TurnoverLost, selectedHalf);
        StatisticPair totalTurnovers = new StatisticPair(turnoversWon.HomeTeamValue + turnoversLost.AwayTeamValue,
            turnoversWon.AwayTeamValue + turnoversLost.HomeTeamValue);
        
        totalTurnoversBar.UpdateValues(totalTurnovers);
        
        StatisticBar[] statBars = _view.GetAllStatisticsBars().Where(bar =>
        {
            string name = bar.Name.Replace(" ", "");
            return Enum.IsDefined(typeof(TurnoverType), name);
        }).ToArray();

        foreach (var bar in statBars)
        {
            Enum.TryParse(bar.Name.Replace(" ", ""), out TurnoverType turnOverType);
            StatisticPair statsPair = _match.GetStatisticPairForTurnoverType(turnOverType, _match.HomeTeam.TeamName, selectedHalf);
            bar.UpdateValues(statsPair);
        }
    }
    #endregion

    private HalfTime GetHalfTime()
    {
        HalfTime selectedType = HalfTime.FullGame;
        string? selectedItem = (string?)_view.GetHalfSelectBox().SelectedItem;
        if (selectedItem != null)
        {
            Enum.TryParse<HalfTime>(selectedItem, out selectedType);
        }
        
        return selectedType;
    }
}