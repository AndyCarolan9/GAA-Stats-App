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
        TeamSheet = new string[15];
    }

    public Team(string teamName, Color teamColor, string[] teamSheet)
    {
        TeamName = teamName;
        TeamColor = teamColor;
        TeamSheet = teamSheet;
    }

    #endregion
    
    #region Properties

    public string TeamName { get; set; }

    public string[] TeamSheet { get; set; }

    public Color TeamColor { get; set; }

    #endregion
    
    #region Methods
    /// <summary>
    /// Adds a player to the team sheet.
    /// </summary>
    /// <param name="playerName">The name of the player.</param>
    /// <param name="playerPosition">The position that</param>
    public void AddPlayer(string playerName, int playerPosition)
    {
        TeamSheet[playerPosition] = playerName;
    }

    /// <summary>
    /// Removes a player from the team sheet.
    /// </summary>
    /// <param name="playerPosition">The position of the player to remove.</param>
    public void RemovePlayer(int playerPosition)
    {
        TeamSheet[playerPosition] = "";
    }
    #endregion
}