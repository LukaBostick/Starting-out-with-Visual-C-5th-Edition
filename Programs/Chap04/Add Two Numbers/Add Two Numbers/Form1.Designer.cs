namespace Add_Two_Numbers
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
            this.firstTextBox = new System.Windows.Forms.TextBox();
            this.secondTextBox = new System.Windows.Forms.TextBox();
            this.promptLabel1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.promptLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstTextBox
            // 
            this.firstTextBox.Location = new System.Drawing.Point(89, 60);
            this.firstTextBox.Name = "firstTextBox";
            this.firstTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstTextBox.TabIndex = 0;
            // 
            // secondTextBox
            // 
            this.secondTextBox.Location = new System.Drawing.Point(89, 86);
            this.secondTextBox.Name = "secondTextBox";
            this.secondTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondTextBox.TabIndex = 1;
            // 
            // promptLabel1
            // 
            this.promptLabel1.AutoSize = true;
            this.promptLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLabel1.Location = new System.Drawing.Point(68, 14);
            this.promptLabel1.Name = "promptLabel1";
            this.promptLabel1.Size = new System.Drawing.Size(143, 16);
            this.promptLabel1.TabIndex = 2;
            this.promptLabel1.Text = "Enter Two Numbers";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(102, 124);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // promptLabel2
            // 
            this.promptLabel2.AutoSize = true;
            this.promptLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLabel2.Location = new System.Drawing.Point(58, 32);
            this.promptLabel2.Name = "promptLabel2";
            this.promptLabel2.Size = new System.Drawing.Size(162, 16);
            this.promptLabel2.TabIndex = 4;
            this.promptLabel2.Text = "(Integers Only Please)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 161);
            this.Controls.Add(this.promptLabel2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.promptLabel1);
            this.Controls.Add(this.secondTextBox);
            this.Controls.Add(this.firstTextBox);
            this.Name = "Form1";
            this.Text = "Add Two Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstTextBox;
        private System.Windows.Forms.TextBox secondTextBox;
        private System.Windows.Forms.Label promptLabel1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label promptLabel2;
    }
}

