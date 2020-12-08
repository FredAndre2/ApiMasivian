using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;

namespace ApiMasivian.DataAccess
{
    public class DBConexion
    {
        private MySqlConnection myConnection;
        public IConfiguration Configuration { get; }
        MySqlCommand myCommand;
        MySqlTransaction myTrans;
        public void OpenConnection()
        {        
            string serverDB = "localhost";
            string nameDB = "masivian";
            string userDb = "root";
            string passDB = "12345";
            string server = serverDB;
            string credentials = GetConnectionString (nameDB, userDb, passDB);
            string stringConection = string.Format("server={0}{1}", server, credentials);
            try
            {
                if (myConnection != null)
                {
                    if (myConnection.State == System.Data.ConnectionState.Closed)
                        myConnection.Open();
                }
                else
                {
                    myConnection = new MySqlConnection(stringConection);
                    myConnection.Open();
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }
        public void CloseConnection()
        {
            try
            {
                if (myConnection != null)
                {
                    if (myConnection.State == System.Data.ConnectionState.Open)
                    {
                        myConnection.Close();
                        myConnection.Dispose();
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }
        public MySqlDataReader ExecuteSelect(string query, MySqlParameter[] parameters = null)
        {
            MySqlCommand myCommand;
            MySqlTransaction myTrans;
            myTrans = null;
            try
            {
                myCommand = myConnection.CreateCommand();
                myCommand.Transaction = myTrans;
                if (parameters != null)
                {
                    foreach (MySqlParameter parameter in parameters)
                    {
                        myCommand.Parameters.Add(parameter);
                    }
                }
                myCommand.CommandText = query;
                return myCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }
        public bool Execute(string query, MySqlParameter[] parameters = null)
        {
            myCommand = myConnection.CreateCommand();
            myCommand.Transaction = myTrans;
            myCommand.CommandText = query;
            if (parameters != null)
            {
                foreach (MySqlParameter parameter in parameters)
                {
                    myCommand.Parameters.Add(parameter);
                }
            }
            return myCommand.ExecuteNonQuery() > 0 ? true : false;
        }
        public void BeginTransaccion()
        {
            try
            {
                myCommand = myConnection.CreateCommand();
                myTrans = myConnection.BeginTransaction();
                myCommand.Transaction = myTrans;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Commit()
        {
            try
            {
                if (myTrans != null)
                {
                    myTrans.Commit();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void RollBack()
        {
            if (myTrans != null)
            {
                myTrans.Rollback();
            }
        }
        public static string GetConnectionString (string nameDB, string userDb, string passDB)
        {
            string connectionString = string.Empty;
            connectionString = string.Format(";user id={0};password={1};persist security info=True;database={2}", userDb, passDB, nameDB);
            return connectionString;
        }
        public MySqlParameter[] GetParametros(Hashtable listParam)
        {
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            if (listParam != null)
            {
                foreach (Object key in listParam.Keys)
                {
                    parameters.Add(new MySqlParameter(key.ToString(), listParam[key]));
                }
            }

            return parameters.ToArray();
        }
    }
}
