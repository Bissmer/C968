namespace InventoryManagementSystem
{
    partial class ModifyPart
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
            this.cancelModifyPartBtn = new System.Windows.Forms.Button();
            this.saveModifyPartBtn = new System.Windows.Forms.Button();
            this.modifyPartMachineCompanyTextBox = new System.Windows.Forms.TextBox();
            this.modifyPartPartMachineCompanyLabel = new System.Windows.Forms.Label();
            this.modifyPartMinTextBox = new System.Windows.Forms.TextBox();
            this.modifyPartMinLabel = new System.Windows.Forms.Label();
            this.modifyPartMaxTextBox = new System.Windows.Forms.TextBox();
            this.modifyPartMaxLabel = new System.Windows.Forms.Label();
            this.modifyPartPriceTextBox = new System.Windows.Forms.TextBox();
            this.modifyPartPriceLabel = new System.Windows.Forms.Label();
            this.modifyPartInventoryTextBox = new System.Windows.Forms.TextBox();
            this.modifyPartInventoryLabel = new System.Windows.Forms.Label();
            this.modifyPartNameTextBox = new System.Windows.Forms.TextBox();
            this.modifyPartNameLabel = new System.Windows.Forms.Label();
            this.modifyPartIdTextBox = new System.Windows.Forms.TextBox();
            this.modifyPartIDLabel = new System.Windows.Forms.Label();
            this.modifyPartOutsourcedRadio = new System.Windows.Forms.RadioButton();
            this.modifyPartInHouseRadio = new System.Windows.Forms.RadioButton();
            this.modifyPartLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelModifyPartBtn
            // 
            this.cancelModifyPartBtn.Location = new System.Drawing.Point(404, 434);
            this.cancelModifyPartBtn.Name = "cancelModifyPartBtn";
            this.cancelModifyPartBtn.Size = new System.Drawing.Size(75, 40);
            this.cancelModifyPartBtn.TabIndex = 62;
            this.cancelModifyPartBtn.Text = "Cancel";
            this.cancelModifyPartBtn.UseVisualStyleBackColor = true;
            this.cancelModifyPartBtn.Click += new System.EventHandler(this.cancelModifyPartBtn_Click);
            // 
            // saveModifyPartBtn
            // 
            this.saveModifyPartBtn.Location = new System.Drawing.Point(312, 434);
            this.saveModifyPartBtn.Name = "saveModifyPartBtn";
            this.saveModifyPartBtn.Size = new System.Drawing.Size(75, 40);
            this.saveModifyPartBtn.TabIndex = 61;
            this.saveModifyPartBtn.Text = "Save";
            this.saveModifyPartBtn.UseVisualStyleBackColor = true;
            this.saveModifyPartBtn.Click += new System.EventHandler(this.saveModifyPartBtn_Click);
            // 
            // modifyPartMachineCompanyTextBox
            // 
            this.modifyPartMachineCompanyTextBox.Location = new System.Drawing.Point(229, 353);
            this.modifyPartMachineCompanyTextBox.Name = "modifyPartMachineCompanyTextBox";
            this.modifyPartMachineCompanyTextBox.Size = new System.Drawing.Size(183, 20);
            this.modifyPartMachineCompanyTextBox.TabIndex = 60;
            this.modifyPartMachineCompanyTextBox.Validated += new System.EventHandler(this.modifyPartMachineCompanyTextBox_Validating);
            // 
            // modifyPartPartMachineCompanyLabel
            // 
            this.modifyPartPartMachineCompanyLabel.AutoSize = true;
            this.modifyPartPartMachineCompanyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartPartMachineCompanyLabel.Location = new System.Drawing.Point(84, 351);
            this.modifyPartPartMachineCompanyLabel.Name = "modifyPartPartMachineCompanyLabel";
            this.modifyPartPartMachineCompanyLabel.Size = new System.Drawing.Size(122, 20);
            this.modifyPartPartMachineCompanyLabel.TabIndex = 59;
            this.modifyPartPartMachineCompanyLabel.Text = "Company Name";
            // 
            // modifyPartMinTextBox
            // 
            this.modifyPartMinTextBox.Location = new System.Drawing.Point(399, 310);
            this.modifyPartMinTextBox.Name = "modifyPartMinTextBox";
            this.modifyPartMinTextBox.Size = new System.Drawing.Size(80, 20);
            this.modifyPartMinTextBox.TabIndex = 56;
            this.modifyPartMinTextBox.Validated += new System.EventHandler(this.modifyPartMinTextBox_Validating);
            // 
            // modifyPartMinLabel
            // 
            this.modifyPartMinLabel.AutoSize = true;
            this.modifyPartMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartMinLabel.Location = new System.Drawing.Point(350, 310);
            this.modifyPartMinLabel.Name = "modifyPartMinLabel";
            this.modifyPartMinLabel.Size = new System.Drawing.Size(34, 20);
            this.modifyPartMinLabel.TabIndex = 55;
            this.modifyPartMinLabel.Text = "Min";
            // 
            // modifyPartMaxTextBox
            // 
            this.modifyPartMaxTextBox.Location = new System.Drawing.Point(229, 308);
            this.modifyPartMaxTextBox.Name = "modifyPartMaxTextBox";
            this.modifyPartMaxTextBox.Size = new System.Drawing.Size(80, 20);
            this.modifyPartMaxTextBox.TabIndex = 54;
            this.modifyPartMaxTextBox.Validated += new System.EventHandler(this.modifyPartMaxTextBox_Validating);
            // 
            // modifyPartMaxLabel
            // 
            this.modifyPartMaxLabel.AutoSize = true;
            this.modifyPartMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartMaxLabel.Location = new System.Drawing.Point(168, 308);
            this.modifyPartMaxLabel.Name = "modifyPartMaxLabel";
            this.modifyPartMaxLabel.Size = new System.Drawing.Size(38, 20);
            this.modifyPartMaxLabel.TabIndex = 53;
            this.modifyPartMaxLabel.Text = "Max";
            // 
            // modifyPartPriceTextBox
            // 
            this.modifyPartPriceTextBox.Location = new System.Drawing.Point(229, 262);
            this.modifyPartPriceTextBox.Name = "modifyPartPriceTextBox";
            this.modifyPartPriceTextBox.Size = new System.Drawing.Size(183, 20);
            this.modifyPartPriceTextBox.TabIndex = 52;
            this.modifyPartPriceTextBox.Validated += new System.EventHandler(this.modifyPartPriceTextBox_Validating);
            // 
            // modifyPartPriceLabel
            // 
            this.modifyPartPriceLabel.AutoSize = true;
            this.modifyPartPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartPriceLabel.ForeColor = System.Drawing.Color.Black;
            this.modifyPartPriceLabel.Location = new System.Drawing.Point(117, 260);
            this.modifyPartPriceLabel.Name = "modifyPartPriceLabel";
            this.modifyPartPriceLabel.Size = new System.Drawing.Size(89, 20);
            this.modifyPartPriceLabel.TabIndex = 51;
            this.modifyPartPriceLabel.Text = "Price / Cost";
            // 
            // modifyPartInventoryTextBox
            // 
            this.modifyPartInventoryTextBox.Location = new System.Drawing.Point(229, 213);
            this.modifyPartInventoryTextBox.Name = "modifyPartInventoryTextBox";
            this.modifyPartInventoryTextBox.Size = new System.Drawing.Size(183, 20);
            this.modifyPartInventoryTextBox.TabIndex = 50;
            this.modifyPartInventoryTextBox.Validated += new System.EventHandler(this.modifyPartInventoryTextBox_Validating);
            // 
            // modifyPartInventoryLabel
            // 
            this.modifyPartInventoryLabel.AutoSize = true;
            this.modifyPartInventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartInventoryLabel.Location = new System.Drawing.Point(132, 213);
            this.modifyPartInventoryLabel.Name = "modifyPartInventoryLabel";
            this.modifyPartInventoryLabel.Size = new System.Drawing.Size(74, 20);
            this.modifyPartInventoryLabel.TabIndex = 49;
            this.modifyPartInventoryLabel.Text = "Inventory";
            // 
            // modifyPartNameTextBox
            // 
            this.modifyPartNameTextBox.Location = new System.Drawing.Point(229, 165);
            this.modifyPartNameTextBox.Name = "modifyPartNameTextBox";
            this.modifyPartNameTextBox.Size = new System.Drawing.Size(183, 20);
            this.modifyPartNameTextBox.TabIndex = 48;
            this.modifyPartNameTextBox.Validated += new System.EventHandler(this.modifyPartNameTextBox_Validating);
            // 
            // modifyPartNameLabel
            // 
            this.modifyPartNameLabel.AutoSize = true;
            this.modifyPartNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartNameLabel.ForeColor = System.Drawing.Color.Black;
            this.modifyPartNameLabel.Location = new System.Drawing.Point(155, 163);
            this.modifyPartNameLabel.Name = "modifyPartNameLabel";
            this.modifyPartNameLabel.Size = new System.Drawing.Size(51, 20);
            this.modifyPartNameLabel.TabIndex = 47;
            this.modifyPartNameLabel.Text = "Name";
            // 
            // modifyPartIdTextBox
            // 
            this.modifyPartIdTextBox.Location = new System.Drawing.Point(229, 116);
            this.modifyPartIdTextBox.Name = "modifyPartIdTextBox";
            this.modifyPartIdTextBox.ReadOnly = true;
            this.modifyPartIdTextBox.Size = new System.Drawing.Size(183, 20);
            this.modifyPartIdTextBox.TabIndex = 46;
            // 
            // modifyPartIDLabel
            // 
            this.modifyPartIDLabel.AutoSize = true;
            this.modifyPartIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartIDLabel.Location = new System.Drawing.Point(180, 116);
            this.modifyPartIDLabel.Name = "modifyPartIDLabel";
            this.modifyPartIDLabel.Size = new System.Drawing.Size(26, 20);
            this.modifyPartIDLabel.TabIndex = 45;
            this.modifyPartIDLabel.Text = "ID";
            // 
            // modifyPartOutsourcedRadio
            // 
            this.modifyPartOutsourcedRadio.AutoSize = true;
            this.modifyPartOutsourcedRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartOutsourcedRadio.Location = new System.Drawing.Point(312, 35);
            this.modifyPartOutsourcedRadio.Name = "modifyPartOutsourcedRadio";
            this.modifyPartOutsourcedRadio.Size = new System.Drawing.Size(100, 21);
            this.modifyPartOutsourcedRadio.TabIndex = 44;
            this.modifyPartOutsourcedRadio.TabStop = true;
            this.modifyPartOutsourcedRadio.Text = "Outsourced";
            this.modifyPartOutsourcedRadio.UseVisualStyleBackColor = true;
            this.modifyPartOutsourcedRadio.CheckedChanged += new System.EventHandler(this.modifyPartOutsourcedRadio_CheckedChanged);
            // 
            // modifyPartInHouseRadio
            // 
            this.modifyPartInHouseRadio.AutoSize = true;
            this.modifyPartInHouseRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartInHouseRadio.Location = new System.Drawing.Point(184, 35);
            this.modifyPartInHouseRadio.Name = "modifyPartInHouseRadio";
            this.modifyPartInHouseRadio.Size = new System.Drawing.Size(83, 21);
            this.modifyPartInHouseRadio.TabIndex = 43;
            this.modifyPartInHouseRadio.TabStop = true;
            this.modifyPartInHouseRadio.Text = "In-House";
            this.modifyPartInHouseRadio.UseVisualStyleBackColor = true;
            this.modifyPartInHouseRadio.CheckedChanged += new System.EventHandler(this.modifyPartInHouseRadio_CheckedChanged);
            // 
            // modifyPartLabel
            // 
            this.modifyPartLabel.AutoEllipsis = true;
            this.modifyPartLabel.AutoSize = true;
            this.modifyPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartLabel.Location = new System.Drawing.Point(24, 30);
            this.modifyPartLabel.Name = "modifyPartLabel";
            this.modifyPartLabel.Size = new System.Drawing.Size(122, 26);
            this.modifyPartLabel.TabIndex = 42;
            this.modifyPartLabel.Text = "Modify Part";
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 555);
            this.Controls.Add(this.cancelModifyPartBtn);
            this.Controls.Add(this.saveModifyPartBtn);
            this.Controls.Add(this.modifyPartMachineCompanyTextBox);
            this.Controls.Add(this.modifyPartPartMachineCompanyLabel);
            this.Controls.Add(this.modifyPartMinTextBox);
            this.Controls.Add(this.modifyPartMinLabel);
            this.Controls.Add(this.modifyPartMaxTextBox);
            this.Controls.Add(this.modifyPartMaxLabel);
            this.Controls.Add(this.modifyPartPriceTextBox);
            this.Controls.Add(this.modifyPartPriceLabel);
            this.Controls.Add(this.modifyPartInventoryTextBox);
            this.Controls.Add(this.modifyPartInventoryLabel);
            this.Controls.Add(this.modifyPartNameTextBox);
            this.Controls.Add(this.modifyPartNameLabel);
            this.Controls.Add(this.modifyPartIdTextBox);
            this.Controls.Add(this.modifyPartIDLabel);
            this.Controls.Add(this.modifyPartOutsourcedRadio);
            this.Controls.Add(this.modifyPartInHouseRadio);
            this.Controls.Add(this.modifyPartLabel);
            this.Name = "ModifyPart";
            this.Text = "ModifyPart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelModifyPartBtn;
        private System.Windows.Forms.Button saveModifyPartBtn;
        private System.Windows.Forms.TextBox modifyPartMachineCompanyTextBox;
        private System.Windows.Forms.Label modifyPartPartMachineCompanyLabel;
        private System.Windows.Forms.TextBox modifyPartMinTextBox;
        private System.Windows.Forms.Label modifyPartMinLabel;
        private System.Windows.Forms.TextBox modifyPartMaxTextBox;
        private System.Windows.Forms.Label modifyPartMaxLabel;
        private System.Windows.Forms.TextBox modifyPartPriceTextBox;
        private System.Windows.Forms.Label modifyPartPriceLabel;
        private System.Windows.Forms.TextBox modifyPartInventoryTextBox;
        private System.Windows.Forms.Label modifyPartInventoryLabel;
        private System.Windows.Forms.TextBox modifyPartNameTextBox;
        private System.Windows.Forms.Label modifyPartNameLabel;
        private System.Windows.Forms.TextBox modifyPartIdTextBox;
        private System.Windows.Forms.Label modifyPartIDLabel;
        private System.Windows.Forms.RadioButton modifyPartOutsourcedRadio;
        private System.Windows.Forms.RadioButton modifyPartInHouseRadio;
        private System.Windows.Forms.Label modifyPartLabel;
    }
}