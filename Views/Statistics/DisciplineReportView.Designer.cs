using System.ComponentModel;

namespace StatsTracker.Views.Statistics;

partial class DisciplineReportView
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(DisciplineReportView));
        pictureBox1 = new PictureBox();
        AwayTeamLabel = new Label();
        HomeTeamLabel = new Label();
        pictureBox2 = new PictureBox();
        TeamSelectBox = new ComboBox();
        TeamConcededFreesGrid = new DataGridView();
        PlayerConcededFreesView = new DataGridView();
        PlayerWonFreesGrid = new DataGridView();
        TeamWonFreesGrid = new DataGridView();
        label1 = new Label();
        label2 = new Label();
        ScoreConcededGrid = new DataGridView();
        TotalScoredGrid = new DataGridView();
        ((ISupportInitialize)pictureBox1).BeginInit();
        ((ISupportInitialize)pictureBox2).BeginInit();
        ((ISupportInitialize)TeamConcededFreesGrid).BeginInit();
        ((ISupportInitialize)PlayerConcededFreesView).BeginInit();
        ((ISupportInitialize)PlayerWonFreesGrid).BeginInit();
        ((ISupportInitialize)TeamWonFreesGrid).BeginInit();
        ((ISupportInitialize)ScoreConcededGrid).BeginInit();
        ((ISupportInitialize)TotalScoredGrid).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
        pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        pictureBox1.Location = new Point(15, 30);
        pictureBox1.Margin = new Padding(3, 2, 3, 2);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(612, 723);
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // AwayTeamLabel
        // 
        AwayTeamLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        AwayTeamLabel.Location = new Point(211, 755);
        AwayTeamLabel.Name = "AwayTeamLabel";
        AwayTeamLabel.Size = new Size(199, 27);
        AwayTeamLabel.TabIndex = 1;
        AwayTeamLabel.Text = "Away Team";
        AwayTeamLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // HomeTeamLabel
        // 
        HomeTeamLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        HomeTeamLabel.Location = new Point(211, 1);
        HomeTeamLabel.Name = "HomeTeamLabel";
        HomeTeamLabel.Size = new Size(199, 27);
        HomeTeamLabel.TabIndex = 2;
        HomeTeamLabel.Text = "Home Team";
        HomeTeamLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pictureBox2
        // 
        pictureBox2.BackColor = SystemColors.ActiveCaptionText;
        pictureBox2.Location = new Point(633, -4);
        pictureBox2.Margin = new Padding(3, 2, 3, 2);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(9, 790);
        pictureBox2.TabIndex = 3;
        pictureBox2.TabStop = false;
        // 
        // TeamSelectBox
        // 
        TeamSelectBox.FormattingEnabled = true;
        TeamSelectBox.Location = new Point(651, 7);
        TeamSelectBox.Margin = new Padding(3, 2, 3, 2);
        TeamSelectBox.Name = "TeamSelectBox";
        TeamSelectBox.Size = new Size(155, 23);
        TeamSelectBox.TabIndex = 4;
        // 
        // TeamConcededFreesGrid
        // 
        TeamConcededFreesGrid.BackgroundColor = SystemColors.Control;
        TeamConcededFreesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        TeamConcededFreesGrid.Location = new Point(651, 80);
        TeamConcededFreesGrid.Margin = new Padding(3, 2, 3, 2);
        TeamConcededFreesGrid.Name = "TeamConcededFreesGrid";
        TeamConcededFreesGrid.RowHeadersWidth = 51;
        TeamConcededFreesGrid.Size = new Size(551, 144);
        TeamConcededFreesGrid.TabIndex = 5;
        TeamConcededFreesGrid.Text = "dataGridView1";
        // 
        // PlayerConcededFreesView
        // 
        PlayerConcededFreesView.BackgroundColor = SystemColors.Control;
        PlayerConcededFreesView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        PlayerConcededFreesView.Location = new Point(652, 229);
        PlayerConcededFreesView.Margin = new Padding(3, 2, 3, 2);
        PlayerConcededFreesView.Name = "PlayerConcededFreesView";
        PlayerConcededFreesView.RowHeadersWidth = 51;
        PlayerConcededFreesView.Size = new Size(354, 144);
        PlayerConcededFreesView.TabIndex = 6;
        PlayerConcededFreesView.Text = "dataGridView2";
        // 
        // PlayerWonFreesGrid
        // 
        PlayerWonFreesGrid.BackgroundColor = SystemColors.Control;
        PlayerWonFreesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        PlayerWonFreesGrid.Location = new Point(652, 598);
        PlayerWonFreesGrid.Margin = new Padding(3, 2, 3, 2);
        PlayerWonFreesGrid.Name = "PlayerWonFreesGrid";
        PlayerWonFreesGrid.RowHeadersWidth = 51;
        PlayerWonFreesGrid.Size = new Size(354, 144);
        PlayerWonFreesGrid.TabIndex = 8;
        PlayerWonFreesGrid.Text = "dataGridView3";
        // 
        // TeamWonFreesGrid
        // 
        TeamWonFreesGrid.BackgroundColor = SystemColors.Control;
        TeamWonFreesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        TeamWonFreesGrid.Location = new Point(651, 449);
        TeamWonFreesGrid.Margin = new Padding(3, 2, 3, 2);
        TeamWonFreesGrid.Name = "TeamWonFreesGrid";
        TeamWonFreesGrid.RowHeadersWidth = 51;
        TeamWonFreesGrid.Size = new Size(551, 144);
        TeamWonFreesGrid.TabIndex = 7;
        TeamWonFreesGrid.Text = "dataGridView4";
        // 
        // label1
        // 
        label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
        label1.Location = new Point(652, 38);
        label1.Name = "label1";
        label1.Size = new Size(326, 40);
        label1.TabIndex = 9;
        label1.Text = "Frees Conceded";
        // 
        // label2
        // 
        label2.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
        label2.Location = new Point(651, 407);
        label2.Name = "label2";
        label2.Size = new Size(326, 40);
        label2.TabIndex = 10;
        label2.Text = "Frees Won";
        // 
        // ScoreConcededGrid
        // 
        ScoreConcededGrid.BackgroundColor = SystemColors.Control;
        ScoreConcededGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        ScoreConcededGrid.Location = new Point(1011, 229);
        ScoreConcededGrid.Margin = new Padding(3, 2, 3, 2);
        ScoreConcededGrid.Name = "ScoreConcededGrid";
        ScoreConcededGrid.RowHeadersWidth = 51;
        ScoreConcededGrid.Size = new Size(244, 144);
        ScoreConcededGrid.TabIndex = 11;
        ScoreConcededGrid.Text = "dataGridView2";
        // 
        // TotalScoredGrid
        // 
        TotalScoredGrid.BackgroundColor = SystemColors.Control;
        TotalScoredGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        TotalScoredGrid.Location = new Point(1011, 598);
        TotalScoredGrid.Margin = new Padding(3, 2, 3, 2);
        TotalScoredGrid.Name = "TotalScoredGrid";
        TotalScoredGrid.RowHeadersWidth = 51;
        TotalScoredGrid.Size = new Size(244, 144);
        TotalScoredGrid.TabIndex = 12;
        TotalScoredGrid.Text = "dataGridView2";
        // 
        // DisciplineReportView
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1361, 781);
        Controls.Add(TotalScoredGrid);
        Controls.Add(ScoreConcededGrid);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(PlayerWonFreesGrid);
        Controls.Add(TeamWonFreesGrid);
        Controls.Add(PlayerConcededFreesView);
        Controls.Add(TeamConcededFreesGrid);
        Controls.Add(TeamSelectBox);
        Controls.Add(pictureBox2);
        Controls.Add(HomeTeamLabel);
        Controls.Add(AwayTeamLabel);
        Controls.Add(pictureBox1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "DisciplineReportView";
        Text = "DisciplineReportView";
        ((ISupportInitialize)pictureBox1).EndInit();
        ((ISupportInitialize)pictureBox2).EndInit();
        ((ISupportInitialize)TeamConcededFreesGrid).EndInit();
        ((ISupportInitialize)PlayerConcededFreesView).EndInit();
        ((ISupportInitialize)PlayerWonFreesGrid).EndInit();
        ((ISupportInitialize)TeamWonFreesGrid).EndInit();
        ((ISupportInitialize)ScoreConcededGrid).EndInit();
        ((ISupportInitialize)TotalScoredGrid).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView ScoreConcededGrid;
    private System.Windows.Forms.DataGridView TotalScoredGrid;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.DataGridView PlayerConcededFreesView;
    private System.Windows.Forms.DataGridView PlayerWonFreesGrid;
    private System.Windows.Forms.DataGridView TeamWonFreesGrid;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.ComboBox TeamSelectBox;
    private System.Windows.Forms.DataGridView TeamConcededFreesGrid;

    private System.Windows.Forms.Label HomeTeamLabel;
    private System.Windows.Forms.PictureBox pictureBox2;

    private System.Windows.Forms.Label AwayTeamLabel;

    private System.Windows.Forms.PictureBox pictureBox1;

    #endregion
}