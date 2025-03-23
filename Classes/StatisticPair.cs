namespace StatsTracker.Classes;

public class StatisticPair
{
    public StatisticPair()
    {
        
    }

    public StatisticPair(int homeTeamCount, int awayTeamCount)
    {
        HomeTeamValue = homeTeamCount;
        AwayTeamValue = awayTeamCount;
    }
    
    public int HomeTeamValue{get;set;}
    
    public int AwayTeamValue{get;set;}

    public int TotalValue
    {
        get => HomeTeamValue + AwayTeamValue;
    }

    public float GetHomeTeamPercentage()
    {
        if (TotalValue <= 0)
        {
            return 0;
        }
        
        return (float)HomeTeamValue / TotalValue;
    }

    public float GetAwayTeamPercentage()
    {
        if (TotalValue <= 0)
        {
            return 0;
        }
        
        return (float)AwayTeamValue / TotalValue;
    }

    public bool IsStatisticsEmpty()
    {
        return HomeTeamValue == 0 && AwayTeamValue == 0;
    }
}