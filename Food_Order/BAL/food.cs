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
        DataTable food_Order(DateTime txt1);
        int Delete(int empid, DateTime date, String which_order);
    }
        
    class food : _food
    {
       
        SqlDataAdapter adp;
        DataTable dt;
        SqlCommand scom;
        dbConnect obj = new dbConnect();


        public DataTable food_Order(DateTime txt1)
        {
            string str1 = "SP_tabl_bin_Food_Order";
            adp = new SqlDataAdapter(str1, obj.openconnection());
            scom = adp.SelectCommand;
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            scom.Parameters.Add("@today", SqlDbType.DateTime).Value = txt1;
            //scom.Parameters.AddWithValue("@today", SqlDbType.DateTime).Value = txt1;
           // scom.Parameters.Add("@tomorrow", SqlDbType.DateTime).Value = txt2;
            dt = new DataTable();
            adp.Fill(dt);
            adp.Update(dt);
            obj.closeconnection();
            return dt;

        }
    
        public int Delete(int empid, DateTime date, String which_order)
        {
            int result;
            string str1 = "SP_tbl_bin_Update_Order";
            scom = new SqlCommand(str1, obj.openconnection());
            scom.CommandType = CommandType.StoredProcedure;
            scom.Parameters.Add("@emp_id", SqlDbType.Int).Value = empid;
            scom.Parameters.Add("@current_date", SqlDbType.Date).Value = date;
            scom.Parameters.Add("@which_order", SqlDbType.VarChar).Value = which_order;
            result = scom.ExecuteNonQuery();
            return result;

        }

    }
}
