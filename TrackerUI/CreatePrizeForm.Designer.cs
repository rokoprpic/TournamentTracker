namespace TrackerUI
{
    partial class CreatePrizeForm
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
            this.createPrizeLabel = new System.Windows.Forms.Label();
            this.prizeNumbeValue = new System.Windows.Forms.TextBox();
            this.placeNumberLabel = new System.Windows.Forms.Label();
            this.prizeNameValue = new System.Windows.Forms.TextBox();
            this.prizeNameLabel = new System.Windows.Forms.Label();
            this.prizePercantageValue = new System.Windows.Forms.TextBox();
            this.prizePercantageLabel = new System.Windows.Forms.Label();
            this.prizeAmountValue = new System.Windows.Forms.TextBox();
            this.prizeAmountLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createPrizeLabel
            // 
            this.createPrizeLabel.AutoSize = true;
            this.createPrizeLabel.Location = new System.Drawing.Point(22, 22);
            this.createPrizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.createPrizeLabel.Name = "createPrizeLabel";
            this.createPrizeLabel.Size = new System.Drawing.Size(69, 15);
            this.createPrizeLabel.TabIndex = 12;
            this.createPrizeLabel.Text = "Create Prize";
            // 
            // prizeNumbeValue
            // 
            this.prizeNumbeValue.Location = new System.Drawing.Point(122, 57);
            this.prizeNumbeValue.Name = "prizeNumbeValue";
            this.prizeNumbeValue.Size = new System.Drawing.Size(137, 23);
            this.prizeNumbeValue.TabIndex = 23;
            // 
            // placeNumberLabel
            // 
            this.placeNumberLabel.AutoSize = true;
            this.placeNumberLabel.Location = new System.Drawing.Point(22, 60);
            this.placeNumberLabel.Name = "placeNumberLabel";
            this.placeNumberLabel.Size = new System.Drawing.Size(79, 15);
            this.placeNumberLabel.TabIndex = 22;
            this.placeNumberLabel.Text = "Prize Number";
            // 
            // prizeNameValue
            // 
            this.prizeNameValue.Location = new System.Drawing.Point(122, 95);
            this.prizeNameValue.Name = "prizeNameValue";
            this.prizeNameValue.Size = new System.Drawing.Size(137, 23);
            this.prizeNameValue.TabIndex = 25;
            // 
            // prizeNameLabel
            // 
            this.prizeNameLabel.AutoSize = true;
            this.prizeNameLabel.Location = new System.Drawing.Point(22, 98);
            this.prizeNameLabel.Name = "prizeNameLabel";
            this.prizeNameLabel.Size = new System.Drawing.Size(67, 15);
            this.prizeNameLabel.TabIndex = 24;
            this.prizeNameLabel.Text = "Prize Name";
            // 
            // prizePercantageValue
            // 
            this.prizePercantageValue.Location = new System.Drawing.Point(122, 207);
            this.prizePercantageValue.Name = "prizePercantageValue";
            this.prizePercantageValue.Size = new System.Drawing.Size(137, 23);
            this.prizePercantageValue.TabIndex = 29;
            // 
            // prizePercantageLabel
            // 
            this.prizePercantageLabel.AutoSize = true;
            this.prizePercantageLabel.Location = new System.Drawing.Point(22, 210);
            this.prizePercantageLabel.Name = "prizePercantageLabel";
            this.prizePercantageLabel.Size = new System.Drawing.Size(94, 15);
            this.prizePercantageLabel.TabIndex = 28;
            this.prizePercantageLabel.Text = "Prize Percantage";
            // 
            // prizeAmountValue
            // 
            this.prizeAmountValue.Location = new System.Drawing.Point(122, 137);
            this.prizeAmountValue.Name = "prizeAmountValue";
            this.prizeAmountValue.Size = new System.Drawing.Size(137, 23);
            this.prizeAmountValue.TabIndex = 27;
            // 
            // prizeAmountLabel
            // 
            this.prizeAmountLabel.AutoSize = true;
            this.prizeAmountLabel.Location = new System.Drawing.Point(22, 140);
            this.prizeAmountLabel.Name = "prizeAmountLabel";
            this.prizeAmountLabel.Size = new System.Drawing.Size(79, 15);
            this.prizeAmountLabel.TabIndex = 26;
            this.prizeAmountLabel.Text = "Prize Amount";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Location = new System.Drawing.Point(122, 179);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(34, 15);
            this.orLabel.TabIndex = 30;
            this.orLabel.Text = "- or -";
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.Location = new System.Drawing.Point(66, 266);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(151, 23);
            this.createPrizeButton.TabIndex = 31;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 324);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.prizePercantageValue);
            this.Controls.Add(this.prizePercantageLabel);
            this.Controls.Add(this.prizeAmountValue);
            this.Controls.Add(this.prizeAmountLabel);
            this.Controls.Add(this.prizeNameValue);
            this.Controls.Add(this.prizeNameLabel);
            this.Controls.Add(this.prizeNumbeValue);
            this.Controls.Add(this.placeNumberLabel);
            this.Controls.Add(this.createPrizeLabel);
            this.Name = "CreatePrizeForm";
            this.Text = "Create Prize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label createPrizeLabel;
        private TextBox prizeNumbeValue;
        private Label placeNumberLabel;
        private TextBox prizeNameValue;
        private Label prizeNameLabel;
        private TextBox prizePercantageValue;
        private Label prizePercantageLabel;
        private TextBox prizeAmountValue;
        private Label prizeAmountLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}