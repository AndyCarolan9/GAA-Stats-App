using System.ComponentModel;
using StatsTracker.Controller;

namespace StatsTracker.Views;

public partial class MatchView : Form, IStatsView
{
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
        pointShot.DropDownItems.Add(pointScored);
        
        ToolStripMenuItem wideShot = new ToolStripMenuItem("Wide Shot");
        wideShot.Name = "WideShot";
        pointShot.DropDownItems.Add(wideShot);
        
        ToolStripMenuItem shortShot = new ToolStripMenuItem("Short Shot");
        shortShot.Name = "ShortShot";
        pointShot.DropDownItems.Add(shortShot);
        
        ToolStripMenuItem longShot = new ToolStripMenuItem("2 Point Shot");
        longShot.Name = "LongShot";
        pointShot.DropDownItems.Add(longShot);
        
        ToolStripMenuItem goalShot = new ToolStripMenuItem("Goal Shot");
        EventInputMenu.Items.Add(goalShot);
        
        ToolStripMenuItem goalScored = new ToolStripMenuItem("Goal Scored");
        goalScored.Name = "GoalScored";
        goalShot.DropDownItems.Add(goalScored);
        
        ToolStripMenuItem savedShot = new ToolStripMenuItem("Saved Shot");
        savedShot.Name = "SavedShot";
        goalShot.DropDownItems.Add(savedShot);
        
        ToolStripMenuItem kickout = new ToolStripMenuItem("Kick Out");
        EventInputMenu.Items.Add(kickout);
        
        ToolStripMenuItem kickoutWon = new ToolStripMenuItem("Kick Out Won");
        kickoutWon.Name = "KickOutWon";
        kickout.DropDownItems.Add(kickoutWon);
        
        ToolStripMenuItem kickoutWonMark = new ToolStripMenuItem("Kick Out Won Mark");
        kickoutWonMark.Name = "KickOutWonMark";
        kickout.DropDownItems.Add(kickoutWonMark);
        
        ToolStripMenuItem kickoutLost = new ToolStripMenuItem("Kick Out Lost");
        kickoutLost.Name = "KickOutLost";
        kickout.DropDownItems.Add(kickoutLost);
        
        ToolStripMenuItem kickoutLostMark = new ToolStripMenuItem("Kick Out Lost Mark");
        kickoutLostMark.Name = "KickOutLostMark";
        kickout.DropDownItems.Add(kickoutLostMark);
        
        ToolStripMenuItem freeConceded = new ToolStripMenuItem("Free Conceded");
        freeConceded.Name = "Free Conceded";
        EventInputMenu.Items.Add(freeConceded);
    }
}