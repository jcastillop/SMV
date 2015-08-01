using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;

namespace smv2.Models
{
    public class CabeceraModels
    {
        public int id { get; set; } 
        public string c_Descri { get; set; }
        public int n_estreg { get; set; }
    }

    public class CabeceraConnection
    {
        public List<CabeceraModels> GetAllCabecera()
        {
            Connection c = new Connection();

            using (OracleConnection conn = c.Connect())
            {
                List<CabeceraModels> list = new List<CabeceraModels>();
                string sqlQuery = "select * from gnTCABE";
                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                cmd.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                 DataRow[] dr;
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                
                try
                {
                    conn.Open();
                    da.Fill(dt);

                    foreach (DataRow dataRow in dt.AsEnumerable().ToList())
                    {
                        CabeceraModels o = new CabeceraModels();

                        o.id = Convert.ToInt32(dataRow["N_IDCABE"].ToString());
                        o.c_Descri = dataRow["c_Descri"].ToString();
                        o.n_estreg = Convert.ToInt32(dataRow["n_estreg"].ToString());

                        list.Add(o);
                    }

                    return list;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}