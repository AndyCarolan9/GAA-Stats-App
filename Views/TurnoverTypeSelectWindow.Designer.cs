using System.ComponentModel;

namespace StatsTracker.Views;

partial class TurnoverTypeSelectWindow
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
        TackledButton = new System.Windows.Forms.Button();
        InterceptedButton = new System.Windows.Forms.Button();
        FreeButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // TackledButton
        // 
        TackledButton.BackColor = System.Drawing.Color.LightCoral;
        TackledButton.Location = new System.Drawing.Point(501, 12);
        TackledButton.Name = "TackledButton";
        TackledButton.Size = new System.Drawing.Size(140, 57);
        TackledButton.TabIndex = 18;
        TackledButton.Text = "Tackle";
        TackledButton.UseVisualStyleBackColor = false;
        // 
        // InterceptedButton
        // 
        InterceptedButton.BackColor = System.Drawing.Color.LightCoral;
        InterceptedButton.Location = new System.Drawing.Point(501, 75);
        InterceptedButton.Name = "InterceptedButton";
        InterceptedButton.Size = new System.Drawing.Size(140, 57);
        InterceptedButton.TabIndex = 19;
        InterceptedButton.Text = "Intercept";
        InterceptedButton.UseVisualStyleBackColor = false;
        // 
        // FreeButton
        // 
        FreeButton.BackColor = System.Drawing.Color.LightCoral;
        FreeButton.Location = new System.Drawing.Point(501, 138);
        FreeButton.Name = "FreeButton";
        FreeButton.Size = new System.Drawing.Size(140, 57);
        FreeButton.TabIndex = 20;
        FreeButton.Text = "Free";
        FreeButton.UseVisualStyleBackColor = false;
        // 
        // TurnoverTypeSelectWindow
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(653, 469);
        Controls.Add(FreeButton);
        Controls.Add(InterceptedButton);
        Controls.Add(TackledButton);
        Text = "TurnoverTypeSelectWindow";
        Controls.SetChildIndex(TackledButton, 0);
        Controls.SetChildIndex(InterceptedButton, 0);
        Controls.SetChildIndex(FreeButton, 0);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button TackledButton;
    private System.Windows.Forms.Button InterceptedButton;
    private System.Windows.Forms.Button FreeButton;

    #endregion
}