namespace Management_System1.PL
{
    partial class FRM_PRODUCTSMANGEMENT
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAsExcelFile = new System.Windows.Forms.Button();
            this.btnPrintAllProduct = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnShowPhoto = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(271, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(604, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(24, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1006, 396);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(994, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnAsExcelFile);
            this.groupBox2.Controls.Add(this.btnPrintAllProduct);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.btnShowPhoto);
            this.groupBox2.Controls.Add(this.btnEditProduct);
            this.groupBox2.Controls.Add(this.btnRemoveProduct);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(24, 520);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1006, 130);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operation Validated";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(46, 80);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 35);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAsExcelFile
            // 
            this.btnAsExcelFile.Location = new System.Drawing.Point(179, 77);
            this.btnAsExcelFile.Name = "btnAsExcelFile";
            this.btnAsExcelFile.Size = new System.Drawing.Size(257, 35);
            this.btnAsExcelFile.TabIndex = 7;
            this.btnAsExcelFile.Text = "Save As Excel File";
            this.btnAsExcelFile.UseVisualStyleBackColor = true;
            this.btnAsExcelFile.Click += new System.EventHandler(this.btnAsExcelFile_Click);
            // 
            // btnPrintAllProduct
            // 
            this.btnPrintAllProduct.Location = new System.Drawing.Point(442, 80);
            this.btnPrintAllProduct.Name = "btnPrintAllProduct";
            this.btnPrintAllProduct.Size = new System.Drawing.Size(257, 35);
            this.btnPrintAllProduct.TabIndex = 6;
            this.btnPrintAllProduct.Text = "Print All Products";
            this.btnPrintAllProduct.UseVisualStyleBackColor = true;
            this.btnPrintAllProduct.Click += new System.EventHandler(this.btnPrintAllProduct_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(705, 78);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(257, 34);
            this.button5.TabIndex = 5;
            this.button5.Text = "Print Selected Product";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnShowPhoto
            // 
            this.btnShowPhoto.Location = new System.Drawing.Point(99, 37);
            this.btnShowPhoto.Name = "btnShowPhoto";
            this.btnShowPhoto.Size = new System.Drawing.Size(172, 34);
            this.btnShowPhoto.TabIndex = 2;
            this.btnShowPhoto.Text = "Product Photo";
            this.btnShowPhoto.UseVisualStyleBackColor = true;
            this.btnShowPhoto.Click += new System.EventHandler(this.btnShowPhoto_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(277, 39);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(202, 33);
            this.btnEditProduct.TabIndex = 3;
            this.btnEditProduct.Text = "Edit Product Data";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(485, 40);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(264, 34);
            this.btnRemoveProduct.TabIndex = 4;
            this.btnRemoveProduct.Text = "Remove Selected Product";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(755, 39);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 35);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Product";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FRM_PRODUCTSMANGEMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 667);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_PRODUCTSMANGEMENT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products Management";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrintAllProduct;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnShowPhoto;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAsExcelFile;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}