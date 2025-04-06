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
    public event EventHandler? OnHomeTeamDropTextChanged;
    public event EventHandler? OnHomeTeamDropDownIndexChanged;
    public event EventHandler<MouseEventArgs>? OnHomeTeamColorClick;
    public event EventHandler<MouseEventArgs>? OnHomeTeamMoveUpClick;
    public event EventHandler<MouseEventArgs>? OnHomeTeamMoveDownClick;
    
    public event EventHandler? OnAwayTeamDropTextChanged;
    public event EventHandler? OnAwayTeamDropDownIndexChanged;
    public event EventHandler<MouseEventArgs>? OnAwayTeamColorClick;
    public event EventHandler<MouseEventArgs>? OnAwayTeamMoveUpClick;
    public event EventHandler<MouseEventArgs>? OnAwayTeamMoveDownClick;
    
    public event EventHandler? OnTeamDropDownIndexChanged;
    public event EventHandler<MouseEventArgs>? OnMoveToHomeClick;
    public event EventHandler<MouseEventArgs>? OnMoveToAwayClick;
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

    public ColorDialog GetHomeTeamColorDialog()
    {
        return HomeTeamColor;
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

    public ComboBox GetAwayTeamDropDown()
    {
        return AwayTeamDropDown;
    }
    
    public ListBox GetAwayTeamListBox()
    {
        return AwayTeamPlayersList;
    }

    public ColorDialog GetAwayTeamColorDialog()
    {
        return AwayTeamColor;
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
    #endregion

    private void HomeTeamDropDown_TextUpdate(object sender, EventArgs e)
    {
        OnHomeTeamDropTextChanged?.Invoke(this, e);
    }

    private void HomeTeamDropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
        OnHomeTeamDropDownIndexChanged?.Invoke(this, e);
    }

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

    private void AwayTeamDropDown_TextUpdate(object sender, EventArgs e)
    {
        OnAwayTeamDropTextChanged?.Invoke(this, e);
    }

    private void AwayTeamDropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
        OnAwayTeamDropDownIndexChanged?.Invoke(this, e);
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
}