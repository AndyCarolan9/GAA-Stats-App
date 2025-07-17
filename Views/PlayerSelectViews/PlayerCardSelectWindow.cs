using StatsTracker.Enums;
using StatsTracker.Events;

namespace StatsTracker.Views.PlayerSelectViews;

public partial class PlayerCardSelectWindow : PlayerSelectWindow
{
    private Button? _selectedCardButton;
    private Color _buttonColor;
    
    public PlayerCardSelectWindow(InputStatEventArgs eventArgs)
        : base(eventArgs.Team, eventArgs)
    {
        InitializeComponent();
        SetupCardButtons();
    }

    private void SetupCardButtons()
    {
        _buttonColor = YellowCard.BackColor;
        
        YellowCard.MouseClick += CardButtonClick;
        RedCard.MouseClick += CardButtonClick;
        RedCard2Y.MouseClick += CardButtonClick;
        BlackCard.MouseClick += CardButtonClick;
    }

    private void CardButtonClick(object? sender, MouseEventArgs mouseEventArgs)
    {
        if (mouseEventArgs.Button != MouseButtons.Left) return;
        
        if (sender is null)
        {
            return;
        }

        if (_selectedCardButton is not null)
        {
            _selectedCardButton.BackColor = _buttonColor;
        }
        
        _selectedCardButton = sender as Button;
        if (_selectedCardButton is null)
        {
            return;
        }
            
        _selectedCardButton.BackColor = Color.WhiteSmoke;
    }

    protected override void EnterStat_Click(object? sender, EventArgs eventArgs)
    {
        if(InputStatEventArgs is null || _selectedCardButton is null || SelectedTeam is null) return;
        
        InputStatEventArgs.Team = SelectedTeam;
        InputStatEventArgs.Player = GetSelectedPlayerName();
        Enum.TryParse(_selectedCardButton.Name, out EventType cardType);
        InputStatEventArgs.EventType = cardType;
        OnEnterStatInvoked(InputStatEventArgs);
    }
}