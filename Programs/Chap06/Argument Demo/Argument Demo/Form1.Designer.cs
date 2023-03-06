namespace Argument_Demo
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
            this.demo1Button = new System.Windows.Forms.Button();
            this.demo2Button = new System.Windows.Forms.Button();
            this.demo3Button = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // demo1Button
            // 
            this.demo1Button.Location = new System.Drawing.Point(13, 14);
            this.demo1Button.Name = "demo1Button";
            this.demo1Button.Size = new System.Drawing.Size(75, 23);
            this.demo1Button.TabIndex = 0;
            this.demo1Button.Text = "Demo 1";
            this.demo1Button.UseVisualStyleBackColor = true;
            this.demo1Button.Click += new System.EventHandler(this.demo1Button_Click);
            // 
            // demo2Button
            // 
            this.demo2Button.Location = new System.Drawing.Point(94, 14);
            this.demo2Button.Name = "demo2Button";
            this.demo2Button.Size = new System.Drawing.Size(75, 23);
            this.demo2Button.TabIndex = 1;
            this.demo2Button.Text = "Demo 2";
            this.demo2Button.UseVisualStyleBackColor = true;
            this.demo2Button.Click += new System.EventHandler(this.demo2Button_Click);
            // 
            // demo3Button
            // 
            this.demo3Button.Location = new System.Drawing.Point(175, 14);
            this.demo3Button.Name = "demo3Button";
            this.demo3Button.Size = new System.Drawing.Size(75, 23);
            this.demo3Button.TabIndex = 2;
            this.demo3Button.Text = "Demo 3";
            this.demo3Button.UseVisualStyleBackColor = true;
            this.demo3Button.Click += new System.EventHandler(this.demo3Button_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(94, 53);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 90);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.demo3Button);
            this.Controls.Add(this.demo2Button);
            this.Controls.Add(this.demo1Button);
            this.Name = "Form1";
            this.Text = "Argument Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button demo1Button;
        private System.Windows.Forms.Button demo2Button;
        private System.Windows.Forms.Button demo3Button;
        private System.Windows.Forms.Button exitButton;
    }
}

