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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchView));
        FootballFieldInput = new System.Windows.Forms.PictureBox();
        EventInputMenu = new System.Windows.Forms.ContextMenuStrip(components);
        toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
        toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
        HeaderBar = new System.Windows.Forms.MenuStrip();
        fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
        saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
        cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
        selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        ExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        JournalistData = new System.Windows.Forms.ToolStripMenuItem();
        ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        AllStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        GraphsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
        aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
        pointScoredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        HomeTeamName = new System.Windows.Forms.Label();
        AwayTeamName = new System.Windows.Forms.Label();
        AwayTeamScore = new System.Windows.Forms.Label();
        HomeTeamScore = new System.Windows.Forms.Label();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        pictureBox2 = new System.Windows.Forms.PictureBox();
        HomeTeamSubs = new System.Windows.Forms.Button();
        AwayTeamSubs = new System.Windows.Forms.Button();
        pictureBox3 = new System.Windows.Forms.PictureBox();
        TurnoverStatBar = new StatsTracker.View_Elements.StatisticBar();
        ShotsStatBar = new StatsTracker.View_Elements.StatisticBar();
        KickoutsStatsBar = new StatsTracker.View_Elements.StatisticBar();
        GoalShotsStatBar = new StatsTracker.View_Elements.StatisticBar();
        WidesStatBar = new StatsTracker.View_Elements.StatisticBar();
        AttacksStatBar = new StatsTracker.View_Elements.StatisticBar();
        FreesStatBar = new StatsTracker.View_Elements.StatisticBar();
        HalfLabel = new System.Windows.Forms.Label();
        StartStopButton = new System.Windows.Forms.Button();
        Pause = new System.Windows.Forms.Button();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        pictureBox4 = new System.Windows.Forms.PictureBox();
        MinutesLabel = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        SecondsLabel = new System.Windows.Forms.Label();
        SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
        OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
        toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
        EventListBox = new System.Windows.Forms.ListBox();
        HomePitchLabel = new System.Windows.Forms.Label();
        AwayPitchLabel = new System.Windows.Forms.Label();
        HomePitchHighlight = new System.Windows.Forms.PictureBox();
        AwayPitchHighlight = new System.Windows.Forms.PictureBox();
        toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
        toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
        Scorers = new System.Windows.Forms.ToolStripMenuItem();
        ((System.ComponentModel.ISupportInitialize)FootballFieldInput).BeginInit();
        HeaderBar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
        ((System.ComponentModel.ISupportInitialize)HomePitchHighlight).BeginInit();
        ((System.ComponentModel.ISupportInitialize)AwayPitchHighlight).BeginInit();
        SuspendLayout();
        // 
        // FootballFieldInput
        // 
        FootballFieldInput.BackgroundImage = ((System.Drawing.Image)resources.GetObject("FootballFieldInput.BackgroundImage"));
        FootballFieldInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        FootballFieldInput.ContextMenuStrip = EventInputMenu;
        FootballFieldInput.Location = new System.Drawing.Point(5, 28);
        FootballFieldInput.Name = "FootballFieldInput";
        FootballFieldInput.Size = new System.Drawing.Size(700, 964);
        FootballFieldInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        FootballFieldInput.TabIndex = 0;
        FootballFieldInput.TabStop = false;
        FootballFieldInput.Paint += FootballFieldInput_Paint;
        FootballFieldInput.MouseClick += FootballFieldInput_MouseClick;
        FootballFieldInput.MouseUp += FootballFieldInput_MouseUp;
        // 
        // EventInputMenu
        // 
        EventInputMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
        EventInputMenu.Name = "EventInputMenu";
        EventInputMenu.Size = new System.Drawing.Size(61, 4);
        EventInputMenu.Opening += EventInputMenu_Opening;
        // 
        // toolStripComboBox1
        // 
        toolStripComboBox1.Name = "toolStripComboBox1";
        toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
        toolStripMenuItem1.Text = "toolStripMenuItem1";
        // 
        // toolStripMenuItem2
        // 
        toolStripMenuItem2.Name = "toolStripMenuItem2";
        toolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
        // 
        // toolStripMenuItem3
        // 
        toolStripMenuItem3.Name = "toolStripMenuItem3";
        toolStripMenuItem3.Size = new System.Drawing.Size(32, 19);
        // 
        // HeaderBar
        // 
        HeaderBar.ImageScalingSize = new System.Drawing.Size(20, 20);
        HeaderBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, ExportToolStripMenuItem, ViewToolStripMenuItem, helpToolStripMenuItem });
        HeaderBar.Location = new System.Drawing.Point(0, 0);
        HeaderBar.Name = "HeaderBar";
        HeaderBar.Size = new System.Drawing.Size(1902, 28);
        HeaderBar.TabIndex = 1;
        HeaderBar.Text = "menuStrip1";
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, saveAsToolStripMenuItem });
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
        fileToolStripMenuItem.Text = "&File";
        // 
        // newToolStripMenuItem
        // 
        newToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("newToolStripMenuItem.Image"));
        newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        newToolStripMenuItem.Name = "newToolStripMenuItem";
        newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
        newToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
        newToolStripMenuItem.Text = "&New";
        newToolStripMenuItem.Click += newToolStripMenuItem_Click;
        // 
        // openToolStripMenuItem
        // 
        openToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("openToolStripMenuItem.Image"));
        openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        openToolStripMenuItem.Name = "openToolStripMenuItem";
        openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
        openToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
        openToolStripMenuItem.Text = "&Open";
        openToolStripMenuItem.Click += openToolStripMenuItem_Click;
        // 
        // toolStripSeparator
        // 
        toolStripSeparator.Name = "toolStripSeparator";
        toolStripSeparator.Size = new System.Drawing.Size(230, 6);
        // 
        // saveToolStripMenuItem
        // 
        saveToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("saveToolStripMenuItem.Image"));
        saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        saveToolStripMenuItem.Name = "saveToolStripMenuItem";
        saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
        saveToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
        saveToolStripMenuItem.Text = "&Save";
        saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
        // 
        // saveAsToolStripMenuItem
        // 
        saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
        saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) | System.Windows.Forms.Keys.S));
        saveAsToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
        saveAsToolStripMenuItem.Text = "Save &As";
        saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
        // 
        // editToolStripMenuItem
        // 
        editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator3, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator4, selectAllToolStripMenuItem });
        editToolStripMenuItem.Name = "editToolStripMenuItem";
        editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
        editToolStripMenuItem.Text = "&Edit";
        // 
        // undoToolStripMenuItem
        // 
        undoToolStripMenuItem.Name = "undoToolStripMenuItem";
        undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z));
        undoToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
        undoToolStripMenuItem.Text = "&Undo";
        // 
        // redoToolStripMenuItem
        // 
        redoToolStripMenuItem.Name = "redoToolStripMenuItem";
        redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y));
        redoToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
        redoToolStripMenuItem.Text = "&Redo";
        // 
        // toolStripSeparator3
        // 
        toolStripSeparator3.Name = "toolStripSeparator3";
        toolStripSeparator3.Size = new System.Drawing.Size(176, 6);
        // 
        // cutToolStripMenuItem
        // 
        cutToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("cutToolStripMenuItem.Image"));
        cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        cutToolStripMenuItem.Name = "cutToolStripMenuItem";
        cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X));
        cutToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
        cutToolStripMenuItem.Text = "Cu&t";
        // 
        // copyToolStripMenuItem
        // 
        copyToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("copyToolStripMenuItem.Image"));
        copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        copyToolStripMenuItem.Name = "copyToolStripMenuItem";
        copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C));
        copyToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
        copyToolStripMenuItem.Text = "&Copy";
        // 
        // pasteToolStripMenuItem
        // 
        pasteToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("pasteToolStripMenuItem.Image"));
        pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
        pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V));
        pasteToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
        pasteToolStripMenuItem.Text = "&Paste";
        // 
        // toolStripSeparator4
        // 
        toolStripSeparator4.Name = "toolStripSeparator4";
        toolStripSeparator4.Size = new System.Drawing.Size(176, 6);
        // 
        // selectAllToolStripMenuItem
        // 
        selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
        selectAllToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
        selectAllToolStripMenuItem.Text = "Select &All";
        // 
        // ExportToolStripMenuItem
        // 
        ExportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { JournalistData });
        ExportToolStripMenuItem.Name = "ExportToolStripMenuItem";
        ExportToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
        ExportToolStripMenuItem.Text = "Export";
        // 
        // JournalistData
        // 
        JournalistData.Name = "JournalistData";
        JournalistData.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
        JournalistData.Size = new System.Drawing.Size(240, 26);
        JournalistData.Text = "Journalist Data";
        JournalistData.Click += JournalistData_Click;
        // 
        // ViewToolStripMenuItem
        // 
        ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { Scorers, AllStatsToolStripMenuItem, GraphsToolStripMenuItem });
        ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
        ViewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
        ViewToolStripMenuItem.Text = "&View";
        // 
        // AllStatsToolStripMenuItem
        // 
        AllStatsToolStripMenuItem.Name = "AllStatsToolStripMenuItem";
        AllStatsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
        AllStatsToolStripMenuItem.Text = "&All Stats";
        AllStatsToolStripMenuItem.Click += AllStatsToolStripMenuItem_Click;
        // 
        // GraphsToolStripMenuItem
        // 
        GraphsToolStripMenuItem.Name = "GraphsToolStripMenuItem";
        GraphsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
        GraphsToolStripMenuItem.Text = "&Graphs";
        // 
        // helpToolStripMenuItem
        // 
        helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { contentsToolStripMenuItem, indexToolStripMenuItem, searchToolStripMenuItem, toolStripSeparator5, aboutToolStripMenuItem });
        helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
        helpToolStripMenuItem.Text = "&Help";
        // 
        // contentsToolStripMenuItem
        // 
        contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
        contentsToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
        contentsToolStripMenuItem.Text = "&Contents";
        // 
        // indexToolStripMenuItem
        // 
        indexToolStripMenuItem.Name = "indexToolStripMenuItem";
        indexToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
        indexToolStripMenuItem.Text = "&Index";
        // 
        // searchToolStripMenuItem
        // 
        searchToolStripMenuItem.Name = "searchToolStripMenuItem";
        searchToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
        searchToolStripMenuItem.Text = "&Search";
        // 
        // toolStripSeparator5
        // 
        toolStripSeparator5.Name = "toolStripSeparator5";
        toolStripSeparator5.Size = new System.Drawing.Size(147, 6);
        // 
        // aboutToolStripMenuItem
        // 
        aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        aboutToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
        aboutToolStripMenuItem.Text = "&About...";
        // 
        // toolStripMenuItem4
        // 
        toolStripMenuItem4.Name = "toolStripMenuItem4";
        toolStripMenuItem4.Size = new System.Drawing.Size(32, 19);
        // 
        // toolStripMenuItem5
        // 
        toolStripMenuItem5.Name = "toolStripMenuItem5";
        toolStripMenuItem5.Size = new System.Drawing.Size(32, 19);
        toolStripMenuItem5.Text = "toolStripMenuItem5";
        // 
        // toolStripMenuItem6
        // 
        toolStripMenuItem6.Name = "toolStripMenuItem6";
        toolStripMenuItem6.Size = new System.Drawing.Size(32, 19);
        // 
        // toolStripMenuItem7
        // 
        toolStripMenuItem7.Name = "toolStripMenuItem7";
        toolStripMenuItem7.Size = new System.Drawing.Size(32, 19);
        toolStripMenuItem7.Text = "toolStripMenuItem7";
        // 
        // toolStripMenuItem8
        // 
        toolStripMenuItem8.Name = "toolStripMenuItem8";
        toolStripMenuItem8.Size = new System.Drawing.Size(32, 19);
        // 
        // toolStripMenuItem9
        // 
        toolStripMenuItem9.Name = "toolStripMenuItem9";
        toolStripMenuItem9.Size = new System.Drawing.Size(32, 19);
        // 
        // toolStripMenuItem11
        // 
        toolStripMenuItem11.Name = "toolStripMenuItem11";
        toolStripMenuItem11.Size = new System.Drawing.Size(32, 19);
        // 
        // pointScoredToolStripMenuItem
        // 
        pointScoredToolStripMenuItem.Name = "pointScoredToolStripMenuItem";
        pointScoredToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
        pointScoredToolStripMenuItem.Text = "Point Scored";
        // 
        // HomeTeamName
        // 
        HomeTeamName.Font = new System.Drawing.Font("Segoe UI", 24F);
        HomeTeamName.Location = new System.Drawing.Point(1353, 35);
        HomeTeamName.Name = "HomeTeamName";
        HomeTeamName.Size = new System.Drawing.Size(278, 51);
        HomeTeamName.TabIndex = 2;
        HomeTeamName.Text = "Home Team";
        HomeTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // AwayTeamName
        // 
        AwayTeamName.Font = new System.Drawing.Font("Segoe UI", 24F);
        AwayTeamName.Location = new System.Drawing.Point(1648, 35);
        AwayTeamName.Name = "AwayTeamName";
        AwayTeamName.Size = new System.Drawing.Size(244, 51);
        AwayTeamName.TabIndex = 3;
        AwayTeamName.Text = "Away Team";
        AwayTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // AwayTeamScore
        // 
        AwayTeamScore.Font = new System.Drawing.Font("Segoe UI", 24F);
        AwayTeamScore.Location = new System.Drawing.Point(1648, 86);
        AwayTeamScore.Name = "AwayTeamScore";
        AwayTeamScore.Size = new System.Drawing.Size(244, 51);
        AwayTeamScore.TabIndex = 5;
        AwayTeamScore.Text = "3-13";
        AwayTeamScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // HomeTeamScore
        // 
        HomeTeamScore.Font = new System.Drawing.Font("Segoe UI", 24F);
        HomeTeamScore.Location = new System.Drawing.Point(1353, 86);
        HomeTeamScore.Name = "HomeTeamScore";
        HomeTeamScore.Size = new System.Drawing.Size(278, 51);
        HomeTeamScore.TabIndex = 6;
        HomeTeamScore.Text = "4-12";
        HomeTeamScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // pictureBox1
        // 
        pictureBox1.BackColor = System.Drawing.Color.Black;
        pictureBox1.Location = new System.Drawing.Point(709, 25);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(8, 1023);
        pictureBox1.TabIndex = 7;
        pictureBox1.TabStop = false;
        // 
        // pictureBox2
        // 
        pictureBox2.BackColor = System.Drawing.Color.Black;
        pictureBox2.Location = new System.Drawing.Point(1320, 25);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new System.Drawing.Size(8, 1023);
        pictureBox2.TabIndex = 8;
        pictureBox2.TabStop = false;
        // 
        // HomeTeamSubs
        // 
        HomeTeamSubs.Font = new System.Drawing.Font("Segoe UI", 15F);
        HomeTeamSubs.Location = new System.Drawing.Point(1429, 145);
        HomeTeamSubs.Name = "HomeTeamSubs";
        HomeTeamSubs.Size = new System.Drawing.Size(122, 50);
        HomeTeamSubs.TabIndex = 9;
        HomeTeamSubs.Text = "Subs";
        HomeTeamSubs.UseVisualStyleBackColor = true;
        HomeTeamSubs.MouseClick += SubsMenuButtonClick;
        // 
        // AwayTeamSubs
        // 
        AwayTeamSubs.Font = new System.Drawing.Font("Segoe UI", 15F);
        AwayTeamSubs.Location = new System.Drawing.Point(1708, 145);
        AwayTeamSubs.Name = "AwayTeamSubs";
        AwayTeamSubs.Size = new System.Drawing.Size(122, 49);
        AwayTeamSubs.TabIndex = 10;
        AwayTeamSubs.Text = "Subs";
        AwayTeamSubs.UseVisualStyleBackColor = true;
        AwayTeamSubs.MouseClick += SubsMenuButtonClick;
        // 
        // pictureBox3
        // 
        pictureBox3.BackColor = System.Drawing.Color.Black;
        pictureBox3.Location = new System.Drawing.Point(709, 200);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new System.Drawing.Size(1200, 10);
        pictureBox3.TabIndex = 13;
        pictureBox3.TabStop = false;
        // 
        // TurnoverStatBar
        // 
        TurnoverStatBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        TurnoverStatBar.Location = new System.Drawing.Point(1374, 216);
        TurnoverStatBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        TurnoverStatBar.Name = "TurnoverStatBar";
        TurnoverStatBar.Size = new System.Drawing.Size(500, 101);
        TurnoverStatBar.StatName = "Turnovers";
        TurnoverStatBar.TabIndex = 14;
        // 
        // ShotsStatBar
        // 
        ShotsStatBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        ShotsStatBar.Location = new System.Drawing.Point(1374, 410);
        ShotsStatBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        ShotsStatBar.Name = "ShotsStatBar";
        ShotsStatBar.Size = new System.Drawing.Size(500, 101);
        ShotsStatBar.StatName = "Shots";
        ShotsStatBar.TabIndex = 15;
        // 
        // KickoutsStatsBar
        // 
        KickoutsStatsBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        KickoutsStatsBar.Location = new System.Drawing.Point(1374, 313);
        KickoutsStatsBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        KickoutsStatsBar.Name = "KickoutsStatsBar";
        KickoutsStatsBar.Size = new System.Drawing.Size(500, 101);
        KickoutsStatsBar.StatName = "Kickouts";
        KickoutsStatsBar.TabIndex = 16;
        // 
        // GoalShotsStatBar
        // 
        GoalShotsStatBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        GoalShotsStatBar.Location = new System.Drawing.Point(1374, 507);
        GoalShotsStatBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        GoalShotsStatBar.Name = "GoalShotsStatBar";
        GoalShotsStatBar.Size = new System.Drawing.Size(500, 101);
        GoalShotsStatBar.StatName = "Goal Shots";
        GoalShotsStatBar.TabIndex = 17;
        // 
        // WidesStatBar
        // 
        WidesStatBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        WidesStatBar.Location = new System.Drawing.Point(1374, 603);
        WidesStatBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        WidesStatBar.Name = "WidesStatBar";
        WidesStatBar.Size = new System.Drawing.Size(500, 101);
        WidesStatBar.StatName = "Wides";
        WidesStatBar.TabIndex = 18;
        // 
        // AttacksStatBar
        // 
        AttacksStatBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        AttacksStatBar.Location = new System.Drawing.Point(1374, 701);
        AttacksStatBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        AttacksStatBar.Name = "AttacksStatBar";
        AttacksStatBar.Size = new System.Drawing.Size(500, 101);
        AttacksStatBar.StatName = "Attacks";
        AttacksStatBar.TabIndex = 19;
        // 
        // FreesStatBar
        // 
        FreesStatBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        FreesStatBar.Location = new System.Drawing.Point(1374, 799);
        FreesStatBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        FreesStatBar.Name = "FreesStatBar";
        FreesStatBar.Size = new System.Drawing.Size(500, 101);
        FreesStatBar.StatName = "Frees";
        FreesStatBar.TabIndex = 20;
        // 
        // HalfLabel
        // 
        HalfLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        HalfLabel.Location = new System.Drawing.Point(726, 75);
        HalfLabel.Name = "HalfLabel";
        HalfLabel.Size = new System.Drawing.Size(165, 50);
        HalfLabel.TabIndex = 24;
        HalfLabel.Text = "Second Half";
        HalfLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // StartStopButton
        // 
        StartStopButton.Font = new System.Drawing.Font("Segoe UI", 15F);
        StartStopButton.Location = new System.Drawing.Point(730, 146);
        StartStopButton.Name = "StartStopButton";
        StartStopButton.Size = new System.Drawing.Size(157, 38);
        StartStopButton.TabIndex = 25;
        StartStopButton.Text = "Start";
        StartStopButton.UseVisualStyleBackColor = true;
        StartStopButton.MouseClick += StartStopButton_MouseClick;
        // 
        // Pause
        // 
        Pause.Font = new System.Drawing.Font("Segoe UI", 15F);
        Pause.Location = new System.Drawing.Point(907, 146);
        Pause.Name = "Pause";
        Pause.Size = new System.Drawing.Size(157, 38);
        Pause.TabIndex = 26;
        Pause.Text = "Pause";
        Pause.UseVisualStyleBackColor = true;
        Pause.MouseClick += Pause_MouseClick;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 15F);
        label2.Location = new System.Drawing.Point(930, 26);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(151, 39);
        label2.TabIndex = 27;
        label2.Text = "Time Gone";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 15F);
        label3.Location = new System.Drawing.Point(730, 25);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(151, 39);
        label3.TabIndex = 28;
        label3.Text = "Current Half";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // pictureBox4
        // 
        pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        pictureBox4.Location = new System.Drawing.Point(907, 74);
        pictureBox4.Name = "pictureBox4";
        pictureBox4.Size = new System.Drawing.Size(176, 51);
        pictureBox4.TabIndex = 29;
        pictureBox4.TabStop = false;
        // 
        // MinutesLabel
        // 
        MinutesLabel.BackColor = System.Drawing.Color.Transparent;
        MinutesLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        MinutesLabel.Location = new System.Drawing.Point(931, 80);
        MinutesLabel.Name = "MinutesLabel";
        MinutesLabel.Size = new System.Drawing.Size(64, 39);
        MinutesLabel.TabIndex = 30;
        MinutesLabel.Text = "00";
        MinutesLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        label5.Location = new System.Drawing.Point(983, 78);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(29, 39);
        label5.TabIndex = 31;
        label5.Text = ":";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // SecondsLabel
        // 
        SecondsLabel.BackColor = System.Drawing.Color.Transparent;
        SecondsLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        SecondsLabel.Location = new System.Drawing.Point(1001, 80);
        SecondsLabel.Name = "SecondsLabel";
        SecondsLabel.Size = new System.Drawing.Size(63, 39);
        SecondsLabel.TabIndex = 32;
        SecondsLabel.Text = "00";
        SecondsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // toolStripMenuItem10
        // 
        toolStripMenuItem10.Name = "toolStripMenuItem10";
        toolStripMenuItem10.Size = new System.Drawing.Size(32, 19);
        // 
        // EventListBox
        // 
        EventListBox.FormattingEnabled = true;
        EventListBox.Location = new System.Drawing.Point(723, 219);
        EventListBox.Name = "EventListBox";
        EventListBox.Size = new System.Drawing.Size(591, 544);
        EventListBox.TabIndex = 33;
        EventListBox.KeyDown += EventListBox_KeyDown;
        // 
        // HomePitchLabel
        // 
        HomePitchLabel.BackColor = System.Drawing.Color.Black;
        HomePitchLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        HomePitchLabel.ForeColor = System.Drawing.Color.White;
        HomePitchLabel.Location = new System.Drawing.Point(607, 28);
        HomePitchLabel.Name = "HomePitchLabel";
        HomePitchLabel.Size = new System.Drawing.Size(93, 52);
        HomePitchLabel.TabIndex = 34;
        HomePitchLabel.Text = "Home";
        HomePitchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // AwayPitchLabel
        // 
        AwayPitchLabel.BackColor = System.Drawing.Color.Black;
        AwayPitchLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        AwayPitchLabel.ForeColor = System.Drawing.Color.White;
        AwayPitchLabel.Location = new System.Drawing.Point(607, 930);
        AwayPitchLabel.Name = "AwayPitchLabel";
        AwayPitchLabel.Size = new System.Drawing.Size(93, 52);
        AwayPitchLabel.TabIndex = 37;
        AwayPitchLabel.Text = "Away";
        AwayPitchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // HomePitchHighlight
        // 
        HomePitchHighlight.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)128)), ((int)((byte)0)));
        HomePitchHighlight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        HomePitchHighlight.Location = new System.Drawing.Point(607, 70);
        HomePitchHighlight.Name = "HomePitchHighlight";
        HomePitchHighlight.Size = new System.Drawing.Size(93, 16);
        HomePitchHighlight.TabIndex = 38;
        HomePitchHighlight.TabStop = false;
        // 
        // AwayPitchHighlight
        // 
        AwayPitchHighlight.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)128)), ((int)((byte)0)));
        AwayPitchHighlight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        AwayPitchHighlight.Location = new System.Drawing.Point(607, 976);
        AwayPitchHighlight.Name = "AwayPitchHighlight";
        AwayPitchHighlight.Size = new System.Drawing.Size(93, 16);
        AwayPitchHighlight.TabIndex = 39;
        AwayPitchHighlight.TabStop = false;
        // 
        // toolStripMenuItem12
        // 
        toolStripMenuItem12.Name = "toolStripMenuItem12";
        toolStripMenuItem12.Size = new System.Drawing.Size(32, 19);
        // 
        // toolStripMenuItem13
        // 
        toolStripMenuItem13.Name = "toolStripMenuItem13";
        toolStripMenuItem13.Size = new System.Drawing.Size(32, 19);
        toolStripMenuItem13.Text = "toolStripMenuItem13";
        // 
        // toolStripMenuItem14
        // 
        toolStripMenuItem14.Name = "toolStripMenuItem14";
        toolStripMenuItem14.Size = new System.Drawing.Size(32, 19);
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new System.Drawing.Size(6, 6);
        // 
        // toolStripSeparator2
        // 
        toolStripSeparator2.Name = "toolStripSeparator2";
        toolStripSeparator2.Size = new System.Drawing.Size(6, 6);
        // 
        // toolStripMenuItem15
        // 
        toolStripMenuItem15.Name = "toolStripMenuItem15";
        toolStripMenuItem15.Size = new System.Drawing.Size(32, 19);
        // 
        // toolStripMenuItem16
        // 
        toolStripMenuItem16.Name = "toolStripMenuItem16";
        toolStripMenuItem16.Size = new System.Drawing.Size(32, 19);
        toolStripMenuItem16.Text = "toolStripMenuItem16";
        // 
        // toolStripMenuItem17
        // 
        toolStripMenuItem17.Name = "toolStripMenuItem17";
        toolStripMenuItem17.Size = new System.Drawing.Size(32, 19);
        toolStripMenuItem17.Text = "toolStripMenuItem17";
        // 
        // toolStripMenuItem18
        // 
        toolStripMenuItem18.Name = "toolStripMenuItem18";
        toolStripMenuItem18.Size = new System.Drawing.Size(32, 19);
        toolStripMenuItem18.Text = "toolStripMenuItem18";
        // 
        // toolStripMenuItem19
        // 
        toolStripMenuItem19.Name = "toolStripMenuItem19";
        toolStripMenuItem19.Size = new System.Drawing.Size(32, 19);
        // 
        // Scorers
        // 
        Scorers.Name = "Scorers";
        Scorers.Size = new System.Drawing.Size(224, 26);
        Scorers.Text = "Scorers";
        Scorers.Click += Scorers_Click;
        // 
        // MatchView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        ClientSize = new System.Drawing.Size(1902, 996);
        Controls.Add(AwayPitchHighlight);
        Controls.Add(HomePitchHighlight);
        Controls.Add(AwayPitchLabel);
        Controls.Add(HomePitchLabel);
        Controls.Add(EventListBox);
        Controls.Add(SecondsLabel);
        Controls.Add(label5);
        Controls.Add(MinutesLabel);
        Controls.Add(pictureBox4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(Pause);
        Controls.Add(StartStopButton);
        Controls.Add(HalfLabel);
        Controls.Add(FreesStatBar);
        Controls.Add(AttacksStatBar);
        Controls.Add(WidesStatBar);
        Controls.Add(GoalShotsStatBar);
        Controls.Add(KickoutsStatsBar);
        Controls.Add(ShotsStatBar);
        Controls.Add(TurnoverStatBar);
        Controls.Add(pictureBox3);
        Controls.Add(AwayTeamSubs);
        Controls.Add(HomeTeamSubs);
        Controls.Add(pictureBox2);
        Controls.Add(pictureBox1);
        Controls.Add(HomeTeamScore);
        Controls.Add(AwayTeamScore);
        Controls.Add(AwayTeamName);
        Controls.Add(HomeTeamName);
        Controls.Add(FootballFieldInput);
        Controls.Add(HeaderBar);
        DoubleBuffered = true;
        MainMenuStrip = HeaderBar;
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        Text = "MatchView";
        ((System.ComponentModel.ISupportInitialize)FootballFieldInput).EndInit();
        HeaderBar.ResumeLayout(false);
        HeaderBar.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
        ((System.ComponentModel.ISupportInitialize)HomePitchHighlight).EndInit();
        ((System.ComponentModel.ISupportInitialize)AwayPitchHighlight).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

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

    private System.Windows.Forms.Label SecondsLabel;

    private System.Windows.Forms.Label MinutesLabel;
    private System.Windows.Forms.Label HalfLabel;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.PictureBox pictureBox4;

    private System.Windows.Forms.Button StartStopButton;
    private System.Windows.Forms.Button Pause;

    private System.Windows.Forms.Label label2;

    private StatsTracker.View_Elements.StatisticBar ShotsStatBar;
    private StatsTracker.View_Elements.StatisticBar KickoutsStatsBar;
    private StatsTracker.View_Elements.StatisticBar GoalShotsStatBar;
    private StatsTracker.View_Elements.StatisticBar WidesStatBar;
    private StatsTracker.View_Elements.StatisticBar AttacksStatBar;
    private StatsTracker.View_Elements.StatisticBar FreesStatBar;

    private StatsTracker.View_Elements.StatisticBar TurnoverStatBar;

    private System.Windows.Forms.PictureBox pictureBox3;

    private System.Windows.Forms.Button HomeTeamSubs;
    private System.Windows.Forms.Button AwayTeamSubs;

    private System.Windows.Forms.PictureBox pictureBox2;

    private System.Windows.Forms.PictureBox pictureBox1;

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
}