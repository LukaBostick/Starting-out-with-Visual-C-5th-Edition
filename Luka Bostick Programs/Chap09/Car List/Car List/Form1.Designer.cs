namespace Car_List
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
            this.carInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.makePromptLabel = new System.Windows.Forms.Label();
            this.yearPromptLabel = new System.Windows.Forms.Label();
            this.mileagePromptLabel = new System.Windows.Forms.Label();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.mileageTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.carListBox = new System.Windows.Forms.ListBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.carInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // carInfoGroupBox
            // 
            this.carInfoGroupBox.Controls.Add(this.mileageTextBox);
            this.carInfoGroupBox.Controls.Add(this.yearTextBox);
            this.carInfoGroupBox.Controls.Add(this.makeTextBox);
            this.carInfoGroupBox.Controls.Add(this.mileagePromptLabel);
            this.carInfoGroupBox.Controls.Add(this.yearPromptLabel);
            this.carInfoGroupBox.Controls.Add(this.makePromptLabel);
            this.carInfoGroupBox.Location = new System.Drawing.Point(12, 17);
            this.carInfoGroupBox.Name = "carInfoGroupBox";
            this.carInfoGroupBox.Size = new System.Drawing.Size(200, 105);
            this.carInfoGroupBox.TabIndex = 0;
            this.carInfoGroupBox.TabStop = false;
            this.carInfoGroupBox.Text = "Car Information";
            // 
            // makePromptLabel
            // 
            this.makePromptLabel.AutoSize = true;
            this.makePromptLabel.Location = new System.Drawing.Point(34, 22);
            this.makePromptLabel.Name = "makePromptLabel";
            this.makePromptLabel.Size = new System.Drawing.Size(37, 13);
            this.makePromptLabel.TabIndex = 0;
            this.makePromptLabel.Text = "Make:";
            // 
            // yearPromptLabel
            // 
            this.yearPromptLabel.AutoSize = true;
            this.yearPromptLabel.Location = new System.Drawing.Point(34, 48);
            this.yearPromptLabel.Name = "yearPromptLabel";
            this.yearPromptLabel.Size = new System.Drawing.Size(32, 13);
            this.yearPromptLabel.TabIndex = 1;
            this.yearPromptLabel.Text = "Year:";
            // 
            // mileagePromptLabel
            // 
            this.mileagePromptLabel.AutoSize = true;
            this.mileagePromptLabel.Location = new System.Drawing.Point(19, 74);
            this.mileagePromptLabel.Name = "mileagePromptLabel";
            this.mileagePromptLabel.Size = new System.Drawing.Size(47, 13);
            this.mileagePromptLabel.TabIndex = 2;
            this.mileagePromptLabel.Text = "Mileage:";
            // 
            // makeTextBox
            // 
            this.makeTextBox.Location = new System.Drawing.Point(81, 19);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(100, 20);
            this.makeTextBox.TabIndex = 3;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(81, 46);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 4;
            // 
            // mileageTextBox
            // 
            this.mileageTextBox.Location = new System.Drawing.Point(81, 72);
            this.mileageTextBox.Name = "mileageTextBox";
            this.mileageTextBox.Size = new System.Drawing.Size(100, 20);
            this.mileageTextBox.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(75, 142);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 35);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add Car to List";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // carListBox
            // 
            this.carListBox.FormattingEnabled = true;
            this.carListBox.Location = new System.Drawing.Point(238, 27);
            this.carListBox.Name = "carListBox";
            this.carListBox.Size = new System.Drawing.Size(207, 95);
            this.carListBox.TabIndex = 2;
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(304, 142);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(75, 35);
            this.displayButton.TabIndex = 3;
            this.displayButton.Text = "Display Car List";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 194);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.carListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.carInfoGroupBox);
            this.Name = "Form1";
            this.Text = "Car List";
            this.carInfoGroupBox.ResumeLayout(false);
            this.carInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox carInfoGroupBox;
        private System.Windows.Forms.TextBox mileageTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.Label mileagePromptLabel;
        private System.Windows.Forms.Label yearPromptLabel;
        private System.Windows.Forms.Label makePromptLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox carListBox;
        private System.Windows.Forms.Button displayButton;
    }
}

