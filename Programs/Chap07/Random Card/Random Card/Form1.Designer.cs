namespace Random_Card
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
            this.getCardButton = new System.Windows.Forms.Button();
            this.cardPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // getCardButton
            // 
            this.getCardButton.Location = new System.Drawing.Point(87, 102);
            this.getCardButton.Name = "getCardButton";
            this.getCardButton.Size = new System.Drawing.Size(75, 36);
            this.getCardButton.TabIndex = 3;
            this.getCardButton.Text = "Get Random Card";
            this.getCardButton.UseVisualStyleBackColor = true;
            // 
            // cardPictureBox
            // 
            this.cardPictureBox.Image = global::Random_Card.Properties.Resources.Backface_Blue;
            this.cardPictureBox.Location = new System.Drawing.Point(99, 13);
            this.cardPictureBox.Name = "cardPictureBox";
            this.cardPictureBox.Size = new System.Drawing.Size(50, 70);
            this.cardPictureBox.TabIndex = 2;
            this.cardPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 150);
            this.Controls.Add(this.getCardButton);
            this.Controls.Add(this.cardPictureBox);
            this.Name = "Form1";
            this.Text = "Random Card";
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getCardButton;
        private System.Windows.Forms.PictureBox cardPictureBox;
    }
}

