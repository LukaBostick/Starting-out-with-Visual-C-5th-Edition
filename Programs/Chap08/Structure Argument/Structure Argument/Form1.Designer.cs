namespace Structure_Argument
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
            this.auto1Button = new System.Windows.Forms.Button();
            this.auto2Button = new System.Windows.Forms.Button();
            this.auto3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // auto1Button
            // 
            this.auto1Button.Location = new System.Drawing.Point(24, 20);
            this.auto1Button.Name = "auto1Button";
            this.auto1Button.Size = new System.Drawing.Size(75, 36);
            this.auto1Button.TabIndex = 0;
            this.auto1Button.Text = "Display Auto #1";
            this.auto1Button.UseVisualStyleBackColor = true;
            this.auto1Button.Click += new System.EventHandler(this.auto1Button_Click);
            // 
            // auto2Button
            // 
            this.auto2Button.Location = new System.Drawing.Point(105, 20);
            this.auto2Button.Name = "auto2Button";
            this.auto2Button.Size = new System.Drawing.Size(75, 36);
            this.auto2Button.TabIndex = 1;
            this.auto2Button.Text = "Display Auto #2";
            this.auto2Button.UseVisualStyleBackColor = true;
            this.auto2Button.Click += new System.EventHandler(this.auto2Button_Click);
            // 
            // auto3Button
            // 
            this.auto3Button.Location = new System.Drawing.Point(186, 20);
            this.auto3Button.Name = "auto3Button";
            this.auto3Button.Size = new System.Drawing.Size(75, 36);
            this.auto3Button.TabIndex = 2;
            this.auto3Button.Text = "Display Auto #3";
            this.auto3Button.UseVisualStyleBackColor = true;
            this.auto3Button.Click += new System.EventHandler(this.auto3Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 77);
            this.Controls.Add(this.auto3Button);
            this.Controls.Add(this.auto2Button);
            this.Controls.Add(this.auto1Button);
            this.Name = "Form1";
            this.Text = "Structure Argument";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button auto1Button;
        private System.Windows.Forms.Button auto2Button;
        private System.Windows.Forms.Button auto3Button;
    }
}

