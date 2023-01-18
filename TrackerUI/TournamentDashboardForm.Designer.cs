namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            this.loadTournamentDropDown = new System.Windows.Forms.ComboBox();
            this.loadTournamentLabel = new System.Windows.Forms.Label();
            this.tournamentDashboardLable = new System.Windows.Forms.Label();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadTournamentDropDown
            // 
            this.loadTournamentDropDown.FormattingEnabled = true;
            this.loadTournamentDropDown.Location = new System.Drawing.Point(65, 116);
            this.loadTournamentDropDown.Name = "loadTournamentDropDown";
            this.loadTournamentDropDown.Size = new System.Drawing.Size(211, 23);
            this.loadTournamentDropDown.TabIndex = 8;
            // 
            // loadTournamentLabel
            // 
            this.loadTournamentLabel.AutoSize = true;
            this.loadTournamentLabel.Location = new System.Drawing.Point(122, 86);
            this.loadTournamentLabel.Name = "loadTournamentLabel";
            this.loadTournamentLabel.Size = new System.Drawing.Size(100, 15);
            this.loadTournamentLabel.TabIndex = 7;
            this.loadTournamentLabel.Text = "Load Tournament";
            // 
            // tournamentDashboardLable
            // 
            this.tournamentDashboardLable.AutoSize = true;
            this.tournamentDashboardLable.Location = new System.Drawing.Point(103, 25);
            this.tournamentDashboardLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tournamentDashboardLable.Name = "tournamentDashboardLable";
            this.tournamentDashboardLable.Size = new System.Drawing.Size(131, 15);
            this.tournamentDashboardLable.TabIndex = 5;
            this.tournamentDashboardLable.Text = "Tournament Dashboard";
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.Location = new System.Drawing.Point(94, 156);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(151, 23);
            this.loadTournamentButton.TabIndex = 26;
            this.loadTournamentButton.Text = "Load Tournament";
            this.loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.Location = new System.Drawing.Point(94, 227);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(151, 23);
            this.createTournamentButton.TabIndex = 27;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 314);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.loadTournamentDropDown);
            this.Controls.Add(this.loadTournamentLabel);
            this.Controls.Add(this.tournamentDashboardLable);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournamnet Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox loadTournamentDropDown;
        private Label loadTournamentLabel;
        private Label tournamentDashboardLable;
        private Button loadTournamentButton;
        private Button createTournamentButton;
    }
}