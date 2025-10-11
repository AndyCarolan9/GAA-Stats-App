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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(ScorersView));
        ScorersGrid = new DataGridView();
        panel1 = new Panel();
        ((ISupportInitialize)ScorersGrid).BeginInit();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // ScorersGrid
        // 
        ScorersGrid.AllowUserToAddRows = false;
        ScorersGrid.AllowUserToDeleteRows = false;
        ScorersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        ScorersGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        ScorersGrid.BackgroundColor = SystemColors.Control;
        ScorersGrid.ColumnHeadersHeight = 29;
        ScorersGrid.Dock = DockStyle.Fill;
        ScorersGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
        ScorersGrid.Location = new Point(0, 0);
        ScorersGrid.Margin = new Padding(3, 2, 3, 2);
        ScorersGrid.Name = "ScorersGrid";
        ScorersGrid.ReadOnly = true;
        ScorersGrid.RowHeadersWidth = 51;
        ScorersGrid.Size = new Size(1084, 191);
        ScorersGrid.TabIndex = 0;
        // 
        // panel1
        // 
        panel1.Controls.Add(ScorersGrid);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(1084, 191);
        panel1.TabIndex = 1;
        // 
        // ScorersView
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1084, 191);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(3, 2, 3, 2);
        MinimumSize = new Size(1100, 230);
        Name = "ScorersView";
        Text = "Scorers List";
        ((ISupportInitialize)ScorersGrid).EndInit();
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView ScorersGrid;

    #endregion

    private Panel panel1;
}