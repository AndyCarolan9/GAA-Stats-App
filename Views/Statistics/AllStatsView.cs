namespace StatsTracker.Views.Statistics;

public partial class AllStatsView : Form, IStatsView
{
    public AllStatsView()
    {
        InitializeComponent();
    }

    public Form GetForm()
    {
        return this;
    }
}