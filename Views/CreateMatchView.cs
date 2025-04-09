namespace StatsTracker.Views;

public partial class CreateMatchView : Form, IStatsView
{
    public CreateMatchView()
    {
        InitializeComponent();
    }

    public Form GetForm()
    {
        return this;
    }
    
    #region Events
    public event EventHandler<MouseEventArgs>? OnHomeTeamColorClick;
    public event EventHandler<MouseEventArgs>? OnHomeTeamMoveUpClick;
    public event EventHandler<MouseEventArgs>? OnHomeTeamMoveDownClick;
    
    public event EventHandler<MouseEventArgs>? OnAwayTeamColorClick;
    public event EventHandler<MouseEventArgs>? OnAwayTeamMoveUpClick;
    public event EventHandler<MouseEventArgs>? OnAwayTeamMoveDownClick;
    
    public event EventHandler? OnTeamDropDownIndexChanged;
    public event EventHandler<MouseEventArgs>? OnMoveToHomeClick;
    public event EventHandler<MouseEventArgs>? OnMoveToAwayClick;
    
    public event EventHandler<MouseEventArgs>? OnAddPlayerClick;
    public event EventHandler<MouseEventArgs>? OnAddTeamClick;
    
    public event EventHandler<MouseEventArgs>? OnCreateMatchClick;
    public event EventHandler<MouseEventArgs>? OnCancelClick;
    #endregion
    
    #region View Items
    public ComboBox GetHomeTeamDropDown()
    {
        return HomeTeamDropDown;
    }
    
    public ListBox GetHomeTeamListBox()
    {
        return HomeTeamPlayersListBox;
    }

    public ColorDialog GetTeamColorDialog()
    {
        return TeamColorSelector;
    }

    public Button GetHomeTeamSetColorButton()
    {
        return HomeTeamSetColor;
    }

    public Button GetHomeTeamMoveUpButton()
    {
        return HomeMoveUp;
    }

    public Button GetHomeTeamMoveDownButton()
    {
        return HomeTeamMoveDown;
    }

    public PictureBox GetHomeTeamPictureBox()
    {
        return HomeTeamColorBox;
    }

    public ComboBox GetAwayTeamDropDown()
    {
        return AwayTeamDropDown;
    }
    
    public ListBox GetAwayTeamListBox()
    {
        return AwayTeamPlayersList;
    }
    
    public Button GetAwayTeamSetColorButton()
    {
        return AwayTeamSetColor;
    }

    public Button GetAwayTeamMoveUpButton()
    {
        return AwayMoveUp;
    }

    public Button GetAwayTeamMoveDownButton()
    {
        return AwayMoveDown;
    }

    public TextBox GetAddPlayerTextBox()
    {
        return AddPlayerTextBox;
    }

    public TextBox GetAddTeamTextBox()
    {
        return AddTeamTextBox;
    }
    
    public PictureBox GetAwayTeamPictureBox()
    {
        return AwayTeamColorBox;
    }

    public ComboBox GetTeamDropDown()
    {
        return TeamDropdown;
    }

    public ListBox GetTeamListBox()
    {
        return PlayersList;
    }
    #endregion
    

    private void HomeTeamSetColor_MouseClick(object sender, MouseEventArgs e)
    {
        OnHomeTeamColorClick?.Invoke(this, e);
    }

    private void HomeMoveUp_MouseClick(object sender, MouseEventArgs e)
    {
        OnHomeTeamMoveUpClick?.Invoke(this, e);
    }

    private void HomeTeamMoveDown_MouseClick(object sender, MouseEventArgs e)
    {
        OnHomeTeamMoveDownClick?.Invoke(this, e);
    }

    private void TeamDropdown_SelectedIndexChanged(object sender, EventArgs e)
    {
        OnTeamDropDownIndexChanged?.Invoke(this, e);
    }

    private void MoveToHome_MouseClick(object sender, MouseEventArgs e)
    {
        OnMoveToHomeClick?.Invoke(this, e);
    }

    private void MoveToAway_MouseClick(object sender, MouseEventArgs e)
    {
        OnMoveToAwayClick?.Invoke(this, e);
    }

    private void AwayTeamSetColor_MouseClick(object sender, MouseEventArgs e)
    {
        OnAwayTeamColorClick?.Invoke(this, e);
    }

    private void AwayMoveUp_MouseClick(object sender, MouseEventArgs e)
    {
        OnAwayTeamMoveUpClick?.Invoke(this, e);
    }

    private void AwayMoveDown_MouseClick(object sender, MouseEventArgs e)
    {
        OnAwayTeamMoveDownClick?.Invoke(this, e);
    }

    private void AddPlayer_MouseClick(object sender, MouseEventArgs e)
    {
        OnAddPlayerClick?.Invoke(this, e);
    }

    private void AddTeam_MouseClick(object sender, MouseEventArgs e)
    {
        OnAddTeamClick?.Invoke(this, e);
    }

    private void CreateMatchBtn_MouseClick(object sender, MouseEventArgs e)
    {
        OnCreateMatchClick?.Invoke(this, e);
    }

    private void CancelBtn_MouseClick(object sender, MouseEventArgs e)
    {
        OnCancelClick?.Invoke(this, e);
    }
}