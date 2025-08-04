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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisciplineReportView));
        pictureBox1 = new System.Windows.Forms.PictureBox();
        AwayTeamLabel = new System.Windows.Forms.Label();
        HomeTeamLabel = new System.Windows.Forms.Label();
        pictureBox2 = new System.Windows.Forms.PictureBox();
        TeamSelectBox = new System.Windows.Forms.ComboBox();
        TeamConcededFreesGrid = new System.Windows.Forms.DataGridView();
        PlayerConcededFreesView = new System.Windows.Forms.DataGridView();
        PlayerWonFreesGrid = new System.Windows.Forms.DataGridView();
        TeamWonFreesGrid = new System.Windows.Forms.DataGridView();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)TeamConcededFreesGrid).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PlayerConcededFreesView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PlayerWonFreesGrid).BeginInit();
        ((System.ComponentModel.ISupportInitialize)TeamWonFreesGrid).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.BackgroundImage = ((System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage"));
        pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        pictureBox1.Location = new System.Drawing.Point(17, 40);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(700, 964);
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // AwayTeamLabel
        // 
        AwayTeamLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        AwayTeamLabel.Location = new System.Drawing.Point(241, 1007);
        AwayTeamLabel.Name = "AwayTeamLabel";
        AwayTeamLabel.Size = new System.Drawing.Size(227, 36);
        AwayTeamLabel.TabIndex = 1;
        AwayTeamLabel.Text = "Away Team";
        AwayTeamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // HomeTeamLabel
        // 
        HomeTeamLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        HomeTeamLabel.Location = new System.Drawing.Point(241, 1);
        HomeTeamLabel.Name = "HomeTeamLabel";
        HomeTeamLabel.Size = new System.Drawing.Size(227, 36);
        HomeTeamLabel.TabIndex = 2;
        HomeTeamLabel.Text = "Home Team";
        HomeTeamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // pictureBox2
        // 
        pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        pictureBox2.Location = new System.Drawing.Point(723, -5);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new System.Drawing.Size(10, 1054);
        pictureBox2.TabIndex = 3;
        pictureBox2.TabStop = false;
        // 
        // TeamSelectBox
        // 
        TeamSelectBox.FormattingEnabled = true;
        TeamSelectBox.Location = new System.Drawing.Point(744, 9);
        TeamSelectBox.Name = "TeamSelectBox";
        TeamSelectBox.Size = new System.Drawing.Size(177, 23);
        TeamSelectBox.TabIndex = 4;
        // 
        // TeamConcededFreesGrid
        // 
        TeamConcededFreesGrid.BackgroundColor = System.Drawing.SystemColors.Control;
        TeamConcededFreesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        TeamConcededFreesGrid.Location = new System.Drawing.Point(744, 107);
        TeamConcededFreesGrid.Name = "TeamConcededFreesGrid";
        TeamConcededFreesGrid.Size = new System.Drawing.Size(789, 192);
        TeamConcededFreesGrid.TabIndex = 5;
        TeamConcededFreesGrid.Text = "dataGridView1";
        // 
        // PlayerConcededFreesView
        // 
        PlayerConcededFreesView.BackgroundColor = System.Drawing.SystemColors.Control;
        PlayerConcededFreesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        PlayerConcededFreesView.Location = new System.Drawing.Point(745, 305);
        PlayerConcededFreesView.Name = "PlayerConcededFreesView";
        PlayerConcededFreesView.Size = new System.Drawing.Size(789, 192);
        PlayerConcededFreesView.TabIndex = 6;
        PlayerConcededFreesView.Text = "dataGridView2";
        // 
        // PlayerWonFreesGrid
        // 
        PlayerWonFreesGrid.BackgroundColor = System.Drawing.SystemColors.Control;
        PlayerWonFreesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        PlayerWonFreesGrid.Location = new System.Drawing.Point(745, 797);
        PlayerWonFreesGrid.Name = "PlayerWonFreesGrid";
        PlayerWonFreesGrid.Size = new System.Drawing.Size(789, 192);
        PlayerWonFreesGrid.TabIndex = 8;
        PlayerWonFreesGrid.Text = "dataGridView3";
        // 
        // TeamWonFreesGrid
        // 
        TeamWonFreesGrid.BackgroundColor = System.Drawing.SystemColors.Control;
        TeamWonFreesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        TeamWonFreesGrid.Location = new System.Drawing.Point(744, 599);
        TeamWonFreesGrid.Name = "TeamWonFreesGrid";
        TeamWonFreesGrid.Size = new System.Drawing.Size(789, 192);
        TeamWonFreesGrid.TabIndex = 7;
        TeamWonFreesGrid.Text = "dataGridView4";
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Bold);
        label1.Location = new System.Drawing.Point(745, 51);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(372, 53);
        label1.TabIndex = 9;
        label1.Text = "Frees Conceded";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Bold);
        label2.Location = new System.Drawing.Point(744, 543);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(372, 53);
        label2.TabIndex = 10;
        label2.Text = "Frees Won";
        // 
        // DisciplineReportView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1555, 1041);
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
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Text = "DisciplineReportView";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ((System.ComponentModel.ISupportInitialize)TeamConcededFreesGrid).EndInit();
        ((System.ComponentModel.ISupportInitialize)PlayerConcededFreesView).EndInit();
        ((System.ComponentModel.ISupportInitialize)PlayerWonFreesGrid).EndInit();
        ((System.ComponentModel.ISupportInitialize)TeamWonFreesGrid).EndInit();
        ResumeLayout(false);
    }

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