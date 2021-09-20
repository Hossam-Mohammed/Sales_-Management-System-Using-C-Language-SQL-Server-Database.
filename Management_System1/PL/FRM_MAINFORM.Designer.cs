namespace Management_System1.PL
{
    partial class FRM_MAINFORM
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
            this.usersManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usersManagementToolStripMenuItem
            // 
            this.usersManagementToolStripMenuItem.Name = "usersManagementToolStripMenuItem";
            this.usersManagementToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.usersManagementToolStripMenuItem.Text = "Users Management";
            this.usersManagementToolStripMenuItem.Click += new System.EventHandler(this.usersManagementToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem,
            this.usersManagementToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // employeesManagementToolStripMenuItem
            // 
            this.employeesManagementToolStripMenuItem.Name = "employeesManagementToolStripMenuItem";
            this.employeesManagementToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.employeesManagementToolStripMenuItem.Text = "Employees Management";
            this.employeesManagementToolStripMenuItem.Click += new System.EventHandler(this.employeesManagementToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesManagementToolStripMenuItem});
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.employeesToolStripMenuItem.Text = "Employees";
            // 
            // checkManagementToolStripMenuItem
            // 
            this.checkManagementToolStripMenuItem.Name = "checkManagementToolStripMenuItem";
            this.checkManagementToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.checkManagementToolStripMenuItem.Text = "Check Management";
            // 
            // addNewCheckToolStripMenuItem
            // 
            this.addNewCheckToolStripMenuItem.Name = "addNewCheckToolStripMenuItem";
            this.addNewCheckToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.addNewCheckToolStripMenuItem.Text = "Add New Check";
            this.addNewCheckToolStripMenuItem.Click += new System.EventHandler(this.addNewCheckToolStripMenuItem_Click);
            // 
            // checkToolStripMenuItem
            // 
            this.checkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCheckToolStripMenuItem,
            this.checkManagementToolStripMenuItem});
            this.checkToolStripMenuItem.Name = "checkToolStripMenuItem";
            this.checkToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.checkToolStripMenuItem.Text = "Check";
            // 
            // caToolStripMenuItem
            // 
            this.caToolStripMenuItem.Name = "caToolStripMenuItem";
            this.caToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.caToolStripMenuItem.Text = "Categories Management";
            this.caToolStripMenuItem.Click += new System.EventHandler(this.caToolStripMenuItem_Click);
            // 
            // productsManagementToolStripMenuItem
            // 
            this.productsManagementToolStripMenuItem.Name = "productsManagementToolStripMenuItem";
            this.productsManagementToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.productsManagementToolStripMenuItem.Text = "Products Management";
            this.productsManagementToolStripMenuItem.Click += new System.EventHandler(this.productsManagementToolStripMenuItem_Click);
            // 
            // addNewProductToolStripMenuItem
            // 
            this.addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
            this.addNewProductToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.addNewProductToolStripMenuItem.Text = "Add New Product";
            this.addNewProductToolStripMenuItem.Click += new System.EventHandler(this.addNewProductToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewProductToolStripMenuItem,
            this.productsManagementToolStripMenuItem,
            this.toolStripSeparator1,
            this.caToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(244, 6);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // restoreBackupToolStripMenuItem
            // 
            this.restoreBackupToolStripMenuItem.Name = "restoreBackupToolStripMenuItem";
            this.restoreBackupToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.restoreBackupToolStripMenuItem.Text = "Restore Backup";
            this.restoreBackupToolStripMenuItem.Click += new System.EventHandler(this.restoreBackupToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.backupToolStripMenuItem,
            this.restoreBackupToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.checkToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(15, 6, 0, 6);
            this.menuStrip1.Size = new System.Drawing.Size(1029, 36);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FRM_MAINFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 565);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_MAINFORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_MAINFORM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStripMenuItem usersManagementToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem employeesManagementToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem checkManagementToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addNewCheckToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem checkToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem caToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem productsManagementToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addNewProductToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem restoreBackupToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}