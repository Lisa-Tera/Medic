using Drug2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace Drug2
{
    public class DrugData
    {
        public static void Initialize()
        {
            string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\SW\medi.accdb;Persist Security Info=False;";
            DataTable dt;
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                using (OleDbDataAdapter da = new OleDbDataAdapter())
                {
                    using (OleDbCommand cmd = new OleDbCommand("SELECT * from Sheet0", conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        da.SelectCommand = cmd;
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        if (ds.Tables.Count > 0)
                        {
                            dt = ds.Tables[0];

                            var qDrugs = from row in dt.AsEnumerable()
                                         select new DrugBasic
                                         {
                                             ITEM_NAME = row.Field<string>("품목명"),
                                             EE_DOC_DATA = "", //row.Field<string>("EE_DOC_DATA"),
                                             ETC_OTC_CODE = row.Field<string>("전문일반"),
                                             UD_DOC_DATA = "", // row.Field<string>("UD_DOC_DATA"),
                                             VALID_TERM = row.Field<string>("유효기간"),
                                             NB_DOC_DATA = "",//row.Field<string>("")
                                             STORE = row.Field<string>("저장방법"),
                                             PROPERTIES =  row.Field<string>("성상")
                                         };

                            StaticVars.Drugs = qDrugs.ToList();
                        }
                    }
                }
            }
        }
    }
}