using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Management_System1.DAL
{
    class Data_Access_Layer
    {
        //Feild to Initialies SQL Connection
        SqlConnection sqlConnection;

        //Constructor Give Value to SQL Connection Fild
        public Data_Access_Layer()
        {
            sqlConnection = new SqlConnection(@"Server=.\TADASHI; Database= Management__System; Integrated Security = false; User ID = sa; Password = 258987;");
        }

        //Method to Open Connection
        public void Open()
        {
            if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();
        }

        //Method to Close Connection
        public void Close()
        {
            if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
        }

        //Method to Read/Select Data From Database
        public DataTable SelectData(string stored_Procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_Procedure;
            sqlcmd.Connection = sqlConnection;
            if (param != null) sqlcmd.Parameters.AddRange(param);
            SqlDataAdapter Da = new SqlDataAdapter(sqlcmd);
            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            return Dt;
        }

        //Method to Insert, Update and Delete From Database
        public void ExecuteCommand(string stored_Procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_Procedure;
            sqlcmd.Connection = sqlConnection;
            if (param != null) sqlcmd.Parameters.AddRange(param);
            sqlcmd.ExecuteNonQuery();
        }

    }
}