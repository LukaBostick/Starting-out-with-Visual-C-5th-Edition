namespace Optional_Argument
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
            this.pricePromptLabel = new System.Windows.Forms.Label();
            this.showTaxButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pricePromptLabel
            // 
            this.pricePromptLabel.AutoSize = true;
            this.pricePromptLabel.Location = new System.Drawing.Point(11, 17);
            this.pricePromptLabel.Name = "pricePromptLabel";
            this.pricePromptLabel.Size = new System.Drawing.Size(105, 13);
            this.pricePromptLabel.TabIndex = 0;
            this.pricePromptLabel.Text = "Enter an item\'s price:";
            // 
            // showTaxButton
            // 
            this.showTaxButton.Location = new System.Drawing.Point(38, 49);
            this.showTaxButton.Name = "showTaxButton";
            this.showTaxButton.Size = new System.Drawing.Size(75, 23);
            this.showTaxButton.TabIndex = 2;
            this.showTaxButton.Text = "Show Tax";
            this.showTaxButton.UseVisualStyleBackColor = true;
            this.showTaxButton.Click += new System.EventHandler(this.showTaxButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(119, 49);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(117, 14);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 84);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showTaxButton);
            this.Controls.Add(this.pricePromptLabel);
            this.Name = "Form1";
            this.Text = "Optional Argument";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pricePromptLabel;
        private System.Windows.Forms.Button showTaxButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox priceTextBox;
    }
}

