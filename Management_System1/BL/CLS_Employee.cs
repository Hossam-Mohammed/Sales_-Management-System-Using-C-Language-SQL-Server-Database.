using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Management_System1.BL
{
    class CLS_Employee
    {
        //Method to Get All Employees
        public DataTable Get_All_Employees()
        {
            DAL.Data_Access_Layer DAL = new DAL.Data_Access_Layer();
            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SP_SHOWEMPLOYEE", null);
            DAL.Close();
            return Dt;
        }

        //Method to Add/Insert Employee Into Database
        public void Add_Employee(int EID, string EFName, string ELName
            , string EPh, string EMail, string EAd, decimal ESal, decimal EDedc,
            int ENSal)
        {
            DAL.Data_Access_Layer DAL = new DAL.Data_Access_Layer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@EID", SqlDbType.Int);
            param[0].Value = EID;
            param[1] = new SqlParameter("@EFName", SqlDbType.NVarChar, 15);
            param[1].Value = EFName;
            param[2] = new SqlParameter("@ELName", SqlDbType.NVarChar, 15);
            param[2].Value = ELName;
            param[3] = new SqlParameter("@EPh", SqlDbType.NVarChar, 14);
            param[3].Value = EPh;
            param[4] = new SqlParameter("@EMail", SqlDbType.NVarChar, 40);
            param[4].Value = EMail;
            param[5] = new SqlParameter("@EAd", SqlDbType.NVarChar, 60);
            param[5].Value = EAd;
            param[6] = new SqlParameter("@ESal", SqlDbType.Decimal);
            param[6].Value = ESal;
            param[7] = new SqlParameter("@EDedc", SqlDbType.Decimal);
            param[7].Value = EDedc;
            param[8] = new SqlParameter("@ENSal", SqlDbType.Int);
            param[8].Value = ENSal;

            DAL.ExecuteCommand("SP_ADDEMPLOYEE", param);
            DAL.Close();
        }

        //Method to Edit/Update Employee Into Database
        public void Edit_Employee(int EID, string EFName, string ELName
            , string EPh, string EMail, string EAd, decimal ESal, decimal EDedc,
            int ENSal)
        {
            DAL.Data_Access_Layer DAL = new DAL.Data_Access_Layer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@EID", SqlDbType.Int);
            param[0].Value = EID;
            param[1] = new SqlParameter("@EFName", SqlDbType.NVarChar, 15);
            param[1].Value = EFName;
            param[2] = new SqlParameter("@ELName", SqlDbType.NVarChar, 15);
            param[2].Value = ELName;
            param[3] = new SqlParameter("@EPh", SqlDbType.NVarChar, 14);
            param[3].Value = EPh;
            param[4] = new SqlParameter("@EMail", SqlDbType.NVarChar, 40);
            param[4].Value = EMail;
            param[5] = new SqlParameter("@EAd", SqlDbType.NVarChar, 60);
            param[5].Value = EAd;
            param[6] = new SqlParameter("@ESal", SqlDbType.Decimal);
            param[6].Value = ESal;
            param[7] = new SqlParameter("@EDedc", SqlDbType.Decimal);
            param[7].Value = EDedc;
            param[8] = new SqlParameter("@ENSal", SqlDbType.Int);
            param[8].Value = ENSal;

            DAL.ExecuteCommand("SP_EDITEMPLOYEE", param);
            DAL.Close();
        }
        //Method to Delete Employee Into Database
        public void Delete_Employee(int EID)
        {
            DAL.Data_Access_Layer DAL = new DAL.Data_Access_Layer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@EID", SqlDbType.Int);
            param[0].Value = EID;
       
            DAL.ExecuteCommand("SP_DELETEEMPLOYEE", param);
            DAL.Close();
        }
    }
}
