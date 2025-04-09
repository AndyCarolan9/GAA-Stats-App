namespace StatsTracker.Events;

public class TeamSelectedEventArgs : EventArgs
{
    public string HomeTeamName { get; set; }
    
    public string AwayTeamName { get; set; }
    
    public string[] HomePlayers { get; set; }
    
    public string[] AwayPlayers { get; set; }
}