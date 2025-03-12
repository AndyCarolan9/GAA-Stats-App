using System.ComponentModel;

namespace StatsTracker.View_Elements
{
    public partial class SplitCountBar : ProgressBar
    {
        public SplitCountBar()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint | ControlStyles.UseTextForAccessibility | ControlStyles.Selectable, true);
        }

        public SplitCountBar(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            SetStyle(ControlStyles.UserPaint | ControlStyles.UseTextForAccessibility | ControlStyles.Selectable, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle home = new Rectangle(0, 0, Width, Height);
            Rectangle away = new Rectangle(0, 0, Width, Height);
            
            // c# progressbar color
            // Home Team Bar
            SolidBrush homeFillBrush = new SolidBrush(ForeColor);
            Rectangle rec = e.ClipRectangle;
            rec.Height -= 4;
            
            int homeTeamWidth = (int)(rec.Width * ((double)Value / Maximum)) - 4;
            home.X = 2;
            home.Y = 2;
            home.Width = homeTeamWidth;
            home.Height = rec.Height;

            //Away Team Bar
            SolidBrush awayFillBrush = new SolidBrush(BackColor);
            int remainder = Maximum - Value;
            int awayTeamWidth = (int)(rec.Width * ((double)remainder / Maximum));
            away.X = home.Width + 2;
            away.Y = 2;
            away.Width = awayTeamWidth;
            away.Height = rec.Height;
            
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
            e.Graphics.FillRectangle(homeFillBrush, home);
            e.Graphics.FillRectangle(awayFillBrush, away);
        }
    }
}