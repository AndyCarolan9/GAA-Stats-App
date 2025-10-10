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
        components = new Container();
        StatSplitBar = new SplitCountBar(components);
        StatNameLabel = new Label();
        HomeTeamValue = new Label();
        AwayTeamValue = new Label();
        SuspendLayout();
        // 
        // StatSplitBar
        // 
        StatSplitBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        StatSplitBar.BackColor = SystemColors.ActiveCaptionText;
        StatSplitBar.Location = new Point(1, 33);
        StatSplitBar.Margin = new Padding(2);
        StatSplitBar.Maximum = 10;
        StatSplitBar.MinimumSize = new Size(0, 10);
        StatSplitBar.Name = "StatSplitBar";
        StatSplitBar.Size = new Size(477, 21);
        StatSplitBar.TabIndex = 0;
        StatSplitBar.Value = 5;
        // 
        // StatNameLabel
        // 
        StatNameLabel.Anchor = AnchorStyles.Top;
        StatNameLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        StatNameLabel.Location = new Point(189, 1);
        StatNameLabel.Margin = new Padding(2, 0, 2, 0);
        StatNameLabel.Name = "StatNameLabel";
        StatNameLabel.Size = new Size(112, 30);
        StatNameLabel.TabIndex = 1;
        StatNameLabel.Text = "Stat Name";
        StatNameLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // HomeTeamValue
        // 
        HomeTeamValue.Font = new Font("Segoe UI", 20F);
        HomeTeamValue.Location = new Point(2, -4);
        HomeTeamValue.Margin = new Padding(2, 0, 2, 0);
        HomeTeamValue.Name = "HomeTeamValue";
        HomeTeamValue.Size = new Size(58, 32);
        HomeTeamValue.TabIndex = 2;
        HomeTeamValue.Text = "40";
        HomeTeamValue.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // AwayTeamValue
        // 
        AwayTeamValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        AwayTeamValue.Font = new Font("Segoe UI", 20F);
        AwayTeamValue.Location = new Point(426, -4);
        AwayTeamValue.Margin = new Padding(2, 0, 2, 0);
        AwayTeamValue.Name = "AwayTeamValue";
        AwayTeamValue.Size = new Size(58, 32);
        AwayTeamValue.TabIndex = 3;
        AwayTeamValue.Text = "40";
        AwayTeamValue.TextAlign = ContentAlignment.MiddleRight;
        // 
        // StatisticBar
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        Controls.Add(AwayTeamValue);
        Controls.Add(HomeTeamValue);
        Controls.Add(StatNameLabel);
        Controls.Add(StatSplitBar);
        Margin = new Padding(2, 3, 2, 3);
        Name = "StatisticBar";
        Size = new Size(481, 66);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label StatNameLabel;
    private System.Windows.Forms.Label HomeTeamValue;
    private System.Windows.Forms.Label AwayTeamValue;

    private StatsTracker.View_Elements.SplitCountBar StatSplitBar;

    #endregion
}