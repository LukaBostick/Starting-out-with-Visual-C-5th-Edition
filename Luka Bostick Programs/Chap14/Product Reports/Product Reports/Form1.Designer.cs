namespace Product_Reports
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
            this.qtyLT100Button = new System.Windows.Forms.Button();
            this.qtyGT100Button = new System.Windows.Forms.Button();
            this.priceLT100Button = new System.Windows.Forms.Button();
            this.priceGT100Button = new System.Windows.Forms.Button();
            this.descriptionListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(52, 170);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // qtyLT100Button
            // 
            this.qtyLT100Button.Location = new System.Drawing.Point(94, 141);
            this.qtyLT100Button.Name = "qtyLT100Button";
            this.qtyLT100Button.Size = new System.Drawing.Size(75, 23);
            this.qtyLT100Button.TabIndex = 10;
            this.qtyLT100Button.Text = "Qty < $100";
            this.qtyLT100Button.UseVisualStyleBackColor = true;
            // 
            // qtyGT100Button
            // 
            this.qtyGT100Button.Location = new System.Drawing.Point(13, 141);
            this.qtyGT100Button.Name = "qtyGT100Button";
            this.qtyGT100Button.Size = new System.Drawing.Size(75, 23);
            this.qtyGT100Button.TabIndex = 9;
            this.qtyGT100Button.Text = "Qty > $100";
            this.qtyGT100Button.UseVisualStyleBackColor = true;
            // 
            // priceLT100Button
            // 
            this.priceLT100Button.Location = new System.Drawing.Point(94, 112);
            this.priceLT100Button.Name = "priceLT100Button";
            this.priceLT100Button.Size = new System.Drawing.Size(75, 23);
            this.priceLT100Button.TabIndex = 8;
            this.priceLT100Button.Text = "Price < $100";
            this.priceLT100Button.UseVisualStyleBackColor = true;
            // 
            // priceGT100Button
            // 
            this.priceGT100Button.Location = new System.Drawing.Point(13, 112);
            this.priceGT100Button.Name = "priceGT100Button";
            this.priceGT100Button.Size = new System.Drawing.Size(75, 23);
            this.priceGT100Button.TabIndex = 7;
            this.priceGT100Button.Text = "Price > $100";
            this.priceGT100Button.UseVisualStyleBackColor = true;
            // 
            // descriptionListBox
            // 
            this.descriptionListBox.FormattingEnabled = true;
            this.descriptionListBox.Location = new System.Drawing.Point(13, 11);
            this.descriptionListBox.Name = "descriptionListBox";
            this.descriptionListBox.Size = new System.Drawing.Size(156, 95);
            this.descriptionListBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 204);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.qtyLT100Button);
            this.Controls.Add(this.qtyGT100Button);
            this.Controls.Add(this.priceLT100Button);
            this.Controls.Add(this.priceGT100Button);
            this.Controls.Add(this.descriptionListBox);
            this.Name = "Form1";
            this.Text = "Product Reports";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button qtyLT100Button;
        private System.Windows.Forms.Button qtyGT100Button;
        private System.Windows.Forms.Button priceLT100Button;
        private System.Windows.Forms.Button priceGT100Button;
        private System.Windows.Forms.ListBox descriptionListBox;
    }
}

