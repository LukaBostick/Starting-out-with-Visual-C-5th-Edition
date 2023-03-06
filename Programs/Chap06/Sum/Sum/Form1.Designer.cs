namespace Sum
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
            this.prompt1Label = new System.Windows.Forms.Label();
            this.prompt2Label = new System.Windows.Forms.Label();
            this.age1TextBox = new System.Windows.Forms.TextBox();
            this.age2TextBox = new System.Windows.Forms.TextBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.combinedAgeLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prompt1Label
            // 
            this.prompt1Label.AutoSize = true;
            this.prompt1Label.Location = new System.Drawing.Point(75, 25);
            this.prompt1Label.Name = "prompt1Label";
            this.prompt1Label.Size = new System.Drawing.Size(79, 13);
            this.prompt1Label.TabIndex = 0;
            this.prompt1Label.Text = "Enter your age:";
            // 
            // prompt2Label
            // 
            this.prompt2Label.AutoSize = true;
            this.prompt2Label.Location = new System.Drawing.Point(16, 57);
            this.prompt2Label.Name = "prompt2Label";
            this.prompt2Label.Size = new System.Drawing.Size(138, 13);
            this.prompt2Label.TabIndex = 1;
            this.prompt2Label.Text = "Enter your best friend\'s age:";
            // 
            // age1TextBox
            // 
            this.age1TextBox.Location = new System.Drawing.Point(160, 22);
            this.age1TextBox.Name = "age1TextBox";
            this.age1TextBox.Size = new System.Drawing.Size(74, 20);
            this.age1TextBox.TabIndex = 2;
            // 
            // age2TextBox
            // 
            this.age2TextBox.Location = new System.Drawing.Point(160, 54);
            this.age2TextBox.Name = "age2TextBox";
            this.age2TextBox.Size = new System.Drawing.Size(74, 20);
            this.age2TextBox.TabIndex = 3;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(21, 93);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(133, 13);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "This is your combined age:";
            // 
            // combinedAgeLabel
            // 
            this.combinedAgeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.combinedAgeLabel.Location = new System.Drawing.Point(160, 88);
            this.combinedAgeLabel.Name = "combinedAgeLabel";
            this.combinedAgeLabel.Size = new System.Drawing.Size(74, 23);
            this.combinedAgeLabel.TabIndex = 5;
            this.combinedAgeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(36, 126);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(86, 37);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate Combined Age";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(128, 126);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(86, 37);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 183);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.combinedAgeLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.age2TextBox);
            this.Controls.Add(this.age1TextBox);
            this.Controls.Add(this.prompt2Label);
            this.Controls.Add(this.prompt1Label);
            this.Name = "Form1";
            this.Text = "Sum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label prompt1Label;
        private System.Windows.Forms.Label prompt2Label;
        private System.Windows.Forms.TextBox age1TextBox;
        private System.Windows.Forms.TextBox age2TextBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label combinedAgeLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

