using System.ComponentModel;

namespace StatsTracker.Views;

partial class ActionSelectWindow
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
        Play = new System.Windows.Forms.Button();
        Free = new System.Windows.Forms.Button();
        From45 = new System.Windows.Forms.Button();
        Mark = new System.Windows.Forms.Button();
        Penalty = new System.Windows.Forms.Button();
        Sideline = new System.Windows.Forms.Button();
        pictureBox2 = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        SuspendLayout();
        // 
        // Play
        // 
        Play.BackColor = System.Drawing.Color.LightCoral;
        Play.Font = new System.Drawing.Font("Segoe UI", 12F);
        Play.Location = new System.Drawing.Point(516, 19);
        Play.Name = "Play";
        Play.Size = new System.Drawing.Size(125, 63);
        Play.TabIndex = 0;
        Play.Text = "From Play";
        Play.UseVisualStyleBackColor = false;
        // 
        // Free
        // 
        Free.BackColor = System.Drawing.Color.LightCoral;
        Free.Font = new System.Drawing.Font("Segoe UI", 12F);
        Free.Location = new System.Drawing.Point(516, 88);
        Free.Name = "Free";
        Free.Size = new System.Drawing.Size(125, 63);
        Free.TabIndex = 1;
        Free.Text = "From Free";
        Free.UseVisualStyleBackColor = false;
        // 
        // From45
        // 
        From45.BackColor = System.Drawing.Color.LightCoral;
        From45.Font = new System.Drawing.Font("Segoe UI", 12F);
        From45.Location = new System.Drawing.Point(516, 157);
        From45.Name = "From45";
        From45.Size = new System.Drawing.Size(125, 63);
        From45.TabIndex = 2;
        From45.Text = "From 45";
        From45.UseVisualStyleBackColor = false;
        // 
        // Mark
        // 
        Mark.BackColor = System.Drawing.Color.LightCoral;
        Mark.Font = new System.Drawing.Font("Segoe UI", 12F);
        Mark.Location = new System.Drawing.Point(516, 226);
        Mark.Name = "Mark";
        Mark.Size = new System.Drawing.Size(125, 63);
        Mark.TabIndex = 3;
        Mark.Text = "From Mark";
        Mark.UseVisualStyleBackColor = false;
        // 
        // Penalty
        // 
        Penalty.BackColor = System.Drawing.Color.LightCoral;
        Penalty.Font = new System.Drawing.Font("Segoe UI", 10F);
        Penalty.Location = new System.Drawing.Point(516, 295);
        Penalty.Name = "Penalty";
        Penalty.Size = new System.Drawing.Size(125, 63);
        Penalty.TabIndex = 4;
        Penalty.Text = "From Penalty";
        Penalty.UseVisualStyleBackColor = false;
        // 
        // Sideline
        // 
        Sideline.BackColor = System.Drawing.Color.LightCoral;
        Sideline.Font = new System.Drawing.Font("Segoe UI", 10F);
        Sideline.Location = new System.Drawing.Point(516, 364);
        Sideline.Name = "Sideline";
        Sideline.Size = new System.Drawing.Size(125, 63);
        Sideline.TabIndex = 5;
        Sideline.Text = "From Sideline";
        Sideline.UseVisualStyleBackColor = false;
        // 
        // pictureBox2
        // 
        pictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
        pictureBox2.Location = new System.Drawing.Point(493, -4);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new System.Drawing.Size(17, 473);
        pictureBox2.TabIndex = 8;
        pictureBox2.TabStop = false;
        // 
        // ActionSelectWindow
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        ClientSize = new System.Drawing.Size(649, 461);
        Controls.Add(pictureBox2);
        Controls.Add(Sideline);
        Controls.Add(Penalty);
        Controls.Add(Mark);
        Controls.Add(From45);
        Controls.Add(Free);
        Controls.Add(Play);
        Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
        Text = "Action Select Window";
        Controls.SetChildIndex(Play, 0);
        Controls.SetChildIndex(Free, 0);
        Controls.SetChildIndex(From45, 0);
        Controls.SetChildIndex(Mark, 0);
        Controls.SetChildIndex(Penalty, 0);
        Controls.SetChildIndex(Sideline, 0);
        Controls.SetChildIndex(pictureBox2, 0);
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.PictureBox pictureBox2;

    private System.Windows.Forms.Button Play;
    private System.Windows.Forms.Button Free;
    private System.Windows.Forms.Button From45;
    private System.Windows.Forms.Button Mark;
    private System.Windows.Forms.Button Penalty;
    private System.Windows.Forms.Button Sideline;

    #endregion
}