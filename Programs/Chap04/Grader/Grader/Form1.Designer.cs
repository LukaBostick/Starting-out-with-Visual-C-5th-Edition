namespace Grader
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
            this.testScorePromptLabel = new System.Windows.Forms.Label();
            this.testScoreTextBox = new System.Windows.Forms.TextBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.determineGradeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testScorePromptLabel
            // 
            this.testScorePromptLabel.AutoSize = true;
            this.testScorePromptLabel.Location = new System.Drawing.Point(17, 9);
            this.testScorePromptLabel.Name = "testScorePromptLabel";
            this.testScorePromptLabel.Size = new System.Drawing.Size(107, 13);
            this.testScorePromptLabel.TabIndex = 0;
            this.testScorePromptLabel.Text = "Enter your test score:";
            // 
            // testScoreTextBox
            // 
            this.testScoreTextBox.Location = new System.Drawing.Point(130, 6);
            this.testScoreTextBox.Name = "testScoreTextBox";
            this.testScoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.testScoreTextBox.TabIndex = 1;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(62, 43);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(62, 13);
            this.outputDescriptionLabel.TabIndex = 2;
            this.outputDescriptionLabel.Text = "Your grade:";
            // 
            // gradeLabel
            // 
            this.gradeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradeLabel.Location = new System.Drawing.Point(130, 38);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(100, 23);
            this.gradeLabel.TabIndex = 3;
            this.gradeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // determineGradeButton
            // 
            this.determineGradeButton.Location = new System.Drawing.Point(45, 82);
            this.determineGradeButton.Name = "determineGradeButton";
            this.determineGradeButton.Size = new System.Drawing.Size(75, 36);
            this.determineGradeButton.TabIndex = 4;
            this.determineGradeButton.Text = "Determine Grade";
            this.determineGradeButton.UseVisualStyleBackColor = true;
            this.determineGradeButton.Click += new System.EventHandler(this.determineGradeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(126, 82);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 36);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 133);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.determineGradeButton);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.testScoreTextBox);
            this.Controls.Add(this.testScorePromptLabel);
            this.Name = "Form1";
            this.Text = "Grader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label testScorePromptLabel;
        private System.Windows.Forms.TextBox testScoreTextBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Button determineGradeButton;
        private System.Windows.Forms.Button exitButton;
    }
}

