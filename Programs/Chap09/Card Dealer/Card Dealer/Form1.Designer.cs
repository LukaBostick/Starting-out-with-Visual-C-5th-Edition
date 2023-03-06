namespace Card_Dealer
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
            this.cardsLeftLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dealButton = new System.Windows.Forms.Button();
            this.valueLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numCardsTextBox = new System.Windows.Forms.TextBox();
            this.dealtCardsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cardsLeftLabel
            // 
            this.cardsLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardsLeftLabel.Location = new System.Drawing.Point(127, 225);
            this.cardsLeftLabel.Name = "cardsLeftLabel";
            this.cardsLeftLabel.Size = new System.Drawing.Size(80, 23);
            this.cardsLeftLabel.TabIndex = 23;
            this.cardsLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Cards Left in Deck:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Number of Cards to Deal:";
            // 
            // dealButton
            // 
            this.dealButton.Location = new System.Drawing.Point(80, 45);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(75, 23);
            this.dealButton.TabIndex = 20;
            this.dealButton.Text = "Deal Cards";
            this.dealButton.UseVisualStyleBackColor = true;
            // 
            // valueLabel
            // 
            this.valueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valueLabel.Location = new System.Drawing.Point(127, 186);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(80, 23);
            this.valueLabel.TabIndex = 19;
            this.valueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Value of Hand:";
            // 
            // numCardsTextBox
            // 
            this.numCardsTextBox.Location = new System.Drawing.Point(152, 19);
            this.numCardsTextBox.Name = "numCardsTextBox";
            this.numCardsTextBox.Size = new System.Drawing.Size(59, 20);
            this.numCardsTextBox.TabIndex = 17;
            // 
            // dealtCardsListBox
            // 
            this.dealtCardsListBox.FormattingEnabled = true;
            this.dealtCardsListBox.Location = new System.Drawing.Point(21, 79);
            this.dealtCardsListBox.Name = "dealtCardsListBox";
            this.dealtCardsListBox.Size = new System.Drawing.Size(188, 95);
            this.dealtCardsListBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 267);
            this.Controls.Add(this.cardsLeftLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numCardsTextBox);
            this.Controls.Add(this.dealtCardsListBox);
            this.Name = "Form1";
            this.Text = "Card Dealer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cardsLeftLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numCardsTextBox;
        private System.Windows.Forms.ListBox dealtCardsListBox;
    }
}

