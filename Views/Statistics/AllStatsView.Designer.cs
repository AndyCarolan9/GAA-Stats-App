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
        components = new System.ComponentModel.Container();
        TeamSelectorBox = new System.Windows.Forms.ComboBox();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        pictureBox2 = new System.Windows.Forms.PictureBox();
        TotalKickoutsBar = new StatsTracker.View_Elements.StatisticBar();
        KOWonCleanBar = new StatsTracker.View_Elements.StatisticBar();
        StatSplitBar = new StatsTracker.View_Elements.SplitCountBar(components);
        KOLabel = new System.Windows.Forms.Label();
        KOWonMarkBar = new StatsTracker.View_Elements.StatisticBar();
        object_4f1641f2_92c2_46c8_a2b7_2daf7901bc29 = new StatsTracker.View_Elements.SplitCountBar(components);
        splitCountBar1 = new StatsTracker.View_Elements.SplitCountBar(components);
        KOWonBreak = new StatsTracker.View_Elements.StatisticBar();
        object_d764597b_1a89_44bf_90dc_c422991bdb6e = new StatsTracker.View_Elements.SplitCountBar(components);
        splitCountBar2 = new StatsTracker.View_Elements.SplitCountBar(components);
        splitCountBar3 = new StatsTracker.View_Elements.SplitCountBar(components);
        KOLostCleanBar = new StatsTracker.View_Elements.StatisticBar();
        object_dc80317d_725f_498a_a84d_c335d06e7ff7 = new StatsTracker.View_Elements.SplitCountBar(components);
        splitCountBar4 = new StatsTracker.View_Elements.SplitCountBar(components);
        splitCountBar5 = new StatsTracker.View_Elements.SplitCountBar(components);
        splitCountBar6 = new StatsTracker.View_Elements.SplitCountBar(components);
        KOLostMarkBar = new StatsTracker.View_Elements.StatisticBar();
        object_dcbb98d9_53c9_4165_876e_a29608eedee9 = new StatsTracker.View_Elements.SplitCountBar(components);
        splitCountBar7 = new StatsTracker.View_Elements.SplitCountBar(components);
        splitCountBar8 = new StatsTracker.View_Elements.SplitCountBar(components);
        splitCountBar9 = new StatsTracker.View_Elements.SplitCountBar(components);
        splitCountBar10 = new StatsTracker.View_Elements.SplitCountBar(components);
        KOLostBreakBar = new StatsTracker.View_Elements.StatisticBar();
        object_9cf9d193_b9bf_486f_af84_3eb3afad7171 = new StatsTracker.View_Elements.SplitCountBar(components);
        splitCountBar11 = new StatsTracker.View_Elements.SplitCountBar(components);
        splitCountBar12 = new StatsTracker.View_Elements.SplitCountBar(components);
        splitCountBar13 = new StatsTracker.View_Elements.SplitCountBar(components);
        splitCountBar14 = new StatsTracker.View_Elements.SplitCountBar(components);
        splitCountBar15 = new StatsTracker.View_Elements.SplitCountBar(components);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        KOWonCleanBar.SuspendLayout();
        KOWonMarkBar.SuspendLayout();
        KOWonBreak.SuspendLayout();
        KOLostCleanBar.SuspendLayout();
        KOLostMarkBar.SuspendLayout();
        KOLostBreakBar.SuspendLayout();
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
        // pictureBox1
        // 
        pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        pictureBox1.Location = new System.Drawing.Point(216, -2);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(12, 1058);
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        // 
        // pictureBox2
        // 
        pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        pictureBox2.Location = new System.Drawing.Point(732, -2);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new System.Drawing.Size(12, 1058);
        pictureBox2.TabIndex = 2;
        pictureBox2.TabStop = false;
        // 
        // TotalKickoutsBar
        // 
        TotalKickoutsBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        TotalKickoutsBar.Location = new System.Drawing.Point(234, 58);
        TotalKickoutsBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        TotalKickoutsBar.Name = "TotalKickoutsBar";
        TotalKickoutsBar.Size = new System.Drawing.Size(492, 60);
        TotalKickoutsBar.StatName = "Total";
        TotalKickoutsBar.TabIndex = 3;
        // 
        // KOWonCleanBar
        // 
        KOWonCleanBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        KOWonCleanBar.Controls.Add(StatSplitBar);
        KOWonCleanBar.Location = new System.Drawing.Point(234, 126);
        KOWonCleanBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        KOWonCleanBar.Name = "KOWonCleanBar";
        KOWonCleanBar.Size = new System.Drawing.Size(492, 60);
        KOWonCleanBar.StatName = "Won Clean";
        KOWonCleanBar.TabIndex = 4;
        // 
        // StatSplitBar
        // 
        StatSplitBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        StatSplitBar.Location = new System.Drawing.Point(0, 39);
        StatSplitBar.Maximum = 2;
        StatSplitBar.Name = "StatSplitBar";
        StatSplitBar.Size = new System.Drawing.Size(499, 27);
        StatSplitBar.TabIndex = 0;
        StatSplitBar.Value = 1;
        // 
        // KOLabel
        // 
        KOLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
        KOLabel.Location = new System.Drawing.Point(337, -2);
        KOLabel.Name = "KOLabel";
        KOLabel.Size = new System.Drawing.Size(286, 49);
        KOLabel.TabIndex = 5;
        KOLabel.Text = "Kickouts";
        KOLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // KOWonMarkBar
        // 
        KOWonMarkBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        KOWonMarkBar.Controls.Add(object_4f1641f2_92c2_46c8_a2b7_2daf7901bc29);
        KOWonMarkBar.Controls.Add(splitCountBar1);
        KOWonMarkBar.Location = new System.Drawing.Point(234, 199);
        KOWonMarkBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        KOWonMarkBar.Name = "KOWonMarkBar";
        KOWonMarkBar.Size = new System.Drawing.Size(492, 60);
        KOWonMarkBar.StatName = "Won Mark";
        KOWonMarkBar.TabIndex = 6;
        // 
        // object_4f1641f2_92c2_46c8_a2b7_2daf7901bc29
        // 
        object_4f1641f2_92c2_46c8_a2b7_2daf7901bc29.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        object_4f1641f2_92c2_46c8_a2b7_2daf7901bc29.Location = new System.Drawing.Point(0, 39);
        object_4f1641f2_92c2_46c8_a2b7_2daf7901bc29.Maximum = 2;
        object_4f1641f2_92c2_46c8_a2b7_2daf7901bc29.Name = "object_4f1641f2_92c2_46c8_a2b7_2daf7901bc29";
        object_4f1641f2_92c2_46c8_a2b7_2daf7901bc29.Size = new System.Drawing.Size(499, 27);
        object_4f1641f2_92c2_46c8_a2b7_2daf7901bc29.TabIndex = 0;
        object_4f1641f2_92c2_46c8_a2b7_2daf7901bc29.Value = 1;
        // 
        // splitCountBar1
        // 
        splitCountBar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        splitCountBar1.Location = new System.Drawing.Point(0, 39);
        splitCountBar1.Maximum = 2;
        splitCountBar1.Name = "splitCountBar1";
        splitCountBar1.Size = new System.Drawing.Size(499, 27);
        splitCountBar1.TabIndex = 0;
        splitCountBar1.Value = 1;
        // 
        // KOWonBreak
        // 
        KOWonBreak.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        KOWonBreak.Controls.Add(object_d764597b_1a89_44bf_90dc_c422991bdb6e);
        KOWonBreak.Controls.Add(splitCountBar2);
        KOWonBreak.Controls.Add(splitCountBar3);
        KOWonBreak.Location = new System.Drawing.Point(234, 267);
        KOWonBreak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        KOWonBreak.Name = "KOWonBreak";
        KOWonBreak.Size = new System.Drawing.Size(492, 60);
        KOWonBreak.StatName = "Won Break";
        KOWonBreak.TabIndex = 7;
        // 
        // object_d764597b_1a89_44bf_90dc_c422991bdb6e
        // 
        object_d764597b_1a89_44bf_90dc_c422991bdb6e.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        object_d764597b_1a89_44bf_90dc_c422991bdb6e.Location = new System.Drawing.Point(0, 39);
        object_d764597b_1a89_44bf_90dc_c422991bdb6e.Maximum = 2;
        object_d764597b_1a89_44bf_90dc_c422991bdb6e.Name = "object_d764597b_1a89_44bf_90dc_c422991bdb6e";
        object_d764597b_1a89_44bf_90dc_c422991bdb6e.Size = new System.Drawing.Size(499, 27);
        object_d764597b_1a89_44bf_90dc_c422991bdb6e.TabIndex = 0;
        object_d764597b_1a89_44bf_90dc_c422991bdb6e.Value = 1;
        // 
        // splitCountBar2
        // 
        splitCountBar2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        splitCountBar2.Location = new System.Drawing.Point(0, 39);
        splitCountBar2.Maximum = 2;
        splitCountBar2.Name = "splitCountBar2";
        splitCountBar2.Size = new System.Drawing.Size(499, 27);
        splitCountBar2.TabIndex = 0;
        splitCountBar2.Value = 1;
        // 
        // splitCountBar3
        // 
        splitCountBar3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        splitCountBar3.Location = new System.Drawing.Point(0, 39);
        splitCountBar3.Maximum = 2;
        splitCountBar3.Name = "splitCountBar3";
        splitCountBar3.Size = new System.Drawing.Size(499, 27);
        splitCountBar3.TabIndex = 0;
        splitCountBar3.Value = 1;
        // 
        // KOLostCleanBar
        // 
        KOLostCleanBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        KOLostCleanBar.Controls.Add(object_dc80317d_725f_498a_a84d_c335d06e7ff7);
        KOLostCleanBar.Controls.Add(splitCountBar4);
        KOLostCleanBar.Controls.Add(splitCountBar5);
        KOLostCleanBar.Controls.Add(splitCountBar6);
        KOLostCleanBar.Location = new System.Drawing.Point(234, 340);
        KOLostCleanBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        KOLostCleanBar.Name = "KOLostCleanBar";
        KOLostCleanBar.Size = new System.Drawing.Size(492, 60);
        KOLostCleanBar.StatName = "Lost Clean";
        KOLostCleanBar.TabIndex = 8;
        // 
        // object_dc80317d_725f_498a_a84d_c335d06e7ff7
        // 
        object_dc80317d_725f_498a_a84d_c335d06e7ff7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        object_dc80317d_725f_498a_a84d_c335d06e7ff7.Location = new System.Drawing.Point(0, 39);
        object_dc80317d_725f_498a_a84d_c335d06e7ff7.Maximum = 2;
        object_dc80317d_725f_498a_a84d_c335d06e7ff7.Name = "object_dc80317d_725f_498a_a84d_c335d06e7ff7";
        object_dc80317d_725f_498a_a84d_c335d06e7ff7.Size = new System.Drawing.Size(499, 27);
        object_dc80317d_725f_498a_a84d_c335d06e7ff7.TabIndex = 0;
        object_dc80317d_725f_498a_a84d_c335d06e7ff7.Value = 1;
        // 
        // splitCountBar4
        // 
        splitCountBar4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        splitCountBar4.Location = new System.Drawing.Point(0, 39);
        splitCountBar4.Maximum = 2;
        splitCountBar4.Name = "splitCountBar4";
        splitCountBar4.Size = new System.Drawing.Size(499, 27);
        splitCountBar4.TabIndex = 0;
        splitCountBar4.Value = 1;
        // 
        // splitCountBar5
        // 
        splitCountBar5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        splitCountBar5.Location = new System.Drawing.Point(0, 39);
        splitCountBar5.Maximum = 2;
        splitCountBar5.Name = "splitCountBar5";
        splitCountBar5.Size = new System.Drawing.Size(499, 27);
        splitCountBar5.TabIndex = 0;
        splitCountBar5.Value = 1;
        // 
        // splitCountBar6
        // 
        splitCountBar6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        splitCountBar6.Location = new System.Drawing.Point(0, 39);
        splitCountBar6.Maximum = 2;
        splitCountBar6.Name = "splitCountBar6";
        splitCountBar6.Size = new System.Drawing.Size(499, 27);
        splitCountBar6.TabIndex = 0;
        splitCountBar6.Value = 1;
        // 
        // KOLostMarkBar
        // 
        KOLostMarkBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        KOLostMarkBar.Controls.Add(object_dcbb98d9_53c9_4165_876e_a29608eedee9);
        KOLostMarkBar.Controls.Add(splitCountBar7);
        KOLostMarkBar.Controls.Add(splitCountBar8);
        KOLostMarkBar.Controls.Add(splitCountBar9);
        KOLostMarkBar.Controls.Add(splitCountBar10);
        KOLostMarkBar.Location = new System.Drawing.Point(234, 413);
        KOLostMarkBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        KOLostMarkBar.Name = "KOLostMarkBar";
        KOLostMarkBar.Size = new System.Drawing.Size(492, 60);
        KOLostMarkBar.StatName = "Lost Mark";
        KOLostMarkBar.TabIndex = 9;
        // 
        // object_dcbb98d9_53c9_4165_876e_a29608eedee9
        // 
        object_dcbb98d9_53c9_4165_876e_a29608eedee9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        object_dcbb98d9_53c9_4165_876e_a29608eedee9.Location = new System.Drawing.Point(0, 39);
        object_dcbb98d9_53c9_4165_876e_a29608eedee9.Maximum = 2;
        object_dcbb98d9_53c9_4165_876e_a29608eedee9.Name = "object_dcbb98d9_53c9_4165_876e_a29608eedee9";
        object_dcbb98d9_53c9_4165_876e_a29608eedee9.Size = new System.Drawing.Size(499, 27);
        object_dcbb98d9_53c9_4165_876e_a29608eedee9.TabIndex = 0;
        object_dcbb98d9_53c9_4165_876e_a29608eedee9.Value = 1;
        // 
        // splitCountBar7
        // 
        splitCountBar7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        splitCountBar7.Location = new System.Drawing.Point(0, 39);
        splitCountBar7.Maximum = 2;
        splitCountBar7.Name = "splitCountBar7";
        splitCountBar7.Size = new System.Drawing.Size(499, 27);
        splitCountBar7.TabIndex = 0;
        splitCountBar7.Value = 1;
        // 
        // splitCountBar8
        // 
        splitCountBar8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        splitCountBar8.Location = new System.Drawing.Point(0, 39);
        splitCountBar8.Maximum = 2;
        splitCountBar8.Name = "splitCountBar8";
        splitCountBar8.Size = new System.Drawing.Size(499, 27);
        splitCountBar8.TabIndex = 0;
        splitCountBar8.Value = 1;
        // 
        // splitCountBar9
        // 
        splitCountBar9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        splitCountBar9.Location = new System.Drawing.Point(0, 39);
        splitCountBar9.Maximum = 2;
        splitCountBar9.Name = "splitCountBar9";
        splitCountBar9.Size = new System.Drawing.Size(499, 27);
        splitCountBar9.TabIndex = 0;
        splitCountBar9.Value = 1;
        // 
        // splitCountBar10
        // 
        splitCountBar10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        splitCountBar10.Location = new System.Drawing.Point(0, 39);
        splitCountBar10.Maximum = 2;
        splitCountBar10.Name = "splitCountBar10";
        splitCountBar10.Size = new System.Drawing.Size(499, 27);
        splitCountBar10.TabIndex = 0;
        splitCountBar10.Value = 1;
        // 
        // KOLostBreakBar
        // 
        KOLostBreakBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        KOLostBreakBar.Controls.Add(object_9cf9d193_b9bf_486f_af84_3eb3afad7171);
        KOLostBreakBar.Controls.Add(splitCountBar11);
        KOLostBreakBar.Controls.Add(splitCountBar12);
        KOLostBreakBar.Controls.Add(splitCountBar13);
        KOLostBreakBar.Controls.Add(splitCountBar14);
        KOLostBreakBar.Controls.Add(splitCountBar15);
        KOLostBreakBar.Location = new System.Drawing.Point(234, 486);
        KOLostBreakBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        KOLostBreakBar.Name = "KOLostBreakBar";
        KOLostBreakBar.Size = new System.Drawing.Size(492, 60);
        KOLostBreakBar.StatName = "Lost Break";
        KOLostBreakBar.TabIndex = 10;
        // 
        // object_9cf9d193_b9bf_486f_af84_3eb3afad7171
        // 
        object_9cf9d193_b9bf_486f_af84_3eb3afad7171.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        object_9cf9d193_b9bf_486f_af84_3eb3afad7171.Location = new System.Drawing.Point(0, 39);
        object_9cf9d193_b9bf_486f_af84_3eb3afad7171.Maximum = 2;
        object_9cf9d193_b9bf_486f_af84_3eb3afad7171.Name = "object_9cf9d193_b9bf_486f_af84_3eb3afad7171";
        object_9cf9d193_b9bf_486f_af84_3eb3afad7171.Size = new System.Drawing.Size(499, 27);
        object_9cf9d193_b9bf_486f_af84_3eb3afad7171.TabIndex = 0;
        object_9cf9d193_b9bf_486f_af84_3eb3afad7171.Value = 1;
        // 
        // splitCountBar11
        // 
        splitCountBar11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        splitCountBar11.Location = new System.Drawing.Point(0, 39);
        splitCountBar11.Maximum = 2;
        splitCountBar11.Name = "splitCountBar11";
        splitCountBar11.Size = new System.Drawing.Size(499, 27);
        splitCountBar11.TabIndex = 0;
        splitCountBar11.Value = 1;
        // 
        // splitCountBar12
        // 
        splitCountBar12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        splitCountBar12.Location = new System.Drawing.Point(0, 39);
        splitCountBar12.Maximum = 2;
        splitCountBar12.Name = "splitCountBar12";
        splitCountBar12.Size = new System.Drawing.Size(499, 27);
        splitCountBar12.TabIndex = 0;
        splitCountBar12.Value = 1;
        // 
        // splitCountBar13
        // 
        splitCountBar13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        splitCountBar13.Location = new System.Drawing.Point(0, 39);
        splitCountBar13.Maximum = 2;
        splitCountBar13.Name = "splitCountBar13";
        splitCountBar13.Size = new System.Drawing.Size(499, 27);
        splitCountBar13.TabIndex = 0;
        splitCountBar13.Value = 1;
        // 
        // splitCountBar14
        // 
        splitCountBar14.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        splitCountBar14.Location = new System.Drawing.Point(0, 39);
        splitCountBar14.Maximum = 2;
        splitCountBar14.Name = "splitCountBar14";
        splitCountBar14.Size = new System.Drawing.Size(499, 27);
        splitCountBar14.TabIndex = 0;
        splitCountBar14.Value = 1;
        // 
        // splitCountBar15
        // 
        splitCountBar15.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        splitCountBar15.Location = new System.Drawing.Point(0, 39);
        splitCountBar15.Maximum = 2;
        splitCountBar15.Name = "splitCountBar15";
        splitCountBar15.Size = new System.Drawing.Size(499, 27);
        splitCountBar15.TabIndex = 0;
        splitCountBar15.Value = 1;
        // 
        // AllStatsView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1902, 1033);
        Controls.Add(KOLostBreakBar);
        Controls.Add(KOLostMarkBar);
        Controls.Add(KOLostCleanBar);
        Controls.Add(KOWonBreak);
        Controls.Add(KOWonMarkBar);
        Controls.Add(KOLabel);
        Controls.Add(KOWonCleanBar);
        Controls.Add(TotalKickoutsBar);
        Controls.Add(pictureBox2);
        Controls.Add(pictureBox1);
        Controls.Add(TeamSelectorBox);
        Text = "AllStatsView";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        KOWonCleanBar.ResumeLayout(false);
        KOWonMarkBar.ResumeLayout(false);
        KOWonBreak.ResumeLayout(false);
        KOLostCleanBar.ResumeLayout(false);
        KOLostMarkBar.ResumeLayout(false);
        KOLostBreakBar.ResumeLayout(false);
        ResumeLayout(false);
    }

    private StatsTracker.View_Elements.StatisticBar TotalKickoutsBar;
    private StatsTracker.View_Elements.StatisticBar KOWonCleanBar;
    private StatsTracker.View_Elements.SplitCountBar StatSplitBar;
    private System.Windows.Forms.Label KOLabel;
    private StatsTracker.View_Elements.StatisticBar KOWonMarkBar;
    private StatsTracker.View_Elements.SplitCountBar object_4f1641f2_92c2_46c8_a2b7_2daf7901bc29;
    private StatsTracker.View_Elements.SplitCountBar splitCountBar1;
    private StatsTracker.View_Elements.StatisticBar KOWonBreak;
    private StatsTracker.View_Elements.SplitCountBar object_d764597b_1a89_44bf_90dc_c422991bdb6e;
    private StatsTracker.View_Elements.SplitCountBar splitCountBar2;
    private StatsTracker.View_Elements.SplitCountBar splitCountBar3;
    private StatsTracker.View_Elements.StatisticBar KOLostCleanBar;
    private StatsTracker.View_Elements.SplitCountBar object_dc80317d_725f_498a_a84d_c335d06e7ff7;
    private StatsTracker.View_Elements.SplitCountBar splitCountBar4;
    private StatsTracker.View_Elements.SplitCountBar splitCountBar5;
    private StatsTracker.View_Elements.SplitCountBar splitCountBar6;
    private StatsTracker.View_Elements.StatisticBar KOLostMarkBar;
    private StatsTracker.View_Elements.SplitCountBar object_dcbb98d9_53c9_4165_876e_a29608eedee9;
    private StatsTracker.View_Elements.SplitCountBar splitCountBar7;
    private StatsTracker.View_Elements.SplitCountBar splitCountBar8;
    private StatsTracker.View_Elements.SplitCountBar splitCountBar9;
    private StatsTracker.View_Elements.SplitCountBar splitCountBar10;
    private StatsTracker.View_Elements.StatisticBar KOLostBreakBar;
    private StatsTracker.View_Elements.SplitCountBar object_9cf9d193_b9bf_486f_af84_3eb3afad7171;
    private StatsTracker.View_Elements.SplitCountBar splitCountBar11;
    private StatsTracker.View_Elements.SplitCountBar splitCountBar12;
    private StatsTracker.View_Elements.SplitCountBar splitCountBar13;
    private StatsTracker.View_Elements.SplitCountBar splitCountBar14;
    private StatsTracker.View_Elements.SplitCountBar splitCountBar15;

    private System.Windows.Forms.PictureBox pictureBox2;

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.ComboBox TeamSelectorBox;

    #endregion
}