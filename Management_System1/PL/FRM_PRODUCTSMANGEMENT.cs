using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace Management_System1.PL
{
    public partial class FRM_PRODUCTSMANGEMENT : Form
    {
        //Single Instant 
        private static FRM_PRODUCTSMANGEMENT frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FRM_PRODUCTSMANGEMENT getProductForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_PRODUCTSMANGEMENT();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        BL.CLS_Products pro = new BL.CLS_Products();
        public FRM_PRODUCTSMANGEMENT()
        {
            InitializeComponent();
            if (frm == null) frm = this;
            this.dataGridView1.DataSource = pro.Show_AllPRODUCT();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RPT.RPT_PRODUCT singlePro = new RPT.RPT_PRODUCT();
            singlePro.SetParameterValue("@Id_Product", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT();
            frm.crystalReportViewer1.ReportSource = singlePro;
            frm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = pro.Search_Product(textBox1.Text);
            this.dataGridView1.DataSource = Dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.ShowDialog();
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("are you sure to delete it!", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
                pro.Delete_Product(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = pro.Show_AllPRODUCT();
            }
            else
            {
                MessageBox.Show("Deleted Cancaled", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.txtID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtDescrip.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtQTN.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtPrice.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.comboBox1.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();

            frm.Text = "Update Product" + this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.btnAdd.Text = "Update";
            frm.state = "update";
            frm.txtID.ReadOnly = true;
            byte[] image = (byte[])pro.Get_Image(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pictureBox1.Image = Image.FromStream(ms);
            frm.ShowDialog();
        }

        private void btnShowPhoto_Click(object sender, EventArgs e)
        {
            FRM_PREVIEW frm = new FRM_PREVIEW();
            byte[] image = (byte[])pro.Get_Image(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pictureBox1.Image = Image.FromStream(ms);
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrintAllProduct_Click(object sender, EventArgs e)
        {
            RPT.RPT_ALLPRODUCT rpt = new RPT.RPT_ALLPRODUCT();
            RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }

        private void btnAsExcelFile_Click(object sender, EventArgs e)
        {

            RPT.RPT_ALLPRODUCT rpt = new RPT.RPT_ALLPRODUCT();
            ExportOptions Eo = new ExportOptions();
            DiskFileDestinationOptions Dfdo = new DiskFileDestinationOptions();
            ExcelFormatOptions Efo = new ExcelFormatOptions();

            Dfdo.DiskFileName = @"D:\Product_List.xls";
            Eo = rpt.ExportOptions;
            Eo.ExportDestinationType = ExportDestinationType.DiskFile;
            Eo.ExportFormatType = ExportFormatType.Excel;
            Eo.ExportFormatOptions = Efo;
            Eo.ExportDestinationOptions = Dfdo;

            rpt.Export();
            MessageBox.Show("File Exported Successfully","Save File", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
