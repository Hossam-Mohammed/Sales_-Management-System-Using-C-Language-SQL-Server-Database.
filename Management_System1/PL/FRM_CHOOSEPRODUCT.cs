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

namespace Management_System1.PL
{
    public partial class FRM_CHOOSEPRODUCT : Form
    {
        BL.CLS_Oreders ord = new BL.CLS_Oreders();
        public FRM_CHOOSEPRODUCT()
        {
            InitializeComponent();
            this.dgv1.DataSource = ord.Show_AllPRODUCT();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = ord.Search_Product(textBox1.Text);
            this.dgv1.DataSource = Dt;
        }

        private void dgv1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
