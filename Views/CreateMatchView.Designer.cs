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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(CreateMatchView));
        HomeTeamDropDown = new ComboBox();
        label1 = new Label();
        TeamColorSelector = new ColorDialog();
        HomeTeamSetColor = new Button();
        HomeTeamPlayersListBox = new ListBox();
        HomeMoveUp = new Button();
        HomeTeamMoveDown = new Button();
        PlayersList = new ListBox();
        TeamDropdown = new ComboBox();
        AwayMoveDown = new Button();
        AwayMoveUp = new Button();
        AwayTeamPlayersList = new ListBox();
        AwayTeamSetColor = new Button();
        label2 = new Label();
        AwayTeamDropDown = new ComboBox();
        MoveToHome = new Button();
        MoveToAway = new Button();
        HomeTeamColorBox = new PictureBox();
        AwayTeamColorBox = new PictureBox();
        AddPlayer = new Button();
        AddTeam = new Button();
        AddTeamTextBox = new TextBox();
        AddPlayerTextBox = new TextBox();
        CreateMatchBtn = new Button();
        CancelBtn = new Button();
        HomeRemovePlayer = new Button();
        AwayRemovePlayer = new Button();
        ((ISupportInitialize)HomeTeamColorBox).BeginInit();
        ((ISupportInitialize)AwayTeamColorBox).BeginInit();
        SuspendLayout();
        // 
        // HomeTeamDropDown
        // 
        HomeTeamDropDown.FormattingEnabled = true;
        HomeTeamDropDown.Location = new Point(8, 41);
        HomeTeamDropDown.Margin = new Padding(2);
        HomeTeamDropDown.Name = "HomeTeamDropDown";
        HomeTeamDropDown.Size = new Size(143, 23);
        HomeTeamDropDown.TabIndex = 0;
        HomeTeamDropDown.SelectedIndexChanged += HomeTeamDropDown_SelectedIndexChanged;
        // 
        // label1
        // 
        label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        label1.Location = new Point(8, 5);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(142, 28);
        label1.TabIndex = 1;
        label1.Text = "Home Team";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // TeamColorSelector
        // 
        TeamColorSelector.Color = Color.Gray;
        // 
        // HomeTeamSetColor
        // 
        HomeTeamSetColor.Location = new Point(155, 66);
        HomeTeamSetColor.Margin = new Padding(2);
        HomeTeamSetColor.Name = "HomeTeamSetColor";
        HomeTeamSetColor.Size = new Size(83, 19);
        HomeTeamSetColor.TabIndex = 2;
        HomeTeamSetColor.Text = "Color";
        HomeTeamSetColor.UseVisualStyleBackColor = true;
        HomeTeamSetColor.MouseClick += HomeTeamSetColor_MouseClick;
        // 
        // HomeTeamPlayersListBox
        // 
        HomeTeamPlayersListBox.FormattingEnabled = true;
        HomeTeamPlayersListBox.Location = new Point(8, 66);
        HomeTeamPlayersListBox.Margin = new Padding(2);
        HomeTeamPlayersListBox.Name = "HomeTeamPlayersListBox";
        HomeTeamPlayersListBox.Size = new Size(143, 244);
        HomeTeamPlayersListBox.TabIndex = 3;
        // 
        // HomeMoveUp
        // 
        HomeMoveUp.Location = new Point(155, 103);
        HomeMoveUp.Margin = new Padding(2);
        HomeMoveUp.Name = "HomeMoveUp";
        HomeMoveUp.Size = new Size(83, 22);
        HomeMoveUp.TabIndex = 4;
        HomeMoveUp.Text = "Move Up";
        HomeMoveUp.UseVisualStyleBackColor = true;
        HomeMoveUp.MouseClick += HomeMoveUp_MouseClick;
        // 
        // HomeTeamMoveDown
        // 
        HomeTeamMoveDown.Location = new Point(155, 126);
        HomeTeamMoveDown.Margin = new Padding(2);
        HomeTeamMoveDown.Name = "HomeTeamMoveDown";
        HomeTeamMoveDown.Size = new Size(83, 24);
        HomeTeamMoveDown.TabIndex = 5;
        HomeTeamMoveDown.Text = "Move Down";
        HomeTeamMoveDown.UseVisualStyleBackColor = true;
        HomeTeamMoveDown.MouseClick += HomeTeamMoveDown_MouseClick;
        // 
        // PlayersList
        // 
        PlayersList.FormattingEnabled = true;
        PlayersList.Location = new Point(243, 66);
        PlayersList.Margin = new Padding(2);
        PlayersList.Name = "PlayersList";
        PlayersList.Size = new Size(143, 244);
        PlayersList.TabIndex = 7;
        // 
        // TeamDropdown
        // 
        TeamDropdown.FormattingEnabled = true;
        TeamDropdown.Location = new Point(243, 41);
        TeamDropdown.Margin = new Padding(2);
        TeamDropdown.Name = "TeamDropdown";
        TeamDropdown.Size = new Size(143, 23);
        TeamDropdown.TabIndex = 6;
        TeamDropdown.SelectedIndexChanged += TeamDropdown_SelectedIndexChanged;
        // 
        // AwayMoveDown
        // 
        AwayMoveDown.Location = new Point(390, 126);
        AwayMoveDown.Margin = new Padding(2);
        AwayMoveDown.Name = "AwayMoveDown";
        AwayMoveDown.Size = new Size(83, 24);
        AwayMoveDown.TabIndex = 13;
        AwayMoveDown.Text = "Move Down";
        AwayMoveDown.UseVisualStyleBackColor = true;
        AwayMoveDown.MouseClick += AwayMoveDown_MouseClick;
        // 
        // AwayMoveUp
        // 
        AwayMoveUp.Location = new Point(390, 103);
        AwayMoveUp.Margin = new Padding(2);
        AwayMoveUp.Name = "AwayMoveUp";
        AwayMoveUp.Size = new Size(83, 22);
        AwayMoveUp.TabIndex = 12;
        AwayMoveUp.Text = "Move Up";
        AwayMoveUp.UseVisualStyleBackColor = true;
        AwayMoveUp.MouseClick += AwayMoveUp_MouseClick;
        // 
        // AwayTeamPlayersList
        // 
        AwayTeamPlayersList.FormattingEnabled = true;
        AwayTeamPlayersList.Location = new Point(478, 66);
        AwayTeamPlayersList.Margin = new Padding(2);
        AwayTeamPlayersList.Name = "AwayTeamPlayersList";
        AwayTeamPlayersList.Size = new Size(143, 244);
        AwayTeamPlayersList.TabIndex = 11;
        // 
        // AwayTeamSetColor
        // 
        AwayTeamSetColor.Location = new Point(390, 66);
        AwayTeamSetColor.Margin = new Padding(2);
        AwayTeamSetColor.Name = "AwayTeamSetColor";
        AwayTeamSetColor.Size = new Size(83, 19);
        AwayTeamSetColor.TabIndex = 10;
        AwayTeamSetColor.Text = "Color";
        AwayTeamSetColor.UseVisualStyleBackColor = true;
        AwayTeamSetColor.MouseClick += AwayTeamSetColor_MouseClick;
        // 
        // label2
        // 
        label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        label2.Location = new Point(478, 5);
        label2.Margin = new Padding(2, 0, 2, 0);
        label2.Name = "label2";
        label2.Size = new Size(142, 28);
        label2.TabIndex = 9;
        label2.Text = "Away Team";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // AwayTeamDropDown
        // 
        AwayTeamDropDown.FormattingEnabled = true;
        AwayTeamDropDown.Location = new Point(478, 41);
        AwayTeamDropDown.Margin = new Padding(2);
        AwayTeamDropDown.Name = "AwayTeamDropDown";
        AwayTeamDropDown.Size = new Size(143, 23);
        AwayTeamDropDown.TabIndex = 8;
        AwayTeamDropDown.SelectedIndexChanged += AwayTeamDropDown_SelectedIndexChanged;
        // 
        // MoveToHome
        // 
        MoveToHome.Location = new Point(243, 326);
        MoveToHome.Margin = new Padding(2);
        MoveToHome.Name = "MoveToHome";
        MoveToHome.Size = new Size(41, 18);
        MoveToHome.TabIndex = 14;
        MoveToHome.Text = "<-";
        MoveToHome.UseVisualStyleBackColor = true;
        MoveToHome.MouseClick += MoveToHome_MouseClick;
        // 
        // MoveToAway
        // 
        MoveToAway.Location = new Point(345, 326);
        MoveToAway.Margin = new Padding(2);
        MoveToAway.Name = "MoveToAway";
        MoveToAway.Size = new Size(41, 18);
        MoveToAway.TabIndex = 15;
        MoveToAway.Text = "->";
        MoveToAway.UseVisualStyleBackColor = true;
        MoveToAway.MouseClick += MoveToAway_MouseClick;
        // 
        // HomeTeamColorBox
        // 
        HomeTeamColorBox.BackColor = SystemColors.ActiveCaptionText;
        HomeTeamColorBox.Location = new Point(155, 41);
        HomeTeamColorBox.Margin = new Padding(2);
        HomeTeamColorBox.Name = "HomeTeamColorBox";
        HomeTeamColorBox.Size = new Size(82, 18);
        HomeTeamColorBox.TabIndex = 16;
        HomeTeamColorBox.TabStop = false;
        // 
        // AwayTeamColorBox
        // 
        AwayTeamColorBox.BackColor = SystemColors.ActiveCaptionText;
        AwayTeamColorBox.Location = new Point(390, 41);
        AwayTeamColorBox.Margin = new Padding(2);
        AwayTeamColorBox.Name = "AwayTeamColorBox";
        AwayTeamColorBox.Size = new Size(83, 18);
        AwayTeamColorBox.TabIndex = 17;
        AwayTeamColorBox.TabStop = false;
        // 
        // AddPlayer
        // 
        AddPlayer.Location = new Point(389, 372);
        AddPlayer.Margin = new Padding(2);
        AddPlayer.Name = "AddPlayer";
        AddPlayer.Size = new Size(83, 22);
        AddPlayer.TabIndex = 19;
        AddPlayer.Text = "Add Player";
        AddPlayer.UseVisualStyleBackColor = true;
        AddPlayer.MouseClick += AddPlayer_MouseClick;
        // 
        // AddTeam
        // 
        AddTeam.Location = new Point(390, 350);
        AddTeam.Margin = new Padding(2);
        AddTeam.Name = "AddTeam";
        AddTeam.Size = new Size(83, 21);
        AddTeam.TabIndex = 20;
        AddTeam.Text = "Add Team";
        AddTeam.UseVisualStyleBackColor = true;
        AddTeam.MouseClick += AddTeam_MouseClick;
        // 
        // AddTeamTextBox
        // 
        AddTeamTextBox.Location = new Point(243, 349);
        AddTeamTextBox.Margin = new Padding(2);
        AddTeamTextBox.Name = "AddTeamTextBox";
        AddTeamTextBox.Size = new Size(143, 23);
        AddTeamTextBox.TabIndex = 21;
        // 
        // AddPlayerTextBox
        // 
        AddPlayerTextBox.Location = new Point(243, 372);
        AddPlayerTextBox.Margin = new Padding(2);
        AddPlayerTextBox.Name = "AddPlayerTextBox";
        AddPlayerTextBox.Size = new Size(143, 23);
        AddPlayerTextBox.TabIndex = 22;
        // 
        // CreateMatchBtn
        // 
        CreateMatchBtn.BackColor = Color.PaleGreen;
        CreateMatchBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        CreateMatchBtn.ForeColor = SystemColors.ControlText;
        CreateMatchBtn.Location = new Point(8, 396);
        CreateMatchBtn.Margin = new Padding(2);
        CreateMatchBtn.Name = "CreateMatchBtn";
        CreateMatchBtn.Size = new Size(229, 34);
        CreateMatchBtn.TabIndex = 23;
        CreateMatchBtn.Text = "Create Match";
        CreateMatchBtn.UseVisualStyleBackColor = false;
        CreateMatchBtn.MouseClick += CreateMatchBtn_MouseClick;
        // 
        // CancelBtn
        // 
        CancelBtn.BackColor = Color.Tomato;
        CancelBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        CancelBtn.ForeColor = SystemColors.ControlText;
        CancelBtn.Location = new Point(392, 396);
        CancelBtn.Margin = new Padding(2);
        CancelBtn.Name = "CancelBtn";
        CancelBtn.Size = new Size(229, 34);
        CancelBtn.TabIndex = 24;
        CancelBtn.Text = "Cancel";
        CancelBtn.UseVisualStyleBackColor = false;
        CancelBtn.MouseClick += CancelBtn_MouseClick;
        // 
        // HomeRemovePlayer
        // 
        HomeRemovePlayer.Location = new Point(155, 155);
        HomeRemovePlayer.Margin = new Padding(2);
        HomeRemovePlayer.Name = "HomeRemovePlayer";
        HomeRemovePlayer.Size = new Size(83, 22);
        HomeRemovePlayer.TabIndex = 25;
        HomeRemovePlayer.Text = "Remove Player";
        HomeRemovePlayer.UseVisualStyleBackColor = true;
        HomeRemovePlayer.MouseClick += HomeRemovePlayer_MouseClick;
        // 
        // AwayRemovePlayer
        // 
        AwayRemovePlayer.Location = new Point(392, 155);
        AwayRemovePlayer.Margin = new Padding(2);
        AwayRemovePlayer.Name = "AwayRemovePlayer";
        AwayRemovePlayer.Size = new Size(83, 22);
        AwayRemovePlayer.TabIndex = 26;
        AwayRemovePlayer.Text = "Remove Player";
        AwayRemovePlayer.UseVisualStyleBackColor = true;
        AwayRemovePlayer.MouseClick += AwayRemovePlayer_MouseClick;
        // 
        // CreateMatchView
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        AutoSizeMode = AutoSizeMode.GrowAndShrink;
        ClientSize = new Size(629, 437);
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
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(2, 3, 2, 3);
        MaximizeBox = false;
        MaximumSize = new Size(645, 476);
        MinimizeBox = false;
        MinimumSize = new Size(645, 476);
        Name = "CreateMatchView";
        Text = "Create Match";
        ((ISupportInitialize)HomeTeamColorBox).EndInit();
        ((ISupportInitialize)AwayTeamColorBox).EndInit();
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