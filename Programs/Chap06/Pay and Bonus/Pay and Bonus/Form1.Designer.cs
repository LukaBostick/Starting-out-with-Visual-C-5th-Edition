namespace Pay_and_Bonus
{
    partial class Form1
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
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.contributionLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.bonusTextBox = new System.Windows.Forms.TextBox();
            this.grossPayTextBox = new System.Windows.Forms.TextBox();
            this.bonusPromptLabel = new System.Windows.Forms.Label();
            this.grossPayPromptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(131, 116);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 39);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(50, 116);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 39);
            this.calculateButton.TabIndex = 14;
            this.calculateButton.Text = "Calculate Contribution";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // contributionLabel
            // 
            this.contributionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contributionLabel.Location = new System.Drawing.Point(138, 81);
            this.contributionLabel.Name = "contributionLabel";
            this.contributionLabel.Size = new System.Drawing.Size(100, 23);
            this.contributionLabel.TabIndex = 13;
            this.contributionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(12, 86);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(120, 13);
            this.outputDescriptionLabel.TabIndex = 12;
            this.outputDescriptionLabel.Text = "Retirement Contribution:";
            // 
            // bonusTextBox
            // 
            this.bonusTextBox.Location = new System.Drawing.Point(138, 41);
            this.bonusTextBox.Name = "bonusTextBox";
            this.bonusTextBox.Size = new System.Drawing.Size(100, 20);
            this.bonusTextBox.TabIndex = 11;
            // 
            // grossPayTextBox
            // 
            this.grossPayTextBox.Location = new System.Drawing.Point(138, 15);
            this.grossPayTextBox.Name = "grossPayTextBox";
            this.grossPayTextBox.Size = new System.Drawing.Size(100, 20);
            this.grossPayTextBox.TabIndex = 10;
            // 
            // bonusPromptLabel
            // 
            this.bonusPromptLabel.AutoSize = true;
            this.bonusPromptLabel.Location = new System.Drawing.Point(29, 45);
            this.bonusPromptLabel.Name = "bonusPromptLabel";
            this.bonusPromptLabel.Size = new System.Drawing.Size(102, 13);
            this.bonusPromptLabel.TabIndex = 9;
            this.bonusPromptLabel.Text = "Amount of Bonuses:";
            // 
            // grossPayPromptLabel
            // 
            this.grossPayPromptLabel.AutoSize = true;
            this.grossPayPromptLabel.Location = new System.Drawing.Point(46, 19);
            this.grossPayPromptLabel.Name = "grossPayPromptLabel";
            this.grossPayPromptLabel.Size = new System.Drawing.Size(85, 13);
            this.grossPayPromptLabel.TabIndex = 8;
            this.grossPayPromptLabel.Text = "Total Gross Pay:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 171);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.contributionLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.bonusTextBox);
            this.Controls.Add(this.grossPayTextBox);
            this.Controls.Add(this.bonusPromptLabel);
            this.Controls.Add(this.grossPayPromptLabel);
            this.Name = "Form1";
            this.Text = "Pay and Bonus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label contributionLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.TextBox bonusTextBox;
        private System.Windows.Forms.TextBox grossPayTextBox;
        private System.Windows.Forms.Label bonusPromptLabel;
        private System.Windows.Forms.Label grossPayPromptLabel;
    }
}

