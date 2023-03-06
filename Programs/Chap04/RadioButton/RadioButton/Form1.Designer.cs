namespace RadioButton
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
            this.sportGroupBox = new System.Windows.Forms.GroupBox();
            this.baseballRadioButton = new System.Windows.Forms.RadioButton();
            this.basketballRadioButton = new System.Windows.Forms.RadioButton();
            this.footballRadioButton = new System.Windows.Forms.RadioButton();
            this.okButton = new System.Windows.Forms.Button();
            this.sportGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sportGroupBox
            // 
            this.sportGroupBox.Controls.Add(this.baseballRadioButton);
            this.sportGroupBox.Controls.Add(this.basketballRadioButton);
            this.sportGroupBox.Controls.Add(this.footballRadioButton);
            this.sportGroupBox.Location = new System.Drawing.Point(42, 13);
            this.sportGroupBox.Name = "sportGroupBox";
            this.sportGroupBox.Size = new System.Drawing.Size(223, 111);
            this.sportGroupBox.TabIndex = 0;
            this.sportGroupBox.TabStop = false;
            this.sportGroupBox.Text = "Select Your Favorite Sport";
            // 
            // baseballRadioButton
            // 
            this.baseballRadioButton.AutoSize = true;
            this.baseballRadioButton.Location = new System.Drawing.Point(74, 70);
            this.baseballRadioButton.Name = "baseballRadioButton";
            this.baseballRadioButton.Size = new System.Drawing.Size(65, 17);
            this.baseballRadioButton.TabIndex = 2;
            this.baseballRadioButton.TabStop = true;
            this.baseballRadioButton.Text = "Baseball";
            this.baseballRadioButton.UseVisualStyleBackColor = true;
            // 
            // basketballRadioButton
            // 
            this.basketballRadioButton.AutoSize = true;
            this.basketballRadioButton.Location = new System.Drawing.Point(74, 47);
            this.basketballRadioButton.Name = "basketballRadioButton";
            this.basketballRadioButton.Size = new System.Drawing.Size(74, 17);
            this.basketballRadioButton.TabIndex = 1;
            this.basketballRadioButton.TabStop = true;
            this.basketballRadioButton.Text = "Basketball";
            this.basketballRadioButton.UseVisualStyleBackColor = true;
            // 
            // footballRadioButton
            // 
            this.footballRadioButton.AutoSize = true;
            this.footballRadioButton.Location = new System.Drawing.Point(74, 24);
            this.footballRadioButton.Name = "footballRadioButton";
            this.footballRadioButton.Size = new System.Drawing.Size(62, 17);
            this.footballRadioButton.TabIndex = 0;
            this.footballRadioButton.TabStop = true;
            this.footballRadioButton.Text = "Football";
            this.footballRadioButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(116, 135);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 170);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.sportGroupBox);
            this.Name = "Form1";
            this.Text = "RadioButton Example";
            this.sportGroupBox.ResumeLayout(false);
            this.sportGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sportGroupBox;
        private System.Windows.Forms.RadioButton baseballRadioButton;
        private System.Windows.Forms.RadioButton basketballRadioButton;
        private System.Windows.Forms.RadioButton footballRadioButton;
        private System.Windows.Forms.Button okButton;
    }
}

