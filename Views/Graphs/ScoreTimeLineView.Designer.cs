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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(ScoreTimeLineView));
        label1 = new Label();
        label2 = new Label();
        ViewTable = new TableLayoutPanel();
        ViewTable.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Dock = DockStyle.Fill;
        label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        label1.Location = new Point(5, 5);
        label1.Margin = new Padding(5);
        label1.Name = "label1";
        label1.Size = new Size(822, 40);
        label1.TabIndex = 0;
        label1.Text = "First Half";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Dock = DockStyle.Fill;
        label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        label2.Location = new Point(837, 5);
        label2.Margin = new Padding(5);
        label2.Name = "label2";
        label2.Size = new Size(822, 40);
        label2.TabIndex = 1;
        label2.Text = "Second Half";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // ViewTable
        // 
        ViewTable.ColumnCount = 2;
        ViewTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        ViewTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        ViewTable.Controls.Add(label2, 1, 0);
        ViewTable.Controls.Add(label1, 0, 0);
        ViewTable.Dock = DockStyle.Fill;
        ViewTable.Location = new Point(0, 0);
        ViewTable.Name = "ViewTable";
        ViewTable.RowCount = 2;
        ViewTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        ViewTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        ViewTable.Size = new Size(1664, 452);
        ViewTable.TabIndex = 2;
        // 
        // ScoreTimeLineView
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1664, 452);
        Controls.Add(ViewTable);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(3, 2, 3, 2);
        Name = "ScoreTimeLineView";
        Text = "Score Timeline";
        Load += ScoreTimeLineView_Load;
        ViewTable.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    #endregion

    private TableLayoutPanel ViewTable;
}