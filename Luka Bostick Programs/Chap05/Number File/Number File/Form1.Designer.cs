namespace Number_File
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
            this.writeNumbersButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // writeNumbersButton
            // 
            this.writeNumbersButton.Location = new System.Drawing.Point(21, 22);
            this.writeNumbersButton.Name = "writeNumbersButton";
            this.writeNumbersButton.Size = new System.Drawing.Size(75, 38);
            this.writeNumbersButton.TabIndex = 0;
            this.writeNumbersButton.Text = "Write Numbers";
            this.writeNumbersButton.UseVisualStyleBackColor = true;
            this.writeNumbersButton.Click += new System.EventHandler(this.writeNumbersButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(102, 22);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 38);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 88);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.writeNumbersButton);
            this.Name = "Form1";
            this.Text = "Number File";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button writeNumbersButton;
        private System.Windows.Forms.Button exitButton;
    }
}

