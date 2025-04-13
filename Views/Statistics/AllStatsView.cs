namespace StatsTracker.Views.Statistics;

public partial class AllStatsView : Form, IStatsView
{
    #region Events
    public event EventHandler? OnTeamChanged;
    #endregion
    
    public AllStatsView()
    {
        InitializeComponent();
    }

    public Form GetForm()
    {
        return this;
    }
    
    #region Control Getters
    public ComboBox GetTeamSelector()
    {
        return TeamSelectorBox;
    }
    #endregion

    #region Control Events
    private void TeamSelectBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        OnTeamChanged?.Invoke(this, e);
    }
    #endregion
}