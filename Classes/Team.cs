namespace StatsTracker.Classes;

/// <summary>
/// Class used to represent a team in a match.
/// Teams contain a name, color and team sheet.
/// </summary>
public class Team
{
    #region Constructors

    public Team()
    {
        TeamName = "";
        TeamColor = new Color();
        TeamSheet = new List<string>();
        CurrentTeam = new string[15];
    }

    public Team(string name)
    {
        TeamName = name;
        TeamColor = new Color();
        TeamSheet = new List<string>();
        CurrentTeam = new string[15];
    }

    public Team(string teamName, Color teamColor, List<string> teamSheet)
    {
        TeamName = teamName;
        TeamColor = teamColor;
        TeamSheet = teamSheet;
        
        CurrentTeam = new string[15];

        int playerCount = 15;
        if (teamSheet.Count < playerCount)
        {
            playerCount = teamSheet.Count;
        }

        for (int i = 0; i < playerCount; i++)
        {
            CurrentTeam[i] = teamSheet[i];
        }
    }

    #endregion
    
    #region Properties

    public string TeamName { get; set; }

    /// <summary>
    /// The list of all players in this team which play this match.
    /// </summary>
    public List<string> TeamSheet { get; set; }

    public Color TeamColor { get; set; }
    
    /// <summary>
    /// The current 15 on the field.
    /// </summary>
    public string[] CurrentTeam{ get; set; }

    #endregion
    
    #region Methods
    /// <summary>
    /// Adds a player to the team sheet.
    /// </summary>
    /// <param name="playerName">The name of the player.</param>
    public void AddPlayerToTeamSheet(string playerName)
    {
        TeamSheet.Add(playerName);
    }

    /// <summary>
    /// Removes a player from the team sheet.
    /// </summary>
    /// <param name="playerName">The name of the player.</param>
    public void RemovePlayerFromTeamSheet(string playerName)
    {
        TeamSheet.Remove(playerName);
    }

    /// <summary>
    /// Replaces the player in position index with the new player.
    /// </summary>
    /// <param name="playerOn">The name of the player coming on.</param>
    /// <param name="position">The index of the position they are going on for.</param>
    /// <returns>The name of the player who came off.</returns>
    public string MakeSub(string playerOn, int position)
    {
        string playerOffName = CurrentTeam[position];
        
        CurrentTeam[position] = playerOn;
        
        return playerOffName;
    }
    #endregion
}