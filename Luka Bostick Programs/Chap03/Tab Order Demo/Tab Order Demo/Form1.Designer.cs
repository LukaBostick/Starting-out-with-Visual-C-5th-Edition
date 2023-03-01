namespace Tab_Order_Demo
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.promptNameLabel = new System.Windows.Forms.Label();
            this.promptAddressLabel = new System.Windows.Forms.Label();
            this.promptCityLabel = new System.Windows.Forms.Label();
            this.promptStateLabel = new System.Windows.Forms.Label();
            this.promptZipLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(91, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(91, 38);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 3;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(91, 64);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 0;
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(91, 90);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(100, 20);
            this.stateTextBox.TabIndex = 4;
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(91, 116);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(100, 20);
            this.zipTextBox.TabIndex = 1;
            // 
            // promptNameLabel
            // 
            this.promptNameLabel.AutoSize = true;
            this.promptNameLabel.Location = new System.Drawing.Point(41, 15);
            this.promptNameLabel.Name = "promptNameLabel";
            this.promptNameLabel.Size = new System.Drawing.Size(38, 13);
            this.promptNameLabel.TabIndex = 5;
            this.promptNameLabel.Text = "Name:";
            // 
            // promptAddressLabel
            // 
            this.promptAddressLabel.AutoSize = true;
            this.promptAddressLabel.Location = new System.Drawing.Point(31, 40);
            this.promptAddressLabel.Name = "promptAddressLabel";
            this.promptAddressLabel.Size = new System.Drawing.Size(48, 13);
            this.promptAddressLabel.TabIndex = 7;
            this.promptAddressLabel.Text = "Address:";
            // 
            // promptCityLabel
            // 
            this.promptCityLabel.AutoSize = true;
            this.promptCityLabel.Location = new System.Drawing.Point(52, 67);
            this.promptCityLabel.Name = "promptCityLabel";
            this.promptCityLabel.Size = new System.Drawing.Size(27, 13);
            this.promptCityLabel.TabIndex = 6;
            this.promptCityLabel.Text = "City:";
            // 
            // promptStateLabel
            // 
            this.promptStateLabel.AutoSize = true;
            this.promptStateLabel.Location = new System.Drawing.Point(44, 94);
            this.promptStateLabel.Name = "promptStateLabel";
            this.promptStateLabel.Size = new System.Drawing.Size(35, 13);
            this.promptStateLabel.TabIndex = 9;
            this.promptStateLabel.Text = "State:";
            // 
            // promptZipLabel
            // 
            this.promptZipLabel.AutoSize = true;
            this.promptZipLabel.Location = new System.Drawing.Point(52, 119);
            this.promptZipLabel.Name = "promptZipLabel";
            this.promptZipLabel.Size = new System.Drawing.Size(27, 13);
            this.promptZipLabel.TabIndex = 10;
            this.promptZipLabel.Text = "ZIP:";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(74, 157);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 196);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.promptZipLabel);
            this.Controls.Add(this.promptStateLabel);
            this.Controls.Add(this.promptCityLabel);
            this.Controls.Add(this.promptAddressLabel);
            this.Controls.Add(this.promptNameLabel);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "Form1";
            this.Text = "Tab Order Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.Label promptNameLabel;
        private System.Windows.Forms.Label promptAddressLabel;
        private System.Windows.Forms.Label promptCityLabel;
        private System.Windows.Forms.Label promptStateLabel;
        private System.Windows.Forms.Label promptZipLabel;
        private System.Windows.Forms.Button clearButton;
    }
}

