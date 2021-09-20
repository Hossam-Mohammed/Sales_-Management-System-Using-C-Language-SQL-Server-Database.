using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Management_System1.BL
{
    class CLS_Login
    {
        //Method to Comapare Between Data Enterd and Data in Database When Login
        public DataTable Login(string ID, string Pass)
        {
            DAL.Data_Access_Layer DAL = new DAL.Data_Access_Layer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 40);
            param[0].Value = ID;

            param[1] = new SqlParameter("@Pass", SqlDbType.NVarChar, 16);
            param[1].Value = Pass;

            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SP_LOGIN", param);
            DAL.Close();
            return Dt;
        }

        //Method to Get Add For Every User
        public void Add_User(string ID, string Pass, string Acc)
        {
            DAL.Data_Access_Layer DAL = new DAL.Data_Access_Layer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 40);
            param[0].Value = ID;
            param[1] = new SqlParameter("@Pass", SqlDbType.NVarChar, 16);
            param[1].Value = Pass;
            param[2] = new SqlParameter("@Access", SqlDbType.NVarChar, 6);
            param[2].Value = Acc;
            DAL.ExecuteCommand("SP_ADD_USER", param);
            DAL.Close();
        }

        //Method to Edit Users
        public void Edit_User(string ID, string Pass, string Acc)
        {
            DAL.Data_Access_Layer DAL = new DAL.Data_Access_Layer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 40);
            param[0].Value = ID;
            param[1] = new SqlParameter("@Pass", SqlDbType.NVarChar, 16);
            param[1].Value = Pass;
            param[2] = new SqlParameter("@Access", SqlDbType.NVarChar, 6);
            param[2].Value = Acc;
            DAL.ExecuteCommand("SP_Edit_USER", param);
            DAL.Close();
        }

        //Method to Delete User
        public void Delete_User(string ID)
        {
            DAL.Data_Access_Layer DAL = new DAL.Data_Access_Layer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 40);
            param[0].Value = ID;
            DAL.ExecuteCommand("SP_DELETEUSER", param);
            DAL.Close();
        }

        //Method to Search in Users Data
        public DataTable Search_Users(string Key)
        {
            DAL.Data_Access_Layer DAL = new DAL.Data_Access_Layer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@KeyWord", SqlDbType.NVarChar, 50);
            param[0].Value = Key;

            Dt = DAL.SelectData("SP_SEARCH", param);
            DAL.Close();
            return Dt;
        }

    }
}
