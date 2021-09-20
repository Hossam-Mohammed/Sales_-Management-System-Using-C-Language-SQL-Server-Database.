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
    public partial class FRM_LOGIN : Form
    {
        BL.CLS_Login log = new BL.CLS_Login();
        public FRM_LOGIN()
        {
            InitializeComponent();
            txtUser.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {

            //Statement to Check if Data Enterd Was Exixts in Database
            DataTable Dt = log.Login(txtUser.Text, txtPass.Text);
            if (Dt.Rows.Count > 0)
            {
                if (Dt.Rows[0][2].ToString() == "admin")
                {
                    MessageBox.Show("Login Successfully", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FRM_MAINFORM.getMainForm.backupToolStripMenuItem.Enabled = true;
                    FRM_MAINFORM.getMainForm.restoreBackupToolStripMenuItem.Enabled = true;
                    FRM_MAINFORM.getMainForm.productsToolStripMenuItem.Enabled = true;
                    FRM_MAINFORM.getMainForm.checkToolStripMenuItem.Enabled = true;
                    FRM_MAINFORM.getMainForm.employeesToolStripMenuItem.Enabled = true;
                    FRM_MAINFORM.getMainForm.usersToolStripMenuItem.Enabled = true;
                    Program.userName = Dt.Rows[0]["FullName"].ToString();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login Successfully", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FRM_MAINFORM.getMainForm.checkToolStripMenuItem.Enabled = true;
                    FRM_MAINFORM.getMainForm.addNewCheckToolStripMenuItem.Enabled = true;
                    FRM_MAINFORM.getMainForm.checkManagementToolStripMenuItem.Enabled = false;
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Login Faild, Try Again", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Clear();
                txtUser.Focus();
            }
        }

    }
}
