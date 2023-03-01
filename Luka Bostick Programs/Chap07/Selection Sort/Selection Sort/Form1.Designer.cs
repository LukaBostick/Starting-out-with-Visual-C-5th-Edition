namespace Selection_Sort
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
            this.originalOrderLabel = new System.Windows.Forms.Label();
            this.sortedOrderLabel = new System.Windows.Forms.Label();
            this.originalListBox = new System.Windows.Forms.ListBox();
            this.sortedListBox = new System.Windows.Forms.ListBox();
            this.goButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // originalOrderLabel
            // 
            this.originalOrderLabel.AutoSize = true;
            this.originalOrderLabel.Location = new System.Drawing.Point(12, 9);
            this.originalOrderLabel.Name = "originalOrderLabel";
            this.originalOrderLabel.Size = new System.Drawing.Size(71, 13);
            this.originalOrderLabel.TabIndex = 0;
            this.originalOrderLabel.Text = "Original Order";
            // 
            // sortedOrderLabel
            // 
            this.sortedOrderLabel.AutoSize = true;
            this.sortedOrderLabel.Location = new System.Drawing.Point(152, 9);
            this.sortedOrderLabel.Name = "sortedOrderLabel";
            this.sortedOrderLabel.Size = new System.Drawing.Size(67, 13);
            this.sortedOrderLabel.TabIndex = 1;
            this.sortedOrderLabel.Text = "Sorted Order";
            // 
            // originalListBox
            // 
            this.originalListBox.FormattingEnabled = true;
            this.originalListBox.Location = new System.Drawing.Point(12, 25);
            this.originalListBox.Name = "originalListBox";
            this.originalListBox.Size = new System.Drawing.Size(120, 95);
            this.originalListBox.TabIndex = 2;
            // 
            // sortedListBox
            // 
            this.sortedListBox.FormattingEnabled = true;
            this.sortedListBox.Location = new System.Drawing.Point(152, 25);
            this.sortedListBox.Name = "sortedListBox";
            this.sortedListBox.Size = new System.Drawing.Size(120, 95);
            this.sortedListBox.TabIndex = 3;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(64, 131);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 4;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(145, 131);
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
            this.ClientSize = new System.Drawing.Size(284, 166);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.sortedListBox);
            this.Controls.Add(this.originalListBox);
            this.Controls.Add(this.sortedOrderLabel);
            this.Controls.Add(this.originalOrderLabel);
            this.Name = "Form1";
            this.Text = "Selection Sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originalOrderLabel;
        private System.Windows.Forms.Label sortedOrderLabel;
        private System.Windows.Forms.ListBox originalListBox;
        private System.Windows.Forms.ListBox sortedListBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button exitButton;
    }
}

