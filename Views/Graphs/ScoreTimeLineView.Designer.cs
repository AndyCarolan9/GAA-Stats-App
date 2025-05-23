using System.ComponentModel;

namespace StatsTracker.Views.Graphs;

partial class ScoreTimeLineView
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreTimeLineView));
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        label1.Location = new System.Drawing.Point(314, -7);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(133, 34);
        label1.TabIndex = 0;
        label1.Text = "First Half";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        label2.Location = new System.Drawing.Point(1378, -7);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(186, 34);
        label2.TabIndex = 1;
        label2.Text = "Second Half";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // ScoreTimeLineView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1902, 603);
        Controls.Add(label2);
        Controls.Add(label1);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Text = "Score Timeline";
        Load += ScoreTimeLineView_Load;
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    #endregion
}