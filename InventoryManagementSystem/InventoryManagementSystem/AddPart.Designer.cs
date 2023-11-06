namespace InventoryManagementSystem
{
    partial class addPart
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
            this.cancelAddPartBtn = new System.Windows.Forms.Button();
            this.saveAddPartBtn = new System.Windows.Forms.Button();
            this.addPartMachineCompanyTextBox = new System.Windows.Forms.TextBox();
            this.addPartMachineCompanyLabel = new System.Windows.Forms.Label();
            this.addPartMinTextBox = new System.Windows.Forms.TextBox();
            this.addPartMinLabel = new System.Windows.Forms.Label();
            this.addPartMaxTextBox = new System.Windows.Forms.TextBox();
            this.addPartMaxLabel = new System.Windows.Forms.Label();
            this.addPartPriceTextBox = new System.Windows.Forms.TextBox();
            this.addPartPriceLabel = new System.Windows.Forms.Label();
            this.addPartInventoryTextBox = new System.Windows.Forms.TextBox();
            this.addPartInventoryLabel = new System.Windows.Forms.Label();
            this.addPartNameTextBox = new System.Windows.Forms.TextBox();
            this.addPartNameLabel = new System.Windows.Forms.Label();
            this.addPartIdtTextBox = new System.Windows.Forms.TextBox();
            this.addPartPartIDLabel = new System.Windows.Forms.Label();
            this.addPartOutsourcedRadio = new System.Windows.Forms.RadioButton();
            this.addPartInHouseRadio = new System.Windows.Forms.RadioButton();
            this.addPartLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelAddPartBtn
            // 
            this.cancelAddPartBtn.Location = new System.Drawing.Point(404, 424);
            this.cancelAddPartBtn.Name = "cancelAddPartBtn";
            this.cancelAddPartBtn.Size = new System.Drawing.Size(75, 40);
            this.cancelAddPartBtn.TabIndex = 41;
            this.cancelAddPartBtn.Text = "Cancel";
            this.cancelAddPartBtn.UseVisualStyleBackColor = true;
            // 
            // saveAddPartBtn
            // 
            this.saveAddPartBtn.Location = new System.Drawing.Point(312, 424);
            this.saveAddPartBtn.Name = "saveAddPartBtn";
            this.saveAddPartBtn.Size = new System.Drawing.Size(75, 40);
            this.saveAddPartBtn.TabIndex = 40;
            this.saveAddPartBtn.Text = "Save";
            this.saveAddPartBtn.UseVisualStyleBackColor = true;
            this.saveAddPartBtn.Click += new System.EventHandler(this.saveAddPartBtn_Click);
            // 
            // addPartMachineCompanyTextBox
            // 
            this.addPartMachineCompanyTextBox.Location = new System.Drawing.Point(229, 342);
            this.addPartMachineCompanyTextBox.Name = "addPartMachineCompanyTextBox";
            this.addPartMachineCompanyTextBox.Size = new System.Drawing.Size(183, 20);
            this.addPartMachineCompanyTextBox.TabIndex = 39;
            this.addPartMachineCompanyTextBox.Validated += new System.EventHandler(this.addPartMachineCompanyTextBox_Validating);
            // 
            // addPartMachineCompanyLabel
            // 
            this.addPartMachineCompanyLabel.AutoSize = true;
            this.addPartMachineCompanyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartMachineCompanyLabel.Location = new System.Drawing.Point(84, 340);
            this.addPartMachineCompanyLabel.Name = "addPartMachineCompanyLabel";
            this.addPartMachineCompanyLabel.Size = new System.Drawing.Size(122, 20);
            this.addPartMachineCompanyLabel.TabIndex = 38;
            this.addPartMachineCompanyLabel.Text = "Company Name";
            // 
            // addPartMinTextBox
            // 
            this.addPartMinTextBox.Location = new System.Drawing.Point(399, 300);
            this.addPartMinTextBox.Name = "addPartMinTextBox";
            this.addPartMinTextBox.Size = new System.Drawing.Size(80, 20);
            this.addPartMinTextBox.TabIndex = 35;
            this.addPartMinTextBox.Validated += new System.EventHandler(this.addPartMinTextBox_Validating);
            // 
            // addPartMinLabel
            // 
            this.addPartMinLabel.AutoSize = true;
            this.addPartMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartMinLabel.Location = new System.Drawing.Point(350, 300);
            this.addPartMinLabel.Name = "addPartMinLabel";
            this.addPartMinLabel.Size = new System.Drawing.Size(34, 20);
            this.addPartMinLabel.TabIndex = 34;
            this.addPartMinLabel.Text = "Min";
            // 
            // addPartMaxTextBox
            // 
            this.addPartMaxTextBox.Location = new System.Drawing.Point(229, 298);
            this.addPartMaxTextBox.Name = "addPartMaxTextBox";
            this.addPartMaxTextBox.Size = new System.Drawing.Size(80, 20);
            this.addPartMaxTextBox.TabIndex = 33;
            this.addPartMaxTextBox.Validated += new System.EventHandler(this.addPartMaxTextBox_Validating);
            // 
            // addPartMaxLabel
            // 
            this.addPartMaxLabel.AutoSize = true;
            this.addPartMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartMaxLabel.Location = new System.Drawing.Point(168, 298);
            this.addPartMaxLabel.Name = "addPartMaxLabel";
            this.addPartMaxLabel.Size = new System.Drawing.Size(38, 20);
            this.addPartMaxLabel.TabIndex = 32;
            this.addPartMaxLabel.Text = "Max";
            // 
            // addPartPriceTextBox
            // 
            this.addPartPriceTextBox.Location = new System.Drawing.Point(229, 252);
            this.addPartPriceTextBox.Name = "addPartPriceTextBox";
            this.addPartPriceTextBox.Size = new System.Drawing.Size(183, 20);
            this.addPartPriceTextBox.TabIndex = 31;
            this.addPartPriceTextBox.Validated += new System.EventHandler(this.addPartPriceTextBox_Validating);
            // 
            // addPartPriceLabel
            // 
            this.addPartPriceLabel.AutoSize = true;
            this.addPartPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartPriceLabel.ForeColor = System.Drawing.Color.Black;
            this.addPartPriceLabel.Location = new System.Drawing.Point(117, 250);
            this.addPartPriceLabel.Name = "addPartPriceLabel";
            this.addPartPriceLabel.Size = new System.Drawing.Size(89, 20);
            this.addPartPriceLabel.TabIndex = 30;
            this.addPartPriceLabel.Text = "Price / Cost";
            // 
            // addPartInventoryTextBox
            // 
            this.addPartInventoryTextBox.Location = new System.Drawing.Point(229, 203);
            this.addPartInventoryTextBox.Name = "addPartInventoryTextBox";
            this.addPartInventoryTextBox.Size = new System.Drawing.Size(183, 20);
            this.addPartInventoryTextBox.TabIndex = 29;
            this.addPartInventoryTextBox.Validated += new System.EventHandler(this.addPartInventoryTextBox_Validating);
            // 
            // addPartInventoryLabel
            // 
            this.addPartInventoryLabel.AutoSize = true;
            this.addPartInventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartInventoryLabel.Location = new System.Drawing.Point(132, 203);
            this.addPartInventoryLabel.Name = "addPartInventoryLabel";
            this.addPartInventoryLabel.Size = new System.Drawing.Size(74, 20);
            this.addPartInventoryLabel.TabIndex = 28;
            this.addPartInventoryLabel.Text = "Inventory";
            // 
            // addPartNameTextBox
            // 
            this.addPartNameTextBox.Location = new System.Drawing.Point(229, 155);
            this.addPartNameTextBox.Name = "addPartNameTextBox";
            this.addPartNameTextBox.Size = new System.Drawing.Size(183, 20);
            this.addPartNameTextBox.TabIndex = 27;
            // 
            // addPartNameLabel
            // 
            this.addPartNameLabel.AutoSize = true;
            this.addPartNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartNameLabel.ForeColor = System.Drawing.Color.Black;
            this.addPartNameLabel.Location = new System.Drawing.Point(155, 153);
            this.addPartNameLabel.Name = "addPartNameLabel";
            this.addPartNameLabel.Size = new System.Drawing.Size(51, 20);
            this.addPartNameLabel.TabIndex = 26;
            this.addPartNameLabel.Text = "Name";
            // 
            // addPartIdtTextBox
            // 
            this.addPartIdtTextBox.Location = new System.Drawing.Point(229, 106);
            this.addPartIdtTextBox.Name = "addPartIdtTextBox";
            this.addPartIdtTextBox.Size = new System.Drawing.Size(183, 20);
            this.addPartIdtTextBox.TabIndex = 25;
            // 
            // addPartPartIDLabel
            // 
            this.addPartPartIDLabel.AutoSize = true;
            this.addPartPartIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartPartIDLabel.Location = new System.Drawing.Point(180, 106);
            this.addPartPartIDLabel.Name = "addPartPartIDLabel";
            this.addPartPartIDLabel.Size = new System.Drawing.Size(26, 20);
            this.addPartPartIDLabel.TabIndex = 24;
            this.addPartPartIDLabel.Text = "ID";
            // 
            // addPartOutsourcedRadio
            // 
            this.addPartOutsourcedRadio.AutoSize = true;
            this.addPartOutsourcedRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartOutsourcedRadio.Location = new System.Drawing.Point(312, 25);
            this.addPartOutsourcedRadio.Name = "addPartOutsourcedRadio";
            this.addPartOutsourcedRadio.Size = new System.Drawing.Size(100, 21);
            this.addPartOutsourcedRadio.TabIndex = 23;
            this.addPartOutsourcedRadio.TabStop = true;
            this.addPartOutsourcedRadio.Text = "Outsourced";
            this.addPartOutsourcedRadio.UseVisualStyleBackColor = true;
            this.addPartOutsourcedRadio.CheckedChanged += new System.EventHandler(this.outsourcedRadioAddPart_CheckedChanged);
            // 
            // addPartInHouseRadio
            // 
            this.addPartInHouseRadio.AutoSize = true;
            this.addPartInHouseRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartInHouseRadio.Location = new System.Drawing.Point(184, 25);
            this.addPartInHouseRadio.Name = "addPartInHouseRadio";
            this.addPartInHouseRadio.Size = new System.Drawing.Size(83, 21);
            this.addPartInHouseRadio.TabIndex = 22;
            this.addPartInHouseRadio.TabStop = true;
            this.addPartInHouseRadio.Text = "In-House";
            this.addPartInHouseRadio.UseVisualStyleBackColor = true;
            this.addPartInHouseRadio.CheckedChanged += new System.EventHandler(this.inHouseRadioAddPart_CheckedChanged);
            // 
            // addPartLabel
            // 
            this.addPartLabel.AutoEllipsis = true;
            this.addPartLabel.AutoSize = true;
            this.addPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartLabel.Location = new System.Drawing.Point(24, 20);
            this.addPartLabel.Name = "addPartLabel";
            this.addPartLabel.Size = new System.Drawing.Size(97, 26);
            this.addPartLabel.TabIndex = 21;
            this.addPartLabel.Text = "Add Part";
            // 
            // addPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 555);
            this.Controls.Add(this.cancelAddPartBtn);
            this.Controls.Add(this.saveAddPartBtn);
            this.Controls.Add(this.addPartMachineCompanyTextBox);
            this.Controls.Add(this.addPartMachineCompanyLabel);
            this.Controls.Add(this.addPartMinTextBox);
            this.Controls.Add(this.addPartMinLabel);
            this.Controls.Add(this.addPartMaxTextBox);
            this.Controls.Add(this.addPartMaxLabel);
            this.Controls.Add(this.addPartPriceTextBox);
            this.Controls.Add(this.addPartPriceLabel);
            this.Controls.Add(this.addPartInventoryTextBox);
            this.Controls.Add(this.addPartInventoryLabel);
            this.Controls.Add(this.addPartNameTextBox);
            this.Controls.Add(this.addPartNameLabel);
            this.Controls.Add(this.addPartIdtTextBox);
            this.Controls.Add(this.addPartPartIDLabel);
            this.Controls.Add(this.addPartOutsourcedRadio);
            this.Controls.Add(this.addPartInHouseRadio);
            this.Controls.Add(this.addPartLabel);
            this.Name = "addPart";
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelAddPartBtn;
        private System.Windows.Forms.Button saveAddPartBtn;
        private System.Windows.Forms.TextBox addPartMachineCompanyTextBox;
        private System.Windows.Forms.Label addPartMachineCompanyLabel;
        private System.Windows.Forms.TextBox addPartMinTextBox;
        private System.Windows.Forms.Label addPartMinLabel;
        private System.Windows.Forms.TextBox addPartMaxTextBox;
        private System.Windows.Forms.Label addPartMaxLabel;
        private System.Windows.Forms.TextBox addPartPriceTextBox;
        private System.Windows.Forms.Label addPartPriceLabel;
        private System.Windows.Forms.TextBox addPartInventoryTextBox;
        private System.Windows.Forms.Label addPartInventoryLabel;
        private System.Windows.Forms.TextBox addPartNameTextBox;
        private System.Windows.Forms.Label addPartNameLabel;
        private System.Windows.Forms.TextBox addPartIdtTextBox;
        private System.Windows.Forms.Label addPartPartIDLabel;
        private System.Windows.Forms.RadioButton addPartOutsourcedRadio;
        private System.Windows.Forms.RadioButton addPartInHouseRadio;
        private System.Windows.Forms.Label addPartLabel;
    }
}