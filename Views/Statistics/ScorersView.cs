namespace StatsTracker.Views.Statistics;

public partial class ScorersView : Form, IStatsView
{
    public ScorersView()
    {
        InitializeComponent();
    }

    public DataGridView GetScorersGrid()
    {
        return ScorersGrid;
    }

    public Form GetForm()
    {
        return this;
    }
}