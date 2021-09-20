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
    public partial class FRM_BACKUP : Form
    {

        SqlConnection con = new SqlConnection(@"Server=.\TADASHI; Database= Management__System; Integrated Security = false; User ID = sa; Password = 258987;");
        SqlCommand cmd;

        public FRM_BACKUP()
        {
            InitializeComponent();
        }

        private void btnBrowes_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = folderBrowserDialog1.SelectedPath;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = txtPath.Text + "\\MS_Backup" + DateTime.Now.ToShortDateString().Replace('/', '-')
                + " - " + DateTime.Now.ToLongTimeString().Replace(':', '-');
                string strQuary = @"Backup Database Management__System to Disk ='" + fileName + ".bak'";

                cmd = new SqlCommand(strQuary, con);
                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("BackUp Saved", "BackUp", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Some Errors Have Been Occurss.");
            }
            finally
            {
                con.Close();
            }

        }

    }
}
