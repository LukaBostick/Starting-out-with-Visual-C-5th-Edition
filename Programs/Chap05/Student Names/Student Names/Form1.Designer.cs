namespace Student_Names
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
            this.displayNamesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayNamesButton
            // 
            this.displayNamesButton.Location = new System.Drawing.Point(31, 16);
            this.displayNamesButton.Name = "displayNamesButton";
            this.displayNamesButton.Size = new System.Drawing.Size(75, 37);
            this.displayNamesButton.TabIndex = 0;
            this.displayNamesButton.Text = "Display Names";
            this.displayNamesButton.UseVisualStyleBackColor = true;
            this.displayNamesButton.Click += new System.EventHandler(this.displayNamesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(112, 16);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 37);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 69);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayNamesButton);
            this.Name = "Form1";
            this.Text = "Student Names";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button displayNamesButton;
        private System.Windows.Forms.Button exitButton;
    }
}

