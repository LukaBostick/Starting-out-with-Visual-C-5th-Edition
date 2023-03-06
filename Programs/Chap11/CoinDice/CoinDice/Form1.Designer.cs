namespace CoinDice
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
            this.tossDieButton = new System.Windows.Forms.Button();
            this.dieLabel = new System.Windows.Forms.Label();
            this.tossCoinButton = new System.Windows.Forms.Button();
            this.coinLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tossDieButton
            // 
            this.tossDieButton.Location = new System.Drawing.Point(157, 67);
            this.tossDieButton.Name = "tossDieButton";
            this.tossDieButton.Size = new System.Drawing.Size(88, 23);
            this.tossDieButton.TabIndex = 7;
            this.tossDieButton.Text = "Toss the Die";
            this.tossDieButton.UseVisualStyleBackColor = true;
            // 
            // dieLabel
            // 
            this.dieLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dieLabel.Location = new System.Drawing.Point(151, 30);
            this.dieLabel.Name = "dieLabel";
            this.dieLabel.Size = new System.Drawing.Size(100, 23);
            this.dieLabel.TabIndex = 6;
            this.dieLabel.Text = "1";
            this.dieLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tossCoinButton
            // 
            this.tossCoinButton.Location = new System.Drawing.Point(31, 67);
            this.tossCoinButton.Name = "tossCoinButton";
            this.tossCoinButton.Size = new System.Drawing.Size(88, 23);
            this.tossCoinButton.TabIndex = 5;
            this.tossCoinButton.Text = "Toss the Coin";
            this.tossCoinButton.UseVisualStyleBackColor = true;
            // 
            // coinLabel
            // 
            this.coinLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coinLabel.Location = new System.Drawing.Point(25, 30);
            this.coinLabel.Name = "coinLabel";
            this.coinLabel.Size = new System.Drawing.Size(100, 23);
            this.coinLabel.TabIndex = 4;
            this.coinLabel.Text = "Heads";
            this.coinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 121);
            this.Controls.Add(this.tossDieButton);
            this.Controls.Add(this.dieLabel);
            this.Controls.Add(this.tossCoinButton);
            this.Controls.Add(this.coinLabel);
            this.Name = "Form1";
            this.Text = "Coin & Die";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tossDieButton;
        private System.Windows.Forms.Label dieLabel;
        private System.Windows.Forms.Button tossCoinButton;
        private System.Windows.Forms.Label coinLabel;
    }
}

