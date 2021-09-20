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

namespace Management_System1.PL
{
    public partial class FRM_ADD_PRODUCT : Form
    {
        public string state = "add";
        //Get Class Product From BL File
        BL.CLS_Products pro = new BL.CLS_Products();
        public FRM_ADD_PRODUCT()
        {
            InitializeComponent();
            //Full Combobox by Category Data
            comboBox1.DataSource = pro.Get_All_Categories();
            comboBox1.DisplayMember = "Name_Category";
            comboBox1.ValueMember = "ID_Category";
            txtID.Focus();
        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            //Function to Make User Select Picture From Pc
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images Files | *.JPG; *.PNG; *.GIF; *.BMP";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Save Picture in Database as binary code
            if (state == "add")
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] byteImage = ms.ToArray();

                pro.Add_Product(txtID.Text, txtDescrip.Text, Convert.ToInt32(txtQTN.Text)
                    , Convert.ToDecimal(txtPrice.Text), byteImage, Convert.ToInt32(comboBox1.SelectedValue));

                MessageBox.Show("Added Successfully", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] byteImage = ms.ToArray();

                pro.Update_Product(txtID.Text, txtDescrip.Text, Convert.ToInt32(txtQTN.Text)
                    , Convert.ToDecimal(txtPrice.Text), byteImage, Convert.ToInt32(comboBox1.SelectedValue));

                MessageBox.Show("Updated Successfully", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            FRM_PRODUCTSMANGEMENT.getProductForm.dataGridView1.DataSource = pro.Show_AllPRODUCT();
        }

        private void txtID_Validated(object sender, EventArgs e)
        {
            //Check If Product ID Existis
            if (state == "add")
            {
                DataTable Dt = new DataTable();
                Dt = pro.Verify_IDProduct(txtID.Text);
                if (Dt.Rows.Count > 0)
                {
                    MessageBox.Show("This ID is Already Existis", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Focus();
                    txtID.SelectionStart = 0;
                    txtID.SelectionLength = txtID.TextLength;
                }
            }
            else
            {

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
