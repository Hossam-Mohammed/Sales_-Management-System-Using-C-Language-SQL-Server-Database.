using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_System1.PL
{
    public partial class FRM_MAINFORM : Form
    {
        //Feild to Make a Main Form instance and aviliable to Access From Other Forms
        private static FRM_MAINFORM frm;

        //Method to Destroy this Form
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        //Method to get Form
        public static FRM_MAINFORM getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_MAINFORM();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        public FRM_MAINFORM()
        {
            InitializeComponent();

            //Get Value to frm Componant
            if (frm == null) frm = this;

            //Menustrip Componant Disabled
            this.backupToolStripMenuItem.Enabled = false;
            this.restoreBackupToolStripMenuItem.Enabled = false;
            this.productsToolStripMenuItem.Enabled = false;
            this.checkToolStripMenuItem.Enabled = false;
            this.employeesToolStripMenuItem.Enabled = false;
            this.usersToolStripMenuItem.Enabled = false;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open Login Form
            PL.FRM_LOGIN frm = new PL.FRM_LOGIN();
            frm.ShowDialog();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.ShowDialog();
        }

        private void productsManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_PRODUCTSMANGEMENT frm = new FRM_PRODUCTSMANGEMENT();
            frm.ShowDialog();
        }

        private void caToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CATEGORIES frm = new FRM_CATEGORIES();
            frm.ShowDialog();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADDUSER frm = new FRM_ADDUSER();
            frm.ShowDialog();
        }

        private void usersManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_USERMANAGEMENT frm = new FRM_USERMANAGEMENT();
            frm.ShowDialog();
        }

        private void employeesManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_EMPLOYESSMANAGE frm = new FRM_EMPLOYESSMANAGE();
            frm.ShowDialog();
        }

        private void addNewCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ORDERS frm = new FRM_ORDERS();
            frm.ShowDialog();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_BACKUP frm = new FRM_BACKUP();
            frm.ShowDialog();
        }

        private void restoreBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_RESTORBACKUP frm = new FRM_RESTORBACKUP();
            frm.ShowDialog();
        }
    }
}
