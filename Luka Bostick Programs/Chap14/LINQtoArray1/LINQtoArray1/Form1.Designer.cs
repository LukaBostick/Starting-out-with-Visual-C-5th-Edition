namespace LINQtoArray1
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
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.getValuesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultsListBox
            // 
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.Location = new System.Drawing.Point(40, 21);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(120, 95);
            this.resultsListBox.TabIndex = 0;
            // 
            // getValuesButton
            // 
            this.getValuesButton.Location = new System.Drawing.Point(58, 131);
            this.getValuesButton.Name = "getValuesButton";
            this.getValuesButton.Size = new System.Drawing.Size(75, 23);
            this.getValuesButton.TabIndex = 1;
            this.getValuesButton.Text = "Get Values";
            this.getValuesButton.UseVisualStyleBackColor = true;
            this.getValuesButton.Click += new System.EventHandler(this.getValuesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 174);
            this.Controls.Add(this.getValuesButton);
            this.Controls.Add(this.resultsListBox);
            this.Name = "Form1";
            this.Text = "LINQtoArray1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.Button getValuesButton;
    }
}

