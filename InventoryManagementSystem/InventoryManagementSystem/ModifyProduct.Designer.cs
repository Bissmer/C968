namespace InventoryManagementSystem
{
    partial class ModifyProduct
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
            this.modifyPrdMinTextBox = new System.Windows.Forms.TextBox();
            this.modifyPrdMinLabel = new System.Windows.Forms.Label();
            this.modifyPrdMaxTextBox = new System.Windows.Forms.TextBox();
            this.modifyPrdMaxLabel = new System.Windows.Forms.Label();
            this.modifyPrdPriceTextBox = new System.Windows.Forms.TextBox();
            this.modifyPrdPriceLabel = new System.Windows.Forms.Label();
            this.modifyPrdInventoryTextBox = new System.Windows.Forms.TextBox();
            this.modifyPrdInventoryLabel = new System.Windows.Forms.Label();
            this.modifyPrdNameTextBox = new System.Windows.Forms.TextBox();
            this.modifyPrdNameLabel = new System.Windows.Forms.Label();
            this.modifyPrdIDTextBox = new System.Windows.Forms.TextBox();
            this.modifyPrdIDLabel = new System.Windows.Forms.Label();
            this.modifyPrdSaveButton = new System.Windows.Forms.Button();
            this.modifyPrdCancelButton = new System.Windows.Forms.Button();
            this.modifyPrdAssociatedPartsLabel = new System.Windows.Forms.Label();
            this.modifyPrdAssociatedPartsGridView = new System.Windows.Forms.DataGridView();
            this.modifyPrdAssociatedPartsDeleteButton = new System.Windows.Forms.Button();
            this.modifyPrdAllCandidatePartsLabel = new System.Windows.Forms.Label();
            this.modifyPrdCandidatePartsGridView = new System.Windows.Forms.DataGridView();
            this.modifyPrdCandidatePartsAddButton = new System.Windows.Forms.Button();
            this.modifyPrdCandidatePartsSearchTextBox = new System.Windows.Forms.TextBox();
            this.modifyPrdCandidatePartsSearchButton = new System.Windows.Forms.Button();
            this.modifyPrdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.modifyPrdAssociatedPartsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyPrdCandidatePartsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // modifyPrdMinTextBox
            // 
            this.modifyPrdMinTextBox.Location = new System.Drawing.Point(317, 495);
            this.modifyPrdMinTextBox.Name = "modifyPrdMinTextBox";
            this.modifyPrdMinTextBox.Size = new System.Drawing.Size(80, 20);
            this.modifyPrdMinTextBox.TabIndex = 91;
            this.modifyPrdMinTextBox.Validated += new System.EventHandler(this.modifyPrdProductMinTextBox_Validating);
            // 
            // modifyPrdMinLabel
            // 
            this.modifyPrdMinLabel.AutoSize = true;
            this.modifyPrdMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPrdMinLabel.Location = new System.Drawing.Point(268, 495);
            this.modifyPrdMinLabel.Name = "modifyPrdMinLabel";
            this.modifyPrdMinLabel.Size = new System.Drawing.Size(34, 20);
            this.modifyPrdMinLabel.TabIndex = 90;
            this.modifyPrdMinLabel.Text = "Min";
            // 
            // modifyPrdMaxTextBox
            // 
            this.modifyPrdMaxTextBox.Location = new System.Drawing.Point(147, 493);
            this.modifyPrdMaxTextBox.Name = "modifyPrdMaxTextBox";
            this.modifyPrdMaxTextBox.Size = new System.Drawing.Size(80, 20);
            this.modifyPrdMaxTextBox.TabIndex = 89;
            this.modifyPrdMaxTextBox.Validated += new System.EventHandler(this.modifyPrdProductMaxTextBox_Validating);
            // 
            // modifyPrdMaxLabel
            // 
            this.modifyPrdMaxLabel.AutoSize = true;
            this.modifyPrdMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPrdMaxLabel.Location = new System.Drawing.Point(86, 493);
            this.modifyPrdMaxLabel.Name = "modifyPrdMaxLabel";
            this.modifyPrdMaxLabel.Size = new System.Drawing.Size(38, 20);
            this.modifyPrdMaxLabel.TabIndex = 88;
            this.modifyPrdMaxLabel.Text = "Max";
            // 
            // modifyPrdPriceTextBox
            // 
            this.modifyPrdPriceTextBox.Location = new System.Drawing.Point(147, 447);
            this.modifyPrdPriceTextBox.Name = "modifyPrdPriceTextBox";
            this.modifyPrdPriceTextBox.Size = new System.Drawing.Size(183, 20);
            this.modifyPrdPriceTextBox.TabIndex = 87;
            this.modifyPrdPriceTextBox.Validated += new System.EventHandler(this.modifyPrdProductPriceTextBox_Validating);
            // 
            // modifyPrdPriceLabel
            // 
            this.modifyPrdPriceLabel.AutoSize = true;
            this.modifyPrdPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPrdPriceLabel.ForeColor = System.Drawing.Color.Black;
            this.modifyPrdPriceLabel.Location = new System.Drawing.Point(35, 445);
            this.modifyPrdPriceLabel.Name = "modifyPrdPriceLabel";
            this.modifyPrdPriceLabel.Size = new System.Drawing.Size(89, 20);
            this.modifyPrdPriceLabel.TabIndex = 86;
            this.modifyPrdPriceLabel.Text = "Price / Cost";
            // 
            // modifyPrdInventoryTextBox
            // 
            this.modifyPrdInventoryTextBox.Location = new System.Drawing.Point(147, 398);
            this.modifyPrdInventoryTextBox.Name = "modifyPrdInventoryTextBox";
            this.modifyPrdInventoryTextBox.Size = new System.Drawing.Size(183, 20);
            this.modifyPrdInventoryTextBox.TabIndex = 85;
            this.modifyPrdInventoryTextBox.Validated += new System.EventHandler(this.modifyPrdProductInventoryTextBox_Validating);
            // 
            // modifyPrdInventoryLabel
            // 
            this.modifyPrdInventoryLabel.AutoSize = true;
            this.modifyPrdInventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPrdInventoryLabel.Location = new System.Drawing.Point(50, 398);
            this.modifyPrdInventoryLabel.Name = "modifyPrdInventoryLabel";
            this.modifyPrdInventoryLabel.Size = new System.Drawing.Size(74, 20);
            this.modifyPrdInventoryLabel.TabIndex = 84;
            this.modifyPrdInventoryLabel.Text = "Inventory";
            // 
            // modifyPrdNameTextBox
            // 
            this.modifyPrdNameTextBox.Location = new System.Drawing.Point(147, 350);
            this.modifyPrdNameTextBox.Name = "modifyPrdNameTextBox";
            this.modifyPrdNameTextBox.Size = new System.Drawing.Size(183, 20);
            this.modifyPrdNameTextBox.TabIndex = 83;
            this.modifyPrdNameTextBox.Validated += new System.EventHandler(this.modifyPrdProductNameTextBox_Validated);
            // 
            // modifyPrdNameLabel
            // 
            this.modifyPrdNameLabel.AutoSize = true;
            this.modifyPrdNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPrdNameLabel.ForeColor = System.Drawing.Color.Black;
            this.modifyPrdNameLabel.Location = new System.Drawing.Point(73, 348);
            this.modifyPrdNameLabel.Name = "modifyPrdNameLabel";
            this.modifyPrdNameLabel.Size = new System.Drawing.Size(51, 20);
            this.modifyPrdNameLabel.TabIndex = 82;
            this.modifyPrdNameLabel.Text = "Name";
            // 
            // modifyPrdIDTextBox
            // 
            this.modifyPrdIDTextBox.Location = new System.Drawing.Point(147, 301);
            this.modifyPrdIDTextBox.Name = "modifyPrdIDTextBox";
            this.modifyPrdIDTextBox.Size = new System.Drawing.Size(183, 20);
            this.modifyPrdIDTextBox.TabIndex = 81;
            // 
            // modifyPrdIDLabel
            // 
            this.modifyPrdIDLabel.AutoSize = true;
            this.modifyPrdIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPrdIDLabel.Location = new System.Drawing.Point(98, 301);
            this.modifyPrdIDLabel.Name = "modifyPrdIDLabel";
            this.modifyPrdIDLabel.Size = new System.Drawing.Size(26, 20);
            this.modifyPrdIDLabel.TabIndex = 80;
            this.modifyPrdIDLabel.Text = "ID";
            // 
            // modifyPrdSaveButton
            // 
            this.modifyPrdSaveButton.Location = new System.Drawing.Point(981, 784);
            this.modifyPrdSaveButton.Name = "modifyPrdSaveButton";
            this.modifyPrdSaveButton.Size = new System.Drawing.Size(104, 41);
            this.modifyPrdSaveButton.TabIndex = 79;
            this.modifyPrdSaveButton.Text = "Save";
            this.modifyPrdSaveButton.UseVisualStyleBackColor = true;
            this.modifyPrdSaveButton.Click += new System.EventHandler(this.modifyPrdAddProductSaveButton_Click);
            // 
            // modifyPrdCancelButton
            // 
            this.modifyPrdCancelButton.Location = new System.Drawing.Point(1104, 784);
            this.modifyPrdCancelButton.Name = "modifyPrdCancelButton";
            this.modifyPrdCancelButton.Size = new System.Drawing.Size(104, 41);
            this.modifyPrdCancelButton.TabIndex = 78;
            this.modifyPrdCancelButton.Text = "Cancel";
            this.modifyPrdCancelButton.UseVisualStyleBackColor = true;
            this.modifyPrdCancelButton.Click += new System.EventHandler(this.modifyPrdAddProductCancelButton_Click);
            // 
            // modifyPrdAssociatedPartsLabel
            // 
            this.modifyPrdAssociatedPartsLabel.AutoSize = true;
            this.modifyPrdAssociatedPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPrdAssociatedPartsLabel.Location = new System.Drawing.Point(582, 438);
            this.modifyPrdAssociatedPartsLabel.Name = "modifyPrdAssociatedPartsLabel";
            this.modifyPrdAssociatedPartsLabel.Size = new System.Drawing.Size(338, 26);
            this.modifyPrdAssociatedPartsLabel.TabIndex = 77;
            this.modifyPrdAssociatedPartsLabel.Text = "Parts Associated with the Product";
            // 
            // modifyPrdAssociatedPartsGridView
            // 
            this.modifyPrdAssociatedPartsGridView.AllowUserToAddRows = false;
            this.modifyPrdAssociatedPartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modifyPrdAssociatedPartsGridView.Location = new System.Drawing.Point(587, 467);
            this.modifyPrdAssociatedPartsGridView.MultiSelect = false;
            this.modifyPrdAssociatedPartsGridView.Name = "modifyPrdAssociatedPartsGridView";
            this.modifyPrdAssociatedPartsGridView.ReadOnly = true;
            this.modifyPrdAssociatedPartsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modifyPrdAssociatedPartsGridView.Size = new System.Drawing.Size(621, 250);
            this.modifyPrdAssociatedPartsGridView.TabIndex = 76;
            this.modifyPrdAssociatedPartsGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.modifyPrdAssociatedPartsGridView_RowsAdded);
            this.modifyPrdAssociatedPartsGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.modifyPrdAssociatedPartsGridView_RowsRemoved);
            // 
            // modifyPrdAssociatedPartsDeleteButton
            // 
            this.modifyPrdAssociatedPartsDeleteButton.Enabled = false;
            this.modifyPrdAssociatedPartsDeleteButton.Location = new System.Drawing.Point(1110, 723);
            this.modifyPrdAssociatedPartsDeleteButton.Name = "modifyPrdAssociatedPartsDeleteButton";
            this.modifyPrdAssociatedPartsDeleteButton.Size = new System.Drawing.Size(98, 23);
            this.modifyPrdAssociatedPartsDeleteButton.TabIndex = 75;
            this.modifyPrdAssociatedPartsDeleteButton.Text = "Delete";
            this.modifyPrdAssociatedPartsDeleteButton.UseVisualStyleBackColor = true;
            this.modifyPrdAssociatedPartsDeleteButton.Click += new System.EventHandler(this.modifyPrdAssociatedPartsDeleteButton_Click);
            // 
            // modifyPrdAllCandidatePartsLabel
            // 
            this.modifyPrdAllCandidatePartsLabel.AutoSize = true;
            this.modifyPrdAllCandidatePartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPrdAllCandidatePartsLabel.Location = new System.Drawing.Point(582, 86);
            this.modifyPrdAllCandidatePartsLabel.Name = "modifyPrdAllCandidatePartsLabel";
            this.modifyPrdAllCandidatePartsLabel.Size = new System.Drawing.Size(199, 26);
            this.modifyPrdAllCandidatePartsLabel.TabIndex = 74;
            this.modifyPrdAllCandidatePartsLabel.Text = "All Candidate Parts";
            // 
            // modifyPrdCandidatePartsGridView
            // 
            this.modifyPrdCandidatePartsGridView.AllowUserToAddRows = false;
            this.modifyPrdCandidatePartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modifyPrdCandidatePartsGridView.Location = new System.Drawing.Point(587, 122);
            this.modifyPrdCandidatePartsGridView.MultiSelect = false;
            this.modifyPrdCandidatePartsGridView.Name = "modifyPrdCandidatePartsGridView";
            this.modifyPrdCandidatePartsGridView.ReadOnly = true;
            this.modifyPrdCandidatePartsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modifyPrdCandidatePartsGridView.Size = new System.Drawing.Size(621, 250);
            this.modifyPrdCandidatePartsGridView.TabIndex = 73;
            // 
            // modifyPrdCandidatePartsAddButton
            // 
            this.modifyPrdCandidatePartsAddButton.Location = new System.Drawing.Point(1110, 378);
            this.modifyPrdCandidatePartsAddButton.Name = "modifyPrdCandidatePartsAddButton";
            this.modifyPrdCandidatePartsAddButton.Size = new System.Drawing.Size(98, 23);
            this.modifyPrdCandidatePartsAddButton.TabIndex = 72;
            this.modifyPrdCandidatePartsAddButton.Text = "Add";
            this.modifyPrdCandidatePartsAddButton.UseVisualStyleBackColor = true;
            this.modifyPrdCandidatePartsAddButton.Click += new System.EventHandler(this.modifyPrdCandidatePartsAddButton_Click);
            // 
            // modifyPrdCandidatePartsSearchTextBox
            // 
            this.modifyPrdCandidatePartsSearchTextBox.Location = new System.Drawing.Point(1002, 92);
            this.modifyPrdCandidatePartsSearchTextBox.Name = "modifyPrdCandidatePartsSearchTextBox";
            this.modifyPrdCandidatePartsSearchTextBox.Size = new System.Drawing.Size(206, 20);
            this.modifyPrdCandidatePartsSearchTextBox.TabIndex = 71;
            // 
            // modifyPrdCandidatePartsSearchButton
            // 
            this.modifyPrdCandidatePartsSearchButton.Location = new System.Drawing.Point(877, 90);
            this.modifyPrdCandidatePartsSearchButton.Name = "modifyPrdCandidatePartsSearchButton";
            this.modifyPrdCandidatePartsSearchButton.Size = new System.Drawing.Size(92, 23);
            this.modifyPrdCandidatePartsSearchButton.TabIndex = 70;
            this.modifyPrdCandidatePartsSearchButton.Text = "Search";
            this.modifyPrdCandidatePartsSearchButton.UseVisualStyleBackColor = true;
            this.modifyPrdCandidatePartsSearchButton.Click += new System.EventHandler(this.modifyPrdCandidatePartsSearchButton_Click);
            // 
            // modifyPrdLabel
            // 
            this.modifyPrdLabel.AutoSize = true;
            this.modifyPrdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPrdLabel.Location = new System.Drawing.Point(21, 31);
            this.modifyPrdLabel.Name = "modifyPrdLabel";
            this.modifyPrdLabel.Size = new System.Drawing.Size(157, 26);
            this.modifyPrdLabel.TabIndex = 69;
            this.modifyPrdLabel.Text = "Modify Product";
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1255, 861);
            this.Controls.Add(this.modifyPrdMinTextBox);
            this.Controls.Add(this.modifyPrdMinLabel);
            this.Controls.Add(this.modifyPrdMaxTextBox);
            this.Controls.Add(this.modifyPrdMaxLabel);
            this.Controls.Add(this.modifyPrdPriceTextBox);
            this.Controls.Add(this.modifyPrdPriceLabel);
            this.Controls.Add(this.modifyPrdInventoryTextBox);
            this.Controls.Add(this.modifyPrdInventoryLabel);
            this.Controls.Add(this.modifyPrdNameTextBox);
            this.Controls.Add(this.modifyPrdNameLabel);
            this.Controls.Add(this.modifyPrdIDTextBox);
            this.Controls.Add(this.modifyPrdIDLabel);
            this.Controls.Add(this.modifyPrdSaveButton);
            this.Controls.Add(this.modifyPrdCancelButton);
            this.Controls.Add(this.modifyPrdAssociatedPartsLabel);
            this.Controls.Add(this.modifyPrdAssociatedPartsGridView);
            this.Controls.Add(this.modifyPrdAssociatedPartsDeleteButton);
            this.Controls.Add(this.modifyPrdAllCandidatePartsLabel);
            this.Controls.Add(this.modifyPrdCandidatePartsGridView);
            this.Controls.Add(this.modifyPrdCandidatePartsAddButton);
            this.Controls.Add(this.modifyPrdCandidatePartsSearchTextBox);
            this.Controls.Add(this.modifyPrdCandidatePartsSearchButton);
            this.Controls.Add(this.modifyPrdLabel);
            this.Name = "ModifyProduct";
            this.Text = "ModifyProduct";
            ((System.ComponentModel.ISupportInitialize)(this.modifyPrdAssociatedPartsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyPrdCandidatePartsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox modifyPrdMinTextBox;
        private System.Windows.Forms.Label modifyPrdMinLabel;
        private System.Windows.Forms.TextBox modifyPrdMaxTextBox;
        private System.Windows.Forms.Label modifyPrdMaxLabel;
        private System.Windows.Forms.TextBox modifyPrdPriceTextBox;
        private System.Windows.Forms.Label modifyPrdPriceLabel;
        private System.Windows.Forms.TextBox modifyPrdInventoryTextBox;
        private System.Windows.Forms.Label modifyPrdInventoryLabel;
        private System.Windows.Forms.TextBox modifyPrdNameTextBox;
        private System.Windows.Forms.Label modifyPrdNameLabel;
        private System.Windows.Forms.TextBox modifyPrdIDTextBox;
        private System.Windows.Forms.Label modifyPrdIDLabel;
        private System.Windows.Forms.Button modifyPrdSaveButton;
        private System.Windows.Forms.Button modifyPrdCancelButton;
        private System.Windows.Forms.Label modifyPrdAssociatedPartsLabel;
        public System.Windows.Forms.DataGridView modifyPrdAssociatedPartsGridView;
        private System.Windows.Forms.Button modifyPrdAssociatedPartsDeleteButton;
        private System.Windows.Forms.Label modifyPrdAllCandidatePartsLabel;
        public System.Windows.Forms.DataGridView modifyPrdCandidatePartsGridView;
        private System.Windows.Forms.Button modifyPrdCandidatePartsAddButton;
        private System.Windows.Forms.TextBox modifyPrdCandidatePartsSearchTextBox;
        private System.Windows.Forms.Button modifyPrdCandidatePartsSearchButton;
        public System.Windows.Forms.Label modifyPrdLabel;
    }
}