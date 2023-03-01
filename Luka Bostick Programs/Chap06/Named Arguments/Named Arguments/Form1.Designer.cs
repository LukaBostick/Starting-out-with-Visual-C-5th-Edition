namespace Named_Arguments
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
            this.firstNamePrompt = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNamePrompt = new System.Windows.Forms.Label();
            this.combineButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNamePrompt
            // 
            this.firstNamePrompt.AutoSize = true;
            this.firstNamePrompt.Location = new System.Drawing.Point(34, 20);
            this.firstNamePrompt.Name = "firstNamePrompt";
            this.firstNamePrompt.Size = new System.Drawing.Size(60, 13);
            this.firstNamePrompt.TabIndex = 0;
            this.firstNamePrompt.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(100, 17);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(100, 43);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // lastNamePrompt
            // 
            this.lastNamePrompt.AutoSize = true;
            this.lastNamePrompt.Location = new System.Drawing.Point(34, 46);
            this.lastNamePrompt.Name = "lastNamePrompt";
            this.lastNamePrompt.Size = new System.Drawing.Size(61, 13);
            this.lastNamePrompt.TabIndex = 2;
            this.lastNamePrompt.Text = "Last Name:";
            // 
            // combineButton
            // 
            this.combineButton.Location = new System.Drawing.Point(39, 78);
            this.combineButton.Name = "combineButton";
            this.combineButton.Size = new System.Drawing.Size(75, 23);
            this.combineButton.TabIndex = 4;
            this.combineButton.Text = "Combine";
            this.combineButton.UseVisualStyleBackColor = true;
            this.combineButton.Click += new System.EventHandler(this.combineButton_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(120, 78);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 116);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.combineButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNamePrompt);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNamePrompt);
            this.Name = "Form1";
            this.Text = "Named Arguments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNamePrompt;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNamePrompt;
        private System.Windows.Forms.Button combineButton;
        private System.Windows.Forms.Button Exit;
    }
}

