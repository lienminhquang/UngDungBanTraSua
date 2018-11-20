using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.DB_layer
{
    public class DBMain
    {
        private string connectionString = "Server=(local);DataBase=UngDungBanTraSua;Integrated Security=SSPI";
        private SqlConnection sqlCon = null;


        public bool login(string tendn, string mk)
        {
            string fullString = connectionString + " User ID=" + tendn + ";Password=" + mk + "";          

            try
            {
                
                sqlCon.ConnectionString = fullString;
                sqlCon.Open();


            }
            catch (Exception err)
            {

                return false;
            }


            return true;
        }


        private DBMain()
        {
            connectionString = ReadStringConnectionFromFile("config.txt");
            //sqlCon = new SqlConnection(connectionString);
            sqlCon = new SqlConnection();
        }

        private static DBMain instance = null;

        private static string ReadStringConnectionFromFile(string fileName)
        {
            string conString = "//Server=(local);DataBase=UngDungBanTraSua;Integrated Security=SSPI;";
            try
            {
                using (StreamReader rd = new StreamReader(fileName))
                {
                    conString = rd.ReadLine();
                }
            }
            catch (Exception err)
            {

                throw err;
            }

            return conString;
        }

        public static DBMain Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DBMain();

                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        ~DBMain()
        {
            
        }

       

        public object executeFunctionScalar(string funcName, List<SqlParameter> lstParam = null)
        {
            if (sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
            sqlCon.Open();

            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select " + funcName;

            if(lstParam != null)
                cmd.Parameters.AddRange(lstParam.ToArray());

            return cmd.ExecuteScalar();
        }

        public DataSet executeFunctionDataset(string funcName, List<SqlParameter> lstParam = null)
        {
            DataSet ds = new DataSet();

            if (sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
            sqlCon.Open();

            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from " + funcName;

            if(lstParam != null)
                cmd.Parameters.AddRange(lstParam.ToArray());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);


            return ds;
        }

        public void executeStoredProc(string name, List<SqlParameter> lstParam)
        {
            if (sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
            sqlCon.Open();

            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = name;

            cmd.Parameters.AddRange(lstParam.ToArray());

             cmd.ExecuteNonQuery();
        }

        public DataSet executeQueryDataset(string query)
        {
            DataSet ds = new DataSet();

            if (sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
            sqlCon.Open();

            SqlCommand cmd = sqlCon.CreateCommand();      
            cmd.CommandText = query;

            

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);


            return ds;
        }

        internal void executeStoredProc(object p_DoiMK, List<SqlParameter> lstParam)
        {
            throw new NotImplementedException();
        }

        public object executeQueryScalar(string query, CommandType type = CommandType.Text, List<SqlParameter> lstParam = null)
        {
            DataSet ds = new DataSet();

            if (sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
            sqlCon.Open();

            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = type;
            cmd.CommandText = query;

            if (lstParam != null)
                cmd.Parameters.AddRange(lstParam.ToArray());

            return cmd.ExecuteScalar();
        }

        

    }
}
