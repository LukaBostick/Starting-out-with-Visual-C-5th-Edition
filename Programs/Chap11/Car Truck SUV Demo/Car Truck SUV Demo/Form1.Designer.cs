namespace Car_Truck_SUV_Demo
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
            this.exitButton = new System.Windows.Forms.Button();
            this.createObjectsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(150, 33);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 40);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // createObjectsButton
            // 
            this.createObjectsButton.Location = new System.Drawing.Point(69, 33);
            this.createObjectsButton.Name = "createObjectsButton";
            this.createObjectsButton.Size = new System.Drawing.Size(75, 40);
            this.createObjectsButton.TabIndex = 5;
            this.createObjectsButton.Text = "Create Objects";
            this.createObjectsButton.UseVisualStyleBackColor = true;
            this.createObjectsButton.Click += new System.EventHandler(this.createObjectsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 107);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.createObjectsButton);
            this.Name = "Form1";
            this.Text = "Car Truck SUV Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button createObjectsButton;
    }
}

