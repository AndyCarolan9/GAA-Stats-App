using StatsTracker.Classes;
using StatsTracker.Enums;
using StatsTracker.Events;

namespace StatsTracker.Views;

public partial class ActionSelectWindow : Form, IStatsView
{
    private Button? _selectedPlayerButton;
    private Button? _selectedActionButton;
    private readonly Team _selectedTeam;
    private Color _actionButtonColor = Color.IndianRed;
    private readonly InputStatEventArgs _inputStatEventArgs;
    
    public event EventHandler<InputStatEventArgs>? OnStatEntered;
    
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

    private void EnterStat_Click(object? sender, EventArgs e)
    {
        _inputStatEventArgs.ActionType = GetSelectedActionType();
        _inputStatEventArgs.Player = GetSelectedPlayerName();
        _inputStatEventArgs.Team = _selectedTeam;
        OnStatEntered?.Invoke(sender, _inputStatEventArgs);
    }

    private void Cancel_Click(object? sender, EventArgs e)
    {
        OnCancelled?.Invoke(sender, e);
    }

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
                return ActionType.Play;
        }
    }

    private string GetSelectedPlayerName()
    {
        if (_selectedPlayerButton is null)
        {
            return "Player";
        }
        
        return _selectedPlayerButton.Text;
    }
}