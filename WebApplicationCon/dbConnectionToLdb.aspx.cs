using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.WebSockets;

namespace WebApplicationCon
{
    public partial class dbConnectionToLdb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Step 1: Connection string
            string s= ConfigurationManager.ConnectionStrings["LDbConStr"].ToString();

            //Step 2: Connection Object
            SqlConnection con = new SqlConnection(s);

            //Step 3: Database command
            SqlCommand cmd = new SqlCommand(" SELECT * FROM [employees]", con);

            //Step 4: Open Connection
            con.Open();

            //Step 5: Execute the comand from Step 4
            SqlDataReader dr = cmd.ExecuteReader();

            /*
             * Take note of the following
             * SELECT statement use  cmd.ExecuteReader();
             *  when ever the command is to INSERT, UPDATE, DELETE a data use cmd.BeginExecuteNonQuery();
             *  For a query to return a specific value eg avg salary, totalnumber use   cmd.ExecuteScalar();
             *  make sure to typecast it because it will return an object
             * 
             */

            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();

            //Step 6: Close the database

            con.Close();


           
        }
    }
}