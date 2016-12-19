using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TripPlanner
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            SqlDataSource SqlDataSource = new SqlDataSource();
            SqlDataSource.ID = "SqlDataSource2";
            this.Page.Controls.Add(SqlDataSource);
            SqlDataSource.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlDataSource.SelectCommand = "SELECT COUNT(*) AS Count from Trips";

            DataView dvSql = (DataView)SqlDataSource.Select(DataSourceSelectArguments.Empty);
            int tripsCount = (int)dvSql[0]["Count"];
            lblTripsCount.Text = string.Format("You have a total of {0} trips planned", tripsCount.ToString()); 
            */
        }

        protected void SqlDataSource1_Selected(object sender, SqlDataSourceStatusEventArgs e)
        {
            int tripsCount = e.AffectedRows;
            lblTripsCount.Text = string.Format("You have a total of {0} trips planned", tripsCount); 

        }
    }
}