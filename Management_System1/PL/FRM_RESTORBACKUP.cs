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
    public partial class FRM_RESTORBACKUP : Form
    {
        SqlConnection con = new SqlConnection(@"Server=.\TADASHI; Database= master; Integrated Security = false; User ID = sa; Password = 258987;");
        SqlCommand cmd;

        public FRM_RESTORBACKUP()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowes_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = openFileDialog1.FileName;
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string strQuary = @"ALTER Database Management__System SET OFFLINE WITH  ROLLBACK IMMEDIATE; Restore Database Management__System From Disk='" + txtPath.Text +"'";

                cmd = new SqlCommand(strQuary, con);
                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("BackUp Restored Successfully.", "BackUp", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
