namespace CheckBox
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
            this.toppingsGroup = new System.Windows.Forms.GroupBox();
            this.anchoviesCheckBox = new System.Windows.Forms.CheckBox();
            this.cheeseCheckBox = new System.Windows.Forms.CheckBox();
            this.pepperoniCheckBox = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.toppingsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // toppingsGroup
            // 
            this.toppingsGroup.Controls.Add(this.anchoviesCheckBox);
            this.toppingsGroup.Controls.Add(this.cheeseCheckBox);
            this.toppingsGroup.Controls.Add(this.pepperoniCheckBox);
            this.toppingsGroup.Location = new System.Drawing.Point(33, 12);
            this.toppingsGroup.Name = "toppingsGroup";
            this.toppingsGroup.Size = new System.Drawing.Size(200, 100);
            this.toppingsGroup.TabIndex = 0;
            this.toppingsGroup.TabStop = false;
            this.toppingsGroup.Text = "Select Your Pizza Toppings";
            // 
            // anchoviesCheckBox
            // 
            this.anchoviesCheckBox.AutoSize = true;
            this.anchoviesCheckBox.Location = new System.Drawing.Point(48, 69);
            this.anchoviesCheckBox.Name = "anchoviesCheckBox";
            this.anchoviesCheckBox.Size = new System.Drawing.Size(76, 17);
            this.anchoviesCheckBox.TabIndex = 2;
            this.anchoviesCheckBox.Text = "Anchovies";
            this.anchoviesCheckBox.UseVisualStyleBackColor = true;
            // 
            // cheeseCheckBox
            // 
            this.cheeseCheckBox.AutoSize = true;
            this.cheeseCheckBox.Location = new System.Drawing.Point(48, 46);
            this.cheeseCheckBox.Name = "cheeseCheckBox";
            this.cheeseCheckBox.Size = new System.Drawing.Size(62, 17);
            this.cheeseCheckBox.TabIndex = 1;
            this.cheeseCheckBox.Text = "Cheese";
            this.cheeseCheckBox.UseVisualStyleBackColor = true;
            // 
            // pepperoniCheckBox
            // 
            this.pepperoniCheckBox.AutoSize = true;
            this.pepperoniCheckBox.Location = new System.Drawing.Point(48, 23);
            this.pepperoniCheckBox.Name = "pepperoniCheckBox";
            this.pepperoniCheckBox.Size = new System.Drawing.Size(74, 17);
            this.pepperoniCheckBox.TabIndex = 0;
            this.pepperoniCheckBox.Text = "Pepperoni";
            this.pepperoniCheckBox.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(96, 121);
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
            this.ClientSize = new System.Drawing.Size(267, 156);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.toppingsGroup);
            this.Name = "Form1";
            this.Text = "CheckBox Example";
            this.toppingsGroup.ResumeLayout(false);
            this.toppingsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox toppingsGroup;
        private System.Windows.Forms.CheckBox anchoviesCheckBox;
        private System.Windows.Forms.CheckBox cheeseCheckBox;
        private System.Windows.Forms.CheckBox pepperoniCheckBox;
        private System.Windows.Forms.Button okButton;
    }
}

