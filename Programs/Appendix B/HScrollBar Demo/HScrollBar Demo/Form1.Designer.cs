namespace HScrollBar_Demo
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
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(79, 26);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(37, 13);
            this.outputDescriptionLabel.TabIndex = 11;
            this.outputDescriptionLabel.Text = "Value:";
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(72, 101);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(123, 13);
            this.promptLabel.TabIndex = 10;
            this.promptLabel.Text = "Slide to adjust the value.";
            // 
            // valueLabel
            // 
            this.valueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.valueLabel.Location = new System.Drawing.Point(122, 21);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(65, 23);
            this.valueLabel.TabIndex = 9;
            // 
            // hScrollBar
            // 
            this.hScrollBar.Location = new System.Drawing.Point(30, 68);
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(206, 23);
            this.hScrollBar.TabIndex = 8;
            this.hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 134);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.hScrollBar);
            this.Name = "Form1";
            this.Text = "HScrollBar Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label outputDescriptionLabel;
        internal System.Windows.Forms.Label promptLabel;
        internal System.Windows.Forms.Label valueLabel;
        internal System.Windows.Forms.HScrollBar hScrollBar;
    }
}

