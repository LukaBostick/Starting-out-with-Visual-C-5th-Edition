namespace Team_Player
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
            this.closeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.diff2Button = new System.Windows.Forms.Button();
            this.diff1Button = new System.Windows.Forms.Button();
            this.unionButton = new System.Windows.Forms.Button();
            this.intersectionButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.basketballListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.baseballListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(98, 371);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 21;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Results";
            // 
            // resultsListBox
            // 
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.Location = new System.Drawing.Point(75, 260);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(120, 95);
            this.resultsListBox.TabIndex = 19;
            // 
            // diff2Button
            // 
            this.diff2Button.Location = new System.Drawing.Point(139, 189);
            this.diff2Button.Name = "diff2Button";
            this.diff2Button.Size = new System.Drawing.Size(97, 45);
            this.diff2Button.TabIndex = 18;
            this.diff2Button.Text = "Basketball But Not Baseball";
            this.diff2Button.UseVisualStyleBackColor = true;
            // 
            // diff1Button
            // 
            this.diff1Button.Location = new System.Drawing.Point(37, 189);
            this.diff1Button.Name = "diff1Button";
            this.diff1Button.Size = new System.Drawing.Size(97, 45);
            this.diff1Button.TabIndex = 17;
            this.diff1Button.Text = "Baseball But Not Basketball";
            this.diff1Button.UseVisualStyleBackColor = true;
            // 
            // unionButton
            // 
            this.unionButton.Location = new System.Drawing.Point(139, 138);
            this.unionButton.Name = "unionButton";
            this.unionButton.Size = new System.Drawing.Size(97, 45);
            this.unionButton.TabIndex = 16;
            this.unionButton.Text = "Either Baseball Or Basketball";
            this.unionButton.UseVisualStyleBackColor = true;
            // 
            // intersectionButton
            // 
            this.intersectionButton.Location = new System.Drawing.Point(36, 138);
            this.intersectionButton.Name = "intersectionButton";
            this.intersectionButton.Size = new System.Drawing.Size(97, 45);
            this.intersectionButton.TabIndex = 15;
            this.intersectionButton.Text = "Both Baseball And Basketball";
            this.intersectionButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Basketball Team";
            // 
            // basketballListBox
            // 
            this.basketballListBox.FormattingEnabled = true;
            this.basketballListBox.Location = new System.Drawing.Point(138, 37);
            this.basketballListBox.Name = "basketballListBox";
            this.basketballListBox.Size = new System.Drawing.Size(120, 95);
            this.basketballListBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Baseball Team";
            // 
            // baseballListBox
            // 
            this.baseballListBox.FormattingEnabled = true;
            this.baseballListBox.Location = new System.Drawing.Point(12, 37);
            this.baseballListBox.Name = "baseballListBox";
            this.baseballListBox.Size = new System.Drawing.Size(120, 95);
            this.baseballListBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 410);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultsListBox);
            this.Controls.Add(this.diff2Button);
            this.Controls.Add(this.diff1Button);
            this.Controls.Add(this.unionButton);
            this.Controls.Add(this.intersectionButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.basketballListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baseballListBox);
            this.Name = "Form1";
            this.Text = "Team Players";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.Button diff2Button;
        private System.Windows.Forms.Button diff1Button;
        private System.Windows.Forms.Button unionButton;
        private System.Windows.Forms.Button intersectionButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox basketballListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox baseballListBox;
    }
}

