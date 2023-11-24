namespace InventoryManagementSystem
{
    partial class AddProduct
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
            this.addPrdAllCandidatePartsLabel = new System.Windows.Forms.Label();
            this.addPrdCandidatePartsGridView = new System.Windows.Forms.DataGridView();
            this.addPrdCandidatePartsAddButton = new System.Windows.Forms.Button();
            this.addPrdCandidatePartsSearchTextBox = new System.Windows.Forms.TextBox();
            this.addPrdCandidatePartsSearchButton = new System.Windows.Forms.Button();
            this.addProductLabel = new System.Windows.Forms.Label();
            this.addPrdAssociatedPartsLabel = new System.Windows.Forms.Label();
            this.addPrdAssociatedPartsGridView = new System.Windows.Forms.DataGridView();
            this.addPrdAssociatedPartsDeleteButton = new System.Windows.Forms.Button();
            this.addPrdAddProductCancelButton = new System.Windows.Forms.Button();
            this.addPrdAddProductSaveButton = new System.Windows.Forms.Button();
            this.addPrdMinTextBox = new System.Windows.Forms.TextBox();
            this.addPrdMinLabel = new System.Windows.Forms.Label();
            this.addPrdMaxTextBox = new System.Windows.Forms.TextBox();
            this.addPrdMaxLabel = new System.Windows.Forms.Label();
            this.addPrdPriceTextBox = new System.Windows.Forms.TextBox();
            this.addPrdPriceLabel = new System.Windows.Forms.Label();
            this.addPrdInventoryTextBox = new System.Windows.Forms.TextBox();
            this.addPrdInventoryLabel = new System.Windows.Forms.Label();
            this.addPrdNameTextBox = new System.Windows.Forms.TextBox();
            this.addPrdNameLabel = new System.Windows.Forms.Label();
            this.addPrdIDTextBox = new System.Windows.Forms.TextBox();
            this.addPrdIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addPrdCandidatePartsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPrdAssociatedPartsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addPrdAllCandidatePartsLabel
            // 
            this.addPrdAllCandidatePartsLabel.AutoSize = true;
            this.addPrdAllCandidatePartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPrdAllCandidatePartsLabel.Location = new System.Drawing.Point(573, 82);
            this.addPrdAllCandidatePartsLabel.Name = "addPrdAllCandidatePartsLabel";
            this.addPrdAllCandidatePartsLabel.Size = new System.Drawing.Size(199, 26);
            this.addPrdAllCandidatePartsLabel.TabIndex = 42;
            this.addPrdAllCandidatePartsLabel.Text = "All Candidate Parts";
            // 
            // addPrdCandidatePartsGridView
            // 
            this.addPrdCandidatePartsGridView.AllowUserToAddRows = false;
            this.addPrdCandidatePartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addPrdCandidatePartsGridView.Location = new System.Drawing.Point(578, 118);
            this.addPrdCandidatePartsGridView.MultiSelect = false;
            this.addPrdCandidatePartsGridView.Name = "addPrdCandidatePartsGridView";
            this.addPrdCandidatePartsGridView.ReadOnly = true;
            this.addPrdCandidatePartsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addPrdCandidatePartsGridView.Size = new System.Drawing.Size(621, 250);
            this.addPrdCandidatePartsGridView.TabIndex = 41;
            // 
            // addPrdCandidatePartsAddButton
            // 
            this.addPrdCandidatePartsAddButton.Location = new System.Drawing.Point(1101, 374);
            this.addPrdCandidatePartsAddButton.Name = "addPrdCandidatePartsAddButton";
            this.addPrdCandidatePartsAddButton.Size = new System.Drawing.Size(98, 23);
            this.addPrdCandidatePartsAddButton.TabIndex = 38;
            this.addPrdCandidatePartsAddButton.Text = "Add";
            this.addPrdCandidatePartsAddButton.UseVisualStyleBackColor = true;
            this.addPrdCandidatePartsAddButton.Click += new System.EventHandler(this.candidatePartsAddButton_Click);
            // 
            // addPrdCandidatePartsSearchTextBox
            // 
            this.addPrdCandidatePartsSearchTextBox.Location = new System.Drawing.Point(993, 88);
            this.addPrdCandidatePartsSearchTextBox.Name = "addPrdCandidatePartsSearchTextBox";
            this.addPrdCandidatePartsSearchTextBox.Size = new System.Drawing.Size(206, 20);
            this.addPrdCandidatePartsSearchTextBox.TabIndex = 37;
            // 
            // addPrdCandidatePartsSearchButton
            // 
            this.addPrdCandidatePartsSearchButton.Location = new System.Drawing.Point(868, 86);
            this.addPrdCandidatePartsSearchButton.Name = "addPrdCandidatePartsSearchButton";
            this.addPrdCandidatePartsSearchButton.Size = new System.Drawing.Size(92, 23);
            this.addPrdCandidatePartsSearchButton.TabIndex = 36;
            this.addPrdCandidatePartsSearchButton.Text = "Search";
            this.addPrdCandidatePartsSearchButton.UseVisualStyleBackColor = true;
            this.addPrdCandidatePartsSearchButton.Click += new System.EventHandler(this.candidatePartsSearchButton_Click);
            // 
            // addProductLabel
            // 
            this.addProductLabel.AutoSize = true;
            this.addProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductLabel.Location = new System.Drawing.Point(12, 27);
            this.addProductLabel.Name = "addProductLabel";
            this.addProductLabel.Size = new System.Drawing.Size(132, 26);
            this.addProductLabel.TabIndex = 35;
            this.addProductLabel.Text = "Add Product";
            // 
            // addPrdAssociatedPartsLabel
            // 
            this.addPrdAssociatedPartsLabel.AutoSize = true;
            this.addPrdAssociatedPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPrdAssociatedPartsLabel.Location = new System.Drawing.Point(573, 434);
            this.addPrdAssociatedPartsLabel.Name = "addPrdAssociatedPartsLabel";
            this.addPrdAssociatedPartsLabel.Size = new System.Drawing.Size(338, 26);
            this.addPrdAssociatedPartsLabel.TabIndex = 47;
            this.addPrdAssociatedPartsLabel.Text = "Parts Associated with the Product";
            // 
            // addPrdAssociatedPartsGridView
            // 
            this.addPrdAssociatedPartsGridView.AllowUserToAddRows = false;
            this.addPrdAssociatedPartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addPrdAssociatedPartsGridView.Location = new System.Drawing.Point(578, 463);
            this.addPrdAssociatedPartsGridView.MultiSelect = false;
            this.addPrdAssociatedPartsGridView.Name = "addPrdAssociatedPartsGridView";
            this.addPrdAssociatedPartsGridView.ReadOnly = true;
            this.addPrdAssociatedPartsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addPrdAssociatedPartsGridView.Size = new System.Drawing.Size(621, 250);
            this.addPrdAssociatedPartsGridView.TabIndex = 46;
            this.addPrdAssociatedPartsGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.associatedPartsGridView_RowsAdded);
            this.addPrdAssociatedPartsGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.associatedPartsGridView_RowsRemoved);
            // 
            // addPrdAssociatedPartsDeleteButton
            // 
            this.addPrdAssociatedPartsDeleteButton.Enabled = false;
            this.addPrdAssociatedPartsDeleteButton.Location = new System.Drawing.Point(1101, 719);
            this.addPrdAssociatedPartsDeleteButton.Name = "addPrdAssociatedPartsDeleteButton";
            this.addPrdAssociatedPartsDeleteButton.Size = new System.Drawing.Size(98, 23);
            this.addPrdAssociatedPartsDeleteButton.TabIndex = 45;
            this.addPrdAssociatedPartsDeleteButton.Text = "Delete";
            this.addPrdAssociatedPartsDeleteButton.UseVisualStyleBackColor = true;
            this.addPrdAssociatedPartsDeleteButton.Click += new System.EventHandler(this.associatedPartsDeleteButton_Click);
            // 
            // addPrdAddProductCancelButton
            // 
            this.addPrdAddProductCancelButton.Location = new System.Drawing.Point(1095, 780);
            this.addPrdAddProductCancelButton.Name = "addPrdAddProductCancelButton";
            this.addPrdAddProductCancelButton.Size = new System.Drawing.Size(104, 41);
            this.addPrdAddProductCancelButton.TabIndex = 48;
            this.addPrdAddProductCancelButton.Text = "Cancel";
            this.addPrdAddProductCancelButton.UseVisualStyleBackColor = true;
            this.addPrdAddProductCancelButton.Click += new System.EventHandler(this.addProductCancelButton_Click);
            // 
            // addPrdAddProductSaveButton
            // 
            this.addPrdAddProductSaveButton.Location = new System.Drawing.Point(972, 780);
            this.addPrdAddProductSaveButton.Name = "addPrdAddProductSaveButton";
            this.addPrdAddProductSaveButton.Size = new System.Drawing.Size(104, 41);
            this.addPrdAddProductSaveButton.TabIndex = 49;
            this.addPrdAddProductSaveButton.Text = "Save";
            this.addPrdAddProductSaveButton.UseVisualStyleBackColor = true;
            this.addPrdAddProductSaveButton.Click += new System.EventHandler(this.addProductSaveButton_Click);
            // 
            // addPrdMinTextBox
            // 
            this.addPrdMinTextBox.Location = new System.Drawing.Point(308, 491);
            this.addPrdMinTextBox.Name = "addPrdMinTextBox";
            this.addPrdMinTextBox.Size = new System.Drawing.Size(80, 20);
            this.addPrdMinTextBox.TabIndex = 68;
            this.addPrdMinTextBox.Validated += new System.EventHandler(this.productMinTextBox_Validating);
            // 
            // addPrdMinLabel
            // 
            this.addPrdMinLabel.AutoSize = true;
            this.addPrdMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPrdMinLabel.Location = new System.Drawing.Point(259, 491);
            this.addPrdMinLabel.Name = "addPrdMinLabel";
            this.addPrdMinLabel.Size = new System.Drawing.Size(34, 20);
            this.addPrdMinLabel.TabIndex = 67;
            this.addPrdMinLabel.Text = "Min";
            // 
            // addPrdMaxTextBox
            // 
            this.addPrdMaxTextBox.Location = new System.Drawing.Point(138, 489);
            this.addPrdMaxTextBox.Name = "addPrdMaxTextBox";
            this.addPrdMaxTextBox.Size = new System.Drawing.Size(80, 20);
            this.addPrdMaxTextBox.TabIndex = 66;
            this.addPrdMaxTextBox.Validated += new System.EventHandler(this.productMaxTextBox_Validating);
            // 
            // addPrdMaxLabel
            // 
            this.addPrdMaxLabel.AutoSize = true;
            this.addPrdMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPrdMaxLabel.Location = new System.Drawing.Point(77, 489);
            this.addPrdMaxLabel.Name = "addPrdMaxLabel";
            this.addPrdMaxLabel.Size = new System.Drawing.Size(38, 20);
            this.addPrdMaxLabel.TabIndex = 65;
            this.addPrdMaxLabel.Text = "Max";
            // 
            // addPrdPriceTextBox
            // 
            this.addPrdPriceTextBox.Location = new System.Drawing.Point(138, 443);
            this.addPrdPriceTextBox.Name = "addPrdPriceTextBox";
            this.addPrdPriceTextBox.Size = new System.Drawing.Size(183, 20);
            this.addPrdPriceTextBox.TabIndex = 64;
            this.addPrdPriceTextBox.Validated += new System.EventHandler(this.productPriceTextBox_Validating);
            // 
            // addPrdPriceLabel
            // 
            this.addPrdPriceLabel.AutoSize = true;
            this.addPrdPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPrdPriceLabel.ForeColor = System.Drawing.Color.Black;
            this.addPrdPriceLabel.Location = new System.Drawing.Point(26, 441);
            this.addPrdPriceLabel.Name = "addPrdPriceLabel";
            this.addPrdPriceLabel.Size = new System.Drawing.Size(89, 20);
            this.addPrdPriceLabel.TabIndex = 63;
            this.addPrdPriceLabel.Text = "Price / Cost";
            // 
            // addPrdInventoryTextBox
            // 
            this.addPrdInventoryTextBox.Location = new System.Drawing.Point(138, 394);
            this.addPrdInventoryTextBox.Name = "addPrdInventoryTextBox";
            this.addPrdInventoryTextBox.Size = new System.Drawing.Size(183, 20);
            this.addPrdInventoryTextBox.TabIndex = 62;
            this.addPrdInventoryTextBox.Validated += new System.EventHandler(this.productInventoryTextBox_Validating);
            // 
            // addPrdInventoryLabel
            // 
            this.addPrdInventoryLabel.AutoSize = true;
            this.addPrdInventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPrdInventoryLabel.Location = new System.Drawing.Point(41, 394);
            this.addPrdInventoryLabel.Name = "addPrdInventoryLabel";
            this.addPrdInventoryLabel.Size = new System.Drawing.Size(74, 20);
            this.addPrdInventoryLabel.TabIndex = 61;
            this.addPrdInventoryLabel.Text = "Inventory";
            // 
            // addPrdNameTextBox
            // 
            this.addPrdNameTextBox.Location = new System.Drawing.Point(138, 346);
            this.addPrdNameTextBox.Name = "addPrdNameTextBox";
            this.addPrdNameTextBox.Size = new System.Drawing.Size(183, 20);
            this.addPrdNameTextBox.TabIndex = 60;
            this.addPrdNameTextBox.Validated += new System.EventHandler(this.productNameTextBox_Validated);
            // 
            // addPrdNameLabel
            // 
            this.addPrdNameLabel.AutoSize = true;
            this.addPrdNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPrdNameLabel.ForeColor = System.Drawing.Color.Black;
            this.addPrdNameLabel.Location = new System.Drawing.Point(64, 344);
            this.addPrdNameLabel.Name = "addPrdNameLabel";
            this.addPrdNameLabel.Size = new System.Drawing.Size(51, 20);
            this.addPrdNameLabel.TabIndex = 59;
            this.addPrdNameLabel.Text = "Name";
            // 
            // addPrdIDTextBox
            // 
            this.addPrdIDTextBox.Location = new System.Drawing.Point(138, 297);
            this.addPrdIDTextBox.Name = "addPrdIDTextBox";
            this.addPrdIDTextBox.Size = new System.Drawing.Size(183, 20);
            this.addPrdIDTextBox.TabIndex = 58;
            // 
            // addPrdIDLabel
            // 
            this.addPrdIDLabel.AutoSize = true;
            this.addPrdIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPrdIDLabel.Location = new System.Drawing.Point(89, 297);
            this.addPrdIDLabel.Name = "addPrdIDLabel";
            this.addPrdIDLabel.Size = new System.Drawing.Size(26, 20);
            this.addPrdIDLabel.TabIndex = 57;
            this.addPrdIDLabel.Text = "ID";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 861);
            this.Controls.Add(this.addPrdMinTextBox);
            this.Controls.Add(this.addPrdMinLabel);
            this.Controls.Add(this.addPrdMaxTextBox);
            this.Controls.Add(this.addPrdMaxLabel);
            this.Controls.Add(this.addPrdPriceTextBox);
            this.Controls.Add(this.addPrdPriceLabel);
            this.Controls.Add(this.addPrdInventoryTextBox);
            this.Controls.Add(this.addPrdInventoryLabel);
            this.Controls.Add(this.addPrdNameTextBox);
            this.Controls.Add(this.addPrdNameLabel);
            this.Controls.Add(this.addPrdIDTextBox);
            this.Controls.Add(this.addPrdIDLabel);
            this.Controls.Add(this.addPrdAddProductSaveButton);
            this.Controls.Add(this.addPrdAddProductCancelButton);
            this.Controls.Add(this.addPrdAssociatedPartsLabel);
            this.Controls.Add(this.addPrdAssociatedPartsGridView);
            this.Controls.Add(this.addPrdAssociatedPartsDeleteButton);
            this.Controls.Add(this.addPrdAllCandidatePartsLabel);
            this.Controls.Add(this.addPrdCandidatePartsGridView);
            this.Controls.Add(this.addPrdCandidatePartsAddButton);
            this.Controls.Add(this.addPrdCandidatePartsSearchTextBox);
            this.Controls.Add(this.addPrdCandidatePartsSearchButton);
            this.Controls.Add(this.addProductLabel);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.addPrdCandidatePartsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPrdAssociatedPartsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addPrdAllCandidatePartsLabel;
        public System.Windows.Forms.DataGridView addPrdCandidatePartsGridView;
        private System.Windows.Forms.Button addPrdCandidatePartsAddButton;
        private System.Windows.Forms.TextBox addPrdCandidatePartsSearchTextBox;
        private System.Windows.Forms.Button addPrdCandidatePartsSearchButton;
        private System.Windows.Forms.Label addProductLabel;
        private System.Windows.Forms.Label addPrdAssociatedPartsLabel;
        public System.Windows.Forms.DataGridView addPrdAssociatedPartsGridView;
        private System.Windows.Forms.Button addPrdAssociatedPartsDeleteButton;
        private System.Windows.Forms.Button addPrdAddProductCancelButton;
        private System.Windows.Forms.Button addPrdAddProductSaveButton;
        private System.Windows.Forms.TextBox addPrdMinTextBox;
        private System.Windows.Forms.Label addPrdMinLabel;
        private System.Windows.Forms.TextBox addPrdMaxTextBox;
        private System.Windows.Forms.Label addPrdMaxLabel;
        private System.Windows.Forms.TextBox addPrdPriceTextBox;
        private System.Windows.Forms.Label addPrdPriceLabel;
        private System.Windows.Forms.TextBox addPrdInventoryTextBox;
        private System.Windows.Forms.Label addPrdInventoryLabel;
        private System.Windows.Forms.TextBox addPrdNameTextBox;
        private System.Windows.Forms.Label addPrdNameLabel;
        private System.Windows.Forms.TextBox addPrdIDTextBox;
        private System.Windows.Forms.Label addPrdIDLabel;
    }
}