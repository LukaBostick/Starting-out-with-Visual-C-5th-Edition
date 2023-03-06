namespace Full_Name
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
            this.firstNamePromptLabel = new System.Windows.Forms.Label();
            this.middleNamePromptLabel = new System.Windows.Forms.Label();
            this.lastNamePromptLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.fullNameGroupBox = new System.Windows.Forms.GroupBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.showFullNameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.fullNameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNamePromptLabel
            // 
            this.firstNamePromptLabel.AutoSize = true;
            this.firstNamePromptLabel.Location = new System.Drawing.Point(22, 12);
            this.firstNamePromptLabel.Name = "firstNamePromptLabel";
            this.firstNamePromptLabel.Size = new System.Drawing.Size(106, 13);
            this.firstNamePromptLabel.TabIndex = 0;
            this.firstNamePromptLabel.Text = "Enter your first name:";
            // 
            // middleNamePromptLabel
            // 
            this.middleNamePromptLabel.AutoSize = true;
            this.middleNamePromptLabel.Location = new System.Drawing.Point(8, 40);
            this.middleNamePromptLabel.Name = "middleNamePromptLabel";
            this.middleNamePromptLabel.Size = new System.Drawing.Size(120, 13);
            this.middleNamePromptLabel.TabIndex = 1;
            this.middleNamePromptLabel.Text = "Enter your middle name:";
            // 
            // lastNamePromptLabel
            // 
            this.lastNamePromptLabel.AutoSize = true;
            this.lastNamePromptLabel.Location = new System.Drawing.Point(22, 71);
            this.lastNamePromptLabel.Name = "lastNamePromptLabel";
            this.lastNamePromptLabel.Size = new System.Drawing.Size(106, 13);
            this.lastNamePromptLabel.TabIndex = 2;
            this.lastNamePromptLabel.Text = "Enter your last name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(138, 9);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(138, 36);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.middleNameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(138, 67);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // fullNameGroupBox
            // 
            this.fullNameGroupBox.Controls.Add(this.fullNameLabel);
            this.fullNameGroupBox.Location = new System.Drawing.Point(11, 105);
            this.fullNameGroupBox.Name = "fullNameGroupBox";
            this.fullNameGroupBox.Size = new System.Drawing.Size(237, 66);
            this.fullNameGroupBox.TabIndex = 6;
            this.fullNameGroupBox.TabStop = false;
            this.fullNameGroupBox.Text = "Your Full Name";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullNameLabel.Location = new System.Drawing.Point(14, 25);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(207, 23);
            this.fullNameLabel.TabIndex = 0;
            this.fullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showFullNameButton
            // 
            this.showFullNameButton.Location = new System.Drawing.Point(53, 188);
            this.showFullNameButton.Name = "showFullNameButton";
            this.showFullNameButton.Size = new System.Drawing.Size(75, 36);
            this.showFullNameButton.TabIndex = 7;
            this.showFullNameButton.Text = "Show Full Name";
            this.showFullNameButton.UseVisualStyleBackColor = true;
            this.showFullNameButton.Click += new System.EventHandler(this.showFullNameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(134, 188);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 36);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 238);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showFullNameButton);
            this.Controls.Add(this.fullNameGroupBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNamePromptLabel);
            this.Controls.Add(this.middleNamePromptLabel);
            this.Controls.Add(this.firstNamePromptLabel);
            this.Name = "Form1";
            this.Text = "Full Name";
            this.fullNameGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNamePromptLabel;
        private System.Windows.Forms.Label middleNamePromptLabel;
        private System.Windows.Forms.Label lastNamePromptLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.GroupBox fullNameGroupBox;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Button showFullNameButton;
        private System.Windows.Forms.Button exitButton;
    }
}

