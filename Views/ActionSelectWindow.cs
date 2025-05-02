using StatsTracker.Classes;
using StatsTracker.Enums;
using StatsTracker.Events;

namespace StatsTracker.Views;

/// <summary>
/// Used for selecting players and the action type of the match event.
/// </summary>
public partial class ActionSelectWindow : PlayerSelectWindow
{
    private Button? _selectedActionButton;
    private Color _actionButtonColor = Color.IndianRed;
    
    public ActionSelectWindow(Team team, InputStatEventArgs eventArgs) : base(team, eventArgs)
    {
        InitializeComponent();
        
        SetupActionButtons();
    }

    /// <summary>
    /// Sets up the action buttons.
    /// </summary>
    private void SetupActionButtons()
    {
        _actionButtonColor = Play.BackColor;
        
        Play.MouseClick += ActionButton_Click;
        Free.MouseClick += ActionButton_Click;
        From45.MouseClick += ActionButton_Click;
        Penalty.MouseClick += ActionButton_Click;
        Sideline.MouseClick += ActionButton_Click;
        Mark.MouseClick += ActionButton_Click;
    }

    /// <summary>
    /// Called when an action button is pressed.
    /// </summary>
    /// <param name="sender">The sender of the event.</param>
    /// <param name="mouseEventArgs">The mouse event arguments of the event.</param>
    private void ActionButton_Click(object? sender, MouseEventArgs mouseEventArgs)
    {
        if (mouseEventArgs.Button != MouseButtons.Left) return;
        
        if (sender is null)
        {
            return;
        }

        if (_selectedActionButton is not null)
        {
            _selectedActionButton.BackColor = _actionButtonColor;
        }
        
        _selectedActionButton = sender as Button;
        if (_selectedActionButton is null)
        {
            return;
        }
            
        _selectedActionButton.BackColor = Color.WhiteSmoke;
    }

    protected override void EnterStat_Click(object? sender, EventArgs eventArgs)
    {
        ShotEventArgs? shotEventArgs = InputStatEventArgs as ShotEventArgs;
        if (shotEventArgs is null || _selectedActionButton is null || SelectedTeam is null)
        {
            return;
        }
        
        shotEventArgs.Team = SelectedTeam;
        shotEventArgs.Player = GetSelectedPlayerName();
        Enum.TryParse(_selectedActionButton.Name, out ActionType actionType);
        shotEventArgs.ActionType = actionType;
        shotEventArgs.IsTurnedOver = GetTurnOverCheckBox().Checked;
        OnEnterStatInvoked(shotEventArgs);
    }
}