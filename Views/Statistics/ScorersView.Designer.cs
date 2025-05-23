using System.ComponentModel;

namespace StatsTracker.Views.Statistics;

partial class ScorersView
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScorersView));
        ScorersGrid = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)ScorersGrid).BeginInit();
        SuspendLayout();
        // 
        // ScorersGrid
        // 
        ScorersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        ScorersGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
        ScorersGrid.BackgroundColor = System.Drawing.SystemColors.Control;
        ScorersGrid.ColumnHeadersHeight = 29;
        ScorersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
        ScorersGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
        ScorersGrid.Location = new System.Drawing.Point(0, 0);
        ScorersGrid.Name = "ScorersGrid";
        ScorersGrid.RowHeadersWidth = 51;
        ScorersGrid.Size = new System.Drawing.Size(800, 450);
        ScorersGrid.TabIndex = 0;
        // 
        // ScorersView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(ScorersGrid);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Text = "Scorers List";
        ((System.ComponentModel.ISupportInitialize)ScorersGrid).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView ScorersGrid;

    #endregion
}