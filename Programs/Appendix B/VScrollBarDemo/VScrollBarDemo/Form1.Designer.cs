namespace VScrollBarDemo
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
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.promptLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(36, 23);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(37, 13);
            this.outputDescriptionLabel.TabIndex = 14;
            this.outputDescriptionLabel.Text = "Value:";
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(29, 98);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(123, 13);
            this.promptLabel.TabIndex = 13;
            this.promptLabel.Text = "Slide to adjust the value.";
            // 
            // valueLabel
            // 
            this.valueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.valueLabel.Location = new System.Drawing.Point(79, 18);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(65, 23);
            this.valueLabel.TabIndex = 12;
            // 
            // vScrollBar
            // 
            this.vScrollBar.Location = new System.Drawing.Point(176, 23);
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(19, 88);
            this.vScrollBar.TabIndex = 15;
            this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 134);
            this.Controls.Add(this.vScrollBar);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.valueLabel);
            this.Name = "Form1";
            this.Text = "VScrollBar Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label outputDescriptionLabel;
        internal System.Windows.Forms.Label promptLabel;
        internal System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.VScrollBar vScrollBar;
    }
}

