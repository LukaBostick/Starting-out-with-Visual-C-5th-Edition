namespace String_Variable_Demo
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
            this.promptFirstNameLabel = new System.Windows.Forms.Label();
            this.promptLastNameLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.showNameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // promptFirstNameLabel
            // 
            this.promptFirstNameLabel.AutoSize = true;
            this.promptFirstNameLabel.Location = new System.Drawing.Point(25, 15);
            this.promptFirstNameLabel.Name = "promptFirstNameLabel";
            this.promptFirstNameLabel.Size = new System.Drawing.Size(106, 13);
            this.promptFirstNameLabel.TabIndex = 0;
            this.promptFirstNameLabel.Text = "Enter your first name:";
            // 
            // promptLastNameLabel
            // 
            this.promptLastNameLabel.AutoSize = true;
            this.promptLastNameLabel.Location = new System.Drawing.Point(25, 44);
            this.promptLastNameLabel.Name = "promptLastNameLabel";
            this.promptLastNameLabel.Size = new System.Drawing.Size(106, 13);
            this.promptLastNameLabel.TabIndex = 1;
            this.promptLastNameLabel.Text = "Enter your last name:";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(25, 88);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(108, 13);
            this.outputDescriptionLabel.TabIndex = 2;
            this.outputDescriptionLabel.Text = "This is your full name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(148, 11);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(148, 40);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullNameLabel.Location = new System.Drawing.Point(145, 83);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(103, 23);
            this.fullNameLabel.TabIndex = 5;
            this.fullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showNameButton
            // 
            this.showNameButton.Location = new System.Drawing.Point(58, 128);
            this.showNameButton.Name = "showNameButton";
            this.showNameButton.Size = new System.Drawing.Size(75, 23);
            this.showNameButton.TabIndex = 6;
            this.showNameButton.Text = "Show Name";
            this.showNameButton.UseVisualStyleBackColor = true;
            this.showNameButton.Click += new System.EventHandler(this.showNameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(139, 128);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 162);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showNameButton);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.promptLastNameLabel);
            this.Controls.Add(this.promptFirstNameLabel);
            this.Name = "Form1";
            this.Text = "String Variable Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptFirstNameLabel;
        private System.Windows.Forms.Label promptLastNameLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Button showNameButton;
        private System.Windows.Forms.Button exitButton;
    }
}

