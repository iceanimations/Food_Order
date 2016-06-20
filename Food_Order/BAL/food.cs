using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Food_Order.DAL;

namespace Food_Order.BAL
{
    interface _food
    {
        DataTable food_Order(string txt1);
    }
        
    class food : _food
    {
       
        SqlDataAdapter adp;
        DataSet ds;
        DataTable dt;
        SqlCommand scom;
        dbConnect obj = new dbConnect();


        public DataTable food_Order(string txt1)
        {
            string str1 = "SP_tabl_bin_Food_Order";
            adp = new SqlDataAdapter(str1, obj.openconnection());
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            scom.Parameters.Add("@today", SqlDbType.DateTime).Value = txt1;
           // scom.Parameters.Add("@tomorrow", SqlDbType.DateTime).Value = txt2;
            dt = new DataTable();
            adp.Fill(dt);
            obj.closeconnection();
            return dt;

        }

    }
}
