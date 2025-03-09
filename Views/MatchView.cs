using System.ComponentModel;
using StatsTracker.Enums;
using StatsTracker.Events;

namespace StatsTracker.Views;

public partial class MatchView : Form, IStatsView
{
    public event EventHandler<InputStatEventArgs>? OnStatEntered;

    private Point _inputLocation = new Point(0, 0);
    
    public MatchView()
    {
        InitializeComponent();
    }

    public Form GetForm()
    {
        return this;
    }
    
    private void FootballFieldInput_MouseClick(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right)
        {
            _inputLocation = e.Location;
            EventInputMenu.Show(this, e.Location);
        }
    }

    private void EventInputMenu_Opening(object sender, CancelEventArgs e)
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

    private void EventInputMenu_ItemClicked(object? sender, MouseEventArgs e)
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
        }

        // TODO create a default.
        return EventType.Wide;
    }
}