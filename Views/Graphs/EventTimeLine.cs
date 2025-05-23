namespace StatsTracker.Views.Graphs;

public partial class EventTimeLine : Form, IStatsView
{
    public EventTimeLine()
    {
        InitializeComponent();
    }

    public Label GetHomeTeamLabel()
    {
        return HomeTeamLabel;
    }

    public Label GetAwayTeamLabel()
    {
        return AwayTeamLabel;
    }

    public Panel GetEventPanel()
    {
        return EventPanel;
    }

    public Form GetForm()
    {
        return this;
    }
}