using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Oracle.DataAccess.Client;

namespace smv2.Models
{
    public class Connection
    {
        private string password, user;
 
        public Connection()
        { }
 
        public OracleConnection Connect()
        {
            ////////////////////////////////////////////////////////////////////////////////////
            //Referencia estática al usuario y password ingresados en el login de la aplicación/
            ////////////////////////////////////////////////////////////////////////////////////
            user ="smv";
            password = "smv";
 
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
                throw new Exception("El usuario y el password son datos requeridos");
 
            string oradb = ConfigurationManager.
            ConnectionStrings["ConnectionStringUsers"].ConnectionString;
            oradb = string.Format(oradb, user, password);
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = oradb;
            return conn;
        }
    }
}