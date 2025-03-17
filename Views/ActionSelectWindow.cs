using StatsTracker.Classes;
using StatsTracker.Enums;
using StatsTracker.Events;

namespace StatsTracker.Views;

/// <summary>
/// Used for selecting players and the action type of the match event.
/// </summary>
public partial class ActionSelectWindow : Form, IStatsView
{
    private Button? _selectedPlayerButton;
    private Button? _selectedActionButton;
    private readonly Team _selectedTeam;
    private Color _actionButtonColor = Color.IndianRed;
    private readonly InputStatEventArgs _inputStatEventArgs;
    
    /// <summary>
    /// Called when the enter stat button is clicked.
    /// </summary>
    public event EventHandler<InputStatEventArgs>? OnEnterStatClicked;
    
    /// <summary>
    /// Called when the cancel button is clicked.
    /// </summary>
    public event EventHandler<EventArgs>? OnCancelled;
    
    public ActionSelectWindow(Team team, InputStatEventArgs eventArgs)
    {
        _selectedTeam = team;
        _inputStatEventArgs = eventArgs;
        
        InitializeComponent();
        
        SetupPlayerButtons();
        SetupActionButtons();
    }
    
    public Form GetForm()
    {
        return this;
    }

    /// <summary>
    /// Sets up the player buttons from the team sheet.
    /// </summary>
    private void SetupPlayerButtons()
    {
        foreach(var button in Controls.OfType<Button>())
        {
            if (button.Name.Contains("Player"))
            {
                button.MouseClick += PlayerButton_Click;
                
                string strIndex = button.Name.Substring(6);
                int index = Int32.Parse(strIndex) - 1;
                button.Text = _selectedTeam.TeamSheet[index];
                button.BackColor = _selectedTeam.TeamColor;
            }
        }
    }

    /// <summary>
    /// Sets up the action buttons.
    /// </summary>
    private void SetupActionButtons()
    {
        _actionButtonColor = FromPlay.BackColor;
        
        FromPlay.MouseClick += ActionButton_Click;
        FromFree.MouseClick += ActionButton_Click;
        From45.MouseClick += ActionButton_Click;
        FromPenalty.MouseClick += ActionButton_Click;
        FromSideline.MouseClick += ActionButton_Click;
        FromMark.MouseClick += ActionButton_Click;
    }

    /// <summary>
    /// Called when a player button is clicked.
    /// </summary>
    /// <param name="sender">The sender of the event.</param>
    /// <param name="mouseEventArgs">The mouse event arguments of the event.</param>
    private void PlayerButton_Click(object? sender, MouseEventArgs mouseEventArgs)
    {
        if (mouseEventArgs.Button != MouseButtons.Left) return;
        
        if (sender is null)
        {
            return;
        }

        if (_selectedPlayerButton is not null)
        {
            _selectedPlayerButton.BackColor = _selectedTeam.TeamColor;
        }
        
        _selectedPlayerButton = sender as Button;
        if (_selectedPlayerButton is null)
        {
            return;
        }
            
        _selectedPlayerButton.BackColor = Color.WhiteSmoke;
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

    /// <summary>
    /// Called when the enter stat button is clicked.
    /// The selected data is added together and the OnEnterStatClicked event is invoked.
    /// </summary>
    /// <param name="sender">The sender of the event.</param>
    /// <param name="eventArgs">The event arguments of the button press.</param>
    private void EnterStat_Click(object? sender, EventArgs eventArgs)
    {
        //_inputStatEventArgs.ActionType = GetSelectedActionType();
        _inputStatEventArgs.Player = GetSelectedPlayerName();
        _inputStatEventArgs.Team = _selectedTeam;
        OnEnterStatClicked?.Invoke(sender, _inputStatEventArgs);
    }

    /// <summary>
    /// Called when the cancel button is clicked.
    /// </summary>
    /// <param name="sender">The sender of the event.</param>
    /// <param name="eventArgs">The event arguments of the button press.</param>
    private void Cancel_Click(object? sender, EventArgs eventArgs)
    {
        OnCancelled?.Invoke(sender, eventArgs);
    }

    /// <summary>
    /// Returns the action type based on the action name.
    /// </summary>
    /// <returns>The action type from the name.</returns>
    private ActionType GetSelectedActionType()
    {
        string? actionName = _selectedActionButton?.Text;

        switch (actionName)
        {
            case "From Free":
                return ActionType.Free;
            case "From Play":
                return ActionType.Play;
            case "From Sideline":
                return ActionType.Sideline;
            case "From Penalty":
                return ActionType.Penalty;
            case "From Mark":
                return ActionType.Mark;
            case "From 45":
                return ActionType.From45;
            default:
                return ActionType.Default;
        }
    }

    /// <summary>
    /// Returns the player name from the button.
    /// </summary>
    /// <returns>The player name from the button.</returns>
    private string GetSelectedPlayerName()
    {
        if (_selectedPlayerButton is null)
        {
            return "Player";
        }
        
        return _selectedPlayerButton.Text;
    }
}