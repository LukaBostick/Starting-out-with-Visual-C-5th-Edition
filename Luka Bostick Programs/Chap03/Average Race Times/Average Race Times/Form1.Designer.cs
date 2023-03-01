namespace Average_Race_Times
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.runner1Label = new System.Windows.Forms.Label();
            this.runner2Label = new System.Windows.Forms.Label();
            this.runner3Label = new System.Windows.Forms.Label();
            this.descriptorAverageLabel = new System.Windows.Forms.Label();
            this.runner1TextBox = new System.Windows.Forms.TextBox();
            this.runner2TextBox = new System.Windows.Forms.TextBox();
            this.runner3TextBox = new System.Windows.Forms.TextBox();
            this.averageTimeLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.averageTimeLabel);
            this.panel1.Controls.Add(this.runner3TextBox);
            this.panel1.Controls.Add(this.runner2TextBox);
            this.panel1.Controls.Add(this.runner1TextBox);
            this.panel1.Controls.Add(this.descriptorAverageLabel);
            this.panel1.Controls.Add(this.runner3Label);
            this.panel1.Controls.Add(this.runner2Label);
            this.panel1.Controls.Add(this.runner1Label);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 152);
            this.panel1.TabIndex = 0;
            // 
            // runner1Label
            // 
            this.runner1Label.AutoSize = true;
            this.runner1Label.Location = new System.Drawing.Point(84, 22);
            this.runner1Label.Name = "runner1Label";
            this.runner1Label.Size = new System.Drawing.Size(54, 13);
            this.runner1Label.TabIndex = 0;
            this.runner1Label.Text = "Runner 1:";
            // 
            // runner2Label
            // 
            this.runner2Label.AutoSize = true;
            this.runner2Label.Location = new System.Drawing.Point(84, 52);
            this.runner2Label.Name = "runner2Label";
            this.runner2Label.Size = new System.Drawing.Size(54, 13);
            this.runner2Label.TabIndex = 1;
            this.runner2Label.Text = "Runner 2:";
            // 
            // runner3Label
            // 
            this.runner3Label.AutoSize = true;
            this.runner3Label.Location = new System.Drawing.Point(84, 78);
            this.runner3Label.Name = "runner3Label";
            this.runner3Label.Size = new System.Drawing.Size(54, 13);
            this.runner3Label.TabIndex = 2;
            this.runner3Label.Text = "Runner 3:";
            // 
            // descriptorAverageLabel
            // 
            this.descriptorAverageLabel.AutoSize = true;
            this.descriptorAverageLabel.Location = new System.Drawing.Point(33, 112);
            this.descriptorAverageLabel.Name = "descriptorAverageLabel";
            this.descriptorAverageLabel.Size = new System.Drawing.Size(105, 13);
            this.descriptorAverageLabel.TabIndex = 3;
            this.descriptorAverageLabel.Text = "Average Race Time:";
            // 
            // runner1TextBox
            // 
            this.runner1TextBox.Location = new System.Drawing.Point(144, 19);
            this.runner1TextBox.Name = "runner1TextBox";
            this.runner1TextBox.Size = new System.Drawing.Size(100, 20);
            this.runner1TextBox.TabIndex = 4;
            // 
            // runner2TextBox
            // 
            this.runner2TextBox.Location = new System.Drawing.Point(144, 47);
            this.runner2TextBox.Name = "runner2TextBox";
            this.runner2TextBox.Size = new System.Drawing.Size(100, 20);
            this.runner2TextBox.TabIndex = 5;
            // 
            // runner3TextBox
            // 
            this.runner3TextBox.Location = new System.Drawing.Point(144, 76);
            this.runner3TextBox.Name = "runner3TextBox";
            this.runner3TextBox.Size = new System.Drawing.Size(100, 20);
            this.runner3TextBox.TabIndex = 6;
            // 
            // averageTimeLabel
            // 
            this.averageTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageTimeLabel.Location = new System.Drawing.Point(144, 106);
            this.averageTimeLabel.Name = "averageTimeLabel";
            this.averageTimeLabel.Size = new System.Drawing.Size(100, 23);
            this.averageTimeLabel.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(24, 185);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 35);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Calculate Average";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(105, 185);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 35);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(186, 185);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 35);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 236);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Average Race Times";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label averageTimeLabel;
        private System.Windows.Forms.TextBox runner3TextBox;
        private System.Windows.Forms.TextBox runner2TextBox;
        private System.Windows.Forms.TextBox runner1TextBox;
        private System.Windows.Forms.Label descriptorAverageLabel;
        private System.Windows.Forms.Label runner3Label;
        private System.Windows.Forms.Label runner2Label;
        private System.Windows.Forms.Label runner1Label;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

