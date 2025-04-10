using System.ComponentModel;

namespace StatsTracker.Views;

partial class CreateMatchView
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
        HomeTeamDropDown = new System.Windows.Forms.ComboBox();
        label1 = new System.Windows.Forms.Label();
        TeamColorSelector = new System.Windows.Forms.ColorDialog();
        HomeTeamSetColor = new System.Windows.Forms.Button();
        HomeTeamPlayersListBox = new System.Windows.Forms.ListBox();
        HomeMoveUp = new System.Windows.Forms.Button();
        HomeTeamMoveDown = new System.Windows.Forms.Button();
        PlayersList = new System.Windows.Forms.ListBox();
        TeamDropdown = new System.Windows.Forms.ComboBox();
        AwayMoveDown = new System.Windows.Forms.Button();
        AwayMoveUp = new System.Windows.Forms.Button();
        AwayTeamPlayersList = new System.Windows.Forms.ListBox();
        AwayTeamSetColor = new System.Windows.Forms.Button();
        label2 = new System.Windows.Forms.Label();
        AwayTeamDropDown = new System.Windows.Forms.ComboBox();
        MoveToHome = new System.Windows.Forms.Button();
        MoveToAway = new System.Windows.Forms.Button();
        HomeTeamColorBox = new System.Windows.Forms.PictureBox();
        AwayTeamColorBox = new System.Windows.Forms.PictureBox();
        AddPlayer = new System.Windows.Forms.Button();
        AddTeam = new System.Windows.Forms.Button();
        AddTeamTextBox = new System.Windows.Forms.TextBox();
        AddPlayerTextBox = new System.Windows.Forms.TextBox();
        CreateMatchBtn = new System.Windows.Forms.Button();
        CancelBtn = new System.Windows.Forms.Button();
        HomeRemovePlayer = new System.Windows.Forms.Button();
        AwayRemovePlayer = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)HomeTeamColorBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)AwayTeamColorBox).BeginInit();
        SuspendLayout();
        // 
        // HomeTeamDropDown
        // 
        HomeTeamDropDown.FormattingEnabled = true;
        HomeTeamDropDown.Location = new System.Drawing.Point(10, 51);
        HomeTeamDropDown.Name = "HomeTeamDropDown";
        HomeTeamDropDown.Size = new System.Drawing.Size(178, 23);
        HomeTeamDropDown.TabIndex = 0;
        HomeTeamDropDown.SelectedIndexChanged += HomeTeamDropDown_SelectedIndexChanged;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        label1.Location = new System.Drawing.Point(10, 14);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(178, 27);
        label1.TabIndex = 1;
        label1.Text = "Home Team";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // TeamColorSelector
        // 
        TeamColorSelector.Color = System.Drawing.Color.Gray;
        // 
        // HomeTeamSetColor
        // 
        HomeTeamSetColor.Location = new System.Drawing.Point(194, 82);
        HomeTeamSetColor.Name = "HomeTeamSetColor";
        HomeTeamSetColor.Size = new System.Drawing.Size(104, 23);
        HomeTeamSetColor.TabIndex = 2;
        HomeTeamSetColor.Text = "Color";
        HomeTeamSetColor.UseVisualStyleBackColor = true;
        HomeTeamSetColor.MouseClick += HomeTeamSetColor_MouseClick;
        // 
        // HomeTeamPlayersListBox
        // 
        HomeTeamPlayersListBox.FormattingEnabled = true;
        HomeTeamPlayersListBox.ItemHeight = 15;
        HomeTeamPlayersListBox.Location = new System.Drawing.Point(10, 82);
        HomeTeamPlayersListBox.Name = "HomeTeamPlayersListBox";
        HomeTeamPlayersListBox.Size = new System.Drawing.Size(178, 319);
        HomeTeamPlayersListBox.TabIndex = 3;
        // 
        // HomeMoveUp
        // 
        HomeMoveUp.Location = new System.Drawing.Point(194, 129);
        HomeMoveUp.Name = "HomeMoveUp";
        HomeMoveUp.Size = new System.Drawing.Size(104, 23);
        HomeMoveUp.TabIndex = 4;
        HomeMoveUp.Text = "Move Up";
        HomeMoveUp.UseVisualStyleBackColor = true;
        HomeMoveUp.MouseClick += HomeMoveUp_MouseClick;
        // 
        // HomeTeamMoveDown
        // 
        HomeTeamMoveDown.Location = new System.Drawing.Point(194, 158);
        HomeTeamMoveDown.Name = "HomeTeamMoveDown";
        HomeTeamMoveDown.Size = new System.Drawing.Size(104, 23);
        HomeTeamMoveDown.TabIndex = 5;
        HomeTeamMoveDown.Text = "Move Down";
        HomeTeamMoveDown.UseVisualStyleBackColor = true;
        HomeTeamMoveDown.MouseClick += HomeTeamMoveDown_MouseClick;
        // 
        // PlayersList
        // 
        PlayersList.FormattingEnabled = true;
        PlayersList.ItemHeight = 15;
        PlayersList.Location = new System.Drawing.Point(304, 82);
        PlayersList.Name = "PlayersList";
        PlayersList.Size = new System.Drawing.Size(178, 319);
        PlayersList.TabIndex = 7;
        // 
        // TeamDropdown
        // 
        TeamDropdown.FormattingEnabled = true;
        TeamDropdown.Location = new System.Drawing.Point(304, 51);
        TeamDropdown.Name = "TeamDropdown";
        TeamDropdown.Size = new System.Drawing.Size(178, 23);
        TeamDropdown.TabIndex = 6;
        TeamDropdown.SelectedIndexChanged += TeamDropdown_SelectedIndexChanged;
        // 
        // AwayMoveDown
        // 
        AwayMoveDown.Location = new System.Drawing.Point(488, 158);
        AwayMoveDown.Name = "AwayMoveDown";
        AwayMoveDown.Size = new System.Drawing.Size(104, 23);
        AwayMoveDown.TabIndex = 13;
        AwayMoveDown.Text = "Move Down";
        AwayMoveDown.UseVisualStyleBackColor = true;
        AwayMoveDown.MouseClick += AwayMoveDown_MouseClick;
        // 
        // AwayMoveUp
        // 
        AwayMoveUp.Location = new System.Drawing.Point(488, 129);
        AwayMoveUp.Name = "AwayMoveUp";
        AwayMoveUp.Size = new System.Drawing.Size(104, 23);
        AwayMoveUp.TabIndex = 12;
        AwayMoveUp.Text = "Move Up";
        AwayMoveUp.UseVisualStyleBackColor = true;
        AwayMoveUp.MouseClick += AwayMoveUp_MouseClick;
        // 
        // AwayTeamPlayersList
        // 
        AwayTeamPlayersList.FormattingEnabled = true;
        AwayTeamPlayersList.ItemHeight = 15;
        AwayTeamPlayersList.Location = new System.Drawing.Point(598, 82);
        AwayTeamPlayersList.Name = "AwayTeamPlayersList";
        AwayTeamPlayersList.Size = new System.Drawing.Size(178, 319);
        AwayTeamPlayersList.TabIndex = 11;
        // 
        // AwayTeamSetColor
        // 
        AwayTeamSetColor.Location = new System.Drawing.Point(488, 83);
        AwayTeamSetColor.Name = "AwayTeamSetColor";
        AwayTeamSetColor.Size = new System.Drawing.Size(104, 23);
        AwayTeamSetColor.TabIndex = 10;
        AwayTeamSetColor.Text = "Color";
        AwayTeamSetColor.UseVisualStyleBackColor = true;
        AwayTeamSetColor.MouseClick += AwayTeamSetColor_MouseClick;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        label2.Location = new System.Drawing.Point(598, 14);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(178, 27);
        label2.TabIndex = 9;
        label2.Text = "Away Team";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // AwayTeamDropDown
        // 
        AwayTeamDropDown.FormattingEnabled = true;
        AwayTeamDropDown.Location = new System.Drawing.Point(598, 51);
        AwayTeamDropDown.Name = "AwayTeamDropDown";
        AwayTeamDropDown.Size = new System.Drawing.Size(178, 23);
        AwayTeamDropDown.TabIndex = 8;
        AwayTeamDropDown.SelectedIndexChanged += AwayTeamDropDown_SelectedIndexChanged;
        // 
        // MoveToHome
        // 
        MoveToHome.Location = new System.Drawing.Point(304, 407);
        MoveToHome.Name = "MoveToHome";
        MoveToHome.Size = new System.Drawing.Size(51, 23);
        MoveToHome.TabIndex = 14;
        MoveToHome.Text = "<-";
        MoveToHome.UseVisualStyleBackColor = true;
        MoveToHome.MouseClick += MoveToHome_MouseClick;
        // 
        // MoveToAway
        // 
        MoveToAway.Location = new System.Drawing.Point(431, 407);
        MoveToAway.Name = "MoveToAway";
        MoveToAway.Size = new System.Drawing.Size(51, 23);
        MoveToAway.TabIndex = 15;
        MoveToAway.Text = "->";
        MoveToAway.UseVisualStyleBackColor = true;
        MoveToAway.MouseClick += MoveToAway_MouseClick;
        // 
        // HomeTeamColorBox
        // 
        HomeTeamColorBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        HomeTeamColorBox.Location = new System.Drawing.Point(194, 51);
        HomeTeamColorBox.Name = "HomeTeamColorBox";
        HomeTeamColorBox.Size = new System.Drawing.Size(103, 22);
        HomeTeamColorBox.TabIndex = 16;
        HomeTeamColorBox.TabStop = false;
        // 
        // AwayTeamColorBox
        // 
        AwayTeamColorBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        AwayTeamColorBox.Location = new System.Drawing.Point(488, 51);
        AwayTeamColorBox.Name = "AwayTeamColorBox";
        AwayTeamColorBox.Size = new System.Drawing.Size(104, 22);
        AwayTeamColorBox.TabIndex = 17;
        AwayTeamColorBox.TabStop = false;
        // 
        // AddPlayer
        // 
        AddPlayer.Location = new System.Drawing.Point(486, 465);
        AddPlayer.Name = "AddPlayer";
        AddPlayer.Size = new System.Drawing.Size(104, 23);
        AddPlayer.TabIndex = 19;
        AddPlayer.Text = "Add Player";
        AddPlayer.UseVisualStyleBackColor = true;
        AddPlayer.MouseClick += AddPlayer_MouseClick;
        // 
        // AddTeam
        // 
        AddTeam.Location = new System.Drawing.Point(488, 437);
        AddTeam.Name = "AddTeam";
        AddTeam.Size = new System.Drawing.Size(104, 23);
        AddTeam.TabIndex = 20;
        AddTeam.Text = "Add Team";
        AddTeam.UseVisualStyleBackColor = true;
        AddTeam.MouseClick += AddTeam_MouseClick;
        // 
        // AddTeamTextBox
        // 
        AddTeamTextBox.Location = new System.Drawing.Point(304, 436);
        AddTeamTextBox.Name = "AddTeamTextBox";
        AddTeamTextBox.Size = new System.Drawing.Size(178, 23);
        AddTeamTextBox.TabIndex = 21;
        // 
        // AddPlayerTextBox
        // 
        AddPlayerTextBox.Location = new System.Drawing.Point(304, 465);
        AddPlayerTextBox.Name = "AddPlayerTextBox";
        AddPlayerTextBox.Size = new System.Drawing.Size(178, 23);
        AddPlayerTextBox.TabIndex = 22;
        // 
        // CreateMatchBtn
        // 
        CreateMatchBtn.BackColor = System.Drawing.Color.PaleGreen;
        CreateMatchBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        CreateMatchBtn.ForeColor = System.Drawing.SystemColors.ControlText;
        CreateMatchBtn.Location = new System.Drawing.Point(10, 505);
        CreateMatchBtn.Name = "CreateMatchBtn";
        CreateMatchBtn.Size = new System.Drawing.Size(286, 33);
        CreateMatchBtn.TabIndex = 23;
        CreateMatchBtn.Text = "Create Match";
        CreateMatchBtn.UseVisualStyleBackColor = false;
        CreateMatchBtn.MouseClick += CreateMatchBtn_MouseClick;
        // 
        // CancelBtn
        // 
        CancelBtn.BackColor = System.Drawing.Color.Tomato;
        CancelBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        CancelBtn.ForeColor = System.Drawing.SystemColors.ControlText;
        CancelBtn.Location = new System.Drawing.Point(490, 505);
        CancelBtn.Name = "CancelBtn";
        CancelBtn.Size = new System.Drawing.Size(286, 33);
        CancelBtn.TabIndex = 24;
        CancelBtn.Text = "Cancel";
        CancelBtn.UseVisualStyleBackColor = false;
        CancelBtn.MouseClick += CancelBtn_MouseClick;
        // 
        // HomeRemovePlayer
        // 
        HomeRemovePlayer.Location = new System.Drawing.Point(194, 187);
        HomeRemovePlayer.Name = "HomeRemovePlayer";
        HomeRemovePlayer.Size = new System.Drawing.Size(104, 23);
        HomeRemovePlayer.TabIndex = 25;
        HomeRemovePlayer.Text = "Remove Player";
        HomeRemovePlayer.UseVisualStyleBackColor = true;
        HomeRemovePlayer.MouseClick += HomeRemovePlayer_MouseClick;
        // 
        // AwayRemovePlayer
        // 
        AwayRemovePlayer.Location = new System.Drawing.Point(490, 187);
        AwayRemovePlayer.Name = "AwayRemovePlayer";
        AwayRemovePlayer.Size = new System.Drawing.Size(104, 23);
        AwayRemovePlayer.TabIndex = 26;
        AwayRemovePlayer.Text = "Remove Player";
        AwayRemovePlayer.UseVisualStyleBackColor = true;
        AwayRemovePlayer.MouseClick += AwayRemovePlayer_MouseClick;
        // 
        // CreateMatchView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(786, 546);
        Controls.Add(AwayRemovePlayer);
        Controls.Add(HomeRemovePlayer);
        Controls.Add(CancelBtn);
        Controls.Add(CreateMatchBtn);
        Controls.Add(AddPlayerTextBox);
        Controls.Add(AddTeamTextBox);
        Controls.Add(AddTeam);
        Controls.Add(AddPlayer);
        Controls.Add(AwayTeamColorBox);
        Controls.Add(HomeTeamColorBox);
        Controls.Add(MoveToAway);
        Controls.Add(MoveToHome);
        Controls.Add(AwayMoveDown);
        Controls.Add(AwayMoveUp);
        Controls.Add(AwayTeamPlayersList);
        Controls.Add(AwayTeamSetColor);
        Controls.Add(label2);
        Controls.Add(AwayTeamDropDown);
        Controls.Add(PlayersList);
        Controls.Add(TeamDropdown);
        Controls.Add(HomeTeamMoveDown);
        Controls.Add(HomeMoveUp);
        Controls.Add(HomeTeamPlayersListBox);
        Controls.Add(HomeTeamSetColor);
        Controls.Add(label1);
        Controls.Add(HomeTeamDropDown);
        Text = "Create Match";
        ((System.ComponentModel.ISupportInitialize)HomeTeamColorBox).EndInit();
        ((System.ComponentModel.ISupportInitialize)AwayTeamColorBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button HomeRemovePlayer;
    private System.Windows.Forms.Button AwayRemovePlayer;

    private System.Windows.Forms.Button CreateMatchBtn;

    private System.Windows.Forms.Button CancelBtn;

    private System.Windows.Forms.TextBox AddPlayerTextBox;

    private System.Windows.Forms.Button AddPlayer;

    private System.Windows.Forms.TextBox AddTeamTextBox;
    private System.Windows.Forms.Button AddTeam;

    private System.Windows.Forms.PictureBox HomeTeamColorBox;

    private System.Windows.Forms.PictureBox AwayTeamColorBox;

    private System.Windows.Forms.Button MoveToHome;
    private System.Windows.Forms.Button MoveToAway;

    private System.Windows.Forms.ListBox PlayersList;
    private System.Windows.Forms.ComboBox TeamDropdown;
    private System.Windows.Forms.Button AwayMoveDown;
    private System.Windows.Forms.Button AwayMoveUp;
    private System.Windows.Forms.ListBox AwayTeamPlayersList;
    private System.Windows.Forms.Button AwayTeamSetColor;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox AwayTeamDropDown;

    private System.Windows.Forms.Button HomeMoveUp;
    private System.Windows.Forms.Button HomeTeamMoveDown;

    private System.Windows.Forms.ListBox HomeTeamPlayersListBox;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ColorDialog TeamColorSelector;
    private System.Windows.Forms.Button HomeTeamSetColor;

    private System.Windows.Forms.ComboBox HomeTeamDropDown;

    #endregion
}