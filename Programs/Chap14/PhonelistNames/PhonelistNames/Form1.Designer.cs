namespace PhonelistNames
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
            this.personListBox = new System.Windows.Forms.ListBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personListBox
            // 
            this.personListBox.FormattingEnabled = true;
            this.personListBox.Location = new System.Drawing.Point(12, 12);
            this.personListBox.Name = "personListBox";
            this.personListBox.Size = new System.Drawing.Size(215, 160);
            this.personListBox.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(82, 183);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 218);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.personListBox);
            this.Name = "Form1";
            this.Text = "Phonelist Names";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox personListBox;
        private System.Windows.Forms.Button closeButton;
    }
}

