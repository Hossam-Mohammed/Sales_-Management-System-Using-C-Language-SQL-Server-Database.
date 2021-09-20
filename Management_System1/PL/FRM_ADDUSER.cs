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
    public partial class FRM_ADDUSER : Form
    {
        public FRM_ADDUSER()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text == string.Empty || txtPass.Text == string.Empty || txtCPass.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter Full Info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUser.Focus();
                    return;
                }
                if (txtPass.Text != txtCPass.Text)
                {
                    MessageBox.Show("Password Not Matching", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPass.Clear();
                    txtCPass.Clear();
                    txtPass.Focus();
                    return;
                }
                if (btnAdd.Text == "Add")
                {
                    try
                    {
                        BL.CLS_Login user = new BL.CLS_Login();
                        user.Add_User(txtUser.Text, txtPass.Text, comboBox1.Text);
                        MessageBox.Show("Added Successfuly", "Add New User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    catch
                    {
                        MessageBox.Show("Some Errors Have Occures");
                    }

                }
                else if (btnAdd.Text == "Edit")
                {
                    try
                    {
                        BL.CLS_Login user = new BL.CLS_Login();
                        user.Edit_User(txtUser.Text, txtPass.Text, comboBox1.Text);
                        MessageBox.Show("Edited Successfuly", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    catch
                    {
                        MessageBox.Show("Some Errors Have Occures");
                    }

                }
            }

            catch
            {
                Console.WriteLine("Some Errors Have Occures");
            }

            finally
            {
                txtUser.Clear();
                txtPass.Clear();
                txtCPass.Clear();
                txtUser.Focus();
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCPass_Validated(object sender, EventArgs e)
        {
            if(txtPass.Text != txtCPass.Text)
            {
                MessageBox.Show("Password Not Matching", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPass.Clear();
                txtCPass.Clear();
                txtPass.Focus();
                return;
            }
        }
    }
}
