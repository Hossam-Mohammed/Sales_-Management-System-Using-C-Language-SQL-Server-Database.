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
    public partial class FRM_EMPLOYESSMANAGE : Form
    {
        BL.CLS_Employee emp = new BL.CLS_Employee();
        public FRM_EMPLOYESSMANAGE()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = emp.Get_All_Employees();
        }

        public void Clear_Fields()
        {
            this.txtEmpID.Clear();
            this.txtFName.Clear();
            this.txtLName.Clear();
            this.txtPhone.Clear();
            this.txtEmail.Clear();
            this.txtAdress.Clear();
            this.txtSal.Clear();
            this.txtDedc.Clear();
            this.txtNSal.Clear();
            txtEmpID.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                emp.Add_Employee(int.Parse(txtEmpID.Text), txtFName.Text, txtLName.Text, txtPhone.Text, txtEmail.Text
            , txtAdress.Text, decimal.Parse(txtSal.Text), decimal.Parse(txtDedc.Text)
            , int.Parse(txtNSal.Text));
                MessageBox.Show("Added Successfuly", "Add New Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Fields();
            }

            catch
            {
                MessageBox.Show("Some Errors Have Occures");
            }

            finally { this.dataGridView1.DataSource = emp.Get_All_Employees(); }
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.txtEmpID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.txtFName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.txtLName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            this.txtPhone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            this.txtEmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            this.txtAdress.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            this.txtSal.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            this.txtDedc.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            this.txtNSal.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear_Fields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                emp.Edit_Employee(int.Parse(txtEmpID.Text), txtFName.Text, txtLName.Text, txtPhone.Text, txtEmail.Text
            , txtAdress.Text, decimal.Parse(txtSal.Text), decimal.Parse(txtDedc.Text)
            , int.Parse(txtNSal.Text));
            MessageBox.Show("Updated Successfuly", "Add New Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch
            {
                MessageBox.Show("Some Errors Have Occures");
            }

            finally { this.dataGridView1.DataSource = emp.Get_All_Employees(); }
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    emp.Delete_Employee(int.Parse(txtEmpID.Text));
                    MessageBox.Show("Deleted Successfully", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Clear_Fields();

            }

            catch
            {
                MessageBox.Show("Some Errors Have Occures");
            }

            finally { this.dataGridView1.DataSource = emp.Get_All_Employees(); }
                       
        }
    }
}
