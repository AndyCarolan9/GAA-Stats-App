using StatsTracker.Views;

namespace StatsTracker.Controller;

public class CreateMatchController : IStatsController
{
    private CreateMatchView _view;
    private Dictionary<string, List<string>> TeamsAndPlayers = new Dictionary<string, List<string>>();

    public CreateMatchController()
    {
        _view = new CreateMatchView();
        
        _view.GetTeamDropDown().Items.AddRange(TeamsAndPlayers.Keys.ToArray());
        
        // Home Events
        _view.OnHomeTeamColorClick += OnHomeTeamColorClick;
        _view.OnMoveToHomeClick += MovePlayerToHome;
        _view.OnHomeTeamMoveUpClick += OnHomeTeamMoveUpClicked;
        _view.OnHomeTeamMoveDownClick += OnHomeTeamMoveDownClicked;
        
        // Away Events
        _view.OnAwayTeamColorClick += OnAwayTeamColorClick;
        _view.OnMoveToAwayClick += MovePlayerToAway;
        _view.OnAwayTeamMoveUpClick += OnAwayTeamMoveUpClicked;
        _view.OnAwayTeamMoveDownClick += OnAwayTeamMoveDownClicked;
        
        // Team Events
        _view.OnTeamDropDownIndexChanged += OnTeamDropDownIndexChanged;
        _view.OnAddPlayerClick += AddPlayerToTeam;
        _view.OnAddTeamClick += AddNewTeamToTeamList;
        
        _view.ShowDialog();
    }
    
    public IStatsView GetView()
    {
        return _view;
    }

    #region Home Events
    private void OnHomeTeamColorClick(object? sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            PictureBox homeTeamColorBox = _view.GetHomeTeamPictureBox();
            ColorDialog colorSelector = _view.GetTeamColorDialog();
            colorSelector.Color = homeTeamColorBox.BackColor;
            
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorSelector.Color;
                homeTeamColorBox.BackColor = selectedColor;
            }
        }
    }

    private void MovePlayerToHome(object? sender, MouseEventArgs e)
    {
        string? selectedPlayer = _view.GetTeamListBox().SelectedItem?.ToString();
        if (selectedPlayer == null)
        {
            return;
        }

        if (!_view.GetHomeTeamListBox().Items.Contains(selectedPlayer))
        {
            _view.GetHomeTeamListBox().Items.Add(selectedPlayer);
        }
    }

    private void OnHomeTeamMoveUpClicked(object? sender, MouseEventArgs e)
    {
        ListBox homeTeamListBox = _view.GetHomeTeamListBox();
        object? selectedItem = homeTeamListBox.SelectedItem;
        if (selectedItem == null)
        {
            return;
        }
        
        int index = homeTeamListBox.Items.IndexOf(selectedItem);
        if (index == 0)
        {
            return;
        }
        
        homeTeamListBox.BeginUpdate();
        homeTeamListBox.Items.RemoveAt(index);
        homeTeamListBox.Items.Insert(index - 1, selectedItem);
        homeTeamListBox.SelectedItem = selectedItem;
        homeTeamListBox.EndUpdate();
    }

    private void OnHomeTeamMoveDownClicked(object? sender, MouseEventArgs e)
    {
        ListBox homeTeamListBox = _view.GetHomeTeamListBox();
        object? selectedItem = homeTeamListBox.SelectedItem;
        if (selectedItem == null)
        {
            return;
        }
        
        int index = homeTeamListBox.Items.IndexOf(selectedItem);
        if (index == homeTeamListBox.Items.Count - 1)
        {
            return;
        }
        
        homeTeamListBox.BeginUpdate();
        homeTeamListBox.Items.RemoveAt(index);
        homeTeamListBox.Items.Insert(index + 1, selectedItem);
        homeTeamListBox.SelectedItem = selectedItem;
        homeTeamListBox.EndUpdate();
    }
    #endregion Home Events
    
    #region Away Events
    private void OnAwayTeamColorClick(object? sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            PictureBox awayTeamColorBox = _view.GetAwayTeamPictureBox();
            ColorDialog colorSelector = _view.GetTeamColorDialog();
            colorSelector.Color = awayTeamColorBox.BackColor;
            
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorSelector.Color;
                awayTeamColorBox.BackColor = selectedColor;
            }
        }
    }
    
    private void MovePlayerToAway(object? sender, MouseEventArgs e)
    {
        string? selectedPlayer = _view.GetTeamListBox().SelectedItem?.ToString();
        if (selectedPlayer == null)
        {
            return;
        }

        if (!_view.GetAwayTeamListBox().Items.Contains(selectedPlayer))
        {
            _view.GetAwayTeamListBox().Items.Add(selectedPlayer);
        }
    }
    
    private void OnAwayTeamMoveUpClicked(object? sender, MouseEventArgs e)
    {
        ListBox awayTeamListBox = _view.GetAwayTeamListBox();
        object? selectedItem = awayTeamListBox.SelectedItem;
        if (selectedItem == null)
        {
            return;
        }
        
        int index = awayTeamListBox.Items.IndexOf(selectedItem);
        if (index == 0)
        {
            return;
        }
        
        awayTeamListBox.BeginUpdate();
        awayTeamListBox.Items.RemoveAt(index);
        awayTeamListBox.Items.Insert(index - 1, selectedItem);
        awayTeamListBox.SelectedItem = selectedItem;
        awayTeamListBox.EndUpdate();
    }
    
    private void OnAwayTeamMoveDownClicked(object? sender, MouseEventArgs e)
    {
        ListBox awayTeamListBox = _view.GetAwayTeamListBox();
        object? selectedItem = awayTeamListBox.SelectedItem;
        if (selectedItem == null)
        {
            return;
        }
        
        int index = awayTeamListBox.Items.IndexOf(selectedItem);
        if (index == awayTeamListBox.Items.Count - 1)
        {
            return;
        }
        
        awayTeamListBox.BeginUpdate();
        awayTeamListBox.Items.RemoveAt(index);
        awayTeamListBox.Items.Insert(index + 1, selectedItem);
        awayTeamListBox.SelectedItem = selectedItem;
        awayTeamListBox.EndUpdate();
    }
    #endregion Away Events

    #region Team Events

    private void AddNewTeamToTeamList(object? sender, MouseEventArgs e)
    {
        string teamName = _view.GetAddTeamTextBox().Text;
        if (string.IsNullOrEmpty(teamName))
        {
            return;
        }
        
        TeamsAndPlayers.Add(teamName, []);
        
        UpdateTeamDropdown();
    }

    private void AddPlayerToTeam(object? sender, MouseEventArgs e)
    {
        string? selectedTeam = _view.GetTeamDropDown().SelectedItem?.ToString();
        if (string.IsNullOrEmpty(selectedTeam))
        {
            return;
        }
        
        string playerName = _view.GetAddPlayerTextBox().Text;
        if (string.IsNullOrEmpty(playerName))
        {
            return;
        }
        
        TeamsAndPlayers[selectedTeam].Add(playerName);
        
        OnTeamDropDownIndexChanged(sender, e);
    }
    
    private void OnTeamDropDownIndexChanged(object? sender, EventArgs e)
    {
        string? selectedTeam = _view.GetTeamDropDown().SelectedItem?.ToString();
        if (string.IsNullOrEmpty(selectedTeam))
        {
            return;
        }
        
        if (TeamsAndPlayers.ContainsKey(selectedTeam))
        {
            ListBox teamsListBox = _view.GetTeamListBox();
            teamsListBox.BeginUpdate();
            teamsListBox.Items.Clear();
            teamsListBox.Items.AddRange(TeamsAndPlayers[selectedTeam].ToArray());
            teamsListBox.EndUpdate();
        }
    }
    #endregion
    
    #region View Method
    private void UpdateTeamDropdown()
    {
        _view.GetTeamDropDown().BeginUpdate();
        _view.GetTeamDropDown().Items.Clear();
        _view.GetTeamDropDown().Items.AddRange(TeamsAndPlayers.Keys.ToArray());
        _view.GetTeamDropDown().EndUpdate();
    }
    #endregion
}