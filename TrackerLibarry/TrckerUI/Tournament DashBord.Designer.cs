namespace TrckerUI
{
    partial class Tournament_DashBord
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
            this.SelectTeamMemberComboBox = new System.Windows.Forms.ComboBox();
            this.SelectTeamMemberLabel = new System.Windows.Forms.Label();
            this.CreateTeamHeaderLabel = new System.Windows.Forms.Label();
            this.Load_TournamentButton = new System.Windows.Forms.Button();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectTeamMemberComboBox
            // 
            this.SelectTeamMemberComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamMemberComboBox.FormattingEnabled = true;
            this.SelectTeamMemberComboBox.Location = new System.Drawing.Point(290, 167);
            this.SelectTeamMemberComboBox.Name = "SelectTeamMemberComboBox";
            this.SelectTeamMemberComboBox.Size = new System.Drawing.Size(351, 36);
            this.SelectTeamMemberComboBox.TabIndex = 31;
            // 
            // SelectTeamMemberLabel
            // 
            this.SelectTeamMemberLabel.AutoSize = true;
            this.SelectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.SelectTeamMemberLabel.Location = new System.Drawing.Point(320, 132);
            this.SelectTeamMemberLabel.Name = "SelectTeamMemberLabel";
            this.SelectTeamMemberLabel.Size = new System.Drawing.Size(290, 32);
            this.SelectTeamMemberLabel.TabIndex = 30;
            this.SelectTeamMemberLabel.Text = "Load Existing Tournament";
            // 
            // CreateTeamHeaderLabel
            // 
            this.CreateTeamHeaderLabel.AutoSize = true;
            this.CreateTeamHeaderLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTeamHeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTeamHeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTeamHeaderLabel.Location = new System.Drawing.Point(233, 46);
            this.CreateTeamHeaderLabel.Name = "CreateTeamHeaderLabel";
            this.CreateTeamHeaderLabel.Size = new System.Drawing.Size(477, 65);
            this.CreateTeamHeaderLabel.TabIndex = 29;
            this.CreateTeamHeaderLabel.Text = "TournaMent DashBord";
            // 
            // Load_TournamentButton
            // 
            this.Load_TournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Load_TournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Load_TournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Load_TournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Load_TournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_TournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Load_TournamentButton.Location = new System.Drawing.Point(315, 223);
            this.Load_TournamentButton.Name = "Load_TournamentButton";
            this.Load_TournamentButton.Size = new System.Drawing.Size(301, 51);
            this.Load_TournamentButton.TabIndex = 33;
            this.Load_TournamentButton.Text = "Load Tournament";
            this.Load_TournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTournamentButton.Location = new System.Drawing.Point(163, 299);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(604, 68);
            this.CreateTournamentButton.TabIndex = 34;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // Tournament_DashBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(952, 419);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.Load_TournamentButton);
            this.Controls.Add(this.SelectTeamMemberComboBox);
            this.Controls.Add(this.SelectTeamMemberLabel);
            this.Controls.Add(this.CreateTeamHeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Tournament_DashBord";
            this.Text = "Tournament_DashBord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectTeamMemberComboBox;
        private System.Windows.Forms.Label SelectTeamMemberLabel;
        private System.Windows.Forms.Label CreateTeamHeaderLabel;
        private System.Windows.Forms.Button Load_TournamentButton;
        private System.Windows.Forms.Button CreateTournamentButton;
    }
}