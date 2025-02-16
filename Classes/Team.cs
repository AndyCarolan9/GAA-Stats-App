namespace StatsTracker.Classes;

public class Team
{
    #region Fields
    private string _teamName;
    
    private Color _teamColor;

    private string[] _teamSheet;

    #endregion
    
    #region Constructors

    public Team()
    {
        _teamName = "";
        _teamColor = new Color();
        _teamSheet = new string[15];
    }

    public Team(string teamName, Color teamColor, string[] teamSheet)
    {
        _teamName = teamName;
        _teamColor = teamColor;
        _teamSheet = teamSheet;
    }

    #endregion
    
    #region Properties

    public string TeamName
    {
        get => _teamName;
        set => _teamName = value;
    }

    public string[] TeamSheet
    {
        get => _teamSheet;
        set => _teamSheet = value;
    }

    public Color TeamColor
    {
        get => _teamColor;
        set => _teamColor = value;
    }

    #endregion
    
    #region Methods

    public void AddPlayer(string playerName, int playerPosition)
    {
        _teamSheet[playerPosition] = playerName;
    }

    public void RemovePlayer(int playerPosition)
    {
        _teamSheet[playerPosition] = "";
    }
    #endregion
}