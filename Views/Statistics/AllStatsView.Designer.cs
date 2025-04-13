using System.ComponentModel;

namespace StatsTracker.Views.Statistics;

partial class AllStatsView
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
        TeamSelectorBox = new System.Windows.Forms.ComboBox();
        SuspendLayout();
        // 
        // TeamSelectorBox
        // 
        TeamSelectorBox.FormattingEnabled = true;
        TeamSelectorBox.Location = new System.Drawing.Point(10, 10);
        TeamSelectorBox.Name = "TeamSelectorBox";
        TeamSelectorBox.Size = new System.Drawing.Size(200, 28);
        TeamSelectorBox.TabIndex = 0;
        TeamSelectorBox.SelectedIndexChanged += TeamSelectBox_SelectedIndexChanged;
        // 
        // AllStatsView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1902, 1033);
        Controls.Add(TeamSelectorBox);
        Text = "AllStatsView";
        ResumeLayout(false);
    }

    private System.Windows.Forms.ComboBox TeamSelectorBox;

    #endregion
}