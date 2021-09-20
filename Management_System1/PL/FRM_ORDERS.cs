using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Globalization;

namespace Management_System1.PL
{
    public partial class FRM_ORDERS : Form
    {
        BL.CLS_Oreders ord = new BL.CLS_Oreders();
        DataTable Dt = new DataTable();

        void Clear_Data()
        {
            txtChNum.Clear();
            txtChDesc.Clear();
            Clear_Boxes();
            Dt.Clear();
            dataGridView1.DataSource = null;
            txtTotal.Clear();
            btnSaveCheck.Enabled = false;
            btnNewCheck.Enabled = true;
        }

        void Clear_Boxes()
        {
            txtPID.Clear();
            txtPName.Clear();
            txtPPrice.Clear();
            txtPQnt.Clear();
            txtAmount.Clear();
            txtDiscount.Clear();
            txtTAmount.Clear();
        }

        void Calculate_TotalAmount()
        {

            if(txtDiscount.Text != string.Empty && txtAmount.Text != string.Empty)
            {
                double discount = Convert.ToDouble(txtDiscount.Text);
                double Amount = Convert.ToDouble(txtAmount.Text);
                double TAmount = Amount - (Amount * (discount / 100));
                txtTAmount.Text = TAmount.ToString();
            }   
                   
        }

        void Calculate_Amount()
        {

            if(txtPPrice.Text != string.Empty && txtPQnt.Text != string.Empty)
            {
                txtAmount.Text = (Convert.ToDouble(txtPPrice.Text) * Convert.ToInt32(txtPQnt.Text)).ToString();
            }

        }

        void Create_DataTable()
        {
            Dt.Columns.Add("Product ID");
            Dt.Columns.Add("Product Name");
            Dt.Columns.Add("Product Price");
            Dt.Columns.Add("Quantity");
            Dt.Columns.Add("Amount");
            Dt.Columns.Add("Dicount");
            Dt.Columns.Add("Total Amount");

            dataGridView1.DataSource = Dt;
        }
        void Resize_DGV()
        {
            this.dataGridView1.RowHeadersWidth = 117;
            this.dataGridView1.Columns[0].Width = 123;
            this.dataGridView1.Columns[1].Width = 291;
            this.dataGridView1.Columns[2].Width = 137;
            this.dataGridView1.Columns[3].Width = 111;
            this.dataGridView1.Columns[4].Width = 145;
            this.dataGridView1.Columns[5].Width = 138;
            this.dataGridView1.Columns[6].Width = 169;
        }

        public FRM_ORDERS()
        {
            InitializeComponent();
            Create_DataTable();
            Resize_DGV();
            txtUser.Text = Program.userName;
            comboBox1.DataSource = ord.Get_AllEmployees();
            comboBox1.DisplayMember = "First_Name";
            comboBox1.ValueMember = "ID_Employee";
        }

        private void btnNewCheck_Click(object sender, EventArgs e)
        {
            this.txtChNum.Text = ord.Get_Last_Order_ID().Rows[0][0].ToString();
            btnNewCheck.Enabled = false;
            btnSaveCheck.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear_Boxes();
            FRM_CHOOSEPRODUCT frm = new FRM_CHOOSEPRODUCT();
            frm.ShowDialog();
            txtPID.Text = frm.dgv1.CurrentRow.Cells[0].Value.ToString();
            txtPName.Text = frm.dgv1.CurrentRow.Cells[1].Value.ToString();
            txtPPrice.Text = frm.dgv1.CurrentRow.Cells[3].Value.ToString();
            txtPQnt.Focus();
        }

        private void txtPQnt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if(!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        private void txtPPrice_KeyPress(object sender, KeyPressEventArgs e)
        {

            Char decimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != decimalSeparator)
            {
                e.Handled = true;
            }

        }

        private void txtPPrice_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Enter && txtPPrice.Text != string.Empty)
            {
                txtPQnt.Focus();
            }

        }

        private void txtPQnt_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && txtPPrice.Text != string.Empty)
            {
                txtDiscount.Focus();
            }

        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            return;
        }

        private void txtPQnt_KeyUp(object sender, KeyEventArgs e)
        {
            Calculate_Amount();
            Calculate_TotalAmount();
        }

        private void txtPPrice_KeyUp(object sender, KeyEventArgs e)
        {
            Calculate_Amount();
            Calculate_TotalAmount();
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {

            Char decimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != decimalSeparator)
            {
                e.Handled = true;
            }

        }

        private void txtDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            Calculate_TotalAmount();
        }

        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Enter)
            {
                if (ord.Verify_Qtn(txtPID.Text, Convert.ToInt32(txtPQnt.Text)).Rows.Count < 1)
                {
                    MessageBox.Show("Entered Quantity is Not Available in Stock", "Atention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == txtPID.Text)
                    {
                        MessageBox.Show("This Product is Already Exists", "Atention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                        return;
                    }
                }

                DataRow Dr = Dt.NewRow();
                Dr[0] = txtPID.Text;
                Dr[1] = txtPName.Text;
                Dr[2] = txtPPrice.Text;
                Dr[3] = txtPQnt.Text;
                Dr[4] = txtAmount.Text;
                Dr[5] = txtDiscount.Text;
                Dr[6] = txtTAmount.Text;

                Dt.Rows.Add(Dr);
                dataGridView1.DataSource = Dt;
                Clear_Boxes();
                Click.Focus();

                txtTotal.Text =
                    (from DataGridViewRow row in dataGridView1.Rows
                     where row.Cells[6].FormattedValue.ToString() != string.Empty
                     select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
            }

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtPID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPPrice.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPQnt.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtAmount.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtDiscount.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtTAmount.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            txtPQnt.Focus();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            txtTotal.Text =
                    (from DataGridViewRow row in dataGridView1.Rows
                     where row.Cells[6].FormattedValue.ToString() != string.Empty
                     select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1_DoubleClick(sender, e);
        }

        private void deleteCurrentRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dt.Clear();
            dataGridView1.Refresh();
        }

        private void btnSaveCheck_Click(object sender, EventArgs e)
        {
            //Check Value
            if(txtChNum.Text == string.Empty || dataGridView1.Rows.Count<1 || txtChDesc.Text == string.Empty)
            {
                MessageBox.Show("You Should Enter Full Important Data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            ord.Add_Order(Convert.ToInt32(txtChNum.Text), txtChDesc.Text, Convert.ToString(dateTimePicker1.Value), Convert.ToInt32(comboBox1.SelectedValue), txtUser.Text);

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string dg_ADd = dataGridView1.Rows[i].Cells[0].Value.ToString();
                int Ch_ID = Convert.ToInt32(txtChNum.Text);
                int qtn = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                string price = dataGridView1.Rows[i].Cells[2].Value.ToString();
                int Ch_dis = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                string amount = dataGridView1.Rows[i].Cells[4].Value.ToString();
                string Tamount = dataGridView1.Rows[i].Cells[6].Value.ToString();
                ord.Add_OrderDetails(dg_ADd, Ch_ID, qtn, price, Ch_dis, amount, Tamount);
            }

            MessageBox.Show("Added Successfully", "Add New Order", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Clear_Data();
            btnPrintCheck.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void txtPPrice_TextChanged(object sender, EventArgs e)
        {
            return;
        }

        private void btnPrintCheck_Click(object sender, EventArgs e)
        {
            int orderID = Convert.ToInt32(ord.Get_Last_Order_ID_PR().Rows[0][0]);
            RPT.CrystalReport1 report = new RPT.CrystalReport1();
            RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT();
            report.SetDataSource(ord.Get_Order_Deatails(orderID));

            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();
        }

    }
}