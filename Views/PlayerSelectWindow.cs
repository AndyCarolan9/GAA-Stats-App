using StatsTracker.Classes;
using StatsTracker.Enums;
using StatsTracker.Events;

namespace StatsTracker.Views;

public partial class PlayerSelectWindow : Form, IStatsView
{
    private Button? _selectedPlayerButton;
    protected readonly Team? SelectedTeam;
    protected readonly InputStatEventArgs? InputStatEventArgs;
    
    /// <summary>
    /// Called when the enter stat button is clicked.
    /// </summary>
    public event EventHandler<InputStatEventArgs>? OnEnterStatClicked;
    
    /// <summary>
    /// Called when the cancel button is clicked.
    /// </summary>
    public event EventHandler<EventArgs>? OnCancelled;

    public PlayerSelectWindow()
    {
        InitializeComponent();
    }
    
    public PlayerSelectWindow(Team team, InputStatEventArgs inputStatEventArgs)
    {
        SelectedTeam = team;
        InputStatEventArgs = inputStatEventArgs;
        
        InitializeComponent();
        
        SetupPlayerButtons();
        
        SetupPossessionCheckBox();
    }

    public Form GetForm()
    {
        return this;
    }

    private void SetupPossessionCheckBox()
    {
        ShotEventArgs? shotEventArgs = InputStatEventArgs as ShotEventArgs;
        if (shotEventArgs is null)
        {
            TurnOverCheckBox.Visible = false;
            return;
        }

        if (shotEventArgs.IsPossessionButtonsVisible())
        {
            TurnOverCheckBox.Visible = true;
            return;
        }
        
        TurnOverCheckBox.Visible = false;
    }

    protected CheckBox GetTurnOverCheckBox()
    {
        return TurnOverCheckBox;
    }
    
    /// <summary>
    /// Sets up the player buttons from the team sheet.
    /// </summary>
    private void SetupPlayerButtons()
    {
        if (SelectedTeam is null)
        {
            return;
        }
        
        foreach(var button in Controls.OfType<Button>())
        {
            if (button.Name.Contains("Player"))
            {
                button.MouseClick += PlayerButton_Click;
                
                string strIndex = button.Name.Substring(6);
                int index = Int32.Parse(strIndex) - 1;
                button.Text = SelectedTeam.TeamSheet[index];
                button.BackColor = SelectedTeam.TeamColor;
            }
        }
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
            _selectedPlayerButton.BackColor = SelectedTeam.TeamColor;
        }
        
        _selectedPlayerButton = sender as Button;
        if (_selectedPlayerButton is null)
        {
            return;
        }
            
        _selectedPlayerButton.BackColor = Color.WhiteSmoke;
    }
    
    /// <summary>
    /// Called when the enter stat button is clicked.
    /// The selected data is added together and the OnEnterStatClicked event is invoked.
    /// </summary>
    /// <param name="sender">The sender of the event.</param>
    /// <param name="eventArgs">The event arguments of the button press.</param>
    protected virtual void EnterStat_Click(object? sender, EventArgs eventArgs)
    {
        InputStatEventArgs.Player = GetSelectedPlayerName();
        InputStatEventArgs.Team = SelectedTeam;
        OnEnterStatInvoked(InputStatEventArgs);
    }

    /// <summary>
    /// Called when the cancel button is clicked.
    /// </summary>
    /// <param name="sender">The sender of the event.</param>
    /// <param name="eventArgs">The event arguments of the button press.</param>
    protected virtual void Cancel_Click(object? sender, EventArgs eventArgs)
    {
        OnCancelled?.Invoke(sender, eventArgs);
    }

    protected void OnEnterStatInvoked(InputStatEventArgs eventArgs)
    {
        OnEnterStatClicked?.Invoke(this, eventArgs);
    }
    
    protected string GetSelectedPlayerName()
    {
        if (_selectedPlayerButton is null)
        {
            return "Player";
        }
        
        return _selectedPlayerButton.Text;
    }
}