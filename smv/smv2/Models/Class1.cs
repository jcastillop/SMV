using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;

namespace smv2.Models
{
    public class Class1
    {

        public DataTable GetAllDepartments()
        {
            Connection c = new Connection();

            using (OracleConnection conn = c.Connect())
            {
                //List<string> LDptos = new List<string>();
                string sqlQuery = "select * from gnTCABE";
                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                cmd.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                try
                {
                    conn.Open();
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

    }
}