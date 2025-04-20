using System.ComponentModel;
using StatsTracker.Classes;

namespace StatsTracker.View_Elements
{
    public partial class StatisticBar : UserControl
    {
        public StatisticBar()
        {
            InitializeComponent();

            // Set default bar values so that it is always split 50/50 event when the real value are 0
            StatSplitBar.Maximum = 2;
            StatSplitBar.Value = 1;
        }

        #region Properties
        [Description("Test text displayed in the textbox"),Category("Data")] 
        public string StatName
        {
            get => StatNameLabel.Text;
            set => StatNameLabel.Text = value;
        }
        #endregion

        public void SetHomeValue(int value)
        {
            HomeTeamValue.Text = value.ToString();
        }

        public void SetAwayValue(int value)
        {
            AwayTeamValue.Text = value.ToString();
        }

        public void InitialiseValues()
        {
            SetHomeValue(0);
            SetAwayValue(0);

            StatSplitBar.Maximum = 2;
            StatSplitBar.Value = 1;
        }

        public void UpdateValues(StatisticPair valuePair)
        {
            if (valuePair.IsStatisticsEmpty())
            {
                return;
            }
            
            SetHomeValue(valuePair.HomeTeamValue);
            SetAwayValue(valuePair.AwayTeamValue);
        
            int total = valuePair.TotalValue;
            StatSplitBar.Maximum = total;
            StatSplitBar.Value = valuePair.HomeTeamValue;
        }

        public void SetTeamColors(Color homeTeamColor, Color awayTeamColor)
        {
            StatSplitBar.ForeColor = homeTeamColor;
            StatSplitBar.BackColor = awayTeamColor;
        }
    }
}