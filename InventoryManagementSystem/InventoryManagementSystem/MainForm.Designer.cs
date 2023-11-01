namespace InventoryManagementSystem
{
    partial class formMain
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
            System.Windows.Forms.Button addProductsMainButton;
            this.appExit = new System.Windows.Forms.Button();
            this.deleteProductsMainButton = new System.Windows.Forms.Button();
            this.modifyProductsMainButton = new System.Windows.Forms.Button();
            this.productsTableGrid = new System.Windows.Forms.DataGridView();
            this.partsTableGrid = new System.Windows.Forms.DataGridView();
            this.productsSearchTextBox = new System.Windows.Forms.TextBox();
            this.productsSearchButton = new System.Windows.Forms.Button();
            this.productsLabel = new System.Windows.Forms.Label();
            this.deletePartsMainButton = new System.Windows.Forms.Button();
            this.modifyPartsMainButton = new System.Windows.Forms.Button();
            this.addPartsMainButton = new System.Windows.Forms.Button();
            this.artsSearchTextBox = new System.Windows.Forms.TextBox();
            this.partsSearchButton = new System.Windows.Forms.Button();
            this.PartsMainFormLabel = new System.Windows.Forms.Label();
            this.mainFormLabel = new System.Windows.Forms.Label();
            this.parstLabel = new System.Windows.Forms.Label();
            addProductsMainButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsTableGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsTableGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductsMainButton
            // 
            addProductsMainButton.Location = new System.Drawing.Point(1100, 408);
            addProductsMainButton.Name = "addProductsMainButton";
            addProductsMainButton.Size = new System.Drawing.Size(98, 23);
            addProductsMainButton.TabIndex = 30;
            addProductsMainButton.Text = "Add";
            addProductsMainButton.UseVisualStyleBackColor = true;
            // 
            // appExit
            // 
            this.appExit.Location = new System.Drawing.Point(1308, 492);
            this.appExit.Name = "appExit";
            this.appExit.Size = new System.Drawing.Size(104, 41);
            this.appExit.TabIndex = 33;
            this.appExit.Text = "Exit";
            this.appExit.UseVisualStyleBackColor = true;
            // 
            // deleteProductsMainButton
            // 
            this.deleteProductsMainButton.Location = new System.Drawing.Point(1308, 409);
            this.deleteProductsMainButton.Name = "deleteProductsMainButton";
            this.deleteProductsMainButton.Size = new System.Drawing.Size(98, 23);
            this.deleteProductsMainButton.TabIndex = 32;
            this.deleteProductsMainButton.Text = "Delete";
            this.deleteProductsMainButton.UseVisualStyleBackColor = true;
            // 
            // modifyProductsMainButton
            // 
            this.modifyProductsMainButton.Enabled = false;
            this.modifyProductsMainButton.Location = new System.Drawing.Point(1204, 409);
            this.modifyProductsMainButton.Name = "modifyProductsMainButton";
            this.modifyProductsMainButton.Size = new System.Drawing.Size(98, 23);
            this.modifyProductsMainButton.TabIndex = 31;
            this.modifyProductsMainButton.Text = "Modify";
            this.modifyProductsMainButton.UseVisualStyleBackColor = true;
            // 
            // productsTableGrid
            // 
            this.productsTableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsTableGrid.Location = new System.Drawing.Point(785, 153);
            this.productsTableGrid.Name = "productsTableGrid";
            this.productsTableGrid.Size = new System.Drawing.Size(621, 250);
            this.productsTableGrid.TabIndex = 29;
            // 
            // partsTableGrid
            // 
            this.partsTableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsTableGrid.Location = new System.Drawing.Point(64, 153);
            this.partsTableGrid.Name = "partsTableGrid";
            this.partsTableGrid.Size = new System.Drawing.Size(621, 250);
            this.partsTableGrid.TabIndex = 28;
            // 
            // productsSearchTextBox
            // 
            this.productsSearchTextBox.Location = new System.Drawing.Point(1199, 117);
            this.productsSearchTextBox.Name = "productsSearchTextBox";
            this.productsSearchTextBox.Size = new System.Drawing.Size(207, 20);
            this.productsSearchTextBox.TabIndex = 27;
            // 
            // productsSearchButton
            // 
            this.productsSearchButton.Location = new System.Drawing.Point(1100, 117);
            this.productsSearchButton.Name = "productsSearchButton";
            this.productsSearchButton.Size = new System.Drawing.Size(75, 23);
            this.productsSearchButton.TabIndex = 26;
            this.productsSearchButton.Text = "Search";
            this.productsSearchButton.UseVisualStyleBackColor = true;
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.Location = new System.Drawing.Point(780, 117);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(98, 26);
            this.productsLabel.TabIndex = 25;
            this.productsLabel.Text = "Products";
            // 
            // deletePartsMainButton
            // 
            this.deletePartsMainButton.Location = new System.Drawing.Point(587, 409);
            this.deletePartsMainButton.Name = "deletePartsMainButton";
            this.deletePartsMainButton.Size = new System.Drawing.Size(98, 23);
            this.deletePartsMainButton.TabIndex = 24;
            this.deletePartsMainButton.Text = "Delete";
            this.deletePartsMainButton.UseVisualStyleBackColor = true;
            // 
            // modifyPartsMainButton
            // 
            this.modifyPartsMainButton.Location = new System.Drawing.Point(483, 409);
            this.modifyPartsMainButton.Name = "modifyPartsMainButton";
            this.modifyPartsMainButton.Size = new System.Drawing.Size(98, 23);
            this.modifyPartsMainButton.TabIndex = 23;
            this.modifyPartsMainButton.Text = "Modify";
            this.modifyPartsMainButton.UseVisualStyleBackColor = true;
            // 
            // addPartsMainButton
            // 
            this.addPartsMainButton.Location = new System.Drawing.Point(383, 409);
            this.addPartsMainButton.Name = "addPartsMainButton";
            this.addPartsMainButton.Size = new System.Drawing.Size(98, 23);
            this.addPartsMainButton.TabIndex = 22;
            this.addPartsMainButton.Text = "Add";
            this.addPartsMainButton.UseVisualStyleBackColor = true;
            this.addPartsMainButton.Click += new System.EventHandler(this.addPartsMainButton_Click);
            // 
            // artsSearchTextBox
            // 
            this.artsSearchTextBox.Location = new System.Drawing.Point(479, 123);
            this.artsSearchTextBox.Name = "artsSearchTextBox";
            this.artsSearchTextBox.Size = new System.Drawing.Size(206, 20);
            this.artsSearchTextBox.TabIndex = 21;
            // 
            // partsSearchButton
            // 
            this.partsSearchButton.Location = new System.Drawing.Point(354, 121);
            this.partsSearchButton.Name = "partsSearchButton";
            this.partsSearchButton.Size = new System.Drawing.Size(92, 23);
            this.partsSearchButton.TabIndex = 20;
            this.partsSearchButton.Text = "Search";
            this.partsSearchButton.UseVisualStyleBackColor = true;
            // 
            // PartsMainFormLabel
            // 
            this.PartsMainFormLabel.AutoSize = true;
            this.PartsMainFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsMainFormLabel.Location = new System.Drawing.Point(-101, 113);
            this.PartsMainFormLabel.Name = "PartsMainFormLabel";
            this.PartsMainFormLabel.Size = new System.Drawing.Size(63, 26);
            this.PartsMainFormLabel.TabIndex = 19;
            this.PartsMainFormLabel.Text = "Parts";
            // 
            // mainFormLabel
            // 
            this.mainFormLabel.AutoSize = true;
            this.mainFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFormLabel.Location = new System.Drawing.Point(12, 24);
            this.mainFormLabel.Name = "mainFormLabel";
            this.mainFormLabel.Size = new System.Drawing.Size(314, 26);
            this.mainFormLabel.TabIndex = 18;
            this.mainFormLabel.Text = "Inventory Management System";
            // 
            // parstLabel
            // 
            this.parstLabel.AutoSize = true;
            this.parstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parstLabel.Location = new System.Drawing.Point(59, 117);
            this.parstLabel.Name = "parstLabel";
            this.parstLabel.Size = new System.Drawing.Size(63, 26);
            this.parstLabel.TabIndex = 34;
            this.parstLabel.Text = "Parts";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 659);
            this.Controls.Add(this.parstLabel);
            this.Controls.Add(this.appExit);
            this.Controls.Add(this.deleteProductsMainButton);
            this.Controls.Add(this.modifyProductsMainButton);
            this.Controls.Add(addProductsMainButton);
            this.Controls.Add(this.productsTableGrid);
            this.Controls.Add(this.partsTableGrid);
            this.Controls.Add(this.productsSearchTextBox);
            this.Controls.Add(this.productsSearchButton);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.deletePartsMainButton);
            this.Controls.Add(this.modifyPartsMainButton);
            this.Controls.Add(this.addPartsMainButton);
            this.Controls.Add(this.artsSearchTextBox);
            this.Controls.Add(this.partsSearchButton);
            this.Controls.Add(this.PartsMainFormLabel);
            this.Controls.Add(this.mainFormLabel);
            this.Name = "formMain";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.productsTableGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsTableGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button appExit;
        private System.Windows.Forms.Button deleteProductsMainButton;
        private System.Windows.Forms.Button modifyProductsMainButton;
        public System.Windows.Forms.DataGridView productsTableGrid;
        public System.Windows.Forms.DataGridView partsTableGrid;
        private System.Windows.Forms.TextBox productsSearchTextBox;
        private System.Windows.Forms.Button productsSearchButton;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Button deletePartsMainButton;
        private System.Windows.Forms.Button modifyPartsMainButton;
        private System.Windows.Forms.Button addPartsMainButton;
        private System.Windows.Forms.TextBox artsSearchTextBox;
        private System.Windows.Forms.Button partsSearchButton;
        private System.Windows.Forms.Label PartsMainFormLabel;
        private System.Windows.Forms.Label mainFormLabel;
        private System.Windows.Forms.Label parstLabel;
    }
}

