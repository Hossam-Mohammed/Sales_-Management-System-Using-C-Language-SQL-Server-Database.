using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Management_System1.PL
{
    public partial class FRM_CATEGORIES : Form
    {
        //Connect App to Database
        SqlConnection sqlcon = new SqlConnection(@"Server=.\TADASHI; Database= Management__System; Integrated Security = false; User ID = sa; Password = 258987;");
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();
        //Using Binding Mangere
        BindingManagerBase bmb;
        SqlCommandBuilder cmdb;
        public FRM_CATEGORIES()
        {
            InitializeComponent();
            //Select Categories Data From Database
            Da = new SqlDataAdapter("Select ID_Category as 'ID', Name_Category as'Description' From Categories", sqlcon);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
            
            //Binding Data From DB to Elements in Form
            txtID.DataBindings.Add("text", Dt, "ID");
            txtDecription.DataBindings.Add("text", Dt, "Description");

            //Using Binding Manager to Move between Data
            bmb = this.BindingContext[Dt];
            lblPossition.Text = (bmb.Position+1) + " / " + bmb.Count;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lblPossition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            lblPossition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            lblPossition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            lblPossition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            btnAdd.Enabled = true;
            btnNew.Enabled = false;
            int ID = Convert.ToInt32(Dt.Rows[Dt.Rows.Count - 1][0])+1;
            txtID.Text = ID.ToString();
            txtDecription.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(Da);
            Da.Update(Dt);
            MessageBox.Show("Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            lblPossition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position);
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(Da);
            Da.Update(Dt);
            MessageBox.Show("Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblPossition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(Da);
            Da.Update(Dt);
            MessageBox.Show("Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblPossition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }
    }
}
