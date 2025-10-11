using System.ComponentModel;

namespace StatsTracker.Views.Statistics;

partial class AllStatsView
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new Container();
        ComponentResourceManager resources = new ComponentResourceManager(typeof(AllStatsView));
        TotalKickoutsBar = new StatsTracker.View_Elements.StatisticBar();
        KOWonCleanBar = new StatsTracker.View_Elements.StatisticBar();
        KOLabel = new Label();
        KOWonMarkBar = new StatsTracker.View_Elements.StatisticBar();
        KOWonBreak = new StatsTracker.View_Elements.StatisticBar();
        KOLostCleanBar = new StatsTracker.View_Elements.StatisticBar();
        KOLostMarkBar = new StatsTracker.View_Elements.StatisticBar();
        KOLostBreakBar = new StatsTracker.View_Elements.StatisticBar();
        TotalShots = new StatsTracker.View_Elements.StatisticBar();
        HomeTeamLabel = new Label();
        AwayTeamLabel = new Label();
        HomeTeamScore = new Label();
        AwayTeamScore = new Label();
        TotalPointShots = new StatsTracker.View_Elements.StatisticBar();
        Total2PointShots = new StatsTracker.View_Elements.StatisticBar();
        TotalPointsScored = new StatsTracker.View_Elements.StatisticBar();
        Total2PointScored = new StatsTracker.View_Elements.StatisticBar();
        TotalGoalsScored = new StatsTracker.View_Elements.StatisticBar();
        TotalGoalShots = new StatsTracker.View_Elements.StatisticBar();
        TotalWides = new StatsTracker.View_Elements.StatisticBar();
        TotalBlockedShots = new StatsTracker.View_Elements.StatisticBar();
        TotalSavedShots = new StatsTracker.View_Elements.StatisticBar();
        TotalShortShots = new StatsTracker.View_Elements.StatisticBar();
        TotalOutFor45 = new StatsTracker.View_Elements.StatisticBar();
        TurnoversWon = new StatsTracker.View_Elements.StatisticBar();
        label1 = new Label();
        Free = new StatsTracker.View_Elements.StatisticBar();
        Tackle = new StatsTracker.View_Elements.StatisticBar();
        Intercept = new StatsTracker.View_Elements.StatisticBar();
        DisplayPitch = new PictureBox();
        HomeTeamName = new Label();
        AwayTeamName = new Label();
        HalfSelectBox = new ComboBox();
        MainSplitContainer = new SplitContainer();
        StatsSplitContainer = new SplitContainer();
        KOTOTable = new TableLayoutPanel();
        ShotsTable = new TableLayoutPanel();
        Scorecard = new Panel();
        ((ISupportInitialize)DisplayPitch).BeginInit();
        ((ISupportInitialize)MainSplitContainer).BeginInit();
        MainSplitContainer.Panel1.SuspendLayout();
        MainSplitContainer.Panel2.SuspendLayout();
        MainSplitContainer.SuspendLayout();
        ((ISupportInitialize)StatsSplitContainer).BeginInit();
        StatsSplitContainer.Panel1.SuspendLayout();
        StatsSplitContainer.Panel2.SuspendLayout();
        StatsSplitContainer.SuspendLayout();
        KOTOTable.SuspendLayout();
        ShotsTable.SuspendLayout();
        Scorecard.SuspendLayout();
        SuspendLayout();
        // 
        // TotalKickoutsBar
        // 
        TotalKickoutsBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        TotalKickoutsBar.Dock = DockStyle.Fill;
        TotalKickoutsBar.Location = new Point(6, 57);
        TotalKickoutsBar.Margin = new Padding(5);
        TotalKickoutsBar.Name = "TotalKickoutsBar";
        TotalKickoutsBar.Size = new Size(488, 54);
        TotalKickoutsBar.TabIndex = 3;
        // 
        // KOWonCleanBar
        // 
        KOWonCleanBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        KOWonCleanBar.Dock = DockStyle.Fill;
        KOWonCleanBar.Location = new Point(6, 122);
        KOWonCleanBar.Margin = new Padding(5);
        KOWonCleanBar.Name = "KOWonCleanBar";
        KOWonCleanBar.Size = new Size(488, 54);
        KOWonCleanBar.TabIndex = 4;
        // 
        // KOLabel
        // 
        KOLabel.Dock = DockStyle.Fill;
        KOLabel.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
        KOLabel.Location = new Point(6, 6);
        KOLabel.Margin = new Padding(5);
        KOLabel.Name = "KOLabel";
        KOLabel.Size = new Size(488, 40);
        KOLabel.TabIndex = 5;
        KOLabel.Text = "Kickouts";
        KOLabel.TextAlign = ContentAlignment.TopCenter;
        // 
        // KOWonMarkBar
        // 
        KOWonMarkBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        KOWonMarkBar.Dock = DockStyle.Fill;
        KOWonMarkBar.Location = new Point(6, 187);
        KOWonMarkBar.Margin = new Padding(5);
        KOWonMarkBar.Name = "KOWonMarkBar";
        KOWonMarkBar.Size = new Size(488, 54);
        KOWonMarkBar.TabIndex = 6;
        // 
        // KOWonBreak
        // 
        KOWonBreak.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        KOWonBreak.Dock = DockStyle.Fill;
        KOWonBreak.Location = new Point(6, 252);
        KOWonBreak.Margin = new Padding(5);
        KOWonBreak.Name = "KOWonBreak";
        KOWonBreak.Size = new Size(488, 54);
        KOWonBreak.TabIndex = 7;
        // 
        // KOLostCleanBar
        // 
        KOLostCleanBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        KOLostCleanBar.Dock = DockStyle.Fill;
        KOLostCleanBar.Location = new Point(6, 317);
        KOLostCleanBar.Margin = new Padding(5);
        KOLostCleanBar.Name = "KOLostCleanBar";
        KOLostCleanBar.Size = new Size(488, 54);
        KOLostCleanBar.TabIndex = 8;
        // 
        // KOLostMarkBar
        // 
        KOLostMarkBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        KOLostMarkBar.Dock = DockStyle.Fill;
        KOLostMarkBar.Location = new Point(6, 382);
        KOLostMarkBar.Margin = new Padding(5);
        KOLostMarkBar.Name = "KOLostMarkBar";
        KOLostMarkBar.Size = new Size(488, 54);
        KOLostMarkBar.TabIndex = 9;
        // 
        // KOLostBreakBar
        // 
        KOLostBreakBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        KOLostBreakBar.Dock = DockStyle.Fill;
        KOLostBreakBar.Location = new Point(6, 447);
        KOLostBreakBar.Margin = new Padding(5);
        KOLostBreakBar.Name = "KOLostBreakBar";
        KOLostBreakBar.Size = new Size(488, 54);
        KOLostBreakBar.TabIndex = 10;
        // 
        // TotalShots
        // 
        TotalShots.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        TotalShots.Dock = DockStyle.Fill;
        TotalShots.Location = new Point(6, 98);
        TotalShots.Margin = new Padding(5);
        TotalShots.Name = "TotalShots";
        TotalShots.Size = new Size(500, 50);
        TotalShots.TabIndex = 12;
        // 
        // HomeTeamLabel
        // 
        HomeTeamLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        HomeTeamLabel.BackColor = SystemColors.Control;
        HomeTeamLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        HomeTeamLabel.Location = new Point(408, 0);
        HomeTeamLabel.Margin = new Padding(2, 0, 2, 0);
        HomeTeamLabel.Name = "HomeTeamLabel";
        HomeTeamLabel.Size = new Size(94, 39);
        HomeTeamLabel.TabIndex = 13;
        HomeTeamLabel.Text = "Home";
        HomeTeamLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // AwayTeamLabel
        // 
        AwayTeamLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        AwayTeamLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        AwayTeamLabel.Location = new Point(416, 787);
        AwayTeamLabel.Margin = new Padding(2, 0, 2, 0);
        AwayTeamLabel.Name = "AwayTeamLabel";
        AwayTeamLabel.Size = new Size(86, 39);
        AwayTeamLabel.TabIndex = 14;
        AwayTeamLabel.Text = "Away";
        AwayTeamLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // HomeTeamScore
        // 
        HomeTeamScore.Anchor = AnchorStyles.Top;
        HomeTeamScore.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        HomeTeamScore.Location = new Point(123, 5);
        HomeTeamScore.Margin = new Padding(5);
        HomeTeamScore.Name = "HomeTeamScore";
        HomeTeamScore.Size = new Size(102, 34);
        HomeTeamScore.TabIndex = 15;
        HomeTeamScore.Text = "00-00";
        HomeTeamScore.TextAlign = ContentAlignment.TopCenter;
        // 
        // AwayTeamScore
        // 
        AwayTeamScore.Anchor = AnchorStyles.Top;
        AwayTeamScore.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        AwayTeamScore.Location = new Point(278, 5);
        AwayTeamScore.Margin = new Padding(5);
        AwayTeamScore.Name = "AwayTeamScore";
        AwayTeamScore.Size = new Size(102, 34);
        AwayTeamScore.TabIndex = 16;
        AwayTeamScore.Text = "00-00";
        AwayTeamScore.TextAlign = ContentAlignment.TopCenter;
        // 
        // TotalPointShots
        // 
        TotalPointShots.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        TotalPointShots.Dock = DockStyle.Fill;
        TotalPointShots.Location = new Point(6, 159);
        TotalPointShots.Margin = new Padding(5);
        TotalPointShots.Name = "TotalPointShots";
        TotalPointShots.Size = new Size(500, 50);
        TotalPointShots.TabIndex = 18;
        // 
        // Total2PointShots
        // 
        Total2PointShots.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        Total2PointShots.Dock = DockStyle.Fill;
        Total2PointShots.Location = new Point(6, 220);
        Total2PointShots.Margin = new Padding(5);
        Total2PointShots.Name = "Total2PointShots";
        Total2PointShots.Size = new Size(500, 50);
        Total2PointShots.TabIndex = 19;
        // 
        // TotalPointsScored
        // 
        TotalPointsScored.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        TotalPointsScored.Dock = DockStyle.Fill;
        TotalPointsScored.Location = new Point(6, 342);
        TotalPointsScored.Margin = new Padding(5);
        TotalPointsScored.Name = "TotalPointsScored";
        TotalPointsScored.Size = new Size(500, 50);
        TotalPointsScored.TabIndex = 20;
        // 
        // Total2PointScored
        // 
        Total2PointScored.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        Total2PointScored.Dock = DockStyle.Fill;
        Total2PointScored.Location = new Point(6, 403);
        Total2PointScored.Margin = new Padding(5);
        Total2PointScored.Name = "Total2PointScored";
        Total2PointScored.Size = new Size(500, 50);
        Total2PointScored.TabIndex = 21;
        // 
        // TotalGoalsScored
        // 
        TotalGoalsScored.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        TotalGoalsScored.Dock = DockStyle.Fill;
        TotalGoalsScored.Location = new Point(6, 464);
        TotalGoalsScored.Margin = new Padding(5);
        TotalGoalsScored.Name = "TotalGoalsScored";
        TotalGoalsScored.Size = new Size(500, 50);
        TotalGoalsScored.TabIndex = 22;
        // 
        // TotalGoalShots
        // 
        TotalGoalShots.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        TotalGoalShots.Dock = DockStyle.Fill;
        TotalGoalShots.Location = new Point(3, 279);
        TotalGoalShots.Margin = new Padding(2, 3, 2, 3);
        TotalGoalShots.Name = "TotalGoalShots";
        TotalGoalShots.Size = new Size(506, 54);
        TotalGoalShots.TabIndex = 24;
        // 
        // TotalWides
        // 
        TotalWides.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        TotalWides.Dock = DockStyle.Fill;
        TotalWides.Location = new Point(3, 523);
        TotalWides.Margin = new Padding(2, 3, 2, 3);
        TotalWides.Name = "TotalWides";
        TotalWides.Size = new Size(506, 54);
        TotalWides.TabIndex = 25;
        // 
        // TotalBlockedShots
        // 
        TotalBlockedShots.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        TotalBlockedShots.Dock = DockStyle.Fill;
        TotalBlockedShots.Location = new Point(6, 586);
        TotalBlockedShots.Margin = new Padding(5);
        TotalBlockedShots.Name = "TotalBlockedShots";
        TotalBlockedShots.Size = new Size(500, 50);
        TotalBlockedShots.TabIndex = 26;
        // 
        // TotalSavedShots
        // 
        TotalSavedShots.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        TotalSavedShots.Dock = DockStyle.Fill;
        TotalSavedShots.Location = new Point(6, 647);
        TotalSavedShots.Margin = new Padding(5);
        TotalSavedShots.Name = "TotalSavedShots";
        TotalSavedShots.Size = new Size(500, 50);
        TotalSavedShots.TabIndex = 27;
        // 
        // TotalShortShots
        // 
        TotalShortShots.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        TotalShortShots.Dock = DockStyle.Fill;
        TotalShortShots.Location = new Point(6, 708);
        TotalShortShots.Margin = new Padding(5);
        TotalShortShots.Name = "TotalShortShots";
        TotalShortShots.Size = new Size(500, 50);
        TotalShortShots.TabIndex = 28;
        // 
        // TotalOutFor45
        // 
        TotalOutFor45.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        TotalOutFor45.Dock = DockStyle.Fill;
        TotalOutFor45.Location = new Point(6, 769);
        TotalOutFor45.Margin = new Padding(5);
        TotalOutFor45.Name = "TotalOutFor45";
        TotalOutFor45.Size = new Size(500, 51);
        TotalOutFor45.TabIndex = 29;
        // 
        // TurnoversWon
        // 
        TurnoversWon.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        TurnoversWon.Dock = DockStyle.Fill;
        TurnoversWon.Location = new Point(6, 563);
        TurnoversWon.Margin = new Padding(5);
        TurnoversWon.Name = "TurnoversWon";
        TurnoversWon.Size = new Size(488, 54);
        TurnoversWon.TabIndex = 30;
        // 
        // label1
        // 
        label1.Dock = DockStyle.Fill;
        label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
        label1.Location = new Point(6, 512);
        label1.Margin = new Padding(5);
        label1.Name = "label1";
        label1.Size = new Size(488, 40);
        label1.TabIndex = 31;
        label1.Text = "Turnovers";
        label1.TextAlign = ContentAlignment.TopCenter;
        // 
        // Free
        // 
        Free.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        Free.Dock = DockStyle.Fill;
        Free.Location = new Point(6, 628);
        Free.Margin = new Padding(5);
        Free.Name = "Free";
        Free.Size = new Size(488, 54);
        Free.TabIndex = 32;
        // 
        // Tackle
        // 
        Tackle.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        Tackle.Dock = DockStyle.Fill;
        Tackle.Location = new Point(6, 693);
        Tackle.Margin = new Padding(5);
        Tackle.Name = "Tackle";
        Tackle.Size = new Size(488, 54);
        Tackle.TabIndex = 33;
        // 
        // Intercept
        // 
        Intercept.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        Intercept.Dock = DockStyle.Fill;
        Intercept.Location = new Point(6, 758);
        Intercept.Margin = new Padding(5);
        Intercept.Name = "Intercept";
        Intercept.Size = new Size(488, 62);
        Intercept.TabIndex = 34;
        // 
        // DisplayPitch
        // 
        DisplayPitch.BackgroundImage = (Image)resources.GetObject("DisplayPitch.BackgroundImage");
        DisplayPitch.BackgroundImageLayout = ImageLayout.Stretch;
        DisplayPitch.Dock = DockStyle.Fill;
        DisplayPitch.Location = new Point(0, 0);
        DisplayPitch.Margin = new Padding(2);
        DisplayPitch.Name = "DisplayPitch";
        DisplayPitch.Size = new Size(502, 826);
        DisplayPitch.TabIndex = 35;
        DisplayPitch.TabStop = false;
        DisplayPitch.Paint += DisplayPitch_Paint;
        // 
        // HomeTeamName
        // 
        HomeTeamName.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        HomeTeamName.Location = new Point(2, 5);
        HomeTeamName.Margin = new Padding(5);
        HomeTeamName.Name = "HomeTeamName";
        HomeTeamName.Size = new Size(98, 34);
        HomeTeamName.TabIndex = 36;
        HomeTeamName.Text = "Home";
        HomeTeamName.TextAlign = ContentAlignment.MiddleCenter;
        HomeTeamName.Click += HomeTeam_Click;
        // 
        // AwayTeamName
        // 
        AwayTeamName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        AwayTeamName.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        AwayTeamName.Location = new Point(404, 5);
        AwayTeamName.Margin = new Padding(5);
        AwayTeamName.Name = "AwayTeamName";
        AwayTeamName.Size = new Size(98, 34);
        AwayTeamName.TabIndex = 37;
        AwayTeamName.Text = "Away";
        AwayTeamName.TextAlign = ContentAlignment.MiddleCenter;
        AwayTeamName.Click += AwayTeam_Click;
        // 
        // HalfSelectBox
        // 
        HalfSelectBox.FormattingEnabled = true;
        HalfSelectBox.Location = new Point(6, 6);
        HalfSelectBox.Margin = new Padding(5);
        HalfSelectBox.Name = "HalfSelectBox";
        HalfSelectBox.Size = new Size(136, 23);
        HalfSelectBox.TabIndex = 39;
        // 
        // MainSplitContainer
        // 
        MainSplitContainer.Dock = DockStyle.Fill;
        MainSplitContainer.Location = new Point(0, 0);
        MainSplitContainer.Name = "MainSplitContainer";
        // 
        // MainSplitContainer.Panel1
        // 
        MainSplitContainer.Panel1.Controls.Add(HomeTeamLabel);
        MainSplitContainer.Panel1.Controls.Add(AwayTeamLabel);
        MainSplitContainer.Panel1.Controls.Add(DisplayPitch);
        // 
        // MainSplitContainer.Panel2
        // 
        MainSplitContainer.Panel2.Controls.Add(StatsSplitContainer);
        MainSplitContainer.Size = new Size(1522, 826);
        MainSplitContainer.SplitterDistance = 502;
        MainSplitContainer.TabIndex = 40;
        // 
        // StatsSplitContainer
        // 
        StatsSplitContainer.Dock = DockStyle.Fill;
        StatsSplitContainer.Location = new Point(0, 0);
        StatsSplitContainer.Name = "StatsSplitContainer";
        // 
        // StatsSplitContainer.Panel1
        // 
        StatsSplitContainer.Panel1.Controls.Add(KOTOTable);
        // 
        // StatsSplitContainer.Panel2
        // 
        StatsSplitContainer.Panel2.Controls.Add(ShotsTable);
        StatsSplitContainer.Size = new Size(1016, 826);
        StatsSplitContainer.SplitterDistance = 500;
        StatsSplitContainer.TabIndex = 0;
        // 
        // KOTOTable
        // 
        KOTOTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        KOTOTable.ColumnCount = 1;
        KOTOTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        KOTOTable.Controls.Add(Intercept, 0, 12);
        KOTOTable.Controls.Add(Tackle, 0, 11);
        KOTOTable.Controls.Add(Free, 0, 10);
        KOTOTable.Controls.Add(TurnoversWon, 0, 9);
        KOTOTable.Controls.Add(label1, 0, 8);
        KOTOTable.Controls.Add(KOLostBreakBar, 0, 7);
        KOTOTable.Controls.Add(KOLostMarkBar, 0, 6);
        KOTOTable.Controls.Add(KOLostCleanBar, 0, 5);
        KOTOTable.Controls.Add(KOWonBreak, 0, 4);
        KOTOTable.Controls.Add(KOWonMarkBar, 0, 3);
        KOTOTable.Controls.Add(KOWonCleanBar, 0, 2);
        KOTOTable.Controls.Add(TotalKickoutsBar, 0, 1);
        KOTOTable.Controls.Add(KOLabel, 0, 0);
        KOTOTable.Dock = DockStyle.Fill;
        KOTOTable.Location = new Point(0, 0);
        KOTOTable.Name = "KOTOTable";
        KOTOTable.RowCount = 2;
        KOTOTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        KOTOTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
        KOTOTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
        KOTOTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
        KOTOTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
        KOTOTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
        KOTOTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
        KOTOTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
        KOTOTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        KOTOTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
        KOTOTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
        KOTOTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
        KOTOTable.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
        KOTOTable.Size = new Size(500, 826);
        KOTOTable.TabIndex = 0;
        // 
        // ShotsTable
        // 
        ShotsTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        ShotsTable.ColumnCount = 1;
        ShotsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        ShotsTable.Controls.Add(TotalOutFor45, 0, 13);
        ShotsTable.Controls.Add(TotalShortShots, 0, 12);
        ShotsTable.Controls.Add(TotalSavedShots, 0, 11);
        ShotsTable.Controls.Add(TotalBlockedShots, 0, 10);
        ShotsTable.Controls.Add(TotalWides, 0, 9);
        ShotsTable.Controls.Add(TotalGoalsScored, 0, 8);
        ShotsTable.Controls.Add(Total2PointScored, 0, 7);
        ShotsTable.Controls.Add(TotalPointsScored, 0, 6);
        ShotsTable.Controls.Add(TotalGoalShots, 0, 5);
        ShotsTable.Controls.Add(Total2PointShots, 0, 4);
        ShotsTable.Controls.Add(TotalPointShots, 0, 3);
        ShotsTable.Controls.Add(TotalShots, 0, 2);
        ShotsTable.Controls.Add(HalfSelectBox, 0, 0);
        ShotsTable.Controls.Add(Scorecard, 0, 1);
        ShotsTable.Dock = DockStyle.Fill;
        ShotsTable.Location = new Point(0, 0);
        ShotsTable.Name = "ShotsTable";
        ShotsTable.RowCount = 14;
        ShotsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        ShotsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        ShotsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
        ShotsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
        ShotsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
        ShotsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
        ShotsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
        ShotsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
        ShotsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
        ShotsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
        ShotsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
        ShotsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
        ShotsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
        ShotsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
        ShotsTable.Size = new Size(512, 826);
        ShotsTable.TabIndex = 0;
        // 
        // Scorecard
        // 
        Scorecard.Controls.Add(AwayTeamName);
        Scorecard.Controls.Add(AwayTeamScore);
        Scorecard.Controls.Add(HomeTeamScore);
        Scorecard.Controls.Add(HomeTeamName);
        Scorecard.Dock = DockStyle.Fill;
        Scorecard.Location = new Point(4, 45);
        Scorecard.Name = "Scorecard";
        Scorecard.Size = new Size(504, 44);
        Scorecard.TabIndex = 0;
        // 
        // AllStatsView
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        ClientSize = new Size(1522, 826);
        Controls.Add(MainSplitContainer);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(2);
        Name = "AllStatsView";
        Text = "All Stats";
        ((ISupportInitialize)DisplayPitch).EndInit();
        MainSplitContainer.Panel1.ResumeLayout(false);
        MainSplitContainer.Panel2.ResumeLayout(false);
        ((ISupportInitialize)MainSplitContainer).EndInit();
        MainSplitContainer.ResumeLayout(false);
        StatsSplitContainer.Panel1.ResumeLayout(false);
        StatsSplitContainer.Panel2.ResumeLayout(false);
        ((ISupportInitialize)StatsSplitContainer).EndInit();
        StatsSplitContainer.ResumeLayout(false);
        KOTOTable.ResumeLayout(false);
        ShotsTable.ResumeLayout(false);
        Scorecard.ResumeLayout(false);
        ResumeLayout(false);
    }
    private System.Windows.Forms.ComboBox HalfSelectBox;

    private System.Windows.Forms.Label HomeTeamName;

    private System.Windows.Forms.Label AwayTeamName;

    private System.Windows.Forms.PictureBox DisplayPitch;

    private StatsTracker.View_Elements.StatisticBar TurnoversWon;
    private System.Windows.Forms.Label label1;
    private StatsTracker.View_Elements.StatisticBar Free;
    private StatsTracker.View_Elements.StatisticBar Tackle;
    private StatsTracker.View_Elements.StatisticBar Intercept;

    private StatsTracker.View_Elements.StatisticBar TotalBlockedShots;
    private StatsTracker.View_Elements.StatisticBar TotalSavedShots;
    private StatsTracker.View_Elements.StatisticBar TotalShortShots;
    private StatsTracker.View_Elements.StatisticBar TotalOutFor45;

    private StatsTracker.View_Elements.StatisticBar TotalWides;

    private StatsTracker.View_Elements.StatisticBar TotalGoalShots;

    private System.Windows.Forms.Label HomeTeamLabel;
    private System.Windows.Forms.Label AwayTeamLabel;
    private System.Windows.Forms.Label HomeTeamScore;
    private System.Windows.Forms.Label AwayTeamScore;
    private StatsTracker.View_Elements.StatisticBar TotalPointShots;
    private StatsTracker.View_Elements.StatisticBar Total2PointShots;
    private StatsTracker.View_Elements.StatisticBar TotalPointsScored;
    private StatsTracker.View_Elements.StatisticBar Total2PointScored;
    private StatsTracker.View_Elements.StatisticBar TotalGoalsScored;

    private StatsTracker.View_Elements.StatisticBar TotalShots;

    private StatsTracker.View_Elements.StatisticBar TotalKickoutsBar;
    private StatsTracker.View_Elements.StatisticBar KOWonCleanBar;
    private System.Windows.Forms.Label KOLabel;
    private StatsTracker.View_Elements.StatisticBar KOWonMarkBar;
    private StatsTracker.View_Elements.StatisticBar KOWonBreak;
    private StatsTracker.View_Elements.StatisticBar KOLostCleanBar;
    private StatsTracker.View_Elements.StatisticBar KOLostMarkBar;
    private StatsTracker.View_Elements.StatisticBar KOLostBreakBar;

    #endregion

    private SplitContainer MainSplitContainer;
    private SplitContainer StatsSplitContainer;
    private TableLayoutPanel KOTOTable;
    private TableLayoutPanel ShotsTable;
    private Panel Scorecard;
}