using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Food_Order.DAL
{
    class dbConnect
    {
       //Connection String
        string str = @"Data source= ice-db;Initial Catalog=Ice_Project_Directory;Integrated Security=true;";
    //------------------------------------------------------------------------------------------------
        private SqlConnection sco;
        private SqlDataAdapter adp;

        public dbConnect()
        {
            adp = new SqlDataAdapter();
            // sco  = new SqlConnection(ConfigurationManager.ConnectionStrings
            //  ["App1.config"].ConnectionString);

            sco = new SqlConnection(str);
        }


        public SqlConnection openconnection()
        {
            if (sco.State == ConnectionState.Closed || sco.State ==
        ConnectionState.Broken)
            {
                sco.Open();
            }
            return sco;

        }


        public SqlConnection closeconnection()
        {
            if (sco.State == ConnectionState.Open || sco.State == ConnectionState.Fetching)
            {
                sco.Close();
                sco.Dispose();
            }
            return sco;
        }

    }
}
