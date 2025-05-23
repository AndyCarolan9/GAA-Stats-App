using System.ComponentModel;

namespace StatsTracker.Views;

partial class SubstituteSelectWindow
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubstituteSelectWindow));
        PlayerListbox = new System.Windows.Forms.ListBox();
        SuspendLayout();
        // 
        // PlayerListbox
        // 
        PlayerListbox.FormattingEnabled = true;
        PlayerListbox.Location = new System.Drawing.Point(496, 12);
        PlayerListbox.Name = "PlayerListbox";
        PlayerListbox.Size = new System.Drawing.Size(234, 384);
        PlayerListbox.TabIndex = 18;
        // 
        // SubstituteSelectWindow
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(736, 467);
        Controls.Add(PlayerListbox);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Margin = new System.Windows.Forms.Padding(45, 24, 45, 24);
        Text = "Subsitute Selection";
        Controls.SetChildIndex(PlayerListbox, 0);
        ResumeLayout(false);
    }

    private System.Windows.Forms.ListBox PlayerListbox;

    #endregion
}