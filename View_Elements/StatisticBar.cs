using System.ComponentModel;

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

        public void UpdateValues(int homeValue, int awayValue)
        {
            SetHomeValue(homeValue);
            SetAwayValue(awayValue);
        
            int total = homeValue + awayValue;
            StatSplitBar.Maximum = total;
            StatSplitBar.Value = homeValue;
        }
    }
}