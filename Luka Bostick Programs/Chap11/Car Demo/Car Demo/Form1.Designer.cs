namespace Car_Demo
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
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.doorsTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.mileageTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.inputDoorsLabel = new System.Windows.Forms.Label();
            this.inputPriceLabel = new System.Windows.Forms.Label();
            this.inputMileageLabel = new System.Windows.Forms.Label();
            this.inputModelLabel = new System.Windows.Forms.Label();
            this.inputMakeLabel = new System.Windows.Forms.Label();
            this.objectGroupBox = new System.Windows.Forms.GroupBox();
            this.doorsLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.mileageLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.makeLabel = new System.Windows.Forms.Label();
            this.outputDoors = new System.Windows.Forms.Label();
            this.outputPriceLabel = new System.Windows.Forms.Label();
            this.outputMileageLabel = new System.Windows.Forms.Label();
            this.outputModelLabel = new System.Windows.Forms.Label();
            this.outputMakeLabel = new System.Windows.Forms.Label();
            this.createObjectButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.inputGroupBox.SuspendLayout();
            this.objectGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.doorsTextBox);
            this.inputGroupBox.Controls.Add(this.priceTextBox);
            this.inputGroupBox.Controls.Add(this.mileageTextBox);
            this.inputGroupBox.Controls.Add(this.modelTextBox);
            this.inputGroupBox.Controls.Add(this.makeTextBox);
            this.inputGroupBox.Controls.Add(this.inputDoorsLabel);
            this.inputGroupBox.Controls.Add(this.inputPriceLabel);
            this.inputGroupBox.Controls.Add(this.inputMileageLabel);
            this.inputGroupBox.Controls.Add(this.inputModelLabel);
            this.inputGroupBox.Controls.Add(this.inputMakeLabel);
            this.inputGroupBox.Location = new System.Drawing.Point(22, 13);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(180, 160);
            this.inputGroupBox.TabIndex = 0;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Enter Car Data";
            // 
            // doorsTextBox
            // 
            this.doorsTextBox.Location = new System.Drawing.Point(58, 126);
            this.doorsTextBox.Name = "doorsTextBox";
            this.doorsTextBox.Size = new System.Drawing.Size(100, 20);
            this.doorsTextBox.TabIndex = 9;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(58, 100);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 8;
            // 
            // mileageTextBox
            // 
            this.mileageTextBox.Location = new System.Drawing.Point(59, 74);
            this.mileageTextBox.Name = "mileageTextBox";
            this.mileageTextBox.Size = new System.Drawing.Size(100, 20);
            this.mileageTextBox.TabIndex = 7;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(59, 48);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 6;
            // 
            // makeTextBox
            // 
            this.makeTextBox.Location = new System.Drawing.Point(59, 22);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(100, 20);
            this.makeTextBox.TabIndex = 5;
            // 
            // inputDoorsLabel
            // 
            this.inputDoorsLabel.AutoSize = true;
            this.inputDoorsLabel.Location = new System.Drawing.Point(14, 129);
            this.inputDoorsLabel.Name = "inputDoorsLabel";
            this.inputDoorsLabel.Size = new System.Drawing.Size(38, 13);
            this.inputDoorsLabel.TabIndex = 4;
            this.inputDoorsLabel.Text = "Doors:";
            // 
            // inputPriceLabel
            // 
            this.inputPriceLabel.AutoSize = true;
            this.inputPriceLabel.Location = new System.Drawing.Point(18, 103);
            this.inputPriceLabel.Name = "inputPriceLabel";
            this.inputPriceLabel.Size = new System.Drawing.Size(34, 13);
            this.inputPriceLabel.TabIndex = 3;
            this.inputPriceLabel.Text = "Price:";
            // 
            // inputMileageLabel
            // 
            this.inputMileageLabel.AutoSize = true;
            this.inputMileageLabel.Location = new System.Drawing.Point(5, 77);
            this.inputMileageLabel.Name = "inputMileageLabel";
            this.inputMileageLabel.Size = new System.Drawing.Size(47, 13);
            this.inputMileageLabel.TabIndex = 2;
            this.inputMileageLabel.Text = "Mileage:";
            // 
            // inputModelLabel
            // 
            this.inputModelLabel.AutoSize = true;
            this.inputModelLabel.Location = new System.Drawing.Point(13, 51);
            this.inputModelLabel.Name = "inputModelLabel";
            this.inputModelLabel.Size = new System.Drawing.Size(39, 13);
            this.inputModelLabel.TabIndex = 1;
            this.inputModelLabel.Text = "Model:";
            // 
            // inputMakeLabel
            // 
            this.inputMakeLabel.AutoSize = true;
            this.inputMakeLabel.Location = new System.Drawing.Point(15, 25);
            this.inputMakeLabel.Name = "inputMakeLabel";
            this.inputMakeLabel.Size = new System.Drawing.Size(37, 13);
            this.inputMakeLabel.TabIndex = 0;
            this.inputMakeLabel.Text = "Make:";
            // 
            // objectGroupBox
            // 
            this.objectGroupBox.Controls.Add(this.doorsLabel);
            this.objectGroupBox.Controls.Add(this.priceLabel);
            this.objectGroupBox.Controls.Add(this.mileageLabel);
            this.objectGroupBox.Controls.Add(this.modelLabel);
            this.objectGroupBox.Controls.Add(this.makeLabel);
            this.objectGroupBox.Controls.Add(this.outputDoors);
            this.objectGroupBox.Controls.Add(this.outputPriceLabel);
            this.objectGroupBox.Controls.Add(this.outputMileageLabel);
            this.objectGroupBox.Controls.Add(this.outputModelLabel);
            this.objectGroupBox.Controls.Add(this.outputMakeLabel);
            this.objectGroupBox.Location = new System.Drawing.Point(22, 190);
            this.objectGroupBox.Name = "objectGroupBox";
            this.objectGroupBox.Size = new System.Drawing.Size(180, 170);
            this.objectGroupBox.TabIndex = 1;
            this.objectGroupBox.TabStop = false;
            this.objectGroupBox.Text = "Object Properties";
            // 
            // doorsLabel
            // 
            this.doorsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doorsLabel.Location = new System.Drawing.Point(61, 129);
            this.doorsLabel.Name = "doorsLabel";
            this.doorsLabel.Size = new System.Drawing.Size(100, 23);
            this.doorsLabel.TabIndex = 14;
            this.doorsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceLabel
            // 
            this.priceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceLabel.Location = new System.Drawing.Point(61, 103);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(100, 23);
            this.priceLabel.TabIndex = 13;
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mileageLabel
            // 
            this.mileageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mileageLabel.Location = new System.Drawing.Point(61, 77);
            this.mileageLabel.Name = "mileageLabel";
            this.mileageLabel.Size = new System.Drawing.Size(100, 23);
            this.mileageLabel.TabIndex = 12;
            this.mileageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modelLabel
            // 
            this.modelLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modelLabel.Location = new System.Drawing.Point(61, 51);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(100, 23);
            this.modelLabel.TabIndex = 11;
            this.modelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // makeLabel
            // 
            this.makeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.makeLabel.Location = new System.Drawing.Point(61, 25);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(100, 23);
            this.makeLabel.TabIndex = 10;
            this.makeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputDoors
            // 
            this.outputDoors.AutoSize = true;
            this.outputDoors.Location = new System.Drawing.Point(17, 134);
            this.outputDoors.Name = "outputDoors";
            this.outputDoors.Size = new System.Drawing.Size(38, 13);
            this.outputDoors.TabIndex = 9;
            this.outputDoors.Text = "Doors:";
            // 
            // outputPriceLabel
            // 
            this.outputPriceLabel.AutoSize = true;
            this.outputPriceLabel.Location = new System.Drawing.Point(21, 108);
            this.outputPriceLabel.Name = "outputPriceLabel";
            this.outputPriceLabel.Size = new System.Drawing.Size(34, 13);
            this.outputPriceLabel.TabIndex = 8;
            this.outputPriceLabel.Text = "Price:";
            // 
            // outputMileageLabel
            // 
            this.outputMileageLabel.AutoSize = true;
            this.outputMileageLabel.Location = new System.Drawing.Point(8, 82);
            this.outputMileageLabel.Name = "outputMileageLabel";
            this.outputMileageLabel.Size = new System.Drawing.Size(47, 13);
            this.outputMileageLabel.TabIndex = 7;
            this.outputMileageLabel.Text = "Mileage:";
            // 
            // outputModelLabel
            // 
            this.outputModelLabel.AutoSize = true;
            this.outputModelLabel.Location = new System.Drawing.Point(16, 56);
            this.outputModelLabel.Name = "outputModelLabel";
            this.outputModelLabel.Size = new System.Drawing.Size(39, 13);
            this.outputModelLabel.TabIndex = 6;
            this.outputModelLabel.Text = "Model:";
            // 
            // outputMakeLabel
            // 
            this.outputMakeLabel.AutoSize = true;
            this.outputMakeLabel.Location = new System.Drawing.Point(18, 30);
            this.outputMakeLabel.Name = "outputMakeLabel";
            this.outputMakeLabel.Size = new System.Drawing.Size(37, 13);
            this.outputMakeLabel.TabIndex = 5;
            this.outputMakeLabel.Text = "Make:";
            // 
            // createObjectButton
            // 
            this.createObjectButton.Location = new System.Drawing.Point(34, 376);
            this.createObjectButton.Name = "createObjectButton";
            this.createObjectButton.Size = new System.Drawing.Size(75, 40);
            this.createObjectButton.TabIndex = 2;
            this.createObjectButton.Text = "Create Object";
            this.createObjectButton.UseVisualStyleBackColor = true;
            this.createObjectButton.Click += new System.EventHandler(this.createObjectButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(115, 376);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 40);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 428);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.createObjectButton);
            this.Controls.Add(this.objectGroupBox);
            this.Controls.Add(this.inputGroupBox);
            this.Name = "Form1";
            this.Text = "Car Demo";
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.objectGroupBox.ResumeLayout(false);
            this.objectGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.TextBox doorsTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox mileageTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.Label inputDoorsLabel;
        private System.Windows.Forms.Label inputPriceLabel;
        private System.Windows.Forms.Label inputMileageLabel;
        private System.Windows.Forms.Label inputModelLabel;
        private System.Windows.Forms.Label inputMakeLabel;
        private System.Windows.Forms.GroupBox objectGroupBox;
        private System.Windows.Forms.Label doorsLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label mileageLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label outputDoors;
        private System.Windows.Forms.Label outputPriceLabel;
        private System.Windows.Forms.Label outputMileageLabel;
        private System.Windows.Forms.Label outputModelLabel;
        private System.Windows.Forms.Label outputMakeLabel;
        private System.Windows.Forms.Button createObjectButton;
        private System.Windows.Forms.Button exitButton;
    }
}

