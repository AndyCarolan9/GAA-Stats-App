using StatsTracker.Enums;

namespace StatsTracker.Classes;

/// <summary>
/// Match Event class which is used to define when a relevant statistic is recorded.
/// </summary>
public class MatchEvent
{
    #region Fields
    private Point _location;

    private string _player;
    
    private TimeSpan _time;
    
    private EventType _type;
    
    private ActionType _action;
    #endregion

    #region Constructors
    public MatchEvent()
    {
        _player = string.Empty;
    }
    
    public MatchEvent(Point location, string player, TimeSpan time, EventType eventType, ActionType action)
    {
        _location = location;
        _player = player;
        _time = time;
        _type = eventType;
        _action = action;
    }
    #endregion
    
    #region Properties

    public Point Location
    {
        get => _location;
        set => _location = value;
    }

    public string Player
    {
        get => _player;
        set => _player = value;
    }

    public TimeSpan Time
    {
        get => _time;
        set => _time = value;
    }

    public EventType Type
    {
        get => _type;
        set => _type = value;
    }

    public ActionType Action
    {
        get => _action;
        set => _action = value;
    }
    #endregion
}