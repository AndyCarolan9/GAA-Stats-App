using System.ComponentModel;
using StatsTracker.Classes;
using StatsTracker.Enums;
using StatsTracker.Events;
using StatsTracker.View_Elements;

namespace StatsTracker.Views;

/// <summary>
/// View used for handling the UI inputs of match events.
/// </summary>
public partial class MatchView : Form, IStatsView
{
    public event EventHandler? OnTimerStartStopPressed;
    
    public event EventHandler? OnTimerPausePressed;
    
    public event EventHandler? OnNewGamePressed;
    
    public event EventHandler? OnSaveGamePressed; 
    
    public event EventHandler? OnSaveAsGamePressed; 
    
    public event EventHandler? OnOpenGamePressed;
    
    public event EventHandler? OnAllStatsPressed;
    
    public event EventHandler? OnContextMenuOpened;
    
    public event EventHandler? OnOpenSubsButtonPressed;

    public event EventHandler? OnExportJournalistData; 

    private Point _inputLocation = new Point(0, 0);

    private MatchEvent? _lastMatchEvent;
    
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

    public void SetLastMatchEvent(MatchEvent lastMatchEvent)
    {
        _lastMatchEvent = lastMatchEvent;
        Refresh();
    }

    public Point GetInputLocation()
    {
        return _inputLocation;
    }

    #region Control Getters
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

    public StatisticBar GetTurnoverStatisticBar()
    {
        return TurnoverStatBar;
    }

    public StatisticBar GetShotsStatisticBar()
    {
        return ShotsStatBar;
    }

    public StatisticBar GetGoalShotsStatisticBar()
    {
        return GoalShotsStatBar;
    }

    public StatisticBar GetWidesStatisticBar()
    {
        return WidesStatBar;
    }

    public StatisticBar GetKickoutStatisticBar()
    {
        return KickoutsStatsBar;
    }

    public StatisticBar GetAttacksStatisticBar()
    {
        return AttacksStatBar;
    }

    public StatisticBar GetFreeStatisticBar()
    {
        return FreesStatBar;
    }

    public StatisticBar[] GetAllStatisticBars()
    {
        return Controls.OfType<StatisticBar>().ToArray();
    }

    public Label GetMinutesLabel()
    {
        return MinutesLabel;
    }

    public Label GetSecondsLabel()
    {
        return SecondsLabel;
    }

    public Label GetHalfLabel()
    {
        return HalfLabel;
    }

    public Button GetStartStopButton()
    {
        return StartStopButton;
    }

    public Button GetPauseButton()
    {
        return Pause;
    }

    public SaveFileDialog GetSaveFileDialog()
    {
        return SaveFileDialog;
    }

    public OpenFileDialog GetOpenFileDialog()
    {
        return OpenFileDialog;
    }

    public ListBox GetEventListBox()
    {
        return EventListBox;
    }

    public Label GetHomePitchLabel()
    {
        return HomePitchLabel;
    }

    public Label GetAwayPitchLabel()
    {
        return AwayPitchLabel;
    }

    public PictureBox GetHomePitchHighlight()
    {
        return HomePitchHighlight;
    }

    public PictureBox GetAwayPitchHighlight()
    {
        return AwayPitchHighlight;
    }

    public PictureBox GetPitchInput()
    {
        return FootballFieldInput;
    }

    public ContextMenuStrip GetEventContextMenu()
    {
        return EventInputMenu;
    }
    #endregion
    
    /// <summary>
    /// Shows the context menu when the input field is right-clicked.
    /// </summary>
    /// <param name="sender">The object which sent the event.</param>
    /// <param name="mouseEventArgs">The mouse event arguments of the fired event.</param>
    private void FootballFieldInput_MouseClick(object sender, MouseEventArgs mouseEventArgs)
    {
        if (mouseEventArgs.Button == MouseButtons.Right)
        {
            EventInputMenu.Show(this, mouseEventArgs.Location);
        }
    }

    private void SubsMenuButtonClick(object? sender, MouseEventArgs mouseEventArgs)
    {
        OnOpenSubsButtonPressed?.Invoke(sender, mouseEventArgs);
    }

    /// <summary>
    /// Called when the context menu is opened.
    /// </summary>
    /// <param name="sender">The object which sent the event.</param>
    /// <param name="cancelEventArgs">The event args of the fired event.</param>
    private void EventInputMenu_Opening(object sender, CancelEventArgs cancelEventArgs)
    {
        OnContextMenuOpened?.Invoke(this, EventArgs.Empty);
    }

    private void StartStopButton_MouseClick(object sender, MouseEventArgs e)
    {
        OnTimerStartStopPressed?.Invoke(sender, e);
    }

    private void Pause_MouseClick(object sender, MouseEventArgs e)
    {
        OnTimerPausePressed?.Invoke(sender, e);
    }

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
        OnNewGamePressed?.Invoke(sender, e);
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        OnSaveGamePressed?.Invoke(sender, e);
    }

    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        OnSaveAsGamePressed?.Invoke(sender, e);
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
        OnOpenGamePressed?.Invoke(sender, e);
    }

    private void AllStatsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        OnAllStatsPressed?.Invoke(sender, e);
    }

    private void FootballFieldInput_Paint(object sender, PaintEventArgs e)
    {
        if (_lastMatchEvent == null)
        {
            return;
        }
        
        e.Graphics.FillRectangle(Brushes.IndianRed, _lastMatchEvent.Location.X - 5, _lastMatchEvent.Location.Y - 5, 10, 10);
    }

    private void FootballFieldInput_MouseUp(object sender, MouseEventArgs e)
    {
        if(e.Button == MouseButtons.Right)
            _inputLocation = e.Location;
    }

    private void JournalistData_Click(object sender, EventArgs e)
    {
        OnExportJournalistData?.Invoke(sender, e);
    }
}