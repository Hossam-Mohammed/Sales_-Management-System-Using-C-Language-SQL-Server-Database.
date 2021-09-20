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
    public partial class FRM_USERMANAGEMENT : Form
    {
        BL.CLS_Login login = new BL.CLS_Login();
        public FRM_USERMANAGEMENT()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = login.Search_Users("");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FRM_ADDUSER frm = new FRM_ADDUSER();
            frm.btnAdd.Text = "Add";
            frm.ShowDialog();
            this.dataGridView1.DataSource = login.Search_Users("");
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            FRM_ADDUSER frm = new FRM_ADDUSER();
            frm.txtUser.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtPass.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtCPass.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.btnAdd.Text = "Edit";
            frm.ShowDialog();
            this.dataGridView1.DataSource = login.Search_Users("");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = login.Search_Users(txtSearch.Text);
        }

        private void btnDeletedUser_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("are you sure!", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
                login.Delete_User(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = login.Search_Users("");
            }

        }
    }
}
