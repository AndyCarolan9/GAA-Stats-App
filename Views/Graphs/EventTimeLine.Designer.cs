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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(EventTimeLine));
        HomeTeamLabel = new Label();
        AwayTeamLabel = new Label();
        EventPanel = new Panel();
        SuspendLayout();
        // 
        // HomeTeamLabel
        // 
        HomeTeamLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        HomeTeamLabel.Location = new Point(7, 8);
        HomeTeamLabel.Name = "HomeTeamLabel";
        HomeTeamLabel.Size = new Size(191, 27);
        HomeTeamLabel.TabIndex = 1;
        HomeTeamLabel.Text = "Home Team";
        HomeTeamLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // AwayTeamLabel
        // 
        AwayTeamLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        AwayTeamLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        AwayTeamLabel.Location = new Point(285, 8);
        AwayTeamLabel.Name = "AwayTeamLabel";
        AwayTeamLabel.Size = new Size(191, 27);
        AwayTeamLabel.TabIndex = 2;
        AwayTeamLabel.Text = "Away Team";
        AwayTeamLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // EventPanel
        // 
        EventPanel.AutoScroll = true;
        EventPanel.Location = new Point(7, 38);
        EventPanel.Margin = new Padding(3, 2, 3, 2);
        EventPanel.Name = "EventPanel";
        EventPanel.Size = new Size(477, 598);
        EventPanel.TabIndex = 0;
        // 
        // EventTimeLine
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(488, 640);
        Controls.Add(AwayTeamLabel);
        Controls.Add(HomeTeamLabel);
        Controls.Add(EventPanel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Location = new Point(19, 19);
        Margin = new Padding(3, 2, 3, 2);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "EventTimeLine";
        Text = "Shot Event Timeline";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label AwayTeamLabel;
    private System.Windows.Forms.Panel EventPanel;

    private System.Windows.Forms.Label HomeTeamLabel;

    #endregion
}