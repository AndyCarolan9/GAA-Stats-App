using StatsTracker.Classes;
using StatsTracker.Enums;
using StatsTracker.Events;

namespace StatsTracker.Views;

public partial class TurnoverTypeSelectWindow : PlayerSelectWindow
{
    private Button? _selectedTurnoverTypeButton;
    private Color _turnoverTypeButtonColor = Color.IndianRed;
    
    public TurnoverTypeSelectWindow(Team team, InputStatEventArgs eventArgs) : base(team, eventArgs)
    {
        InitializeComponent();
        InitialiseTurnoverTypeButtons();

        GetEnterStatButton().MouseClick += OnEnterTurnoverStatClicked;
    }

    private void InitialiseTurnoverTypeButtons()
    {
        _turnoverTypeButtonColor = FreeButton.BackColor;
        
        FreeButton.MouseClick += OnTurnoverTypeButtonClicked;
        TackledButton.MouseClick += OnTurnoverTypeButtonClicked;
        InterceptedButton.MouseClick += OnTurnoverTypeButtonClicked;
    }

    private void OnTurnoverTypeButtonClicked(object? sender, MouseEventArgs mouseEventArgs)
    {
        if (mouseEventArgs.Button != MouseButtons.Left) return;
        
        if (sender is null)
        {
            return;
        }

        if (_selectedTurnoverTypeButton is not null)
        {
            _selectedTurnoverTypeButton.BackColor = _turnoverTypeButtonColor;
        }
        
        _selectedTurnoverTypeButton = sender as Button;
        if (_selectedTurnoverTypeButton is null)
        {
            return;
        }
            
        _selectedTurnoverTypeButton.BackColor = Color.WhiteSmoke;
    }

    private void OnEnterTurnoverStatClicked(object? sender, EventArgs eventArgs)
    {
        TurnoverEventArgs? turnoverEventArgs = InputStatEventArgs as TurnoverEventArgs;
        if (turnoverEventArgs is null || SelectedTeam is null || _selectedTurnoverTypeButton is null)
        {
            return;
        }

        turnoverEventArgs.Team = SelectedTeam;
        turnoverEventArgs.Player = GetSelectedPlayerName();
        Enum.TryParse(_selectedTurnoverTypeButton.Text, out TurnoverType turnoverType);
        turnoverEventArgs.TurnoverType = turnoverType;
        OnEnterStatInvoked(turnoverEventArgs);
    }
}