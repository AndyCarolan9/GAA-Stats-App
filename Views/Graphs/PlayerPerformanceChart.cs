using System.Windows.Forms.DataVisualization.Charting;

namespace StatsTracker.Views.Graphs;

public partial class PlayerPerformanceChart : Form, IStatsView
{
    private Chart _chart = new Chart();
    
    public PlayerPerformanceChart()
    {
        InitializeComponent();
    }

    public Form GetForm()
    {
        return this;
    }

    public Chart GetChart()
    {
        return _chart;
    }

    private void PlayerPerformanceChart_Load(object sender, EventArgs e)
    {
        _chart.Size = new Size(500, 500);
        _chart.Location = new Point(10, 10);
        
        ChartArea chartArea = new ChartArea();
        chartArea.Name = "ChartArea1";
        chartArea.AxisX.Title = "Time";
        chartArea.AxisY.Title = "# Of Events";
        chartArea.AxisX.Interval = 5;
        chartArea.AxisX.Minimum = 0;
        chartArea.AxisX.Maximum = 70;
        chartArea.BackColor = Color.Silver;
        
        _chart.ChartAreas.Add(chartArea);
        Controls.Add(_chart);
    }
    
    #region View Getters
    public ComboBox GetTeamsComboBox()
    {
        return TeamComboBox;
    }

    public ComboBox GetPlayersComboBox()
    {
        return PlayerComboBox;
    }

    public Label GetFHTOWonLabel()
    {
        return FHTOWon;
    }

    public Label GetSHTOWonLabel()
    {
        return SHTOWon;
    }

    public Label GetTOTTOWonLabel()
    {
        return TOTTOWon;
    }
    
    public Label GetFHTOLostLabel()
    {
        return FHTOLost;
    }

    public Label GetSHTOLostLabel()
    {
        return SHTOLost;
    }

    public Label GetTOTTOLostLabel()
    {
        return TOTTOLost;
    }
    
    public Label GetFHKOWonLabel()
    {
        return FHKOWon;
    }

    public Label GetSHKOWonLabel()
    {
        return SHKOWon;
    }

    public Label GetTOTKOWonLabel()
    {
        return TOTKOWon;
    }
    
    public Label GetFHPointLabel()
    {
        return FHPointScored;
    }

    public Label GetSHPointLabel()
    {
        return SHPointScored;
    }

    public Label GetTOTPointLabel()
    {
        return TOTPointScored;
    }
    
    public Label GetFHGoalLabel()
    {
        return FHGoalScored;
    }

    public Label GetSHGoalLabel()
    {
        return SHGoalScored;
    }

    public Label GetTOTGoalLabel()
    {
        return TOTGoalScored;
    }
    
    public Label GetFH2PointLabel()
    {
        return FH2PointScored;
    }

    public Label GetSH2PointLabel()
    {
        return SH2PointScored;
    }

    public Label GetTOT2PointLabel()
    {
        return TOT2PointScored;
    }
    
    public Label GetFHMissesLabel()
    {
        return FHMisses;
    }

    public Label GetSHMissesLabel()
    {
        return SHMisses;
    }

    public Label GetTOTMissesLabel()
    {
        return TOTMisses;
    }
    
    public Label GetFHFreesLabel()
    {
        return FHFrees;
    }

    public Label GetSHFreesLabel()
    {
        return SHFrees;
    }

    public Label GetTOTFreesLabel()
    {
        return TOTFrees;
    }
    
    public Label GetFHScoreableFreesLabel()
    {
        return FHScoreableFrees;
    }

    public Label GetSHScoreableFreesLabel()
    {
        return SHScoreableFrees;
    }

    public Label GetTOTScoreableFreesLabel()
    {
        return TOTScoreableFrees;
    }
    #endregion
}