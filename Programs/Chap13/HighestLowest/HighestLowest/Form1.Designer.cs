namespace HighestLowest
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
            this.highestButton = new System.Windows.Forms.Button();
            this.lowestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // highestButton
            // 
            this.highestButton.Location = new System.Drawing.Point(79, 38);
            this.highestButton.Name = "highestButton";
            this.highestButton.Size = new System.Drawing.Size(75, 23);
            this.highestButton.TabIndex = 0;
            this.highestButton.Text = "Find Highest";
            this.highestButton.UseVisualStyleBackColor = true;
            this.highestButton.Click += new System.EventHandler(this.highestButton_Click);
            // 
            // lowestButton
            // 
            this.lowestButton.Location = new System.Drawing.Point(79, 77);
            this.lowestButton.Name = "lowestButton";
            this.lowestButton.Size = new System.Drawing.Size(75, 23);
            this.lowestButton.TabIndex = 1;
            this.lowestButton.Text = "Find Lowest";
            this.lowestButton.UseVisualStyleBackColor = true;
            this.lowestButton.Click += new System.EventHandler(this.lowestButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 138);
            this.Controls.Add(this.lowestButton);
            this.Controls.Add(this.highestButton);
            this.Name = "Form1";
            this.Text = "Highest/Lowest";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button highestButton;
        private System.Windows.Forms.Button lowestButton;
    }
}

