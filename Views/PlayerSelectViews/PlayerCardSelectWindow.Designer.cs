using System.ComponentModel;

namespace StatsTracker.Views.PlayerSelectViews;

partial class PlayerCardSelectWindow
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
        YellowCard = new System.Windows.Forms.Button();
        RedCard = new System.Windows.Forms.Button();
        RedCard2Y = new System.Windows.Forms.Button();
        BlackCard = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // YellowCard
        // 
        YellowCard.BackColor = System.Drawing.Color.LightCoral;
        YellowCard.Location = new System.Drawing.Point(533, 8);
        YellowCard.Name = "YellowCard";
        YellowCard.Size = new System.Drawing.Size(159, 66);
        YellowCard.TabIndex = 18;
        YellowCard.Text = "Yellow Card";
        YellowCard.UseVisualStyleBackColor = false;
        // 
        // RedCard
        // 
        RedCard.BackColor = System.Drawing.Color.LightCoral;
        RedCard.Location = new System.Drawing.Point(533, 80);
        RedCard.Name = "RedCard";
        RedCard.Size = new System.Drawing.Size(159, 66);
        RedCard.TabIndex = 19;
        RedCard.Text = "Red Card";
        RedCard.UseVisualStyleBackColor = false;
        // 
        // RedCard2Y
        // 
        RedCard2Y.BackColor = System.Drawing.Color.LightCoral;
        RedCard2Y.Location = new System.Drawing.Point(533, 152);
        RedCard2Y.Name = "RedCard2Y";
        RedCard2Y.Size = new System.Drawing.Size(159, 66);
        RedCard2Y.TabIndex = 20;
        RedCard2Y.Text = "Red Card (2Y)";
        RedCard2Y.UseVisualStyleBackColor = false;
        // 
        // BlackCard
        // 
        BlackCard.BackColor = System.Drawing.Color.LightCoral;
        BlackCard.Location = new System.Drawing.Point(533, 224);
        BlackCard.Name = "BlackCard";
        BlackCard.Size = new System.Drawing.Size(159, 66);
        BlackCard.TabIndex = 21;
        BlackCard.Text = "Black Card";
        BlackCard.UseVisualStyleBackColor = false;
        // 
        // PlayerCardSelectWindow
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(699, 492);
        Controls.Add(BlackCard);
        Controls.Add(RedCard2Y);
        Controls.Add(RedCard);
        Controls.Add(YellowCard);
        Margin = new System.Windows.Forms.Padding(45, 24, 45, 24);
        Text = "PlayerCardSelectWindow";
        Controls.SetChildIndex(YellowCard, 0);
        Controls.SetChildIndex(RedCard, 0);
        Controls.SetChildIndex(RedCard2Y, 0);
        Controls.SetChildIndex(BlackCard, 0);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button RedCard;
    private System.Windows.Forms.Button RedCard2Y;
    private System.Windows.Forms.Button BlackCard;

    private System.Windows.Forms.Button YellowCard;

    #endregion
}