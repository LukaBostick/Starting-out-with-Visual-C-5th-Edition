namespace Field_Demo
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
            this.showNameButton = new System.Windows.Forms.Button();
            this.chrisButton = new System.Windows.Forms.Button();
            this.carmenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showNameButton
            // 
            this.showNameButton.Location = new System.Drawing.Point(65, 11);
            this.showNameButton.Name = "showNameButton";
            this.showNameButton.Size = new System.Drawing.Size(75, 35);
            this.showNameButton.TabIndex = 0;
            this.showNameButton.Text = "Show Name";
            this.showNameButton.UseVisualStyleBackColor = true;
            this.showNameButton.Click += new System.EventHandler(this.showNameButton_Click);
            // 
            // chrisButton
            // 
            this.chrisButton.Location = new System.Drawing.Point(12, 52);
            this.chrisButton.Name = "chrisButton";
            this.chrisButton.Size = new System.Drawing.Size(87, 35);
            this.chrisButton.TabIndex = 1;
            this.chrisButton.Text = "Change Name to Chris";
            this.chrisButton.UseVisualStyleBackColor = true;
            this.chrisButton.Click += new System.EventHandler(this.chrisButton_Click);
            // 
            // carmenButton
            // 
            this.carmenButton.Location = new System.Drawing.Point(105, 52);
            this.carmenButton.Name = "carmenButton";
            this.carmenButton.Size = new System.Drawing.Size(87, 35);
            this.carmenButton.TabIndex = 2;
            this.carmenButton.Text = "Change Name to Carmen";
            this.carmenButton.UseVisualStyleBackColor = true;
            this.carmenButton.Click += new System.EventHandler(this.carmenButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 105);
            this.Controls.Add(this.carmenButton);
            this.Controls.Add(this.chrisButton);
            this.Controls.Add(this.showNameButton);
            this.Name = "Form1";
            this.Text = "Field Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showNameButton;
        private System.Windows.Forms.Button chrisButton;
        private System.Windows.Forms.Button carmenButton;
    }
}

