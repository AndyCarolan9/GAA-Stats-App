using System.ComponentModel;
using StatsTracker.Enums;
using StatsTracker.Events;

namespace StatsTracker.Views;

/// <summary>
/// View used for handling the UI inputs of match events.
/// </summary>
public partial class MatchView : Form, IStatsView
{
    /// <summary>
    /// Event used when a stat is entered on the field input.
    /// </summary>
    public event EventHandler<InputStatEventArgs>? OnStatEntered;

    private Point _inputLocation = new Point(0, 0);
    
    public MatchView()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Returns the form class of this view.
    /// </summary>
    /// <returns>The form class of this view.</returns>
    public Form GetForm()
    {
        return this;
    }

    public Label GetHomeTeamNameLabel()
    {
        return HomeTeamName;
    }
    
    public Label GetAwayTeamNameLabel()
    {
        return AwayTeamName;
    }
    
    public Label GetHomeTeamScoreLabel()
    {
        return HomeTeamScore;
    }
    
    public Label GetAwayTeamScoreLabel()
    {
        return AwayTeamScore;
    }
    
    /// <summary>
    /// Shows the context menu when the input field is right-clicked.
    /// </summary>
    /// <param name="sender">The object which sent the event.</param>
    /// <param name="mouseEventArgs">The mouse event arguments of the fired event.</param>
    private void FootballFieldInput_MouseClick(object sender, MouseEventArgs mouseEventArgs)
    {
        if (mouseEventArgs.Button == MouseButtons.Right)
        {
            _inputLocation = mouseEventArgs.Location;
            EventInputMenu.Show(this, mouseEventArgs.Location);
        }
    }

    /// <summary>
    /// Called when the context menu is opened.
    /// </summary>
    /// <param name="sender">The object which sent the event.</param>
    /// <param name="cancelEventArgs">The event args of the fired event.</param>
    private void EventInputMenu_Opening(object sender, CancelEventArgs cancelEventArgs)
    {
        EventInputMenu.Items.Clear();
        
        ToolStripMenuItem pointShot = new ToolStripMenuItem("Point Shot");
        EventInputMenu.Items.Add(pointShot);
        
        ToolStripMenuItem pointScored = new ToolStripMenuItem("Point Scored");
        pointScored.Name = "PointScored";
        pointScored.MouseDown += EventInputMenu_ItemClicked;
        pointShot.DropDownItems.Add(pointScored);
        
        ToolStripMenuItem wideShot = new ToolStripMenuItem("Wide Shot");
        wideShot.Name = "WideShot";
        wideShot.MouseDown += EventInputMenu_ItemClicked;
        pointShot.DropDownItems.Add(wideShot);
        
        ToolStripMenuItem shortShot = new ToolStripMenuItem("Short Shot");
        shortShot.Name = "ShortShot";
        shortShot.MouseDown += EventInputMenu_ItemClicked;
        pointShot.DropDownItems.Add(shortShot);
        
        ToolStripMenuItem longShot = new ToolStripMenuItem("2 Point Shot");
        longShot.Name = "LongShot";
        longShot.MouseDown += EventInputMenu_ItemClicked;
        pointShot.DropDownItems.Add(longShot);
        
        ToolStripMenuItem goalShot = new ToolStripMenuItem("Goal Shot");
        EventInputMenu.Items.Add(goalShot);
        
        ToolStripMenuItem goalScored = new ToolStripMenuItem("Goal Scored");
        goalScored.Name = "GoalScored";
        goalScored.MouseDown += EventInputMenu_ItemClicked;
        goalShot.DropDownItems.Add(goalScored);
        
        ToolStripMenuItem savedShot = new ToolStripMenuItem("Saved Shot");
        savedShot.Name = "SavedShot";
        savedShot.MouseDown += EventInputMenu_ItemClicked;
        goalShot.DropDownItems.Add(savedShot);
        
        ToolStripMenuItem kickout = new ToolStripMenuItem("Kick Out");
        EventInputMenu.Items.Add(kickout);
        
        ToolStripMenuItem kickoutWon = new ToolStripMenuItem("Kick Out Won");
        kickoutWon.Name = "KickOutWon";
        kickoutWon.MouseDown += EventInputMenu_ItemClicked;
        kickout.DropDownItems.Add(kickoutWon);
        
        ToolStripMenuItem kickoutWonMark = new ToolStripMenuItem("Kick Out Won Mark");
        kickoutWonMark.Name = "KickOutWonMark";
        kickoutWonMark.MouseDown += EventInputMenu_ItemClicked;
        kickout.DropDownItems.Add(kickoutWonMark);
        
        ToolStripMenuItem kickoutLost = new ToolStripMenuItem("Kick Out Lost");
        kickoutLost.Name = "KickOutLost";
        kickoutLost.MouseDown += EventInputMenu_ItemClicked;
        kickout.DropDownItems.Add(kickoutLost);
        
        ToolStripMenuItem kickoutLostMark = new ToolStripMenuItem("Kick Out Lost Mark");
        kickoutLostMark.Name = "KickOutLostMark";
        kickoutLostMark.MouseDown += EventInputMenu_ItemClicked;
        kickout.DropDownItems.Add(kickoutLostMark);
        
        ToolStripMenuItem freeConceded = new ToolStripMenuItem("Free Conceded");
        freeConceded.Name = "Free Conceded";
        freeConceded.MouseDown += EventInputMenu_ItemClicked;
        EventInputMenu.Items.Add(freeConceded);
    }

    /// <summary>
    /// Called when a button of the context menu is clicked.
    /// </summary>
    /// <param name="sender">The object which sent the event.</param>
    /// <param name="mouseEventArgs">The mouse event arguments of the fired event.</param>
    private void EventInputMenu_ItemClicked(object? sender, MouseEventArgs mouseEventArgs)
    {
        if (sender is null)
        {
            return;
        }
        
        string? eventName = ((ToolStripMenuItem)sender).Name;
        if (eventName == null)
        {
            return;
        }
        EventType eventType = GetEventTypeFromName(eventName);
        
        OnStatEntered?.Invoke(this, new InputStatEventArgs() { EventType = eventType, Location = _inputLocation });
    }

    /// <summary>
    /// Returns the event type enum based on the event name.
    /// </summary>
    /// <param name="eventName">The name of the event.</param>
    /// <returns>The event type.</returns>
    private EventType GetEventTypeFromName(string eventName)
    {
        switch (eventName)
        {
            case "PointScored":
                return EventType.Point;
            case "WideShot":
                return EventType.Wide;
            case "ShortShot":
                return EventType.Short;
            case "LongShot":
                return EventType.DoublePoint;
            case "GoalScored":
                return EventType.Goal;
            case "Saved Shot":
                return EventType.Saved;
            case "KickOutWon":
                return EventType.KickOutWon;
            case "KickOutWonMark":
                return EventType.KickOutWonMark;
            case "KickOutLost":
                return EventType.KickOutLost;
            case "KickOutLostMark":
                return EventType.KickOutLostMark;
            case "FreeConceded":
                return EventType.FreeConceded;
            default:
                return EventType.Default;
        }
    }
}