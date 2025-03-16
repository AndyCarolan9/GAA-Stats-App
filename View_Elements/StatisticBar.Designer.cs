using System.ComponentModel;

namespace StatsTracker.View_Elements;

partial class StatisticBar
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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        StatSplitBar = new StatsTracker.View_Elements.SplitCountBar(components);
        StatNameLabel = new System.Windows.Forms.Label();
        HomeTeamValue = new System.Windows.Forms.Label();
        AwayTeamValue = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // StatSplitBar
        // 
        StatSplitBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        StatSplitBar.Location = new System.Drawing.Point(0, 59);
        StatSplitBar.Maximum = 10;
        StatSplitBar.Name = "StatSplitBar";
        StatSplitBar.Size = new System.Drawing.Size(499, 40);
        StatSplitBar.TabIndex = 0;
        StatSplitBar.Value = 5;
        // 
        // StatNameLabel
        // 
        StatNameLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        StatNameLabel.Location = new System.Drawing.Point(81, 25);
        StatNameLabel.Name = "StatNameLabel";
        StatNameLabel.Size = new System.Drawing.Size(338, 32);
        StatNameLabel.TabIndex = 1;
        StatNameLabel.Text = "Stat Name";
        StatNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // HomeTeamValue
        // 
        HomeTeamValue.Font = new System.Drawing.Font("Segoe UI", 20F);
        HomeTeamValue.Location = new System.Drawing.Point(3, 23);
        HomeTeamValue.Name = "HomeTeamValue";
        HomeTeamValue.Size = new System.Drawing.Size(72, 36);
        HomeTeamValue.TabIndex = 2;
        HomeTeamValue.Text = "40";
        HomeTeamValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // AwayTeamValue
        // 
        AwayTeamValue.Font = new System.Drawing.Font("Segoe UI", 20F);
        AwayTeamValue.Location = new System.Drawing.Point(425, 23);
        AwayTeamValue.Name = "AwayTeamValue";
        AwayTeamValue.Size = new System.Drawing.Size(72, 36);
        AwayTeamValue.TabIndex = 3;
        AwayTeamValue.Text = "40";
        AwayTeamValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // StatisticBar
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(AwayTeamValue);
        Controls.Add(HomeTeamValue);
        Controls.Add(StatNameLabel);
        Controls.Add(StatSplitBar);
        Size = new System.Drawing.Size(500, 70);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label StatNameLabel;
    private System.Windows.Forms.Label HomeTeamValue;
    private System.Windows.Forms.Label AwayTeamValue;

    private StatsTracker.View_Elements.SplitCountBar StatSplitBar;

    #endregion
}