namespace InventoryManagementSystem
{
    partial class MainForm
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
            System.Windows.Forms.Button mainFormAddProductsButton;
            this.appExit = new System.Windows.Forms.Button();
            this.mainFormDeleteProductsButton = new System.Windows.Forms.Button();
            this.mainFormModifyProductsButton = new System.Windows.Forms.Button();
            this.productsGridView = new System.Windows.Forms.DataGridView();
            this.partsGridView = new System.Windows.Forms.DataGridView();
            this.mainFormProductsSearchTextBox = new System.Windows.Forms.TextBox();
            this.mainFormProductsSearchButton = new System.Windows.Forms.Button();
            this.mainFormProductsLabel = new System.Windows.Forms.Label();
            this.mainFormDeletePartsButton = new System.Windows.Forms.Button();
            this.mainFormModifyPartsButton = new System.Windows.Forms.Button();
            this.mainFormAddPartsButton = new System.Windows.Forms.Button();
            this.mainFormPartsSearchTextBox = new System.Windows.Forms.TextBox();
            this.mainFormPartsSearchButton = new System.Windows.Forms.Button();
            this.PartsMainFormLabel = new System.Windows.Forms.Label();
            this.mainFormLabel = new System.Windows.Forms.Label();
            this.mainFormPartsLabel = new System.Windows.Forms.Label();
            mainFormAddProductsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainFormAddProductsButton
            // 
            mainFormAddProductsButton.Location = new System.Drawing.Point(1100, 408);
            mainFormAddProductsButton.Name = "mainFormAddProductsButton";
            mainFormAddProductsButton.Size = new System.Drawing.Size(98, 23);
            mainFormAddProductsButton.TabIndex = 30;
            mainFormAddProductsButton.Text = "Add";
            mainFormAddProductsButton.UseVisualStyleBackColor = true;
            mainFormAddProductsButton.Click += new System.EventHandler(this.mainFormAddProductsButton_Click);
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
            // mainFormDeleteProductsButton
            // 
            this.mainFormDeleteProductsButton.Location = new System.Drawing.Point(1308, 409);
            this.mainFormDeleteProductsButton.Name = "mainFormDeleteProductsButton";
            this.mainFormDeleteProductsButton.Size = new System.Drawing.Size(98, 23);
            this.mainFormDeleteProductsButton.TabIndex = 32;
            this.mainFormDeleteProductsButton.Text = "Delete";
            this.mainFormDeleteProductsButton.UseVisualStyleBackColor = true;
            // 
            // mainFormModifyProductsButton
            // 
            this.mainFormModifyProductsButton.Enabled = false;
            this.mainFormModifyProductsButton.Location = new System.Drawing.Point(1204, 409);
            this.mainFormModifyProductsButton.Name = "mainFormModifyProductsButton";
            this.mainFormModifyProductsButton.Size = new System.Drawing.Size(98, 23);
            this.mainFormModifyProductsButton.TabIndex = 31;
            this.mainFormModifyProductsButton.Text = "Modify";
            this.mainFormModifyProductsButton.UseVisualStyleBackColor = true;
            // 
            // productsGridView
            // 
            this.productsGridView.AllowUserToAddRows = false;
            this.productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGridView.Location = new System.Drawing.Point(785, 153);
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.Size = new System.Drawing.Size(621, 250);
            this.productsGridView.TabIndex = 29;
            // 
            // partsGridView
            // 
            this.partsGridView.AllowUserToAddRows = false;
            this.partsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsGridView.Location = new System.Drawing.Point(64, 153);
            this.partsGridView.Name = "partsGridView";
            this.partsGridView.Size = new System.Drawing.Size(621, 250);
            this.partsGridView.TabIndex = 28;
            this.partsGridView.SelectionChanged += new System.EventHandler(this.partsTableGrid_SelectionChanged);
            // 
            // mainFormProductsSearchTextBox
            // 
            this.mainFormProductsSearchTextBox.Location = new System.Drawing.Point(1199, 117);
            this.mainFormProductsSearchTextBox.Name = "mainFormProductsSearchTextBox";
            this.mainFormProductsSearchTextBox.Size = new System.Drawing.Size(207, 20);
            this.mainFormProductsSearchTextBox.TabIndex = 27;
            // 
            // mainFormProductsSearchButton
            // 
            this.mainFormProductsSearchButton.Location = new System.Drawing.Point(1100, 117);
            this.mainFormProductsSearchButton.Name = "mainFormProductsSearchButton";
            this.mainFormProductsSearchButton.Size = new System.Drawing.Size(75, 23);
            this.mainFormProductsSearchButton.TabIndex = 26;
            this.mainFormProductsSearchButton.Text = "Search";
            this.mainFormProductsSearchButton.UseVisualStyleBackColor = true;
            // 
            // mainFormProductsLabel
            // 
            this.mainFormProductsLabel.AutoSize = true;
            this.mainFormProductsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFormProductsLabel.Location = new System.Drawing.Point(780, 117);
            this.mainFormProductsLabel.Name = "mainFormProductsLabel";
            this.mainFormProductsLabel.Size = new System.Drawing.Size(98, 26);
            this.mainFormProductsLabel.TabIndex = 25;
            this.mainFormProductsLabel.Text = "Products";
            // 
            // mainFormDeletePartsButton
            // 
            this.mainFormDeletePartsButton.Location = new System.Drawing.Point(587, 409);
            this.mainFormDeletePartsButton.Name = "mainFormDeletePartsButton";
            this.mainFormDeletePartsButton.Size = new System.Drawing.Size(98, 23);
            this.mainFormDeletePartsButton.TabIndex = 24;
            this.mainFormDeletePartsButton.Text = "Delete";
            this.mainFormDeletePartsButton.UseVisualStyleBackColor = true;
            this.mainFormDeletePartsButton.Click += new System.EventHandler(this.mainFormDeletePartsButton_Click);
            // 
            // mainFormModifyPartsButton
            // 
            this.mainFormModifyPartsButton.Enabled = false;
            this.mainFormModifyPartsButton.Location = new System.Drawing.Point(483, 409);
            this.mainFormModifyPartsButton.Name = "mainFormModifyPartsButton";
            this.mainFormModifyPartsButton.Size = new System.Drawing.Size(98, 23);
            this.mainFormModifyPartsButton.TabIndex = 23;
            this.mainFormModifyPartsButton.Text = "Modify";
            this.mainFormModifyPartsButton.UseVisualStyleBackColor = true;
            this.mainFormModifyPartsButton.Click += new System.EventHandler(this.modifyPartsMainButton_Click);
            // 
            // mainFormAddPartsButton
            // 
            this.mainFormAddPartsButton.Location = new System.Drawing.Point(383, 409);
            this.mainFormAddPartsButton.Name = "mainFormAddPartsButton";
            this.mainFormAddPartsButton.Size = new System.Drawing.Size(98, 23);
            this.mainFormAddPartsButton.TabIndex = 22;
            this.mainFormAddPartsButton.Text = "Add";
            this.mainFormAddPartsButton.UseVisualStyleBackColor = true;
            this.mainFormAddPartsButton.Click += new System.EventHandler(this.addPartsMainButton_Click);
            // 
            // mainFormPartsSearchTextBox
            // 
            this.mainFormPartsSearchTextBox.Location = new System.Drawing.Point(479, 123);
            this.mainFormPartsSearchTextBox.Name = "mainFormPartsSearchTextBox";
            this.mainFormPartsSearchTextBox.Size = new System.Drawing.Size(206, 20);
            this.mainFormPartsSearchTextBox.TabIndex = 21;
            // 
            // mainFormPartsSearchButton
            // 
            this.mainFormPartsSearchButton.Location = new System.Drawing.Point(354, 121);
            this.mainFormPartsSearchButton.Name = "mainFormPartsSearchButton";
            this.mainFormPartsSearchButton.Size = new System.Drawing.Size(92, 23);
            this.mainFormPartsSearchButton.TabIndex = 20;
            this.mainFormPartsSearchButton.Text = "Search";
            this.mainFormPartsSearchButton.UseVisualStyleBackColor = true;
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
            // mainFormPartsLabel
            // 
            this.mainFormPartsLabel.AutoSize = true;
            this.mainFormPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFormPartsLabel.Location = new System.Drawing.Point(59, 117);
            this.mainFormPartsLabel.Name = "mainFormPartsLabel";
            this.mainFormPartsLabel.Size = new System.Drawing.Size(63, 26);
            this.mainFormPartsLabel.TabIndex = 34;
            this.mainFormPartsLabel.Text = "Parts";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 659);
            this.Controls.Add(this.mainFormPartsLabel);
            this.Controls.Add(this.appExit);
            this.Controls.Add(this.mainFormDeleteProductsButton);
            this.Controls.Add(this.mainFormModifyProductsButton);
            this.Controls.Add(mainFormAddProductsButton);
            this.Controls.Add(this.productsGridView);
            this.Controls.Add(this.partsGridView);
            this.Controls.Add(this.mainFormProductsSearchTextBox);
            this.Controls.Add(this.mainFormProductsSearchButton);
            this.Controls.Add(this.mainFormProductsLabel);
            this.Controls.Add(this.mainFormDeletePartsButton);
            this.Controls.Add(this.mainFormModifyPartsButton);
            this.Controls.Add(this.mainFormAddPartsButton);
            this.Controls.Add(this.mainFormPartsSearchTextBox);
            this.Controls.Add(this.mainFormPartsSearchButton);
            this.Controls.Add(this.PartsMainFormLabel);
            this.Controls.Add(this.mainFormLabel);
            this.Name = "MainForm";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button appExit;
        private System.Windows.Forms.Button mainFormDeleteProductsButton;
        private System.Windows.Forms.Button mainFormModifyProductsButton;
        public System.Windows.Forms.DataGridView productsGridView;
        public System.Windows.Forms.DataGridView partsGridView;
        private System.Windows.Forms.TextBox mainFormProductsSearchTextBox;
        private System.Windows.Forms.Button mainFormProductsSearchButton;
        private System.Windows.Forms.Label mainFormProductsLabel;
        private System.Windows.Forms.Button mainFormDeletePartsButton;
        private System.Windows.Forms.Button mainFormModifyPartsButton;
        private System.Windows.Forms.Button mainFormAddPartsButton;
        private System.Windows.Forms.TextBox mainFormPartsSearchTextBox;
        private System.Windows.Forms.Button mainFormPartsSearchButton;
        private System.Windows.Forms.Label PartsMainFormLabel;
        private System.Windows.Forms.Label mainFormLabel;
        private System.Windows.Forms.Label mainFormPartsLabel;
    }
}

