using StatsTracker.Classes;
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

    public PlayerCardSelectWindow(Team team, MatchEvent matchEvent)
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

        if (MatchEvent is not null)
        {
            switch (MatchEvent.Type)
            {
                case EventType.YellowCard:
                    _selectedCardButton = YellowCard;
                    YellowCard.BackColor = Color.WhiteSmoke;
                    break;
                case EventType.RedCard:
                    _selectedCardButton = RedCard;
                    RedCard.BackColor = Color.WhiteSmoke;
                    break;
                case EventType.BlackCard:
                    _selectedCardButton = BlackCard;
                    BlackCard.BackColor = Color.WhiteSmoke;
                    break;
                case EventType.RedCard2Y:
                    _selectedCardButton = RedCard2Y;
                    RedCard2Y.BackColor = Color.WhiteSmoke;
                    break;
                default:
                    break;
            }
        }
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
        if(_selectedCardButton is null || SelectedTeam is null) return;

        Enum.TryParse(_selectedCardButton.Name, out EventType cardType);
        
        if (InputStatEventArgs is not null)
        {
            InputStatEventArgs.Team = SelectedTeam;
            InputStatEventArgs.Player = GetSelectedPlayerName();
            InputStatEventArgs.EventType = cardType;
            OnEnterStatInvoked(InputStatEventArgs);
        }

        if (MatchEvent is not null)
        {
            MatchEvent.Player = GetSelectedPlayerName();
            MatchEvent.Type = cardType;
            OnEnterStatInvoked(new InputStatEventArgs());
        }
    }
}