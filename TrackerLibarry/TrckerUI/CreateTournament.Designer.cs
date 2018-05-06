namespace TrckerUI
{
    partial class CreateTournament
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournament));
            this.CreateTournamntHeaderLabel = new System.Windows.Forms.Label();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.EntryFeeTextBox = new System.Windows.Forms.TextBox();
            this.EntryFeeLabel = new System.Windows.Forms.Label();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.SelectTeamLinkLabel = new System.Windows.Forms.LinkLabel();
            this.AddTeamButton = new System.Windows.Forms.Button();
            this.CreateTeamButton = new System.Windows.Forms.Button();
            this.teamPlayerlabel = new System.Windows.Forms.Label();
            this.TournamentPlayerListBox = new System.Windows.Forms.ListBox();
            this.deleteSeletedTeamPlayeButton = new System.Windows.Forms.Button();
            this.DeleteSletedPrizwButton = new System.Windows.Forms.Button();
            this.PrizeListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SelectTeamComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CreateTournamntHeaderLabel
            // 
            this.CreateTournamntHeaderLabel.AutoSize = true;
            this.CreateTournamntHeaderLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamntHeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournamntHeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTournamntHeaderLabel.Location = new System.Drawing.Point(39, 9);
            this.CreateTournamntHeaderLabel.Name = "CreateTournamntHeaderLabel";
            this.CreateTournamntHeaderLabel.Size = new System.Drawing.Size(396, 65);
            this.CreateTournamntHeaderLabel.TabIndex = 1;
            this.CreateTournamntHeaderLabel.Text = "Create Tornament:";
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTextBox.Location = new System.Drawing.Point(61, 132);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(302, 31);
            this.scoreTextBox.TabIndex = 10;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ScoreLabel.Location = new System.Drawing.Point(55, 97);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(215, 32);
            this.ScoreLabel.TabIndex = 9;
            this.ScoreLabel.Text = "Tournament Name";
            // 
            // EntryFeeTextBox
            // 
            this.EntryFeeTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryFeeTextBox.Location = new System.Drawing.Point(168, 189);
            this.EntryFeeTextBox.Name = "EntryFeeTextBox";
            this.EntryFeeTextBox.Size = new System.Drawing.Size(143, 31);
            this.EntryFeeTextBox.TabIndex = 12;
            // 
            // EntryFeeLabel
            // 
            this.EntryFeeLabel.AutoSize = true;
            this.EntryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryFeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.EntryFeeLabel.Location = new System.Drawing.Point(55, 187);
            this.EntryFeeLabel.Name = "EntryFeeLabel";
            this.EntryFeeLabel.Size = new System.Drawing.Size(119, 32);
            this.EntryFeeLabel.TabIndex = 11;
            this.EntryFeeLabel.Text = "Entry Fee:";
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.SelectTeamLabel.Location = new System.Drawing.Point(55, 236);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(153, 32);
            this.SelectTeamLabel.TabIndex = 13;
            this.SelectTeamLabel.Text = "Select Teams";
            // 
            // SelectTeamLinkLabel
            // 
            this.SelectTeamLinkLabel.AutoSize = true;
            this.SelectTeamLinkLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamLinkLabel.Location = new System.Drawing.Point(264, 243);
            this.SelectTeamLinkLabel.Name = "SelectTeamLinkLabel";
            this.SelectTeamLinkLabel.Size = new System.Drawing.Size(99, 23);
            this.SelectTeamLinkLabel.TabIndex = 15;
            this.SelectTeamLinkLabel.TabStop = true;
            this.SelectTeamLinkLabel.Text = "Create New";
            this.SelectTeamLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SelectTeamLinkLabel_LinkClicked);
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.AddTeamButton.Location = new System.Drawing.Point(100, 311);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(195, 51);
            this.AddTeamButton.TabIndex = 17;
            this.AddTeamButton.Text = "Add Team";
            this.AddTeamButton.UseVisualStyleBackColor = true;
            this.AddTeamButton.Click += new System.EventHandler(this.AddTeamButton_Click);
            // 
            // CreateTeamButton
            // 
            this.CreateTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTeamButton.Location = new System.Drawing.Point(100, 382);
            this.CreateTeamButton.Name = "CreateTeamButton";
            this.CreateTeamButton.Size = new System.Drawing.Size(195, 51);
            this.CreateTeamButton.TabIndex = 18;
            this.CreateTeamButton.Text = "Create Prize";
            this.CreateTeamButton.UseVisualStyleBackColor = true;
            this.CreateTeamButton.Click += new System.EventHandler(this.CreateTeamButton_Click);
            // 
            // teamPlayerlabel
            // 
            this.teamPlayerlabel.AutoSize = true;
            this.teamPlayerlabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamPlayerlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamPlayerlabel.Location = new System.Drawing.Point(432, 97);
            this.teamPlayerlabel.Name = "teamPlayerlabel";
            this.teamPlayerlabel.Size = new System.Drawing.Size(159, 32);
            this.teamPlayerlabel.TabIndex = 19;
            this.teamPlayerlabel.Text = "Team / Player";
            // 
            // TournamentPlayerListBox
            // 
            this.TournamentPlayerListBox.FormattingEnabled = true;
            this.TournamentPlayerListBox.ItemHeight = 31;
            this.TournamentPlayerListBox.Location = new System.Drawing.Point(438, 132);
            this.TournamentPlayerListBox.Name = "TournamentPlayerListBox";
            this.TournamentPlayerListBox.Size = new System.Drawing.Size(250, 128);
            this.TournamentPlayerListBox.TabIndex = 20;
            // 
            // deleteSeletedTeamPlayeButton
            // 
            this.deleteSeletedTeamPlayeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSeletedTeamPlayeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSeletedTeamPlayeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSeletedTeamPlayeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSeletedTeamPlayeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSeletedTeamPlayeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteSeletedTeamPlayeButton.Location = new System.Drawing.Point(694, 143);
            this.deleteSeletedTeamPlayeButton.Name = "deleteSeletedTeamPlayeButton";
            this.deleteSeletedTeamPlayeButton.Size = new System.Drawing.Size(174, 92);
            this.deleteSeletedTeamPlayeButton.TabIndex = 21;
            this.deleteSeletedTeamPlayeButton.Text = "Remove Selected";
            this.deleteSeletedTeamPlayeButton.UseVisualStyleBackColor = true;
            this.deleteSeletedTeamPlayeButton.Click += new System.EventHandler(this.deleteSeletedTeamPlayeButton_Click);
            // 
            // DeleteSletedPrizwButton
            // 
            this.DeleteSletedPrizwButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteSletedPrizwButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeleteSletedPrizwButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteSletedPrizwButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSletedPrizwButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSletedPrizwButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.DeleteSletedPrizwButton.Location = new System.Drawing.Point(694, 341);
            this.DeleteSletedPrizwButton.Name = "DeleteSletedPrizwButton";
            this.DeleteSletedPrizwButton.Size = new System.Drawing.Size(174, 92);
            this.DeleteSletedPrizwButton.TabIndex = 24;
            this.DeleteSletedPrizwButton.Text = "Remove Selected";
            this.DeleteSletedPrizwButton.UseVisualStyleBackColor = true;
            this.DeleteSletedPrizwButton.Click += new System.EventHandler(this.DeleteSletedPrizwButton_Click);
            // 
            // PrizeListBox
            // 
            this.PrizeListBox.FormattingEnabled = true;
            this.PrizeListBox.ItemHeight = 31;
            this.PrizeListBox.Location = new System.Drawing.Point(438, 330);
            this.PrizeListBox.Name = "PrizeListBox";
            this.PrizeListBox.Size = new System.Drawing.Size(250, 128);
            this.PrizeListBox.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(432, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Prizes";
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.BackColor = System.Drawing.Color.White;
            this.CreateTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTournamentButton.Location = new System.Drawing.Point(240, 473);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(434, 66);
            this.CreateTournamentButton.TabIndex = 25;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = false;
            this.CreateTournamentButton.Click += new System.EventHandler(this.CreateTournamentButton_Click);
            // 
            // SelectTeamComboBox
            // 
            this.SelectTeamComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamComboBox.FormattingEnabled = true;
            this.SelectTeamComboBox.Location = new System.Drawing.Point(61, 269);
            this.SelectTeamComboBox.Name = "SelectTeamComboBox";
            this.SelectTeamComboBox.Size = new System.Drawing.Size(302, 36);
            this.SelectTeamComboBox.TabIndex = 26;
            // 
            // CreateTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 552);
            this.Controls.Add(this.SelectTeamComboBox);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.DeleteSletedPrizwButton);
            this.Controls.Add(this.PrizeListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteSeletedTeamPlayeButton);
            this.Controls.Add(this.TournamentPlayerListBox);
            this.Controls.Add(this.teamPlayerlabel);
            this.Controls.Add(this.CreateTeamButton);
            this.Controls.Add(this.AddTeamButton);
            this.Controls.Add(this.SelectTeamLinkLabel);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.EntryFeeTextBox);
            this.Controls.Add(this.EntryFeeLabel);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.CreateTournamntHeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateTournament";
            this.Text = "CreateTournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateTournamntHeaderLabel;
        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.TextBox EntryFeeTextBox;
        private System.Windows.Forms.Label EntryFeeLabel;
        private System.Windows.Forms.Label SelectTeamLabel;
        private System.Windows.Forms.LinkLabel SelectTeamLinkLabel;
        private System.Windows.Forms.Button AddTeamButton;
        private System.Windows.Forms.Button CreateTeamButton;
        private System.Windows.Forms.Label teamPlayerlabel;
        private System.Windows.Forms.ListBox TournamentPlayerListBox;
        private System.Windows.Forms.Button deleteSeletedTeamPlayeButton;
        private System.Windows.Forms.Button DeleteSletedPrizwButton;
        private System.Windows.Forms.ListBox PrizeListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateTournamentButton;
        private System.Windows.Forms.ComboBox SelectTeamComboBox;
    }
}