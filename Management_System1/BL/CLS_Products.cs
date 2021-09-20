using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Management_System1.BL
{
    class CLS_Products
    {
        //Method to Get All Categories
        public DataTable Get_All_Categories()
        {
            DAL.Data_Access_Layer DAL = new DAL.Data_Access_Layer();
            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SP_GETALLCATEGORIES", null);
            DAL.Close();
            return Dt;
        }

        //Method to Add/Insert Product Into Database
        public void Add_Product(string ID_Product, string LBL_Product, int Qtn_Product
            , decimal Price_Product, byte[] Image_Product,int ID_Cat)
        {
            DAL.Data_Access_Layer DAL = new DAL.Data_Access_Layer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_Product", SqlDbType.NVarChar, 10);
            param[0].Value = ID_Product;
            param[1] = new SqlParameter("@LBL_Product", SqlDbType.NVarChar, 60);
            param[1].Value = LBL_Product;
            param[2] = new SqlParameter("@Qtn_Product", SqlDbType.Int);
            param[2].Value = Qtn_Product;
            param[3] = new SqlParameter("@Price_Product", SqlDbType.Decimal);
            param[3].Value = Price_Product;
            param[4] = new SqlParameter("@Image_Product", SqlDbType.Image);
            param[4].Value = Image_Product;
            param[5] = new SqlParameter("@ID_Cat", SqlDbType.Int);
            param[5].Value = ID_Cat;

            DAL.ExecuteCommand("SP_ADDPRODUCT", param);
            DAL.Close();
        }

        //Method to Update Product
        public void Update_Product(string ID_Product, string LBL_Product, int Qtn_Product
            , decimal Price_Product, byte[] Image_Product, int ID_Cat)
        {
            DAL.Data_Access_Layer DAL = new DAL.Data_Access_Layer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_Product", SqlDbType.NVarChar, 10);
            param[0].Value = ID_Product;
            param[1] = new SqlParameter("@LBL_Product", SqlDbType.NVarChar, 60);
            param[1].Value = LBL_Product;
            param[2] = new SqlParameter("@Qtn_Product", SqlDbType.Int);
            param[2].Value = Qtn_Product;
            param[3] = new SqlParameter("@Price_Product", SqlDbType.Decimal);
            param[3].Value = Price_Product;
            param[4] = new SqlParameter("@Image_Product", SqlDbType.Image);
            param[4].Value = Image_Product;
            param[5] = new SqlParameter("@ID_Cat", SqlDbType.Int);
            param[5].Value = ID_Cat;

            DAL.ExecuteCommand("SP_UPDATEPRODUCT", param);
            DAL.Close();
        }

        //Method to Verify ID Product
        public DataTable Verify_IDProduct(string ID_Product)
        {
            DAL.Data_Access_Layer DAL = new DAL.Data_Access_Layer();
            DAL.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_Product", SqlDbType.NVarChar, 10);
            param[0].Value = ID_Product;            
            Dt = DAL.SelectData("SP_VERIFYIDPRODUCT", param);
            DAL.Close();
            return Dt;
        }

        //Method to Show All Data in Grid View
        public DataTable Show_AllPRODUCT()
        {
            DAL.Data_Access_Layer DAL = new DAL.Data_Access_Layer();
            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SP_SHOWALLPRODUCT", null);
            DAL.Close();
            return Dt;
        }

        //Method to Search Product
        public DataTable Search_Product(string ID)
        {
            DAL.Data_Access_Layer DAL = new DAL.Data_Access_Layer();
            DAL.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 10);
            param[0].Value = ID;
            Dt = DAL.SelectData("SP_SEARCHPRODUCT", param);
            DAL.Close();
            return Dt;
        }

        //Method to Get Product Image in Update Form
        public DataTable Get_Image(string ID)
        {
            DAL.Data_Access_Layer DAL = new DAL.Data_Access_Layer();
            DAL.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 10);
            param[0].Value = ID;
            Dt = DAL.SelectData("SP_GETIMAGE", param);
            DAL.Close();
            return Dt;
        }

        //Method to Delete Product
        public void Delete_Product(string ID)
        {
            DAL.Data_Access_Layer DAL = new DAL.Data_Access_Layer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 10);
            param[0].Value = ID;
            DAL.ExecuteCommand("SP_DELETEPRODUCT", param);
            DAL.Close();
        }

    }
}
