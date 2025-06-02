using System.ComponentModel;

namespace StatsTracker.Views.Graphs;

partial class PlayerPerformanceChart
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
        TeamComboBox = new System.Windows.Forms.ComboBox();
        PlayerComboBox = new System.Windows.Forms.ComboBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        label8 = new System.Windows.Forms.Label();
        label9 = new System.Windows.Forms.Label();
        pictureBox2 = new System.Windows.Forms.PictureBox();
        pictureBox3 = new System.Windows.Forms.PictureBox();
        pictureBox4 = new System.Windows.Forms.PictureBox();
        pictureBox5 = new System.Windows.Forms.PictureBox();
        pictureBox6 = new System.Windows.Forms.PictureBox();
        pictureBox7 = new System.Windows.Forms.PictureBox();
        pictureBox8 = new System.Windows.Forms.PictureBox();
        pictureBox9 = new System.Windows.Forms.PictureBox();
        pictureBox10 = new System.Windows.Forms.PictureBox();
        pictureBox11 = new System.Windows.Forms.PictureBox();
        pictureBox12 = new System.Windows.Forms.PictureBox();
        pictureBox13 = new System.Windows.Forms.PictureBox();
        pictureBox14 = new System.Windows.Forms.PictureBox();
        label10 = new System.Windows.Forms.Label();
        label11 = new System.Windows.Forms.Label();
        label12 = new System.Windows.Forms.Label();
        FHTOWon = new System.Windows.Forms.Label();
        FHTOLost = new System.Windows.Forms.Label();
        FHKOWon = new System.Windows.Forms.Label();
        FHPointScored = new System.Windows.Forms.Label();
        FH2PointScored = new System.Windows.Forms.Label();
        FHGoalScored = new System.Windows.Forms.Label();
        FHMisses = new System.Windows.Forms.Label();
        FHFrees = new System.Windows.Forms.Label();
        FHScoreableFrees = new System.Windows.Forms.Label();
        SHMisses = new System.Windows.Forms.Label();
        SHGoalScored = new System.Windows.Forms.Label();
        SH2PointScored = new System.Windows.Forms.Label();
        SHPointScored = new System.Windows.Forms.Label();
        SHKOWon = new System.Windows.Forms.Label();
        SHTOLost = new System.Windows.Forms.Label();
        SHTOWon = new System.Windows.Forms.Label();
        SHScoreableFrees = new System.Windows.Forms.Label();
        SHFrees = new System.Windows.Forms.Label();
        TOTFrees = new System.Windows.Forms.Label();
        TOTMisses = new System.Windows.Forms.Label();
        TOTGoalScored = new System.Windows.Forms.Label();
        TOT2PointScored = new System.Windows.Forms.Label();
        TOTPointScored = new System.Windows.Forms.Label();
        TOTKOWon = new System.Windows.Forms.Label();
        TOTTOLost = new System.Windows.Forms.Label();
        TOTTOWon = new System.Windows.Forms.Label();
        TOTScoreableFrees = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
        SuspendLayout();
        // 
        // TeamComboBox
        // 
        TeamComboBox.FormattingEnabled = true;
        TeamComboBox.Location = new System.Drawing.Point(516, 10);
        TeamComboBox.Name = "TeamComboBox";
        TeamComboBox.Size = new System.Drawing.Size(200, 28);
        TeamComboBox.TabIndex = 1;
        // 
        // PlayerComboBox
        // 
        PlayerComboBox.FormattingEnabled = true;
        PlayerComboBox.Location = new System.Drawing.Point(722, 10);
        PlayerComboBox.Name = "PlayerComboBox";
        PlayerComboBox.Size = new System.Drawing.Size(200, 28);
        PlayerComboBox.TabIndex = 2;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        label1.Location = new System.Drawing.Point(516, 99);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(197, 32);
        label1.TabIndex = 3;
        label1.Text = "Turnovers Won";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        label2.Location = new System.Drawing.Point(516, 151);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(197, 32);
        label2.TabIndex = 4;
        label2.Text = "Turnovers Lost";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        label3.Location = new System.Drawing.Point(516, 203);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(197, 32);
        label3.TabIndex = 5;
        label3.Text = "Kickouts Won";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        label4.Location = new System.Drawing.Point(516, 255);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(197, 32);
        label4.TabIndex = 6;
        label4.Text = "Points Scored";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        label5.Location = new System.Drawing.Point(516, 307);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(207, 32);
        label5.TabIndex = 7;
        label5.Text = "2-Points Scored";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        label6.Location = new System.Drawing.Point(513, 359);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(197, 32);
        label6.TabIndex = 8;
        label6.Text = "Goals Scored";
        label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label7
        // 
        label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        label7.Location = new System.Drawing.Point(516, 411);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(197, 32);
        label7.TabIndex = 9;
        label7.Text = "Misses";
        label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label8
        // 
        label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        label8.Location = new System.Drawing.Point(516, 515);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(207, 32);
        label8.TabIndex = 10;
        label8.Text = "Scoreable Frees";
        label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label9
        // 
        label9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        label9.Location = new System.Drawing.Point(516, 458);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(207, 32);
        label9.TabIndex = 11;
        label9.Text = "Frees Conceded";
        label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // pictureBox2
        // 
        pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        pictureBox2.Location = new System.Drawing.Point(513, 82);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new System.Drawing.Size(596, 14);
        pictureBox2.TabIndex = 12;
        pictureBox2.TabStop = false;
        // 
        // pictureBox3
        // 
        pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        pictureBox3.Location = new System.Drawing.Point(513, 134);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new System.Drawing.Size(596, 14);
        pictureBox3.TabIndex = 13;
        pictureBox3.TabStop = false;
        // 
        // pictureBox4
        // 
        pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        pictureBox4.Location = new System.Drawing.Point(513, 186);
        pictureBox4.Name = "pictureBox4";
        pictureBox4.Size = new System.Drawing.Size(596, 14);
        pictureBox4.TabIndex = 14;
        pictureBox4.TabStop = false;
        // 
        // pictureBox5
        // 
        pictureBox5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        pictureBox5.Location = new System.Drawing.Point(513, 238);
        pictureBox5.Name = "pictureBox5";
        pictureBox5.Size = new System.Drawing.Size(596, 14);
        pictureBox5.TabIndex = 15;
        pictureBox5.TabStop = false;
        // 
        // pictureBox6
        // 
        pictureBox6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        pictureBox6.Location = new System.Drawing.Point(513, 290);
        pictureBox6.Name = "pictureBox6";
        pictureBox6.Size = new System.Drawing.Size(596, 14);
        pictureBox6.TabIndex = 16;
        pictureBox6.TabStop = false;
        // 
        // pictureBox7
        // 
        pictureBox7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        pictureBox7.Location = new System.Drawing.Point(513, 342);
        pictureBox7.Name = "pictureBox7";
        pictureBox7.Size = new System.Drawing.Size(596, 14);
        pictureBox7.TabIndex = 17;
        pictureBox7.TabStop = false;
        // 
        // pictureBox8
        // 
        pictureBox8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        pictureBox8.Location = new System.Drawing.Point(513, 394);
        pictureBox8.Name = "pictureBox8";
        pictureBox8.Size = new System.Drawing.Size(596, 14);
        pictureBox8.TabIndex = 18;
        pictureBox8.TabStop = false;
        // 
        // pictureBox9
        // 
        pictureBox9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        pictureBox9.Location = new System.Drawing.Point(513, 446);
        pictureBox9.Name = "pictureBox9";
        pictureBox9.Size = new System.Drawing.Size(596, 14);
        pictureBox9.TabIndex = 19;
        pictureBox9.TabStop = false;
        // 
        // pictureBox10
        // 
        pictureBox10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        pictureBox10.Location = new System.Drawing.Point(513, 498);
        pictureBox10.Name = "pictureBox10";
        pictureBox10.Size = new System.Drawing.Size(596, 14);
        pictureBox10.TabIndex = 20;
        pictureBox10.TabStop = false;
        // 
        // pictureBox11
        // 
        pictureBox11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        pictureBox11.Location = new System.Drawing.Point(513, 550);
        pictureBox11.Name = "pictureBox11";
        pictureBox11.Size = new System.Drawing.Size(596, 14);
        pictureBox11.TabIndex = 21;
        pictureBox11.TabStop = false;
        // 
        // pictureBox12
        // 
        pictureBox12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        pictureBox12.Location = new System.Drawing.Point(722, 90);
        pictureBox12.Name = "pictureBox12";
        pictureBox12.Size = new System.Drawing.Size(13, 474);
        pictureBox12.TabIndex = 22;
        pictureBox12.TabStop = false;
        // 
        // pictureBox13
        // 
        pictureBox13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        pictureBox13.Location = new System.Drawing.Point(853, 90);
        pictureBox13.Name = "pictureBox13";
        pictureBox13.Size = new System.Drawing.Size(13, 474);
        pictureBox13.TabIndex = 23;
        pictureBox13.TabStop = false;
        // 
        // pictureBox14
        // 
        pictureBox14.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        pictureBox14.Location = new System.Drawing.Point(984, 90);
        pictureBox14.Name = "pictureBox14";
        pictureBox14.Size = new System.Drawing.Size(13, 474);
        pictureBox14.TabIndex = 24;
        pictureBox14.TabStop = false;
        // 
        // label10
        // 
        label10.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        label10.Location = new System.Drawing.Point(762, 47);
        label10.Name = "label10";
        label10.Size = new System.Drawing.Size(58, 32);
        label10.TabIndex = 25;
        label10.Text = "1st";
        label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label11
        // 
        label11.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        label11.Location = new System.Drawing.Point(891, 47);
        label11.Name = "label11";
        label11.Size = new System.Drawing.Size(63, 32);
        label11.TabIndex = 26;
        label11.Text = "2nd";
        label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label12
        // 
        label12.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        label12.Location = new System.Drawing.Point(1014, 47);
        label12.Name = "label12";
        label12.Size = new System.Drawing.Size(83, 32);
        label12.TabIndex = 27;
        label12.Text = "Total";
        label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // FHTOWon
        // 
        FHTOWon.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        FHTOWon.Location = new System.Drawing.Point(741, 99);
        FHTOWon.Name = "FHTOWon";
        FHTOWon.Size = new System.Drawing.Size(106, 32);
        FHTOWon.TabIndex = 28;
        FHTOWon.Text = "00";
        FHTOWon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // FHTOLost
        // 
        FHTOLost.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        FHTOLost.Location = new System.Drawing.Point(741, 151);
        FHTOLost.Name = "FHTOLost";
        FHTOLost.Size = new System.Drawing.Size(106, 32);
        FHTOLost.TabIndex = 29;
        FHTOLost.Text = "00";
        FHTOLost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // FHKOWon
        // 
        FHKOWon.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        FHKOWon.Location = new System.Drawing.Point(741, 203);
        FHKOWon.Name = "FHKOWon";
        FHKOWon.Size = new System.Drawing.Size(106, 32);
        FHKOWon.TabIndex = 30;
        FHKOWon.Text = "00";
        FHKOWon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // FHPointScored
        // 
        FHPointScored.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        FHPointScored.Location = new System.Drawing.Point(741, 255);
        FHPointScored.Name = "FHPointScored";
        FHPointScored.Size = new System.Drawing.Size(106, 32);
        FHPointScored.TabIndex = 31;
        FHPointScored.Text = "00";
        FHPointScored.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // FH2PointScored
        // 
        FH2PointScored.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        FH2PointScored.Location = new System.Drawing.Point(741, 307);
        FH2PointScored.Name = "FH2PointScored";
        FH2PointScored.Size = new System.Drawing.Size(106, 32);
        FH2PointScored.TabIndex = 32;
        FH2PointScored.Text = "00";
        FH2PointScored.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // FHGoalScored
        // 
        FHGoalScored.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        FHGoalScored.Location = new System.Drawing.Point(741, 359);
        FHGoalScored.Name = "FHGoalScored";
        FHGoalScored.Size = new System.Drawing.Size(106, 32);
        FHGoalScored.TabIndex = 33;
        FHGoalScored.Text = "00";
        FHGoalScored.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // FHMisses
        // 
        FHMisses.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        FHMisses.Location = new System.Drawing.Point(741, 411);
        FHMisses.Name = "FHMisses";
        FHMisses.Size = new System.Drawing.Size(106, 32);
        FHMisses.TabIndex = 34;
        FHMisses.Text = "00";
        FHMisses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // FHFrees
        // 
        FHFrees.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        FHFrees.Location = new System.Drawing.Point(741, 463);
        FHFrees.Name = "FHFrees";
        FHFrees.Size = new System.Drawing.Size(106, 32);
        FHFrees.TabIndex = 35;
        FHFrees.Text = "00";
        FHFrees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // FHScoreableFrees
        // 
        FHScoreableFrees.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        FHScoreableFrees.Location = new System.Drawing.Point(741, 515);
        FHScoreableFrees.Name = "FHScoreableFrees";
        FHScoreableFrees.Size = new System.Drawing.Size(106, 32);
        FHScoreableFrees.TabIndex = 36;
        FHScoreableFrees.Text = "00";
        FHScoreableFrees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // SHMisses
        // 
        SHMisses.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        SHMisses.Location = new System.Drawing.Point(872, 411);
        SHMisses.Name = "SHMisses";
        SHMisses.Size = new System.Drawing.Size(106, 32);
        SHMisses.TabIndex = 37;
        SHMisses.Text = "00";
        SHMisses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // SHGoalScored
        // 
        SHGoalScored.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        SHGoalScored.Location = new System.Drawing.Point(872, 359);
        SHGoalScored.Name = "SHGoalScored";
        SHGoalScored.Size = new System.Drawing.Size(106, 32);
        SHGoalScored.TabIndex = 38;
        SHGoalScored.Text = "00";
        SHGoalScored.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // SH2PointScored
        // 
        SH2PointScored.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        SH2PointScored.Location = new System.Drawing.Point(872, 307);
        SH2PointScored.Name = "SH2PointScored";
        SH2PointScored.Size = new System.Drawing.Size(106, 32);
        SH2PointScored.TabIndex = 39;
        SH2PointScored.Text = "00";
        SH2PointScored.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // SHPointScored
        // 
        SHPointScored.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        SHPointScored.Location = new System.Drawing.Point(872, 255);
        SHPointScored.Name = "SHPointScored";
        SHPointScored.Size = new System.Drawing.Size(106, 32);
        SHPointScored.TabIndex = 40;
        SHPointScored.Text = "00";
        SHPointScored.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // SHKOWon
        // 
        SHKOWon.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        SHKOWon.Location = new System.Drawing.Point(872, 203);
        SHKOWon.Name = "SHKOWon";
        SHKOWon.Size = new System.Drawing.Size(106, 32);
        SHKOWon.TabIndex = 41;
        SHKOWon.Text = "00";
        SHKOWon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // SHTOLost
        // 
        SHTOLost.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        SHTOLost.Location = new System.Drawing.Point(872, 151);
        SHTOLost.Name = "SHTOLost";
        SHTOLost.Size = new System.Drawing.Size(106, 32);
        SHTOLost.TabIndex = 42;
        SHTOLost.Text = "00";
        SHTOLost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // SHTOWon
        // 
        SHTOWon.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        SHTOWon.Location = new System.Drawing.Point(872, 99);
        SHTOWon.Name = "SHTOWon";
        SHTOWon.Size = new System.Drawing.Size(106, 32);
        SHTOWon.TabIndex = 43;
        SHTOWon.Text = "00";
        SHTOWon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // SHScoreableFrees
        // 
        SHScoreableFrees.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        SHScoreableFrees.Location = new System.Drawing.Point(872, 515);
        SHScoreableFrees.Name = "SHScoreableFrees";
        SHScoreableFrees.Size = new System.Drawing.Size(106, 32);
        SHScoreableFrees.TabIndex = 44;
        SHScoreableFrees.Text = "00";
        SHScoreableFrees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // SHFrees
        // 
        SHFrees.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        SHFrees.Location = new System.Drawing.Point(872, 463);
        SHFrees.Name = "SHFrees";
        SHFrees.Size = new System.Drawing.Size(106, 32);
        SHFrees.TabIndex = 45;
        SHFrees.Text = "00";
        SHFrees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // TOTFrees
        // 
        TOTFrees.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        TOTFrees.Location = new System.Drawing.Point(1003, 463);
        TOTFrees.Name = "TOTFrees";
        TOTFrees.Size = new System.Drawing.Size(106, 32);
        TOTFrees.TabIndex = 46;
        TOTFrees.Text = "00";
        TOTFrees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // TOTMisses
        // 
        TOTMisses.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        TOTMisses.Location = new System.Drawing.Point(1003, 411);
        TOTMisses.Name = "TOTMisses";
        TOTMisses.Size = new System.Drawing.Size(106, 32);
        TOTMisses.TabIndex = 47;
        TOTMisses.Text = "00";
        TOTMisses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // TOTGoalScored
        // 
        TOTGoalScored.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        TOTGoalScored.Location = new System.Drawing.Point(1003, 359);
        TOTGoalScored.Name = "TOTGoalScored";
        TOTGoalScored.Size = new System.Drawing.Size(106, 32);
        TOTGoalScored.TabIndex = 48;
        TOTGoalScored.Text = "00";
        TOTGoalScored.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // TOT2PointScored
        // 
        TOT2PointScored.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        TOT2PointScored.Location = new System.Drawing.Point(1003, 307);
        TOT2PointScored.Name = "TOT2PointScored";
        TOT2PointScored.Size = new System.Drawing.Size(106, 32);
        TOT2PointScored.TabIndex = 49;
        TOT2PointScored.Text = "00";
        TOT2PointScored.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // TOTPointScored
        // 
        TOTPointScored.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        TOTPointScored.Location = new System.Drawing.Point(1003, 255);
        TOTPointScored.Name = "TOTPointScored";
        TOTPointScored.Size = new System.Drawing.Size(106, 32);
        TOTPointScored.TabIndex = 50;
        TOTPointScored.Text = "00";
        TOTPointScored.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // TOTKOWon
        // 
        TOTKOWon.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        TOTKOWon.Location = new System.Drawing.Point(1003, 203);
        TOTKOWon.Name = "TOTKOWon";
        TOTKOWon.Size = new System.Drawing.Size(106, 32);
        TOTKOWon.TabIndex = 51;
        TOTKOWon.Text = "00";
        TOTKOWon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // TOTTOLost
        // 
        TOTTOLost.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        TOTTOLost.Location = new System.Drawing.Point(1003, 151);
        TOTTOLost.Name = "TOTTOLost";
        TOTTOLost.Size = new System.Drawing.Size(106, 32);
        TOTTOLost.TabIndex = 52;
        TOTTOLost.Text = "00";
        TOTTOLost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // TOTTOWon
        // 
        TOTTOWon.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        TOTTOWon.Location = new System.Drawing.Point(1003, 99);
        TOTTOWon.Name = "TOTTOWon";
        TOTTOWon.Size = new System.Drawing.Size(106, 32);
        TOTTOWon.TabIndex = 53;
        TOTTOWon.Text = "00";
        TOTTOWon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // TOTScoreableFrees
        // 
        TOTScoreableFrees.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        TOTScoreableFrees.Location = new System.Drawing.Point(1003, 515);
        TOTScoreableFrees.Name = "TOTScoreableFrees";
        TOTScoreableFrees.Size = new System.Drawing.Size(106, 32);
        TOTScoreableFrees.TabIndex = 54;
        TOTScoreableFrees.Text = "00";
        TOTScoreableFrees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // PlayerPerformanceChart
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1182, 568);
        Controls.Add(TOTScoreableFrees);
        Controls.Add(TOTTOWon);
        Controls.Add(TOTTOLost);
        Controls.Add(TOTKOWon);
        Controls.Add(TOTPointScored);
        Controls.Add(TOT2PointScored);
        Controls.Add(TOTGoalScored);
        Controls.Add(TOTMisses);
        Controls.Add(TOTFrees);
        Controls.Add(SHFrees);
        Controls.Add(SHScoreableFrees);
        Controls.Add(SHTOWon);
        Controls.Add(SHTOLost);
        Controls.Add(SHKOWon);
        Controls.Add(SHPointScored);
        Controls.Add(SH2PointScored);
        Controls.Add(SHGoalScored);
        Controls.Add(SHMisses);
        Controls.Add(FHScoreableFrees);
        Controls.Add(FHFrees);
        Controls.Add(FHMisses);
        Controls.Add(FHGoalScored);
        Controls.Add(FH2PointScored);
        Controls.Add(FHPointScored);
        Controls.Add(FHKOWon);
        Controls.Add(FHTOLost);
        Controls.Add(FHTOWon);
        Controls.Add(label12);
        Controls.Add(label11);
        Controls.Add(label10);
        Controls.Add(pictureBox14);
        Controls.Add(pictureBox13);
        Controls.Add(pictureBox12);
        Controls.Add(pictureBox11);
        Controls.Add(pictureBox10);
        Controls.Add(pictureBox9);
        Controls.Add(pictureBox8);
        Controls.Add(pictureBox7);
        Controls.Add(pictureBox6);
        Controls.Add(pictureBox5);
        Controls.Add(pictureBox4);
        Controls.Add(pictureBox3);
        Controls.Add(pictureBox2);
        Controls.Add(label9);
        Controls.Add(label8);
        Controls.Add(label7);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(PlayerComboBox);
        Controls.Add(TeamComboBox);
        Text = "PlayerPerformanceChart";
        Load += PlayerPerformanceChart_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.PictureBox pictureBox4;
    private System.Windows.Forms.PictureBox pictureBox5;
    private System.Windows.Forms.PictureBox pictureBox6;
    private System.Windows.Forms.PictureBox pictureBox7;
    private System.Windows.Forms.PictureBox pictureBox8;
    private System.Windows.Forms.PictureBox pictureBox9;
    private System.Windows.Forms.PictureBox pictureBox10;
    private System.Windows.Forms.PictureBox pictureBox11;
    private System.Windows.Forms.PictureBox pictureBox12;
    private System.Windows.Forms.PictureBox pictureBox13;
    private System.Windows.Forms.PictureBox pictureBox14;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label FHTOWon;
    private System.Windows.Forms.Label FHTOLost;
    private System.Windows.Forms.Label FHKOWon;
    private System.Windows.Forms.Label FHPointScored;
    private System.Windows.Forms.Label FH2PointScored;
    private System.Windows.Forms.Label FHGoalScored;
    private System.Windows.Forms.Label FHMisses;
    private System.Windows.Forms.Label FHFrees;
    private System.Windows.Forms.Label FHScoreableFrees;
    private System.Windows.Forms.Label SHMisses;
    private System.Windows.Forms.Label SHGoalScored;
    private System.Windows.Forms.Label SH2PointScored;
    private System.Windows.Forms.Label SHPointScored;
    private System.Windows.Forms.Label SHKOWon;
    private System.Windows.Forms.Label SHTOLost;
    private System.Windows.Forms.Label SHTOWon;
    private System.Windows.Forms.Label SHScoreableFrees;
    private System.Windows.Forms.Label SHFrees;
    private System.Windows.Forms.Label TOTFrees;
    private System.Windows.Forms.Label TOTMisses;
    private System.Windows.Forms.Label TOTGoalScored;
    private System.Windows.Forms.Label TOT2PointScored;
    private System.Windows.Forms.Label TOTPointScored;
    private System.Windows.Forms.Label TOTKOWon;
    private System.Windows.Forms.Label TOTTOLost;
    private System.Windows.Forms.Label TOTTOWon;
    private System.Windows.Forms.Label TOTScoreableFrees;

    private System.Windows.Forms.PictureBox pictureBox2;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;

    private System.Windows.Forms.ComboBox TeamComboBox;
    private System.Windows.Forms.ComboBox PlayerComboBox;
    private System.Windows.Forms.Label label1;

    #endregion
}