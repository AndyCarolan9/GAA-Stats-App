using StatsTracker.Classes;
using StatsTracker.Events;
using StatsTracker.Utils;
using StatsTracker.Views;

namespace StatsTracker.Controller;

public class CreateMatchController : IStatsController
{
    private CreateMatchView _view;
    private List<Team> _teams = new List<Team>();
    
    private readonly string _filePath = "Teams.json";
    
    public event EventHandler<TeamSelectedEventArgs>? OnTeamSelected;

    public event EventHandler? OnCancelBtnClick;

    public CreateMatchController()
    {
        _view = new CreateMatchView();
        
        Team[]? teams = JSONHelper.LoadFromJsonFile<Team[]>(JSONHelper.GetFilePath(_filePath));
        if (teams != null)
        {
            _teams.AddRange(teams);
            _view.GetTeamDropDown().Items.AddRange(GetTeamNames());
            _view.GetHomeTeamDropDown().Items.AddRange(GetTeamNames());
            _view.GetAwayTeamDropDown().Items.AddRange(GetTeamNames());
        }
        
        // Home Events
        _view.OnHomeTeamDropdownChanged += HomeTeamDropdownChanged;
        _view.OnHomeTeamColorClick += OnHomeTeamColorClick;
        _view.OnMoveToHomeClick += MovePlayerToHome;
        _view.OnHomeTeamMoveUpClick += OnHomeTeamMoveUpClicked;
        _view.OnHomeTeamMoveDownClick += OnHomeTeamMoveDownClicked;
        _view.OnHomeTeamRemovePlayerClick += RemovePlayerFromHomeTeam;
        
        // Away Events
        _view.OnAwayTeamDropdownChanged += AwayTeamDropdownChanged;
        _view.OnAwayTeamColorClick += OnAwayTeamColorClick;
        _view.OnMoveToAwayClick += MovePlayerToAway;
        _view.OnAwayTeamMoveUpClick += OnAwayTeamMoveUpClicked;
        _view.OnAwayTeamMoveDownClick += OnAwayTeamMoveDownClicked;
        _view.OnAwayTeamRemovePlayerClick += RemovePlayerFromAwayTeam;
        
        // Team Events
        _view.OnTeamDropDownIndexChanged += OnTeamDropDownIndexChanged;
        _view.OnAddPlayerClick += AddPlayerToTeam;
        _view.OnAddTeamClick += AddNewTeamToTeamList;
        
        // Confim/Cancel
        _view.OnCreateMatchClick += OnTeamSelectedClick;
        _view.OnCancelClick += OnCancelClick;
    }
    
    public IStatsView GetView()
    {
        return _view;
    }

    public DialogResult ShowDialog()
    {
        return _view.GetForm().ShowDialog();
    }

    #region Home Events

    private void HomeTeamDropdownChanged(object? sender, EventArgs e)
    {
        string? selectedTeamName = _view.GetHomeTeamDropDown().SelectedItem?.ToString();
        if (selectedTeamName == null)
        {
            return;
        }
        
        Team? selectedTeam = FindTeam(selectedTeamName);
        if (selectedTeam == null)
        {
            return;
        }
        
        _view.GetHomeTeamPictureBox().BackColor = selectedTeam.TeamColor;
    }
    
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

                string? homeTeamName = _view.GetHomeTeamDropDown().SelectedItem?.ToString();
                if (homeTeamName == null)
                {
                    return;
                }
                
                Team? homeTeam = FindTeam(homeTeamName);
                if (homeTeam == null)
                {
                    return;
                }
                
                homeTeam.TeamColor = selectedColor;
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

    private void RemovePlayerFromHomeTeam(object? sender, MouseEventArgs e)
    {
        ListBox homeTeamListBox = _view.GetHomeTeamListBox();
        object? selectedItem = homeTeamListBox.SelectedItem;
        if (selectedItem == null)
        {
            return;
        }
        
        int index = homeTeamListBox.Items.IndexOf(selectedItem);
        if (index == -1)
        {
            return;
        }
        
        homeTeamListBox.BeginUpdate();
        homeTeamListBox.Items.RemoveAt(index);
        homeTeamListBox.SelectedItem = null;
        homeTeamListBox.EndUpdate();
    }
    #endregion Home Events
    
    #region Away Events

    private void AwayTeamDropdownChanged(object? sender, EventArgs e)
    {
        string? selectedTeamName = _view.GetAwayTeamDropDown().SelectedItem?.ToString();
        if (selectedTeamName == null)
        {
            return;
        }
        
        Team? selectedTeam = FindTeam(selectedTeamName);
        if (selectedTeam == null)
        {
            return;
        }
        
        _view.GetAwayTeamPictureBox().BackColor = selectedTeam.TeamColor;
    }
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
                
                string? awayTeamName = _view.GetAwayTeamDropDown().SelectedItem?.ToString();
                if (awayTeamName == null)
                {
                    return;
                }
                
                Team? awayTeam = FindTeam(awayTeamName);
                if (awayTeam == null)
                {
                    return;
                }
                
                awayTeam.TeamColor = selectedColor;
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
    
    private void RemovePlayerFromAwayTeam(object? sender, MouseEventArgs e)
    {
        ListBox awayTeamListBox = _view.GetAwayTeamListBox();
        object? selectedItem = awayTeamListBox.SelectedItem;
        if (selectedItem == null)
        {
            return;
        }
        
        int index = awayTeamListBox.Items.IndexOf(selectedItem);
        if (index == -1)
        {
            return;
        }
        
        awayTeamListBox.BeginUpdate();
        awayTeamListBox.Items.RemoveAt(index);
        awayTeamListBox.SelectedItem = null;
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
        
        _teams.Add(new Team(teamName));
        _view.GetAddTeamTextBox().Text = "";
        
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
        
        Team? team = FindTeam(selectedTeam);
        if (team == null)
        {
            return;
        }
        
        team.AddPlayerToTeamSheet(playerName);
        _view.GetAddPlayerTextBox().Text = "";
        
        OnTeamDropDownIndexChanged(sender, e);
    }
    
    private void OnTeamDropDownIndexChanged(object? sender, EventArgs e)
    {
        string? selectedTeam = _view.GetTeamDropDown().SelectedItem?.ToString();
        if (string.IsNullOrEmpty(selectedTeam))
        {
            return;
        }
        
        Team? team = FindTeam(selectedTeam);
        if (team != null)
        {
            ListBox teamsListBox = _view.GetTeamListBox();
            teamsListBox.BeginUpdate();
            teamsListBox.Items.Clear();
            teamsListBox.Items.AddRange(team.TeamSheet.ToArray());
            teamsListBox.EndUpdate();
        }
    }
    #endregion

    private void OnTeamSelectedClick(object? sender, MouseEventArgs e)
    {
        string? homeTeamName = _view.GetHomeTeamDropDown().SelectedItem?.ToString();
        string? awayTeamName = _view.GetAwayTeamDropDown().SelectedItem?.ToString();
        string[] homePlayers = _view.GetHomeTeamListBox().Items.Cast<string>().ToArray();
        string[] awayPlayers = _view.GetAwayTeamListBox().Items.Cast<string>().ToArray();

        if (string.IsNullOrEmpty(homeTeamName) || string.IsNullOrEmpty(awayTeamName))
        {
            return;
        }
        
        TeamSelectedEventArgs teamSelectedEventArgs = new TeamSelectedEventArgs();
        teamSelectedEventArgs.HomeTeamName = homeTeamName;
        teamSelectedEventArgs.AwayTeamName = awayTeamName;
        teamSelectedEventArgs.HomePlayers = homePlayers;
        teamSelectedEventArgs.AwayPlayers = awayPlayers;
        teamSelectedEventArgs.HomeTeamColor = _view.GetHomeTeamPictureBox().BackColor;
        teamSelectedEventArgs.AwayTeamColor = _view.GetAwayTeamPictureBox().BackColor;
        
        JSONHelper.SaveToJsonFile(JSONHelper.GetFilePath(_filePath), _teams.ToArray());
        
        OnTeamSelected?.Invoke(this, teamSelectedEventArgs);
    }

    private void OnCancelClick(object? sender, MouseEventArgs e)
    {
        OnCancelBtnClick?.Invoke(this, e);
    }
    
    #region View Method
    private void UpdateTeamDropdown()
    {
        _view.GetTeamDropDown().BeginUpdate();
        _view.GetTeamDropDown().Items.Clear();
        _view.GetTeamDropDown().Items.AddRange(GetTeamNames());
        _view.GetTeamDropDown().EndUpdate();
        
        _view.GetHomeTeamDropDown().BeginUpdate();
        _view.GetHomeTeamDropDown().Items.Clear();
        _view.GetHomeTeamDropDown().Items.AddRange(GetTeamNames());
        _view.GetHomeTeamDropDown().EndUpdate();
        
        _view.GetAwayTeamDropDown().BeginUpdate();
        _view.GetAwayTeamDropDown().Items.Clear();
        _view.GetAwayTeamDropDown().Items.AddRange(GetTeamNames());
        _view.GetAwayTeamDropDown().EndUpdate();
    }

    private string[] GetTeamNames()
    {
        List<string> teamNames = new List<string>();
        foreach (var team in _teams)
        {
            teamNames.Add(team.TeamName);
        }
        
        return teamNames.ToArray();
    }

    private Team? FindTeam(string teamName)
    {
        return _teams.Find(team => team.TeamName == teamName);
    }
    #endregion
}