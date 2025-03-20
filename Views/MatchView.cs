using System.ComponentModel;
using StatsTracker.Classes;
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
        pointShot.Name = "PointShot";
        AddSubMenuItemsForShots(pointShot);
        EventInputMenu.Items.Add(pointShot);
        
        ToolStripMenuItem goalShot = new ToolStripMenuItem("Goal Shot");
        goalShot.Name = "GoalShot";
        AddSubMenuItemsForShots(goalShot);
        EventInputMenu.Items.Add(goalShot);
        
        ToolStripMenuItem longShot = new ToolStripMenuItem("2 Point Shot");
        longShot.Name = "2PointShot";
        AddSubMenuItemsForShots(longShot);
        EventInputMenu.Items.Add(longShot);
        
        ToolStripMenuItem kickout = new ToolStripMenuItem("Kick Out");
        EventInputMenu.Items.Add(kickout);
        
        ToolStripMenuItem kickoutWon = new ToolStripMenuItem("Won");
        kickoutWon.Name = "Won";
        kickoutWon.MouseDown += KickOutItemClicked;
        kickout.DropDownItems.Add(kickoutWon);
        
        ToolStripMenuItem kickoutWonMark = new ToolStripMenuItem("Won Mark");
        kickoutWonMark.Name = "WonMark";
        kickoutWonMark.MouseDown += KickOutItemClicked;
        kickout.DropDownItems.Add(kickoutWonMark);
        
        ToolStripMenuItem kickoutWonBreak = new ToolStripMenuItem("Won Break");
        kickoutWonBreak.Name = "WonBreak";
        kickoutWonBreak.MouseDown += KickOutItemClicked;
        kickout.DropDownItems.Add(kickoutWonBreak);
        
        ToolStripMenuItem kickoutLost = new ToolStripMenuItem("Lost");
        kickoutLost.Name = "Lost";
        kickoutLost.MouseDown += KickOutItemClicked;
        kickout.DropDownItems.Add(kickoutLost);
        
        ToolStripMenuItem kickoutLostMark = new ToolStripMenuItem("Lost Mark");
        kickoutLostMark.Name = "LostMark";
        kickoutLostMark.MouseDown += KickOutItemClicked;
        kickout.DropDownItems.Add(kickoutLostMark);
        
        ToolStripMenuItem kickoutLostBreak = new ToolStripMenuItem("Lost Break");
        kickoutLostBreak.Name = "LostBreak";
        kickoutLostBreak.MouseDown += KickOutItemClicked;
        kickout.DropDownItems.Add(kickoutLostBreak);
        
        ToolStripMenuItem freeConceded = new ToolStripMenuItem("Free Conceded");
        freeConceded.Name = "FreeConceded";
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
        
        Enum.TryParse(eventName, out EventType eventType);
        OnStatEntered?.Invoke(this, new InputStatEventArgs() { EventType = eventType, Location = _inputLocation });
    }

    private void ShotItemClicked(object? sender, MouseEventArgs mouseEventArgs)
    {
        if (sender is null)
        {
            return;
        }
        
        ToolStripMenuItem item = (ToolStripMenuItem)sender;
        ToolStrip? toolStrip = item.GetCurrentParent();
        if (toolStrip is null)
        {
            return;
        }
        
        string? name = toolStrip.AccessibilityObject.Name;
        if (name is null)
        {
            return;
        }
        
        Enum.TryParse(name.Replace(" ", ""), out EventType eventType);
        Enum.TryParse(item.Name, out ShotResultType resultType);
        ShotEventArgs shotEventArgs = new ShotEventArgs() { Location = _inputLocation, EventType = eventType, 
            ResultType = resultType };
        OnStatEntered?.Invoke(this, shotEventArgs);
    }

    private void KickOutItemClicked(object? sender, MouseEventArgs mouseEventArgs)
    {
        if (sender is null)
        {
            return;
        }
        
        ToolStripMenuItem item = (ToolStripMenuItem)sender;
        ToolStrip? toolStrip = item.GetCurrentParent();
        if (toolStrip is null)
        {
            return;
        }
        
        string? name = toolStrip.AccessibilityObject.Name;
        if (name is null)
        {
            return;
        }
        
        Enum.TryParse(name.Replace(" ", ""), out EventType eventType);
        Enum.TryParse(item.Name, out KickOutResultType resultType);
        KickOutEventArgs kickOutEventArgs = new KickOutEventArgs() { EventType = eventType, Location = _inputLocation, 
            ResultType = resultType };
        OnStatEntered?.Invoke(this, kickOutEventArgs);
    }

    private void AddSubMenuItemsForShots(ToolStripMenuItem parent)
    {
        if (parent.Name == "PointShot")
        {
            ToolStripMenuItem pointScored = new ToolStripMenuItem("Point Scored");
            pointScored.Name = "PointScored";
            pointScored.MouseDown += ShotItemClicked;
            parent.DropDownItems.Add(pointScored);
            
            ToolStripMenuItem shortShot = new ToolStripMenuItem("Short");
            shortShot.Name = "Short";
            shortShot.MouseDown += ShotItemClicked;
            parent.DropDownItems.Add(shortShot);
        }

        if (parent.Name == "GoalShot")
        {
            ToolStripMenuItem pointScored = new ToolStripMenuItem("Point Scored");
            pointScored.Name = "PointScored";
            pointScored.MouseDown += ShotItemClicked;
            parent.DropDownItems.Add(pointScored);
            
            ToolStripMenuItem goalScored = new ToolStripMenuItem("Goal Scored");
            goalScored.Name = "GoalScored";
            goalScored.MouseDown += ShotItemClicked;
            parent.DropDownItems.Add(goalScored);
            
            ToolStripMenuItem saved = new ToolStripMenuItem("Saved");
            saved.Name = "Saved";
            saved.MouseDown += ShotItemClicked;
            parent.DropDownItems.Add(saved);
        }

        if (parent.Name == "2PointShot")
        {
            ToolStripMenuItem doublePointScored = new ToolStripMenuItem("2 Pointer Scored");
            doublePointScored.Name = "2PointScored";
            doublePointScored.MouseDown += ShotItemClicked;
            parent.DropDownItems.Add(doublePointScored);
            
            ToolStripMenuItem shortShot = new ToolStripMenuItem("Short");
            shortShot.Name = "Short";
            shortShot.MouseDown += ShotItemClicked;
            parent.DropDownItems.Add(shortShot);
        }
        
        ToolStripMenuItem wideShot = new ToolStripMenuItem("Wide");
        wideShot.Name = "Wide";
        wideShot.MouseDown += ShotItemClicked;
        parent.DropDownItems.Add(wideShot);
        
        ToolStripMenuItem postsShot = new ToolStripMenuItem("Off Posts");
        postsShot.Name = "PostsShot";
        postsShot.MouseDown += ShotItemClicked;
        parent.DropDownItems.Add(postsShot);
        
        ToolStripMenuItem blockedShot = new ToolStripMenuItem("Blocked");
        blockedShot.Name = "BlockedShot";
        blockedShot.MouseDown += ShotItemClicked;
        parent.DropDownItems.Add(blockedShot);
        
        ToolStripMenuItem outFor45 = new ToolStripMenuItem("Out for 45");
        outFor45.Name = "OutFor45Shot";
        outFor45.MouseDown += ShotItemClicked;
        parent.DropDownItems.Add(outFor45);
    }
}