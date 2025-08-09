namespace StatsTracker.Views.Statistics;

public partial class DisciplineReportView : Form, IStatsView
{
    public DisciplineReportView()
    {
        InitializeComponent();
    }

    public Form GetForm()
    {
        return this;
    }
    
    #region Controll Getters
    public PictureBox GetPitchBox()
    {
        return pictureBox1;
    }

    public ComboBox GetTeamComboBox()
    {
        return TeamSelectBox;
    }

    public DataGridView GetTeamConcededFreesDataGrid()
    {
        return TeamConcededFreesGrid;
    }
    
    public DataGridView GetPlayerConcededFreesDataGrid()
    {
        return PlayerConcededFreesView;
    }
    
    public DataGridView GetTeamWonFreesDataGrid()
    {
        return TeamWonFreesGrid;
    }
    
    public DataGridView GetPlayerWonFreesDataGrid()
    {
        return PlayerWonFreesGrid;
    }

    public DataGridView GetScoreConcededDataGrid()
    {
        return ScoreConcededGrid;
    }

    public DataGridView GetTotalScoredDataGrid()
    {
        return TotalScoredGrid;
    }
    #endregion
}