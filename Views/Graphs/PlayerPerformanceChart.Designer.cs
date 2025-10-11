using System.ComponentModel;

namespace StatsTracker.Views.Graphs;

partial class PlayerPerformanceChart
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(PlayerPerformanceChart));
        TeamComboBox = new ComboBox();
        PlayerComboBox = new ComboBox();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        label7 = new Label();
        label8 = new Label();
        label9 = new Label();
        label10 = new Label();
        label11 = new Label();
        label12 = new Label();
        FHTOWon = new Label();
        FHTOLost = new Label();
        FHKOWon = new Label();
        FHPointScored = new Label();
        FH2PointScored = new Label();
        FHGoalScored = new Label();
        FHMisses = new Label();
        FHFrees = new Label();
        FHScoreableFrees = new Label();
        SHMisses = new Label();
        SHGoalScored = new Label();
        SH2PointScored = new Label();
        SHPointScored = new Label();
        SHKOWon = new Label();
        SHTOLost = new Label();
        SHTOWon = new Label();
        SHScoreableFrees = new Label();
        SHFrees = new Label();
        TOTFrees = new Label();
        TOTMisses = new Label();
        TOTGoalScored = new Label();
        TOT2PointScored = new Label();
        TOTPointScored = new Label();
        TOTKOWon = new Label();
        TOTTOLost = new Label();
        TOTTOWon = new Label();
        TOTScoreableFrees = new Label();
        MainSplitController = new SplitContainer();
        splitContainer2 = new SplitContainer();
        StatTable = new TableLayoutPanel();
        ((ISupportInitialize)MainSplitController).BeginInit();
        MainSplitController.Panel2.SuspendLayout();
        MainSplitController.SuspendLayout();
        ((ISupportInitialize)splitContainer2).BeginInit();
        splitContainer2.Panel1.SuspendLayout();
        splitContainer2.Panel2.SuspendLayout();
        splitContainer2.SuspendLayout();
        StatTable.SuspendLayout();
        SuspendLayout();
        // 
        // TeamComboBox
        // 
        TeamComboBox.FormattingEnabled = true;
        TeamComboBox.Location = new Point(3, 8);
        TeamComboBox.Margin = new Padding(5);
        TeamComboBox.Name = "TeamComboBox";
        TeamComboBox.Size = new Size(176, 23);
        TeamComboBox.TabIndex = 1;
        // 
        // PlayerComboBox
        // 
        PlayerComboBox.FormattingEnabled = true;
        PlayerComboBox.Location = new Point(185, 8);
        PlayerComboBox.Margin = new Padding(5);
        PlayerComboBox.Name = "PlayerComboBox";
        PlayerComboBox.Size = new Size(176, 23);
        PlayerComboBox.TabIndex = 2;
        // 
        // label1
        // 
        label1.Dock = DockStyle.Fill;
        label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        label1.Location = new Point(8, 45);
        label1.Margin = new Padding(5);
        label1.Name = "label1";
        label1.Size = new Size(232, 24);
        label1.TabIndex = 3;
        label1.Text = "Turnovers Won";
        label1.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label2
        // 
        label2.Dock = DockStyle.Fill;
        label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        label2.Location = new Point(8, 82);
        label2.Margin = new Padding(5);
        label2.Name = "label2";
        label2.Size = new Size(232, 24);
        label2.TabIndex = 4;
        label2.Text = "Turnovers Lost";
        label2.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label3
        // 
        label3.Dock = DockStyle.Fill;
        label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        label3.Location = new Point(8, 119);
        label3.Margin = new Padding(5);
        label3.Name = "label3";
        label3.Size = new Size(232, 24);
        label3.TabIndex = 5;
        label3.Text = "Kickouts Won";
        label3.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label4
        // 
        label4.Dock = DockStyle.Fill;
        label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        label4.Location = new Point(8, 156);
        label4.Margin = new Padding(5);
        label4.Name = "label4";
        label4.Size = new Size(232, 24);
        label4.TabIndex = 6;
        label4.Text = "Points Scored";
        label4.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label5
        // 
        label5.Dock = DockStyle.Fill;
        label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        label5.Location = new Point(8, 193);
        label5.Margin = new Padding(5);
        label5.Name = "label5";
        label5.Size = new Size(232, 24);
        label5.TabIndex = 7;
        label5.Text = "2-Points Scored";
        label5.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label6
        // 
        label6.Dock = DockStyle.Fill;
        label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        label6.Location = new Point(8, 230);
        label6.Margin = new Padding(5);
        label6.Name = "label6";
        label6.Size = new Size(232, 24);
        label6.TabIndex = 8;
        label6.Text = "Goals Scored";
        label6.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label7
        // 
        label7.Dock = DockStyle.Fill;
        label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        label7.Location = new Point(8, 267);
        label7.Margin = new Padding(5);
        label7.Name = "label7";
        label7.Size = new Size(232, 24);
        label7.TabIndex = 9;
        label7.Text = "Misses";
        label7.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label8
        // 
        label8.Dock = DockStyle.Fill;
        label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        label8.Location = new Point(8, 304);
        label8.Margin = new Padding(5);
        label8.Name = "label8";
        label8.Size = new Size(232, 24);
        label8.TabIndex = 10;
        label8.Text = "Scoreable Frees";
        label8.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label9
        // 
        label9.Dock = DockStyle.Fill;
        label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        label9.Location = new Point(8, 341);
        label9.Margin = new Padding(5);
        label9.Name = "label9";
        label9.Size = new Size(232, 33);
        label9.TabIndex = 11;
        label9.Text = "Frees Conceded";
        label9.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label10
        // 
        label10.Dock = DockStyle.Fill;
        label10.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        label10.Location = new Point(253, 8);
        label10.Margin = new Padding(5);
        label10.Name = "label10";
        label10.Size = new Size(108, 24);
        label10.TabIndex = 25;
        label10.Text = "1st";
        label10.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label11
        // 
        label11.Dock = DockStyle.Fill;
        label11.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        label11.Location = new Point(374, 8);
        label11.Margin = new Padding(5);
        label11.Name = "label11";
        label11.Size = new Size(108, 24);
        label11.TabIndex = 26;
        label11.Text = "2nd";
        label11.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label12
        // 
        label12.Dock = DockStyle.Fill;
        label12.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        label12.Location = new Point(495, 8);
        label12.Margin = new Padding(5);
        label12.Name = "label12";
        label12.Size = new Size(147, 24);
        label12.TabIndex = 27;
        label12.Text = "Total";
        label12.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // FHTOWon
        // 
        FHTOWon.Dock = DockStyle.Fill;
        FHTOWon.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        FHTOWon.Location = new Point(253, 45);
        FHTOWon.Margin = new Padding(5);
        FHTOWon.Name = "FHTOWon";
        FHTOWon.Size = new Size(108, 24);
        FHTOWon.TabIndex = 28;
        FHTOWon.Text = "00";
        FHTOWon.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // FHTOLost
        // 
        FHTOLost.Dock = DockStyle.Fill;
        FHTOLost.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        FHTOLost.Location = new Point(253, 82);
        FHTOLost.Margin = new Padding(5);
        FHTOLost.Name = "FHTOLost";
        FHTOLost.Size = new Size(108, 24);
        FHTOLost.TabIndex = 29;
        FHTOLost.Text = "00";
        FHTOLost.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // FHKOWon
        // 
        FHKOWon.Dock = DockStyle.Fill;
        FHKOWon.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        FHKOWon.Location = new Point(253, 119);
        FHKOWon.Margin = new Padding(5);
        FHKOWon.Name = "FHKOWon";
        FHKOWon.Size = new Size(108, 24);
        FHKOWon.TabIndex = 30;
        FHKOWon.Text = "00";
        FHKOWon.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // FHPointScored
        // 
        FHPointScored.Dock = DockStyle.Fill;
        FHPointScored.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        FHPointScored.Location = new Point(253, 156);
        FHPointScored.Margin = new Padding(5);
        FHPointScored.Name = "FHPointScored";
        FHPointScored.Size = new Size(108, 24);
        FHPointScored.TabIndex = 31;
        FHPointScored.Text = "00";
        FHPointScored.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // FH2PointScored
        // 
        FH2PointScored.Dock = DockStyle.Fill;
        FH2PointScored.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        FH2PointScored.Location = new Point(253, 193);
        FH2PointScored.Margin = new Padding(5);
        FH2PointScored.Name = "FH2PointScored";
        FH2PointScored.Size = new Size(108, 24);
        FH2PointScored.TabIndex = 32;
        FH2PointScored.Text = "00";
        FH2PointScored.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // FHGoalScored
        // 
        FHGoalScored.Dock = DockStyle.Fill;
        FHGoalScored.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        FHGoalScored.Location = new Point(253, 230);
        FHGoalScored.Margin = new Padding(5);
        FHGoalScored.Name = "FHGoalScored";
        FHGoalScored.Size = new Size(108, 24);
        FHGoalScored.TabIndex = 33;
        FHGoalScored.Text = "00";
        FHGoalScored.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // FHMisses
        // 
        FHMisses.Dock = DockStyle.Fill;
        FHMisses.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        FHMisses.Location = new Point(253, 267);
        FHMisses.Margin = new Padding(5);
        FHMisses.Name = "FHMisses";
        FHMisses.Size = new Size(108, 24);
        FHMisses.TabIndex = 34;
        FHMisses.Text = "00";
        FHMisses.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // FHFrees
        // 
        FHFrees.Dock = DockStyle.Fill;
        FHFrees.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        FHFrees.Location = new Point(253, 341);
        FHFrees.Margin = new Padding(5);
        FHFrees.Name = "FHFrees";
        FHFrees.Size = new Size(108, 33);
        FHFrees.TabIndex = 35;
        FHFrees.Text = "00";
        FHFrees.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // FHScoreableFrees
        // 
        FHScoreableFrees.Dock = DockStyle.Fill;
        FHScoreableFrees.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        FHScoreableFrees.Location = new Point(253, 304);
        FHScoreableFrees.Margin = new Padding(5);
        FHScoreableFrees.Name = "FHScoreableFrees";
        FHScoreableFrees.Size = new Size(108, 24);
        FHScoreableFrees.TabIndex = 36;
        FHScoreableFrees.Text = "00";
        FHScoreableFrees.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // SHMisses
        // 
        SHMisses.Dock = DockStyle.Fill;
        SHMisses.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        SHMisses.Location = new Point(374, 267);
        SHMisses.Margin = new Padding(5);
        SHMisses.Name = "SHMisses";
        SHMisses.Size = new Size(108, 24);
        SHMisses.TabIndex = 37;
        SHMisses.Text = "00";
        SHMisses.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // SHGoalScored
        // 
        SHGoalScored.Dock = DockStyle.Fill;
        SHGoalScored.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        SHGoalScored.Location = new Point(374, 230);
        SHGoalScored.Margin = new Padding(5);
        SHGoalScored.Name = "SHGoalScored";
        SHGoalScored.Size = new Size(108, 24);
        SHGoalScored.TabIndex = 38;
        SHGoalScored.Text = "00";
        SHGoalScored.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // SH2PointScored
        // 
        SH2PointScored.Dock = DockStyle.Fill;
        SH2PointScored.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        SH2PointScored.Location = new Point(374, 193);
        SH2PointScored.Margin = new Padding(5);
        SH2PointScored.Name = "SH2PointScored";
        SH2PointScored.Size = new Size(108, 24);
        SH2PointScored.TabIndex = 39;
        SH2PointScored.Text = "00";
        SH2PointScored.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // SHPointScored
        // 
        SHPointScored.Dock = DockStyle.Fill;
        SHPointScored.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        SHPointScored.Location = new Point(374, 156);
        SHPointScored.Margin = new Padding(5);
        SHPointScored.Name = "SHPointScored";
        SHPointScored.Size = new Size(108, 24);
        SHPointScored.TabIndex = 40;
        SHPointScored.Text = "00";
        SHPointScored.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // SHKOWon
        // 
        SHKOWon.Dock = DockStyle.Fill;
        SHKOWon.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        SHKOWon.Location = new Point(374, 119);
        SHKOWon.Margin = new Padding(5);
        SHKOWon.Name = "SHKOWon";
        SHKOWon.Size = new Size(108, 24);
        SHKOWon.TabIndex = 41;
        SHKOWon.Text = "00";
        SHKOWon.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // SHTOLost
        // 
        SHTOLost.Dock = DockStyle.Fill;
        SHTOLost.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        SHTOLost.Location = new Point(374, 82);
        SHTOLost.Margin = new Padding(5);
        SHTOLost.Name = "SHTOLost";
        SHTOLost.Size = new Size(108, 24);
        SHTOLost.TabIndex = 42;
        SHTOLost.Text = "00";
        SHTOLost.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // SHTOWon
        // 
        SHTOWon.Dock = DockStyle.Fill;
        SHTOWon.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        SHTOWon.Location = new Point(374, 45);
        SHTOWon.Margin = new Padding(5);
        SHTOWon.Name = "SHTOWon";
        SHTOWon.Size = new Size(108, 24);
        SHTOWon.TabIndex = 43;
        SHTOWon.Text = "00";
        SHTOWon.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // SHScoreableFrees
        // 
        SHScoreableFrees.Dock = DockStyle.Fill;
        SHScoreableFrees.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        SHScoreableFrees.Location = new Point(374, 304);
        SHScoreableFrees.Margin = new Padding(5);
        SHScoreableFrees.Name = "SHScoreableFrees";
        SHScoreableFrees.Size = new Size(108, 24);
        SHScoreableFrees.TabIndex = 44;
        SHScoreableFrees.Text = "00";
        SHScoreableFrees.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // SHFrees
        // 
        SHFrees.Dock = DockStyle.Fill;
        SHFrees.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        SHFrees.Location = new Point(374, 341);
        SHFrees.Margin = new Padding(5);
        SHFrees.Name = "SHFrees";
        SHFrees.Size = new Size(108, 33);
        SHFrees.TabIndex = 45;
        SHFrees.Text = "00";
        SHFrees.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // TOTFrees
        // 
        TOTFrees.Dock = DockStyle.Fill;
        TOTFrees.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        TOTFrees.Location = new Point(495, 341);
        TOTFrees.Margin = new Padding(5);
        TOTFrees.Name = "TOTFrees";
        TOTFrees.Size = new Size(147, 33);
        TOTFrees.TabIndex = 46;
        TOTFrees.Text = "00";
        TOTFrees.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // TOTMisses
        // 
        TOTMisses.Dock = DockStyle.Fill;
        TOTMisses.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        TOTMisses.Location = new Point(495, 267);
        TOTMisses.Margin = new Padding(5);
        TOTMisses.Name = "TOTMisses";
        TOTMisses.Size = new Size(147, 24);
        TOTMisses.TabIndex = 47;
        TOTMisses.Text = "00";
        TOTMisses.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // TOTGoalScored
        // 
        TOTGoalScored.Dock = DockStyle.Fill;
        TOTGoalScored.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        TOTGoalScored.Location = new Point(495, 230);
        TOTGoalScored.Margin = new Padding(5);
        TOTGoalScored.Name = "TOTGoalScored";
        TOTGoalScored.Size = new Size(147, 24);
        TOTGoalScored.TabIndex = 48;
        TOTGoalScored.Text = "00";
        TOTGoalScored.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // TOT2PointScored
        // 
        TOT2PointScored.Dock = DockStyle.Fill;
        TOT2PointScored.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        TOT2PointScored.Location = new Point(495, 193);
        TOT2PointScored.Margin = new Padding(5);
        TOT2PointScored.Name = "TOT2PointScored";
        TOT2PointScored.Size = new Size(147, 24);
        TOT2PointScored.TabIndex = 49;
        TOT2PointScored.Text = "00";
        TOT2PointScored.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // TOTPointScored
        // 
        TOTPointScored.Dock = DockStyle.Fill;
        TOTPointScored.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        TOTPointScored.Location = new Point(495, 156);
        TOTPointScored.Margin = new Padding(5);
        TOTPointScored.Name = "TOTPointScored";
        TOTPointScored.Size = new Size(147, 24);
        TOTPointScored.TabIndex = 50;
        TOTPointScored.Text = "00";
        TOTPointScored.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // TOTKOWon
        // 
        TOTKOWon.Dock = DockStyle.Fill;
        TOTKOWon.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        TOTKOWon.Location = new Point(495, 119);
        TOTKOWon.Margin = new Padding(5);
        TOTKOWon.Name = "TOTKOWon";
        TOTKOWon.Size = new Size(147, 24);
        TOTKOWon.TabIndex = 51;
        TOTKOWon.Text = "00";
        TOTKOWon.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // TOTTOLost
        // 
        TOTTOLost.Dock = DockStyle.Fill;
        TOTTOLost.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        TOTTOLost.Location = new Point(495, 82);
        TOTTOLost.Margin = new Padding(5);
        TOTTOLost.Name = "TOTTOLost";
        TOTTOLost.Size = new Size(147, 24);
        TOTTOLost.TabIndex = 52;
        TOTTOLost.Text = "00";
        TOTTOLost.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // TOTTOWon
        // 
        TOTTOWon.Dock = DockStyle.Fill;
        TOTTOWon.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        TOTTOWon.Location = new Point(495, 45);
        TOTTOWon.Margin = new Padding(5);
        TOTTOWon.Name = "TOTTOWon";
        TOTTOWon.Size = new Size(147, 24);
        TOTTOWon.TabIndex = 53;
        TOTTOWon.Text = "00";
        TOTTOWon.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // TOTScoreableFrees
        // 
        TOTScoreableFrees.Dock = DockStyle.Fill;
        TOTScoreableFrees.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        TOTScoreableFrees.Location = new Point(495, 304);
        TOTScoreableFrees.Margin = new Padding(5);
        TOTScoreableFrees.Name = "TOTScoreableFrees";
        TOTScoreableFrees.Size = new Size(147, 24);
        TOTScoreableFrees.TabIndex = 54;
        TOTScoreableFrees.Text = "00";
        TOTScoreableFrees.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // MainSplitController
        // 
        MainSplitController.Dock = DockStyle.Fill;
        MainSplitController.Location = new Point(0, 0);
        MainSplitController.Name = "MainSplitController";
        // 
        // MainSplitController.Panel2
        // 
        MainSplitController.Panel2.Controls.Add(splitContainer2);
        MainSplitController.Size = new Size(980, 426);
        MainSplitController.SplitterDistance = 326;
        MainSplitController.TabIndex = 55;
        // 
        // splitContainer2
        // 
        splitContainer2.Dock = DockStyle.Fill;
        splitContainer2.Location = new Point(0, 0);
        splitContainer2.Name = "splitContainer2";
        splitContainer2.Orientation = Orientation.Horizontal;
        // 
        // splitContainer2.Panel1
        // 
        splitContainer2.Panel1.Controls.Add(TeamComboBox);
        splitContainer2.Panel1.Controls.Add(PlayerComboBox);
        // 
        // splitContainer2.Panel2
        // 
        splitContainer2.Panel2.Controls.Add(StatTable);
        splitContainer2.Size = new Size(650, 426);
        splitContainer2.SplitterDistance = 40;
        splitContainer2.TabIndex = 0;
        // 
        // StatTable
        // 
        StatTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetPartial;
        StatTable.ColumnCount = 4;
        StatTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.2022476F));
        StatTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.7265911F));
        StatTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.7265911F));
        StatTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.3445663F));
        StatTable.Controls.Add(TOTFrees, 3, 9);
        StatTable.Controls.Add(SHFrees, 2, 9);
        StatTable.Controls.Add(FHFrees, 1, 9);
        StatTable.Controls.Add(label9, 0, 9);
        StatTable.Controls.Add(TOTScoreableFrees, 3, 8);
        StatTable.Controls.Add(SHScoreableFrees, 2, 8);
        StatTable.Controls.Add(FHScoreableFrees, 1, 8);
        StatTable.Controls.Add(label8, 0, 8);
        StatTable.Controls.Add(TOTMisses, 3, 7);
        StatTable.Controls.Add(SHMisses, 2, 7);
        StatTable.Controls.Add(FHMisses, 1, 7);
        StatTable.Controls.Add(label7, 0, 7);
        StatTable.Controls.Add(TOTGoalScored, 3, 6);
        StatTable.Controls.Add(SHGoalScored, 2, 6);
        StatTable.Controls.Add(FHGoalScored, 1, 6);
        StatTable.Controls.Add(label6, 0, 6);
        StatTable.Controls.Add(TOT2PointScored, 3, 5);
        StatTable.Controls.Add(SH2PointScored, 2, 5);
        StatTable.Controls.Add(FH2PointScored, 1, 5);
        StatTable.Controls.Add(label5, 0, 5);
        StatTable.Controls.Add(TOTPointScored, 3, 4);
        StatTable.Controls.Add(SHPointScored, 2, 4);
        StatTable.Controls.Add(FHPointScored, 1, 4);
        StatTable.Controls.Add(label4, 0, 4);
        StatTable.Controls.Add(TOTKOWon, 3, 3);
        StatTable.Controls.Add(SHKOWon, 2, 3);
        StatTable.Controls.Add(FHKOWon, 1, 3);
        StatTable.Controls.Add(label3, 0, 3);
        StatTable.Controls.Add(TOTTOLost, 3, 2);
        StatTable.Controls.Add(SHTOLost, 2, 2);
        StatTable.Controls.Add(FHTOLost, 1, 2);
        StatTable.Controls.Add(label2, 0, 2);
        StatTable.Controls.Add(TOTTOWon, 3, 1);
        StatTable.Controls.Add(SHTOWon, 2, 1);
        StatTable.Controls.Add(FHTOWon, 1, 1);
        StatTable.Controls.Add(label12, 3, 0);
        StatTable.Controls.Add(label11, 2, 0);
        StatTable.Controls.Add(label10, 1, 0);
        StatTable.Controls.Add(label1, 0, 1);
        StatTable.Dock = DockStyle.Fill;
        StatTable.Location = new Point(0, 0);
        StatTable.Name = "StatTable";
        StatTable.RowCount = 10;
        StatTable.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        StatTable.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        StatTable.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        StatTable.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        StatTable.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        StatTable.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        StatTable.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        StatTable.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        StatTable.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        StatTable.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        StatTable.Size = new Size(650, 382);
        StatTable.TabIndex = 0;
        // 
        // PlayerPerformanceChart
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(980, 426);
        Controls.Add(MainSplitController);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(3, 2, 3, 2);
        MinimizeBox = false;
        Name = "PlayerPerformanceChart";
        Text = "PlayerPerformanceChart";
        Load += PlayerPerformanceChart_Load;
        MainSplitController.Panel2.ResumeLayout(false);
        ((ISupportInitialize)MainSplitController).EndInit();
        MainSplitController.ResumeLayout(false);
        splitContainer2.Panel1.ResumeLayout(false);
        splitContainer2.Panel2.ResumeLayout(false);
        ((ISupportInitialize)splitContainer2).EndInit();
        splitContainer2.ResumeLayout(false);
        StatTable.ResumeLayout(false);
        ResumeLayout(false);
    }
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label FHTOWon;
    private System.Windows.Forms.Label FHTOLost;
    private System.Windows.Forms.Label FHKOWon;
    private System.Windows.Forms.Label FHPointScored;
    private System.Windows.Forms.Label FH2PointScored;
    private System.Windows.Forms.Label FHGoalScored;
    private System.Windows.Forms.Label FHMisses;
    private System.Windows.Forms.Label FHFrees;
    private System.Windows.Forms.Label FHScoreableFrees;
    private System.Windows.Forms.Label SHMisses;
    private System.Windows.Forms.Label SHGoalScored;
    private System.Windows.Forms.Label SH2PointScored;
    private System.Windows.Forms.Label SHPointScored;
    private System.Windows.Forms.Label SHKOWon;
    private System.Windows.Forms.Label SHTOLost;
    private System.Windows.Forms.Label SHTOWon;
    private System.Windows.Forms.Label SHScoreableFrees;
    private System.Windows.Forms.Label SHFrees;
    private System.Windows.Forms.Label TOTFrees;
    private System.Windows.Forms.Label TOTMisses;
    private System.Windows.Forms.Label TOTGoalScored;
    private System.Windows.Forms.Label TOT2PointScored;
    private System.Windows.Forms.Label TOTPointScored;
    private System.Windows.Forms.Label TOTKOWon;
    private System.Windows.Forms.Label TOTTOLost;
    private System.Windows.Forms.Label TOTTOWon;
    private System.Windows.Forms.Label TOTScoreableFrees;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;

    private System.Windows.Forms.ComboBox TeamComboBox;
    private System.Windows.Forms.ComboBox PlayerComboBox;
    private System.Windows.Forms.Label label1;

    #endregion

    private SplitContainer MainSplitController;
    private SplitContainer splitContainer2;
    private TableLayoutPanel StatTable;
}