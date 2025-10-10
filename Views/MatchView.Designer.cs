using System.ComponentModel;

namespace StatsTracker.Views;

partial class MatchView
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(MatchView));
        FootballFieldInput = new PictureBox();
        EventInputMenu = new ContextMenuStrip(components);
        toolStripComboBox1 = new ToolStripComboBox();
        toolStripMenuItem1 = new ToolStripMenuItem();
        toolStripMenuItem2 = new ToolStripMenuItem();
        toolStripMenuItem3 = new ToolStripMenuItem();
        HeaderBar = new MenuStrip();
        fileToolStripMenuItem = new ToolStripMenuItem();
        newToolStripMenuItem = new ToolStripMenuItem();
        openToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator = new ToolStripSeparator();
        saveToolStripMenuItem = new ToolStripMenuItem();
        saveAsToolStripMenuItem = new ToolStripMenuItem();
        editToolStripMenuItem = new ToolStripMenuItem();
        undoToolStripMenuItem = new ToolStripMenuItem();
        redoToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator3 = new ToolStripSeparator();
        cutToolStripMenuItem = new ToolStripMenuItem();
        copyToolStripMenuItem = new ToolStripMenuItem();
        pasteToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator4 = new ToolStripSeparator();
        selectAllToolStripMenuItem = new ToolStripMenuItem();
        ExportToolStripMenuItem = new ToolStripMenuItem();
        JournalistData = new ToolStripMenuItem();
        ViewToolStripMenuItem = new ToolStripMenuItem();
        Scorers = new ToolStripMenuItem();
        AllStatsToolStripMenuItem = new ToolStripMenuItem();
        GraphsToolStripMenuItem = new ToolStripMenuItem();
        ScoreTimeLine = new ToolStripMenuItem();
        EventTimeLine = new ToolStripMenuItem();
        PlayerPerformance = new ToolStripMenuItem();
        DisciplineReport = new ToolStripMenuItem();
        helpToolStripMenuItem = new ToolStripMenuItem();
        contentsToolStripMenuItem = new ToolStripMenuItem();
        indexToolStripMenuItem = new ToolStripMenuItem();
        searchToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator5 = new ToolStripSeparator();
        aboutToolStripMenuItem = new ToolStripMenuItem();
        toolStripMenuItem4 = new ToolStripMenuItem();
        toolStripMenuItem5 = new ToolStripMenuItem();
        toolStripMenuItem6 = new ToolStripMenuItem();
        toolStripMenuItem7 = new ToolStripMenuItem();
        toolStripMenuItem8 = new ToolStripMenuItem();
        toolStripMenuItem9 = new ToolStripMenuItem();
        toolStripMenuItem11 = new ToolStripMenuItem();
        pointScoredToolStripMenuItem = new ToolStripMenuItem();
        HomeTeamName = new Label();
        AwayTeamName = new Label();
        AwayTeamScore = new Label();
        HomeTeamScore = new Label();
        HomeTeamSubs = new Button();
        AwayTeamSubs = new Button();
        TurnoverStatBar = new StatsTracker.View_Elements.StatisticBar();
        ShotsStatBar = new StatsTracker.View_Elements.StatisticBar();
        KickoutsStatsBar = new StatsTracker.View_Elements.StatisticBar();
        GoalShotsStatBar = new StatsTracker.View_Elements.StatisticBar();
        WidesStatBar = new StatsTracker.View_Elements.StatisticBar();
        FreesStatBar = new StatsTracker.View_Elements.StatisticBar();
        HalfLabel = new Label();
        StartStopButton = new Button();
        Pause = new Button();
        label2 = new Label();
        label3 = new Label();
        TimeLabel = new Label();
        SaveFileDialog = new SaveFileDialog();
        OpenFileDialog = new OpenFileDialog();
        toolStripMenuItem10 = new ToolStripMenuItem();
        EventListBox = new ListBox();
        HomePitchLabel = new Label();
        AwayPitchLabel = new Label();
        HomePitchHighlight = new PictureBox();
        AwayPitchHighlight = new PictureBox();
        toolStripMenuItem12 = new ToolStripMenuItem();
        toolStripMenuItem13 = new ToolStripMenuItem();
        toolStripMenuItem14 = new ToolStripMenuItem();
        toolStripSeparator1 = new ToolStripSeparator();
        toolStripSeparator2 = new ToolStripSeparator();
        toolStripMenuItem15 = new ToolStripMenuItem();
        toolStripMenuItem16 = new ToolStripMenuItem();
        toolStripMenuItem17 = new ToolStripMenuItem();
        toolStripMenuItem18 = new ToolStripMenuItem();
        toolStripMenuItem19 = new ToolStripMenuItem();
        HomeCardsButton = new Button();
        AwayCardsButton = new Button();
        HomeTeamCardedPlayers = new ListBox();
        AwayTeamCardedPlayers = new ListBox();
        EventListContextMenu = new ContextMenuStrip(components);
        MainScreenSplitContainer = new SplitContainer();
        StatsViewTable = new TableLayoutPanel();
        TimeControlTable = new TableLayoutPanel();
        ScorecardTable = new TableLayoutPanel();
        splitContainer2 = new SplitContainer();
        splitContainer4 = new SplitContainer();
        splitContainer3 = new SplitContainer();
        splitContainer5 = new SplitContainer();
        StatsBarContainer = new TableLayoutPanel();
        ((ISupportInitialize)FootballFieldInput).BeginInit();
        HeaderBar.SuspendLayout();
        ((ISupportInitialize)HomePitchHighlight).BeginInit();
        ((ISupportInitialize)AwayPitchHighlight).BeginInit();
        ((ISupportInitialize)MainScreenSplitContainer).BeginInit();
        MainScreenSplitContainer.Panel1.SuspendLayout();
        MainScreenSplitContainer.Panel2.SuspendLayout();
        MainScreenSplitContainer.SuspendLayout();
        StatsViewTable.SuspendLayout();
        TimeControlTable.SuspendLayout();
        ScorecardTable.SuspendLayout();
        ((ISupportInitialize)splitContainer2).BeginInit();
        splitContainer2.Panel1.SuspendLayout();
        splitContainer2.Panel2.SuspendLayout();
        splitContainer2.SuspendLayout();
        ((ISupportInitialize)splitContainer4).BeginInit();
        splitContainer4.Panel1.SuspendLayout();
        splitContainer4.Panel2.SuspendLayout();
        splitContainer4.SuspendLayout();
        ((ISupportInitialize)splitContainer3).BeginInit();
        splitContainer3.Panel1.SuspendLayout();
        splitContainer3.Panel2.SuspendLayout();
        splitContainer3.SuspendLayout();
        ((ISupportInitialize)splitContainer5).BeginInit();
        splitContainer5.Panel1.SuspendLayout();
        splitContainer5.Panel2.SuspendLayout();
        splitContainer5.SuspendLayout();
        StatsBarContainer.SuspendLayout();
        SuspendLayout();
        // 
        // FootballFieldInput
        // 
        FootballFieldInput.BackgroundImage = (Image)resources.GetObject("FootballFieldInput.BackgroundImage");
        FootballFieldInput.BackgroundImageLayout = ImageLayout.Stretch;
        FootballFieldInput.ContextMenuStrip = EventInputMenu;
        FootballFieldInput.Dock = DockStyle.Fill;
        FootballFieldInput.Location = new Point(0, 0);
        FootballFieldInput.Name = "FootballFieldInput";
        FootballFieldInput.Size = new Size(632, 1050);
        FootballFieldInput.SizeMode = PictureBoxSizeMode.StretchImage;
        FootballFieldInput.TabIndex = 0;
        FootballFieldInput.TabStop = false;
        FootballFieldInput.Paint += FootballFieldInput_Paint;
        FootballFieldInput.MouseClick += FootballFieldInput_MouseClick;
        FootballFieldInput.MouseUp += FootballFieldInput_MouseUp;
        // 
        // EventInputMenu
        // 
        EventInputMenu.ImageScalingSize = new Size(20, 20);
        EventInputMenu.Name = "EventInputMenu";
        EventInputMenu.Size = new Size(61, 4);
        EventInputMenu.Opening += EventInputMenu_Opening;
        // 
        // toolStripComboBox1
        // 
        toolStripComboBox1.Name = "toolStripComboBox1";
        toolStripComboBox1.Size = new Size(121, 23);
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new Size(32, 19);
        toolStripMenuItem1.Text = "toolStripMenuItem1";
        // 
        // toolStripMenuItem2
        // 
        toolStripMenuItem2.Name = "toolStripMenuItem2";
        toolStripMenuItem2.Size = new Size(32, 19);
        // 
        // toolStripMenuItem3
        // 
        toolStripMenuItem3.Name = "toolStripMenuItem3";
        toolStripMenuItem3.Size = new Size(32, 19);
        // 
        // HeaderBar
        // 
        HeaderBar.BackColor = Color.Gray;
        HeaderBar.ImageScalingSize = new Size(20, 20);
        HeaderBar.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, ExportToolStripMenuItem, ViewToolStripMenuItem, helpToolStripMenuItem });
        HeaderBar.Location = new Point(0, 0);
        HeaderBar.Name = "HeaderBar";
        HeaderBar.Size = new Size(1902, 24);
        HeaderBar.TabIndex = 1;
        HeaderBar.Text = "menuStrip1";
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, saveAsToolStripMenuItem });
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new Size(37, 20);
        fileToolStripMenuItem.Text = "&File";
        // 
        // newToolStripMenuItem
        // 
        newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
        newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        newToolStripMenuItem.Name = "newToolStripMenuItem";
        newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
        newToolStripMenuItem.Size = new Size(186, 22);
        newToolStripMenuItem.Text = "&New";
        newToolStripMenuItem.Click += newToolStripMenuItem_Click;
        // 
        // openToolStripMenuItem
        // 
        openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
        openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        openToolStripMenuItem.Name = "openToolStripMenuItem";
        openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
        openToolStripMenuItem.Size = new Size(186, 22);
        openToolStripMenuItem.Text = "&Open";
        openToolStripMenuItem.Click += openToolStripMenuItem_Click;
        // 
        // toolStripSeparator
        // 
        toolStripSeparator.Name = "toolStripSeparator";
        toolStripSeparator.Size = new Size(183, 6);
        // 
        // saveToolStripMenuItem
        // 
        saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
        saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        saveToolStripMenuItem.Name = "saveToolStripMenuItem";
        saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
        saveToolStripMenuItem.Size = new Size(186, 22);
        saveToolStripMenuItem.Text = "&Save";
        saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
        // 
        // saveAsToolStripMenuItem
        // 
        saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
        saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
        saveAsToolStripMenuItem.Size = new Size(186, 22);
        saveAsToolStripMenuItem.Text = "Save &As";
        saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
        // 
        // editToolStripMenuItem
        // 
        editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator3, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator4, selectAllToolStripMenuItem });
        editToolStripMenuItem.Name = "editToolStripMenuItem";
        editToolStripMenuItem.Size = new Size(39, 20);
        editToolStripMenuItem.Text = "&Edit";
        // 
        // undoToolStripMenuItem
        // 
        undoToolStripMenuItem.Name = "undoToolStripMenuItem";
        undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
        undoToolStripMenuItem.Size = new Size(144, 22);
        undoToolStripMenuItem.Text = "&Undo";
        // 
        // redoToolStripMenuItem
        // 
        redoToolStripMenuItem.Name = "redoToolStripMenuItem";
        redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
        redoToolStripMenuItem.Size = new Size(144, 22);
        redoToolStripMenuItem.Text = "&Redo";
        // 
        // toolStripSeparator3
        // 
        toolStripSeparator3.Name = "toolStripSeparator3";
        toolStripSeparator3.Size = new Size(141, 6);
        // 
        // cutToolStripMenuItem
        // 
        cutToolStripMenuItem.Image = (Image)resources.GetObject("cutToolStripMenuItem.Image");
        cutToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        cutToolStripMenuItem.Name = "cutToolStripMenuItem";
        cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
        cutToolStripMenuItem.Size = new Size(144, 22);
        cutToolStripMenuItem.Text = "Cu&t";
        // 
        // copyToolStripMenuItem
        // 
        copyToolStripMenuItem.Image = (Image)resources.GetObject("copyToolStripMenuItem.Image");
        copyToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        copyToolStripMenuItem.Name = "copyToolStripMenuItem";
        copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
        copyToolStripMenuItem.Size = new Size(144, 22);
        copyToolStripMenuItem.Text = "&Copy";
        // 
        // pasteToolStripMenuItem
        // 
        pasteToolStripMenuItem.Image = (Image)resources.GetObject("pasteToolStripMenuItem.Image");
        pasteToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
        pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
        pasteToolStripMenuItem.Size = new Size(144, 22);
        pasteToolStripMenuItem.Text = "&Paste";
        // 
        // toolStripSeparator4
        // 
        toolStripSeparator4.Name = "toolStripSeparator4";
        toolStripSeparator4.Size = new Size(141, 6);
        // 
        // selectAllToolStripMenuItem
        // 
        selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
        selectAllToolStripMenuItem.Size = new Size(144, 22);
        selectAllToolStripMenuItem.Text = "Select &All";
        // 
        // ExportToolStripMenuItem
        // 
        ExportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { JournalistData });
        ExportToolStripMenuItem.Name = "ExportToolStripMenuItem";
        ExportToolStripMenuItem.Size = new Size(52, 20);
        ExportToolStripMenuItem.Text = "Export";
        // 
        // JournalistData
        // 
        JournalistData.Name = "JournalistData";
        JournalistData.ShortcutKeys = Keys.Control | Keys.E;
        JournalistData.Size = new Size(191, 22);
        JournalistData.Text = "Journalist Data";
        JournalistData.Click += JournalistData_Click;
        // 
        // ViewToolStripMenuItem
        // 
        ViewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Scorers, AllStatsToolStripMenuItem, GraphsToolStripMenuItem, DisciplineReport });
        ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
        ViewToolStripMenuItem.Size = new Size(44, 20);
        ViewToolStripMenuItem.Text = "&View";
        // 
        // Scorers
        // 
        Scorers.Name = "Scorers";
        Scorers.Size = new Size(163, 22);
        Scorers.Text = "Scorers";
        Scorers.Click += Scorers_Click;
        // 
        // AllStatsToolStripMenuItem
        // 
        AllStatsToolStripMenuItem.Name = "AllStatsToolStripMenuItem";
        AllStatsToolStripMenuItem.Size = new Size(163, 22);
        AllStatsToolStripMenuItem.Text = "&All Stats";
        AllStatsToolStripMenuItem.Click += AllStatsToolStripMenuItem_Click;
        // 
        // GraphsToolStripMenuItem
        // 
        GraphsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ScoreTimeLine, EventTimeLine, PlayerPerformance });
        GraphsToolStripMenuItem.Name = "GraphsToolStripMenuItem";
        GraphsToolStripMenuItem.Size = new Size(163, 22);
        GraphsToolStripMenuItem.Text = "&Graphs";
        // 
        // ScoreTimeLine
        // 
        ScoreTimeLine.Name = "ScoreTimeLine";
        ScoreTimeLine.Size = new Size(177, 22);
        ScoreTimeLine.Text = "Score Time Line";
        ScoreTimeLine.Click += ScoreTimeLine_Click;
        // 
        // EventTimeLine
        // 
        EventTimeLine.Name = "EventTimeLine";
        EventTimeLine.Size = new Size(177, 22);
        EventTimeLine.Text = "Event Time Line";
        EventTimeLine.Click += EventTimeLine_Click;
        // 
        // PlayerPerformance
        // 
        PlayerPerformance.Name = "PlayerPerformance";
        PlayerPerformance.Size = new Size(177, 22);
        PlayerPerformance.Text = "Player Performance";
        // 
        // DisciplineReport
        // 
        DisciplineReport.Name = "DisciplineReport";
        DisciplineReport.Size = new Size(163, 22);
        DisciplineReport.Text = "Discipline Report";
        DisciplineReport.Click += DisciplineReport_Click;
        // 
        // helpToolStripMenuItem
        // 
        helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contentsToolStripMenuItem, indexToolStripMenuItem, searchToolStripMenuItem, toolStripSeparator5, aboutToolStripMenuItem });
        helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        helpToolStripMenuItem.Size = new Size(44, 20);
        helpToolStripMenuItem.Text = "&Help";
        // 
        // contentsToolStripMenuItem
        // 
        contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
        contentsToolStripMenuItem.Size = new Size(122, 22);
        contentsToolStripMenuItem.Text = "&Contents";
        // 
        // indexToolStripMenuItem
        // 
        indexToolStripMenuItem.Name = "indexToolStripMenuItem";
        indexToolStripMenuItem.Size = new Size(122, 22);
        indexToolStripMenuItem.Text = "&Index";
        // 
        // searchToolStripMenuItem
        // 
        searchToolStripMenuItem.Name = "searchToolStripMenuItem";
        searchToolStripMenuItem.Size = new Size(122, 22);
        searchToolStripMenuItem.Text = "&Search";
        // 
        // toolStripSeparator5
        // 
        toolStripSeparator5.Name = "toolStripSeparator5";
        toolStripSeparator5.Size = new Size(119, 6);
        // 
        // aboutToolStripMenuItem
        // 
        aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        aboutToolStripMenuItem.Size = new Size(122, 22);
        aboutToolStripMenuItem.Text = "&About...";
        // 
        // toolStripMenuItem4
        // 
        toolStripMenuItem4.Name = "toolStripMenuItem4";
        toolStripMenuItem4.Size = new Size(32, 19);
        // 
        // toolStripMenuItem5
        // 
        toolStripMenuItem5.Name = "toolStripMenuItem5";
        toolStripMenuItem5.Size = new Size(32, 19);
        toolStripMenuItem5.Text = "toolStripMenuItem5";
        // 
        // toolStripMenuItem6
        // 
        toolStripMenuItem6.Name = "toolStripMenuItem6";
        toolStripMenuItem6.Size = new Size(32, 19);
        // 
        // toolStripMenuItem7
        // 
        toolStripMenuItem7.Name = "toolStripMenuItem7";
        toolStripMenuItem7.Size = new Size(32, 19);
        toolStripMenuItem7.Text = "toolStripMenuItem7";
        // 
        // toolStripMenuItem8
        // 
        toolStripMenuItem8.Name = "toolStripMenuItem8";
        toolStripMenuItem8.Size = new Size(32, 19);
        // 
        // toolStripMenuItem9
        // 
        toolStripMenuItem9.Name = "toolStripMenuItem9";
        toolStripMenuItem9.Size = new Size(32, 19);
        // 
        // toolStripMenuItem11
        // 
        toolStripMenuItem11.Name = "toolStripMenuItem11";
        toolStripMenuItem11.Size = new Size(32, 19);
        // 
        // pointScoredToolStripMenuItem
        // 
        pointScoredToolStripMenuItem.Name = "pointScoredToolStripMenuItem";
        pointScoredToolStripMenuItem.Size = new Size(32, 19);
        pointScoredToolStripMenuItem.Text = "Point Scored";
        // 
        // HomeTeamName
        // 
        HomeTeamName.AutoSize = true;
        HomeTeamName.Dock = DockStyle.Fill;
        HomeTeamName.Font = new Font("Segoe UI", 25F);
        HomeTeamName.Location = new Point(10, 10);
        HomeTeamName.Margin = new Padding(10);
        HomeTeamName.Name = "HomeTeamName";
        HomeTeamName.Size = new Size(293, 65);
        HomeTeamName.TabIndex = 2;
        HomeTeamName.Text = "Home Team";
        HomeTeamName.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // AwayTeamName
        // 
        AwayTeamName.AutoSize = true;
        AwayTeamName.Dock = DockStyle.Fill;
        AwayTeamName.Font = new Font("Segoe UI", 25F);
        AwayTeamName.Location = new Point(323, 10);
        AwayTeamName.Margin = new Padding(10);
        AwayTeamName.Name = "AwayTeamName";
        AwayTeamName.Size = new Size(294, 65);
        AwayTeamName.TabIndex = 3;
        AwayTeamName.Text = "Away Team";
        AwayTeamName.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // AwayTeamScore
        // 
        AwayTeamScore.AutoSize = true;
        AwayTeamScore.Dock = DockStyle.Fill;
        AwayTeamScore.Font = new Font("Segoe UI", 35F);
        AwayTeamScore.Location = new Point(323, 95);
        AwayTeamScore.Margin = new Padding(10);
        AwayTeamScore.Name = "AwayTeamScore";
        AwayTeamScore.Size = new Size(294, 65);
        AwayTeamScore.TabIndex = 5;
        AwayTeamScore.Text = "0-00";
        AwayTeamScore.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // HomeTeamScore
        // 
        HomeTeamScore.AutoSize = true;
        HomeTeamScore.Dock = DockStyle.Fill;
        HomeTeamScore.Font = new Font("Segoe UI", 35F);
        HomeTeamScore.Location = new Point(10, 95);
        HomeTeamScore.Margin = new Padding(10);
        HomeTeamScore.Name = "HomeTeamScore";
        HomeTeamScore.Size = new Size(293, 65);
        HomeTeamScore.TabIndex = 6;
        HomeTeamScore.Text = "0-00";
        HomeTeamScore.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // HomeTeamSubs
        // 
        HomeTeamSubs.AutoSize = true;
        HomeTeamSubs.Dock = DockStyle.Fill;
        HomeTeamSubs.Font = new Font("Segoe UI", 15F);
        HomeTeamSubs.Location = new Point(0, 0);
        HomeTeamSubs.Name = "HomeTeamSubs";
        HomeTeamSubs.Size = new Size(102, 34);
        HomeTeamSubs.TabIndex = 9;
        HomeTeamSubs.Text = "Subs";
        HomeTeamSubs.UseVisualStyleBackColor = true;
        HomeTeamSubs.MouseClick += SubsMenuButtonClick;
        // 
        // AwayTeamSubs
        // 
        AwayTeamSubs.AutoSize = true;
        AwayTeamSubs.Dock = DockStyle.Fill;
        AwayTeamSubs.Font = new Font("Segoe UI", 15F);
        AwayTeamSubs.Location = new Point(0, 0);
        AwayTeamSubs.Name = "AwayTeamSubs";
        AwayTeamSubs.Size = new Size(102, 34);
        AwayTeamSubs.TabIndex = 10;
        AwayTeamSubs.Text = "Subs";
        AwayTeamSubs.UseVisualStyleBackColor = true;
        AwayTeamSubs.MouseClick += SubsMenuButtonClick;
        // 
        // TurnoverStatBar
        // 
        TurnoverStatBar.BackColor = SystemColors.ActiveCaption;
        TurnoverStatBar.Dock = DockStyle.Fill;
        TurnoverStatBar.Location = new Point(10, 10);
        TurnoverStatBar.Margin = new Padding(10);
        TurnoverStatBar.Name = "TurnoverStatBar";
        TurnoverStatBar.Size = new Size(607, 110);
        TurnoverStatBar.TabIndex = 14;
        // 
        // ShotsStatBar
        // 
        ShotsStatBar.AutoSize = true;
        ShotsStatBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        ShotsStatBar.Dock = DockStyle.Fill;
        ShotsStatBar.Location = new Point(10, 270);
        ShotsStatBar.Margin = new Padding(10);
        ShotsStatBar.Name = "ShotsStatBar";
        ShotsStatBar.Size = new Size(607, 110);
        ShotsStatBar.TabIndex = 15;
        // 
        // KickoutsStatsBar
        // 
        KickoutsStatsBar.AutoSize = true;
        KickoutsStatsBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        KickoutsStatsBar.Dock = DockStyle.Fill;
        KickoutsStatsBar.Location = new Point(10, 140);
        KickoutsStatsBar.Margin = new Padding(10);
        KickoutsStatsBar.Name = "KickoutsStatsBar";
        KickoutsStatsBar.Size = new Size(607, 110);
        KickoutsStatsBar.TabIndex = 16;
        // 
        // GoalShotsStatBar
        // 
        GoalShotsStatBar.AutoSize = true;
        GoalShotsStatBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        GoalShotsStatBar.Dock = DockStyle.Fill;
        GoalShotsStatBar.Location = new Point(10, 400);
        GoalShotsStatBar.Margin = new Padding(10);
        GoalShotsStatBar.Name = "GoalShotsStatBar";
        GoalShotsStatBar.Size = new Size(607, 110);
        GoalShotsStatBar.TabIndex = 17;
        // 
        // WidesStatBar
        // 
        WidesStatBar.AutoSize = true;
        WidesStatBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        WidesStatBar.Dock = DockStyle.Fill;
        WidesStatBar.Location = new Point(10, 530);
        WidesStatBar.Margin = new Padding(10);
        WidesStatBar.Name = "WidesStatBar";
        WidesStatBar.Size = new Size(607, 110);
        WidesStatBar.TabIndex = 18;
        // 
        // FreesStatBar
        // 
        FreesStatBar.AutoSize = true;
        FreesStatBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        FreesStatBar.Dock = DockStyle.Fill;
        FreesStatBar.Location = new Point(10, 660);
        FreesStatBar.Margin = new Padding(10);
        FreesStatBar.Name = "FreesStatBar";
        FreesStatBar.Size = new Size(607, 112);
        FreesStatBar.TabIndex = 20;
        // 
        // HalfLabel
        // 
        HalfLabel.AutoSize = true;
        HalfLabel.Dock = DockStyle.Fill;
        HalfLabel.Font = new Font("Segoe UI", 35F, FontStyle.Bold);
        HalfLabel.Location = new Point(323, 10);
        HalfLabel.Margin = new Padding(10);
        HalfLabel.Name = "HalfLabel";
        HalfLabel.Size = new Size(294, 65);
        HalfLabel.TabIndex = 24;
        HalfLabel.Text = "Second Half";
        HalfLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // StartStopButton
        // 
        StartStopButton.AutoSize = true;
        StartStopButton.Dock = DockStyle.Fill;
        StartStopButton.Font = new Font("Segoe UI", 15F);
        StartStopButton.Location = new Point(3, 173);
        StartStopButton.Name = "StartStopButton";
        StartStopButton.Size = new Size(307, 80);
        StartStopButton.TabIndex = 25;
        StartStopButton.Text = "Start";
        StartStopButton.UseVisualStyleBackColor = true;
        StartStopButton.MouseClick += StartStopButton_MouseClick;
        // 
        // Pause
        // 
        Pause.AutoSize = true;
        Pause.Dock = DockStyle.Fill;
        Pause.Font = new Font("Segoe UI", 15F);
        Pause.Location = new Point(316, 173);
        Pause.Name = "Pause";
        Pause.Size = new Size(308, 80);
        Pause.TabIndex = 26;
        Pause.Text = "Pause";
        Pause.UseVisualStyleBackColor = true;
        Pause.MouseClick += Pause_MouseClick;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Dock = DockStyle.Fill;
        label2.Font = new Font("Segoe UI", 35F);
        label2.Location = new Point(10, 95);
        label2.Margin = new Padding(10);
        label2.Name = "label2";
        label2.Size = new Size(293, 65);
        label2.TabIndex = 27;
        label2.Text = "Time Gone";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.BackColor = Color.FromArgb(255, 128, 0);
        label3.Dock = DockStyle.Fill;
        label3.Font = new Font("Segoe UI", 35F);
        label3.Location = new Point(10, 10);
        label3.Margin = new Padding(10);
        label3.Name = "label3";
        label3.Size = new Size(293, 65);
        label3.TabIndex = 28;
        label3.Text = "Current Half";
        label3.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // TimeLabel
        // 
        TimeLabel.AutoSize = true;
        TimeLabel.BackColor = Color.Transparent;
        TimeLabel.Dock = DockStyle.Fill;
        TimeLabel.Font = new Font("Segoe UI", 38F, FontStyle.Bold);
        TimeLabel.Location = new Point(323, 95);
        TimeLabel.Margin = new Padding(10);
        TimeLabel.Name = "TimeLabel";
        TimeLabel.Size = new Size(294, 65);
        TimeLabel.TabIndex = 30;
        TimeLabel.Text = "00:00";
        TimeLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // toolStripMenuItem10
        // 
        toolStripMenuItem10.Name = "toolStripMenuItem10";
        toolStripMenuItem10.Size = new Size(32, 19);
        // 
        // EventListBox
        // 
        EventListBox.Dock = DockStyle.Fill;
        EventListBox.FormattingEnabled = true;
        EventListBox.Location = new Point(3, 265);
        EventListBox.Name = "EventListBox";
        EventListBox.Size = new Size(627, 782);
        EventListBox.TabIndex = 33;
        EventListBox.KeyDown += EventListBox_KeyDown;
        // 
        // HomePitchLabel
        // 
        HomePitchLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        HomePitchLabel.BackColor = Color.Black;
        HomePitchLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        HomePitchLabel.ForeColor = Color.White;
        HomePitchLabel.Location = new Point(539, 0);
        HomePitchLabel.Name = "HomePitchLabel";
        HomePitchLabel.Size = new Size(93, 52);
        HomePitchLabel.TabIndex = 34;
        HomePitchLabel.Text = "Home";
        HomePitchLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // AwayPitchLabel
        // 
        AwayPitchLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        AwayPitchLabel.BackColor = Color.Black;
        AwayPitchLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        AwayPitchLabel.ForeColor = Color.White;
        AwayPitchLabel.Location = new Point(539, 989);
        AwayPitchLabel.Name = "AwayPitchLabel";
        AwayPitchLabel.Size = new Size(93, 52);
        AwayPitchLabel.TabIndex = 37;
        AwayPitchLabel.Text = "Away";
        AwayPitchLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // HomePitchHighlight
        // 
        HomePitchHighlight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        HomePitchHighlight.BackColor = Color.FromArgb(255, 128, 0);
        HomePitchHighlight.BorderStyle = BorderStyle.FixedSingle;
        HomePitchHighlight.Location = new Point(539, 45);
        HomePitchHighlight.Name = "HomePitchHighlight";
        HomePitchHighlight.Size = new Size(93, 16);
        HomePitchHighlight.TabIndex = 38;
        HomePitchHighlight.TabStop = false;
        // 
        // AwayPitchHighlight
        // 
        AwayPitchHighlight.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        AwayPitchHighlight.BackColor = Color.FromArgb(255, 128, 0);
        AwayPitchHighlight.BorderStyle = BorderStyle.FixedSingle;
        AwayPitchHighlight.Location = new Point(539, 1034);
        AwayPitchHighlight.Name = "AwayPitchHighlight";
        AwayPitchHighlight.Size = new Size(93, 16);
        AwayPitchHighlight.TabIndex = 39;
        AwayPitchHighlight.TabStop = false;
        // 
        // toolStripMenuItem12
        // 
        toolStripMenuItem12.Name = "toolStripMenuItem12";
        toolStripMenuItem12.Size = new Size(32, 19);
        // 
        // toolStripMenuItem13
        // 
        toolStripMenuItem13.Name = "toolStripMenuItem13";
        toolStripMenuItem13.Size = new Size(32, 19);
        toolStripMenuItem13.Text = "toolStripMenuItem13";
        // 
        // toolStripMenuItem14
        // 
        toolStripMenuItem14.Name = "toolStripMenuItem14";
        toolStripMenuItem14.Size = new Size(32, 19);
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(6, 6);
        // 
        // toolStripSeparator2
        // 
        toolStripSeparator2.Name = "toolStripSeparator2";
        toolStripSeparator2.Size = new Size(6, 6);
        // 
        // toolStripMenuItem15
        // 
        toolStripMenuItem15.Name = "toolStripMenuItem15";
        toolStripMenuItem15.Size = new Size(32, 19);
        // 
        // toolStripMenuItem16
        // 
        toolStripMenuItem16.Name = "toolStripMenuItem16";
        toolStripMenuItem16.Size = new Size(32, 19);
        toolStripMenuItem16.Text = "toolStripMenuItem16";
        // 
        // toolStripMenuItem17
        // 
        toolStripMenuItem17.Name = "toolStripMenuItem17";
        toolStripMenuItem17.Size = new Size(32, 19);
        toolStripMenuItem17.Text = "toolStripMenuItem17";
        // 
        // toolStripMenuItem18
        // 
        toolStripMenuItem18.Name = "toolStripMenuItem18";
        toolStripMenuItem18.Size = new Size(32, 19);
        toolStripMenuItem18.Text = "toolStripMenuItem18";
        // 
        // toolStripMenuItem19
        // 
        toolStripMenuItem19.Name = "toolStripMenuItem19";
        toolStripMenuItem19.Size = new Size(32, 19);
        // 
        // HomeCardsButton
        // 
        HomeCardsButton.AutoSize = true;
        HomeCardsButton.Dock = DockStyle.Fill;
        HomeCardsButton.Font = new Font("Segoe UI", 15F);
        HomeCardsButton.Location = new Point(0, 0);
        HomeCardsButton.Name = "HomeCardsButton";
        HomeCardsButton.Size = new Size(102, 42);
        HomeCardsButton.TabIndex = 40;
        HomeCardsButton.Text = "Cards";
        HomeCardsButton.UseVisualStyleBackColor = true;
        // 
        // AwayCardsButton
        // 
        AwayCardsButton.AutoSize = true;
        AwayCardsButton.Dock = DockStyle.Fill;
        AwayCardsButton.Font = new Font("Segoe UI", 15F);
        AwayCardsButton.Location = new Point(0, 0);
        AwayCardsButton.Name = "AwayCardsButton";
        AwayCardsButton.Size = new Size(102, 42);
        AwayCardsButton.TabIndex = 41;
        AwayCardsButton.Text = "Cards";
        AwayCardsButton.UseVisualStyleBackColor = true;
        // 
        // HomeTeamCardedPlayers
        // 
        HomeTeamCardedPlayers.Dock = DockStyle.Fill;
        HomeTeamCardedPlayers.FormattingEnabled = true;
        HomeTeamCardedPlayers.Location = new Point(0, 0);
        HomeTeamCardedPlayers.Name = "HomeTeamCardedPlayers";
        HomeTeamCardedPlayers.Size = new Size(201, 80);
        HomeTeamCardedPlayers.TabIndex = 42;
        // 
        // AwayTeamCardedPlayers
        // 
        AwayTeamCardedPlayers.Dock = DockStyle.Fill;
        AwayTeamCardedPlayers.FormattingEnabled = true;
        AwayTeamCardedPlayers.Location = new Point(0, 0);
        AwayTeamCardedPlayers.Name = "AwayTeamCardedPlayers";
        AwayTeamCardedPlayers.Size = new Size(202, 80);
        AwayTeamCardedPlayers.TabIndex = 43;
        // 
        // EventListContextMenu
        // 
        EventListContextMenu.ImageScalingSize = new Size(20, 20);
        EventListContextMenu.Name = "EventListContextMenu";
        EventListContextMenu.Size = new Size(61, 4);
        // 
        // MainScreenSplitContainer
        // 
        MainScreenSplitContainer.Dock = DockStyle.Fill;
        MainScreenSplitContainer.Location = new Point(0, 24);
        MainScreenSplitContainer.Name = "MainScreenSplitContainer";
        // 
        // MainScreenSplitContainer.Panel1
        // 
        MainScreenSplitContainer.Panel1.Controls.Add(HomePitchLabel);
        MainScreenSplitContainer.Panel1.Controls.Add(AwayPitchLabel);
        MainScreenSplitContainer.Panel1.Controls.Add(HomePitchHighlight);
        MainScreenSplitContainer.Panel1.Controls.Add(AwayPitchHighlight);
        MainScreenSplitContainer.Panel1.Controls.Add(FootballFieldInput);
        // 
        // MainScreenSplitContainer.Panel2
        // 
        MainScreenSplitContainer.Panel2.Controls.Add(StatsViewTable);
        MainScreenSplitContainer.Size = new Size(1902, 1050);
        MainScreenSplitContainer.SplitterDistance = 632;
        MainScreenSplitContainer.TabIndex = 44;
        MainScreenSplitContainer.Text = "splitContainer1";
        // 
        // StatsViewTable
        // 
        StatsViewTable.ColumnCount = 2;
        StatsViewTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        StatsViewTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        StatsViewTable.Controls.Add(TimeControlTable, 0, 0);
        StatsViewTable.Controls.Add(EventListBox, 0, 1);
        StatsViewTable.Controls.Add(ScorecardTable, 1, 0);
        StatsViewTable.Controls.Add(StatsBarContainer, 1, 1);
        StatsViewTable.Dock = DockStyle.Fill;
        StatsViewTable.Location = new Point(0, 0);
        StatsViewTable.Name = "StatsViewTable";
        StatsViewTable.RowCount = 2;
        StatsViewTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        StatsViewTable.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
        StatsViewTable.Size = new Size(1266, 1050);
        StatsViewTable.TabIndex = 44;
        // 
        // TimeControlTable
        // 
        TimeControlTable.BackColor = Color.FromArgb(255, 128, 0);
        TimeControlTable.ColumnCount = 2;
        TimeControlTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        TimeControlTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        TimeControlTable.Controls.Add(TimeLabel, 1, 1);
        TimeControlTable.Controls.Add(Pause, 1, 2);
        TimeControlTable.Controls.Add(label3, 0, 0);
        TimeControlTable.Controls.Add(StartStopButton, 0, 2);
        TimeControlTable.Controls.Add(HalfLabel, 1, 0);
        TimeControlTable.Controls.Add(label2, 0, 1);
        TimeControlTable.Dock = DockStyle.Fill;
        TimeControlTable.Location = new Point(3, 3);
        TimeControlTable.Name = "TimeControlTable";
        TimeControlTable.RowCount = 3;
        TimeControlTable.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        TimeControlTable.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        TimeControlTable.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        TimeControlTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        TimeControlTable.Size = new Size(627, 256);
        TimeControlTable.TabIndex = 33;
        // 
        // ScorecardTable
        // 
        ScorecardTable.BackColor = Color.FromArgb(255, 255, 192);
        ScorecardTable.ColumnCount = 2;
        ScorecardTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        ScorecardTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        ScorecardTable.Controls.Add(splitContainer2, 0, 2);
        ScorecardTable.Controls.Add(AwayTeamScore, 1, 1);
        ScorecardTable.Controls.Add(HomeTeamScore, 0, 1);
        ScorecardTable.Controls.Add(AwayTeamName, 1, 0);
        ScorecardTable.Controls.Add(HomeTeamName, 0, 0);
        ScorecardTable.Controls.Add(splitContainer3, 1, 2);
        ScorecardTable.Dock = DockStyle.Fill;
        ScorecardTable.Location = new Point(636, 3);
        ScorecardTable.Name = "ScorecardTable";
        ScorecardTable.RowCount = 3;
        ScorecardTable.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        ScorecardTable.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        ScorecardTable.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        ScorecardTable.Size = new Size(627, 256);
        ScorecardTable.TabIndex = 34;
        // 
        // splitContainer2
        // 
        splitContainer2.Dock = DockStyle.Fill;
        splitContainer2.Location = new Point(3, 173);
        splitContainer2.Name = "splitContainer2";
        // 
        // splitContainer2.Panel1
        // 
        splitContainer2.Panel1.Controls.Add(splitContainer4);
        // 
        // splitContainer2.Panel2
        // 
        splitContainer2.Panel2.Controls.Add(HomeTeamCardedPlayers);
        splitContainer2.Size = new Size(307, 80);
        splitContainer2.SplitterDistance = 102;
        splitContainer2.TabIndex = 35;
        // 
        // splitContainer4
        // 
        splitContainer4.Dock = DockStyle.Fill;
        splitContainer4.Location = new Point(0, 0);
        splitContainer4.Name = "splitContainer4";
        splitContainer4.Orientation = Orientation.Horizontal;
        // 
        // splitContainer4.Panel1
        // 
        splitContainer4.Panel1.Controls.Add(HomeTeamSubs);
        // 
        // splitContainer4.Panel2
        // 
        splitContainer4.Panel2.Controls.Add(HomeCardsButton);
        splitContainer4.Size = new Size(102, 80);
        splitContainer4.SplitterDistance = 34;
        splitContainer4.TabIndex = 10;
        // 
        // splitContainer3
        // 
        splitContainer3.Dock = DockStyle.Fill;
        splitContainer3.Location = new Point(316, 173);
        splitContainer3.Name = "splitContainer3";
        // 
        // splitContainer3.Panel1
        // 
        splitContainer3.Panel1.Controls.Add(splitContainer5);
        // 
        // splitContainer3.Panel2
        // 
        splitContainer3.Panel2.Controls.Add(AwayTeamCardedPlayers);
        splitContainer3.Size = new Size(308, 80);
        splitContainer3.SplitterDistance = 102;
        splitContainer3.TabIndex = 36;
        // 
        // splitContainer5
        // 
        splitContainer5.Dock = DockStyle.Fill;
        splitContainer5.Location = new Point(0, 0);
        splitContainer5.Name = "splitContainer5";
        splitContainer5.Orientation = Orientation.Horizontal;
        // 
        // splitContainer5.Panel1
        // 
        splitContainer5.Panel1.Controls.Add(AwayTeamSubs);
        // 
        // splitContainer5.Panel2
        // 
        splitContainer5.Panel2.Controls.Add(AwayCardsButton);
        splitContainer5.Size = new Size(102, 80);
        splitContainer5.SplitterDistance = 34;
        splitContainer5.TabIndex = 11;
        // 
        // StatsBarContainer
        // 
        StatsBarContainer.BackColor = SystemColors.ActiveCaption;
        StatsBarContainer.ColumnCount = 1;
        StatsBarContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        StatsBarContainer.Controls.Add(FreesStatBar, 0, 5);
        StatsBarContainer.Controls.Add(WidesStatBar, 0, 4);
        StatsBarContainer.Controls.Add(GoalShotsStatBar, 0, 3);
        StatsBarContainer.Controls.Add(ShotsStatBar, 0, 2);
        StatsBarContainer.Controls.Add(KickoutsStatsBar, 0, 1);
        StatsBarContainer.Controls.Add(TurnoverStatBar, 0, 0);
        StatsBarContainer.Dock = DockStyle.Fill;
        StatsBarContainer.Location = new Point(636, 265);
        StatsBarContainer.Name = "StatsBarContainer";
        StatsBarContainer.RowCount = 6;
        StatsBarContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
        StatsBarContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
        StatsBarContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
        StatsBarContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
        StatsBarContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
        StatsBarContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
        StatsBarContainer.Size = new Size(627, 782);
        StatsBarContainer.TabIndex = 35;
        // 
        // MatchView
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        AutoScroll = true;
        AutoSize = true;
        AutoSizeMode = AutoSizeMode.GrowAndShrink;
        BackColor = SystemColors.ControlDarkDark;
        ClientSize = new Size(1902, 1074);
        Controls.Add(MainScreenSplitContainer);
        Controls.Add(HeaderBar);
        DoubleBuffered = true;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MainMenuStrip = HeaderBar;
        Margin = new Padding(3, 4, 3, 4);
        MinimumSize = new Size(1918, 1113);
        Name = "MatchView";
        Text = "MatchView";
        Load += MatchView_Load;
        ((ISupportInitialize)FootballFieldInput).EndInit();
        HeaderBar.ResumeLayout(false);
        HeaderBar.PerformLayout();
        ((ISupportInitialize)HomePitchHighlight).EndInit();
        ((ISupportInitialize)AwayPitchHighlight).EndInit();
        MainScreenSplitContainer.Panel1.ResumeLayout(false);
        MainScreenSplitContainer.Panel2.ResumeLayout(false);
        ((ISupportInitialize)MainScreenSplitContainer).EndInit();
        MainScreenSplitContainer.ResumeLayout(false);
        StatsViewTable.ResumeLayout(false);
        TimeControlTable.ResumeLayout(false);
        TimeControlTable.PerformLayout();
        ScorecardTable.ResumeLayout(false);
        ScorecardTable.PerformLayout();
        splitContainer2.Panel1.ResumeLayout(false);
        splitContainer2.Panel2.ResumeLayout(false);
        ((ISupportInitialize)splitContainer2).EndInit();
        splitContainer2.ResumeLayout(false);
        splitContainer4.Panel1.ResumeLayout(false);
        splitContainer4.Panel1.PerformLayout();
        splitContainer4.Panel2.ResumeLayout(false);
        splitContainer4.Panel2.PerformLayout();
        ((ISupportInitialize)splitContainer4).EndInit();
        splitContainer4.ResumeLayout(false);
        splitContainer3.Panel1.ResumeLayout(false);
        splitContainer3.Panel2.ResumeLayout(false);
        ((ISupportInitialize)splitContainer3).EndInit();
        splitContainer3.ResumeLayout(false);
        splitContainer5.Panel1.ResumeLayout(false);
        splitContainer5.Panel1.PerformLayout();
        splitContainer5.Panel2.ResumeLayout(false);
        splitContainer5.Panel2.PerformLayout();
        ((ISupportInitialize)splitContainer5).EndInit();
        splitContainer5.ResumeLayout(false);
        StatsBarContainer.ResumeLayout(false);
        StatsBarContainer.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.SplitContainer MainScreenSplitContainer;

    private System.Windows.Forms.TableLayoutPanel StatsViewTable;

    private System.Windows.Forms.ToolStripMenuItem DisciplineReport;

    private System.Windows.Forms.ContextMenuStrip EventListContextMenu;

    private System.Windows.Forms.ListBox HomeTeamCardedPlayers;
    private System.Windows.Forms.ListBox AwayTeamCardedPlayers;

    private System.Windows.Forms.Button HomeCardsButton;
    private System.Windows.Forms.Button AwayCardsButton;

    private System.Windows.Forms.ToolStripMenuItem PlayerPerformance;

    private System.Windows.Forms.ToolStripMenuItem EventTimeLine;

    private System.Windows.Forms.ToolStripMenuItem ScoreTimeLine;

    private System.Windows.Forms.ToolStripMenuItem Scorers;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem19;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
    private System.Windows.Forms.ToolStripMenuItem JournalistData;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;

    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem ExportToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;

    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;

    private System.Windows.Forms.PictureBox AwayPitchHighlight;

    private System.Windows.Forms.Label AwayPitchLabel;
    private System.Windows.Forms.PictureBox HomePitchHighlight;

    private System.Windows.Forms.Label HomePitchLabel;

    private System.Windows.Forms.ListBox EventListBox;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;

    private System.Windows.Forms.OpenFileDialog OpenFileDialog;

    private System.Windows.Forms.SaveFileDialog SaveFileDialog;

    private System.Windows.Forms.Label TimeLabel;
    private System.Windows.Forms.Label HalfLabel;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Button StartStopButton;
    private System.Windows.Forms.Button Pause;

    private System.Windows.Forms.Label label2;

    private StatsTracker.View_Elements.StatisticBar ShotsStatBar;
    private StatsTracker.View_Elements.StatisticBar KickoutsStatsBar;
    private StatsTracker.View_Elements.StatisticBar GoalShotsStatBar;
    private StatsTracker.View_Elements.StatisticBar WidesStatBar;
    private StatsTracker.View_Elements.StatisticBar FreesStatBar;

    private StatsTracker.View_Elements.StatisticBar TurnoverStatBar;

    private System.Windows.Forms.Button HomeTeamSubs;
    private System.Windows.Forms.Button AwayTeamSubs;

    private System.Windows.Forms.Label AwayTeamScore;
    private System.Windows.Forms.Label HomeTeamScore;

    private System.Windows.Forms.Label HomeTeamName;

    private System.Windows.Forms.Label AwayTeamName;

    private System.Windows.Forms.ToolStripMenuItem pointScoredToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;

    private System.Windows.Forms.ContextMenuStrip EventInputMenu;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;

    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem AllStatsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem GraphsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

    private System.Windows.Forms.MenuStrip HeaderBar;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

    private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;

    private System.Windows.Forms.PictureBox FootballFieldInput;

    #endregion

    private TableLayoutPanel TimeControlTable;
    private TableLayoutPanel ScorecardTable;
    private SplitContainer splitContainer2;
    private SplitContainer splitContainer4;
    private SplitContainer splitContainer3;
    private SplitContainer splitContainer5;
    private TableLayoutPanel StatsBarContainer;
}