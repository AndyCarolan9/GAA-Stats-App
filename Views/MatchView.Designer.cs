﻿using System.ComponentModel;

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
        toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
        exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
        cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
        selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
        ((System.ComponentModel.ISupportInitialize)FootballFieldInput).BeginInit();
        HeaderBar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
        SuspendLayout();
        // 
        // FootballFieldInput
        // 
        FootballFieldInput.BackgroundImage = ((System.Drawing.Image)resources.GetObject("FootballFieldInput.BackgroundImage"));
        FootballFieldInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        FootballFieldInput.ContextMenuStrip = EventInputMenu;
        FootballFieldInput.Location = new System.Drawing.Point(3, 29);
        FootballFieldInput.Name = "FootballFieldInput";
        FootballFieldInput.Size = new System.Drawing.Size(700, 1000);
        FootballFieldInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        FootballFieldInput.TabIndex = 0;
        FootballFieldInput.TabStop = false;
        FootballFieldInput.MouseClick += FootballFieldInput_MouseClick;
        // 
        // EventInputMenu
        // 
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
        HeaderBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
        HeaderBar.Location = new System.Drawing.Point(0, 0);
        HeaderBar.Name = "HeaderBar";
        HeaderBar.Size = new System.Drawing.Size(1904, 24);
        HeaderBar.TabIndex = 1;
        HeaderBar.Text = "menuStrip1";
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, printToolStripMenuItem, printPreviewToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
        fileToolStripMenuItem.Text = "&File";
        // 
        // newToolStripMenuItem
        // 
        newToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("newToolStripMenuItem.Image"));
        newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        newToolStripMenuItem.Name = "newToolStripMenuItem";
        newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
        newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
        newToolStripMenuItem.Text = "&New";
        // 
        // openToolStripMenuItem
        // 
        openToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("openToolStripMenuItem.Image"));
        openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        openToolStripMenuItem.Name = "openToolStripMenuItem";
        openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
        openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
        openToolStripMenuItem.Text = "&Open";
        // 
        // toolStripSeparator
        // 
        toolStripSeparator.Name = "toolStripSeparator";
        toolStripSeparator.Size = new System.Drawing.Size(143, 6);
        // 
        // saveToolStripMenuItem
        // 
        saveToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("saveToolStripMenuItem.Image"));
        saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        saveToolStripMenuItem.Name = "saveToolStripMenuItem";
        saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
        saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
        saveToolStripMenuItem.Text = "&Save";
        // 
        // saveAsToolStripMenuItem
        // 
        saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
        saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
        saveAsToolStripMenuItem.Text = "Save &As";
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
        // 
        // printToolStripMenuItem
        // 
        printToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("printToolStripMenuItem.Image"));
        printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        printToolStripMenuItem.Name = "printToolStripMenuItem";
        printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
        printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
        printToolStripMenuItem.Text = "&Print";
        // 
        // printPreviewToolStripMenuItem
        // 
        printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("printPreviewToolStripMenuItem.Image"));
        printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
        printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
        printPreviewToolStripMenuItem.Text = "Print Pre&view";
        // 
        // toolStripSeparator2
        // 
        toolStripSeparator2.Name = "toolStripSeparator2";
        toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
        // 
        // exitToolStripMenuItem
        // 
        exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
        exitToolStripMenuItem.Text = "E&xit";
        // 
        // editToolStripMenuItem
        // 
        editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator3, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator4, selectAllToolStripMenuItem });
        editToolStripMenuItem.Name = "editToolStripMenuItem";
        editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
        editToolStripMenuItem.Text = "&Edit";
        // 
        // undoToolStripMenuItem
        // 
        undoToolStripMenuItem.Name = "undoToolStripMenuItem";
        undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z));
        undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
        undoToolStripMenuItem.Text = "&Undo";
        // 
        // redoToolStripMenuItem
        // 
        redoToolStripMenuItem.Name = "redoToolStripMenuItem";
        redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y));
        redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
        redoToolStripMenuItem.Text = "&Redo";
        // 
        // toolStripSeparator3
        // 
        toolStripSeparator3.Name = "toolStripSeparator3";
        toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
        // 
        // cutToolStripMenuItem
        // 
        cutToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("cutToolStripMenuItem.Image"));
        cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        cutToolStripMenuItem.Name = "cutToolStripMenuItem";
        cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X));
        cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
        cutToolStripMenuItem.Text = "Cu&t";
        // 
        // copyToolStripMenuItem
        // 
        copyToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("copyToolStripMenuItem.Image"));
        copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        copyToolStripMenuItem.Name = "copyToolStripMenuItem";
        copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C));
        copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
        copyToolStripMenuItem.Text = "&Copy";
        // 
        // pasteToolStripMenuItem
        // 
        pasteToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("pasteToolStripMenuItem.Image"));
        pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
        pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V));
        pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
        pasteToolStripMenuItem.Text = "&Paste";
        // 
        // toolStripSeparator4
        // 
        toolStripSeparator4.Name = "toolStripSeparator4";
        toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
        // 
        // selectAllToolStripMenuItem
        // 
        selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
        selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
        selectAllToolStripMenuItem.Text = "Select &All";
        // 
        // toolsToolStripMenuItem
        // 
        toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { customizeToolStripMenuItem, optionsToolStripMenuItem });
        toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
        toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
        toolsToolStripMenuItem.Text = "&Tools";
        // 
        // customizeToolStripMenuItem
        // 
        customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
        customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
        customizeToolStripMenuItem.Text = "&Customize";
        // 
        // optionsToolStripMenuItem
        // 
        optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
        optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
        optionsToolStripMenuItem.Text = "&Options";
        // 
        // helpToolStripMenuItem
        // 
        helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { contentsToolStripMenuItem, indexToolStripMenuItem, searchToolStripMenuItem, toolStripSeparator5, aboutToolStripMenuItem });
        helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
        helpToolStripMenuItem.Text = "&Help";
        // 
        // contentsToolStripMenuItem
        // 
        contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
        contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
        contentsToolStripMenuItem.Text = "&Contents";
        // 
        // indexToolStripMenuItem
        // 
        indexToolStripMenuItem.Name = "indexToolStripMenuItem";
        indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
        indexToolStripMenuItem.Text = "&Index";
        // 
        // searchToolStripMenuItem
        // 
        searchToolStripMenuItem.Name = "searchToolStripMenuItem";
        searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
        searchToolStripMenuItem.Text = "&Search";
        // 
        // toolStripSeparator5
        // 
        toolStripSeparator5.Name = "toolStripSeparator5";
        toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
        // 
        // aboutToolStripMenuItem
        // 
        aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
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
        HomeTeamSubs.Location = new System.Drawing.Point(1429, 160);
        HomeTeamSubs.Name = "HomeTeamSubs";
        HomeTeamSubs.Size = new System.Drawing.Size(122, 34);
        HomeTeamSubs.TabIndex = 9;
        HomeTeamSubs.Text = "Subs";
        HomeTeamSubs.UseVisualStyleBackColor = true;
        // 
        // AwayTeamSubs
        // 
        AwayTeamSubs.Font = new System.Drawing.Font("Segoe UI", 15F);
        AwayTeamSubs.Location = new System.Drawing.Point(1708, 160);
        AwayTeamSubs.Name = "AwayTeamSubs";
        AwayTeamSubs.Size = new System.Drawing.Size(122, 34);
        AwayTeamSubs.TabIndex = 10;
        AwayTeamSubs.Text = "Subs";
        AwayTeamSubs.UseVisualStyleBackColor = true;
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
        TurnoverStatBar.Location = new System.Drawing.Point(1374, 216);
        TurnoverStatBar.Name = "TurnoverStatBar";
        TurnoverStatBar.Size = new System.Drawing.Size(500, 101);
        TurnoverStatBar.StatName = "Turnovers";
        TurnoverStatBar.TabIndex = 14;
        // 
        // ShotsStatBar
        // 
        ShotsStatBar.Location = new System.Drawing.Point(1374, 410);
        ShotsStatBar.Name = "ShotsStatBar";
        ShotsStatBar.Size = new System.Drawing.Size(500, 101);
        ShotsStatBar.StatName = "Shots";
        ShotsStatBar.TabIndex = 15;
        // 
        // KickoutsStatsBar
        // 
        KickoutsStatsBar.Location = new System.Drawing.Point(1374, 313);
        KickoutsStatsBar.Name = "KickoutsStatsBar";
        KickoutsStatsBar.Size = new System.Drawing.Size(500, 101);
        KickoutsStatsBar.StatName = "Kickouts";
        KickoutsStatsBar.TabIndex = 16;
        // 
        // GoalShotsStatBar
        // 
        GoalShotsStatBar.Location = new System.Drawing.Point(1374, 507);
        GoalShotsStatBar.Name = "GoalShotsStatBar";
        GoalShotsStatBar.Size = new System.Drawing.Size(500, 101);
        GoalShotsStatBar.StatName = "Goal Shots";
        GoalShotsStatBar.TabIndex = 17;
        // 
        // WidesStatBar
        // 
        WidesStatBar.Location = new System.Drawing.Point(1374, 603);
        WidesStatBar.Name = "WidesStatBar";
        WidesStatBar.Size = new System.Drawing.Size(500, 101);
        WidesStatBar.StatName = "Wides";
        WidesStatBar.TabIndex = 18;
        // 
        // AttacksStatBar
        // 
        AttacksStatBar.Location = new System.Drawing.Point(1374, 701);
        AttacksStatBar.Name = "AttacksStatBar";
        AttacksStatBar.Size = new System.Drawing.Size(500, 101);
        AttacksStatBar.StatName = "Attacks";
        AttacksStatBar.TabIndex = 19;
        // 
        // FreesStatBar
        // 
        FreesStatBar.Location = new System.Drawing.Point(1374, 799);
        FreesStatBar.Name = "FreesStatBar";
        FreesStatBar.Size = new System.Drawing.Size(500, 101);
        FreesStatBar.StatName = "Frees";
        FreesStatBar.TabIndex = 20;
        // 
        // MatchView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1904, 1041);
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
        Text = "MatchView";
        ((System.ComponentModel.ISupportInitialize)FootballFieldInput).EndInit();
        HeaderBar.ResumeLayout(false);
        HeaderBar.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

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
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
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