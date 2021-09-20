using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Management_System1.BL
{
    class CLS_Oreders
    {

        //Method to Verify Qnt in Stock
        public DataTable Verify_Qtn(string Id_Product, int Qtn_Entered)
        {
            DAL.Data_Access_Layer DAL = new DAL.Data_Access_Layer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Id_Product", SqlDbType.NVarChar, 60);
            param[0].Value = Id_Product;
            param[1] = new SqlParameter("@Qtn_Entered", SqlDbType.Int);
            param[1].Value = Qtn_Entered;

            Dt = DAL.SelectData("SP_VERIFYQTN", param);
            DAL.Close();
            return Dt;
        }

        //Method to Full Employee Combobox
        public DataTable Get_AllEmployees()
        {
            DAL.Data_Access_Layer DAL = new DAL.Data_Access_Layer();
            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SP_GETEMPLOYEES", null);
            DAL.Close();
            return Dt;
        }

        //Method to Add Orders
        public void Add_Order(int Id_Order, string Desc_Order, string D_Order, int Id_Emp, string Id_User)
        {
            DAL.Data_Access_Layer DAL = new DAL.Data_Access_Layer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Id_Order", SqlDbType.Int);
            param[0].Value = Id_Order;
            param[1] = new SqlParameter("@Desc_Order", SqlDbType.NVarChar, 300);
            param[1].Value = Desc_Order;
            param[2] = new SqlParameter("@D_Order", SqlDbType.Date);
            param[2].Value = D_Order;
            param[3] = new SqlParameter("@Id_Emp", SqlDbType.Int);
            param[3].Value = Id_Emp;
            param[4] = new SqlParameter("@Id_User", SqlDbType.NVarChar, 40);
            param[4].Value = Id_User;

            DAL.ExecuteCommand("SP_ADDORDER", param);
        }

        //Method to Add Orders_Dedaitls
        public void Add_OrderDetails(string Id_Pro, int Id_Ord, int Qte, string Pro_Price, float Disct
            , string Pro_Amount, string T_Amount)
        {
            DAL.Data_Access_Layer DAL = new DAL.Data_Access_Layer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@Id_Pro", SqlDbType.NVarChar, 10);
            param[0].Value = Id_Pro;
            param[1] = new SqlParameter("@Id_Ord", SqlDbType.Int);
            param[1].Value = Id_Ord;
            param[2] = new SqlParameter("@Qte", SqlDbType.Int);
            param[2].Value = Qte;
            param[3] = new SqlParameter("@Pro_Price", SqlDbType.NVarChar, 50);
            param[3].Value = Pro_Price;
            param[4] = new SqlParameter("@Disct", SqlDbType.Float);
            param[4].Value = Disct;
            param[5] = new SqlParameter("@Pro_Amount", SqlDbType.NVarChar, 50);
            param[5].Value = Pro_Amount;
            param[6] = new SqlParameter("@T_Amount", SqlDbType.NVarChar, 50);
            param[6].Value = T_Amount;

            DAL.ExecuteCommand("SP_ADDORDERDETAILS", param);
        }

        //Method to Get Last Order ID
        public DataTable Get_Last_Order_ID()
        {
            DAL.Data_Access_Layer DAL = new DAL.Data_Access_Layer();
            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SP_GETLASTORDERID", null);
            DAL.Close();
            return Dt;
        }

        public DataTable Get_Last_Order_ID_PR()
        {
            DAL.Data_Access_Layer DAL = new DAL.Data_Access_Layer();
            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SP_GETLASTORDERID_PR", null);
            DAL.Close();
            return Dt;
        }

        public DataTable Get_Order_Deatails(int ID_Ord)
        {
            DAL.Data_Access_Layer DAL = new DAL.Data_Access_Layer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_Ord", SqlDbType.Int);
            param[0].Value = ID_Ord;

            Dt = DAL.SelectData("SP_GETORDERDETAILS", param);
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
    }
}
