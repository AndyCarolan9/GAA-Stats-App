using System.ComponentModel;

namespace StatsTracker.Views.Graphs;

partial class EventTimeLine
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
        HomeTeamLabel = new System.Windows.Forms.Label();
        AwayTeamLabel = new System.Windows.Forms.Label();
        EventPanel = new System.Windows.Forms.Panel();
        SuspendLayout();
        // 
        // HomeTeamLabel
        // 
        HomeTeamLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        HomeTeamLabel.Location = new System.Drawing.Point(8, 11);
        HomeTeamLabel.Name = "HomeTeamLabel";
        HomeTeamLabel.Size = new System.Drawing.Size(218, 36);
        HomeTeamLabel.TabIndex = 1;
        HomeTeamLabel.Text = "Home Team";
        HomeTeamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // AwayTeamLabel
        // 
        AwayTeamLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        AwayTeamLabel.Location = new System.Drawing.Point(256, 11);
        AwayTeamLabel.Name = "AwayTeamLabel";
        AwayTeamLabel.Size = new System.Drawing.Size(218, 36);
        AwayTeamLabel.TabIndex = 2;
        AwayTeamLabel.Text = "Away Team";
        AwayTeamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // EventPanel
        // 
        EventPanel.AutoScroll = true;
        EventPanel.Location = new System.Drawing.Point(8, 50);
        EventPanel.Name = "EventPanel";
        EventPanel.Size = new System.Drawing.Size(466, 797);
        EventPanel.TabIndex = 0;
        // 
        // EventTimeLine
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(481, 853);
        Controls.Add(AwayTeamLabel);
        Controls.Add(HomeTeamLabel);
        Controls.Add(EventPanel);
        Location = new System.Drawing.Point(19, 19);
        Text = "Shot Event Timeline";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label AwayTeamLabel;
    private System.Windows.Forms.Panel EventPanel;

    private System.Windows.Forms.Label HomeTeamLabel;

    #endregion
}