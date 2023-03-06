namespace Loan_Qualifier
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
            this.salaryPromptLabel = new System.Windows.Forms.Label();
            this.yearsPromptLabel = new System.Windows.Forms.Label();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.yearsTextBox = new System.Windows.Forms.TextBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.decisionLabel = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salaryPromptLabel
            // 
            this.salaryPromptLabel.AutoSize = true;
            this.salaryPromptLabel.Location = new System.Drawing.Point(59, 13);
            this.salaryPromptLabel.Name = "salaryPromptLabel";
            this.salaryPromptLabel.Size = new System.Drawing.Size(73, 13);
            this.salaryPromptLabel.TabIndex = 0;
            this.salaryPromptLabel.Text = "Annual salary:";
            // 
            // yearsPromptLabel
            // 
            this.yearsPromptLabel.AutoSize = true;
            this.yearsPromptLabel.Location = new System.Drawing.Point(30, 39);
            this.yearsPromptLabel.Name = "yearsPromptLabel";
            this.yearsPromptLabel.Size = new System.Drawing.Size(102, 13);
            this.yearsPromptLabel.TabIndex = 1;
            this.yearsPromptLabel.Text = "Years at current job:";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(138, 9);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.salaryTextBox.TabIndex = 2;
            // 
            // yearsTextBox
            // 
            this.yearsTextBox.Location = new System.Drawing.Point(138, 35);
            this.yearsTextBox.Name = "yearsTextBox";
            this.yearsTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearsTextBox.TabIndex = 3;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(12, 73);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(76, 13);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "Loan decision:";
            // 
            // decisionLabel
            // 
            this.decisionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decisionLabel.Location = new System.Drawing.Point(12, 96);
            this.decisionLabel.Name = "decisionLabel";
            this.decisionLabel.Size = new System.Drawing.Size(260, 23);
            this.decisionLabel.TabIndex = 5;
            this.decisionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(12, 135);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(82, 35);
            this.checkButton.TabIndex = 6;
            this.checkButton.Text = "Check Qualifications";
            this.checkButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(100, 135);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(82, 35);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(188, 135);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(82, 35);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 183);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.decisionLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.yearsTextBox);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.yearsPromptLabel);
            this.Controls.Add(this.salaryPromptLabel);
            this.Name = "Form1";
            this.Text = "Loan Qualifier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label salaryPromptLabel;
        private System.Windows.Forms.Label yearsPromptLabel;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox yearsTextBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label decisionLabel;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

