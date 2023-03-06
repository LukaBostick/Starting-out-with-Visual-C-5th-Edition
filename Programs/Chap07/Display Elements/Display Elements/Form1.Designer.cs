namespace Display_Elements
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
            this.name1TextBox = new System.Windows.Forms.TextBox();
            this.name2TextBox = new System.Windows.Forms.TextBox();
            this.name3TextBox = new System.Windows.Forms.TextBox();
            this.promptLabel = new System.Windows.Forms.Label();
            this.getNamesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name1TextBox
            // 
            this.name1TextBox.Location = new System.Drawing.Point(14, 41);
            this.name1TextBox.Name = "name1TextBox";
            this.name1TextBox.Size = new System.Drawing.Size(100, 20);
            this.name1TextBox.TabIndex = 0;
            // 
            // name2TextBox
            // 
            this.name2TextBox.Location = new System.Drawing.Point(120, 41);
            this.name2TextBox.Name = "name2TextBox";
            this.name2TextBox.Size = new System.Drawing.Size(100, 20);
            this.name2TextBox.TabIndex = 1;
            // 
            // name3TextBox
            // 
            this.name3TextBox.Location = new System.Drawing.Point(226, 41);
            this.name3TextBox.Name = "name3TextBox";
            this.name3TextBox.Size = new System.Drawing.Size(100, 20);
            this.name3TextBox.TabIndex = 2;
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(121, 13);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(99, 13);
            this.promptLabel.TabIndex = 3;
            this.promptLabel.Text = "Enter Three Names";
            // 
            // getNamesButton
            // 
            this.getNamesButton.Location = new System.Drawing.Point(92, 85);
            this.getNamesButton.Name = "getNamesButton";
            this.getNamesButton.Size = new System.Drawing.Size(75, 23);
            this.getNamesButton.TabIndex = 4;
            this.getNamesButton.Text = "Get Names";
            this.getNamesButton.UseVisualStyleBackColor = true;
            this.getNamesButton.Click += new System.EventHandler(this.getNamesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(173, 85);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 133);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getNamesButton);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.name3TextBox);
            this.Controls.Add(this.name2TextBox);
            this.Controls.Add(this.name1TextBox);
            this.Name = "Form1";
            this.Text = "Display Elements";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name1TextBox;
        private System.Windows.Forms.TextBox name2TextBox;
        private System.Windows.Forms.TextBox name3TextBox;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Button getNamesButton;
        private System.Windows.Forms.Button exitButton;
    }
}

