namespace Even_Number
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
            this.promptLabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.evenOrOddButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(28, 24);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(85, 13);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "Enter an integer:";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(119, 21);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(66, 20);
            this.numberTextBox.TabIndex = 1;
            // 
            // evenOrOddButton
            // 
            this.evenOrOddButton.Location = new System.Drawing.Point(28, 57);
            this.evenOrOddButton.Name = "evenOrOddButton";
            this.evenOrOddButton.Size = new System.Drawing.Size(75, 36);
            this.evenOrOddButton.TabIndex = 2;
            this.evenOrOddButton.Text = "Even or Odd?";
            this.evenOrOddButton.UseVisualStyleBackColor = true;
            this.evenOrOddButton.Click += new System.EventHandler(this.evenOrOddButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(110, 57);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 36);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 114);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.evenOrOddButton);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.promptLabel);
            this.Name = "Form1";
            this.Text = "Even Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Button evenOrOddButton;
        private System.Windows.Forms.Button exitButton;
    }
}

