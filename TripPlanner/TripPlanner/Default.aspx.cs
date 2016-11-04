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
            lblCounter.Text = GridView1.Rows.Count.ToString();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onmouseover"] = "this.style.backgroundColor='green';this.style.color='white';";
                e.Row.Attributes["onmouseout"] = "this.style.backgroundColor='white';this.style.color='black';";
                e.Row.ToolTip = "Click to view the details";
                e.Row.Attributes["style"] = "cursor:pointer";

                e.Row.Attributes["onclick"] = string.Format("window.location = 'ViewTrip.aspx?TripID={0}';", DataBinder.Eval(e.Row.DataItem, "Id"));

            }

        }


    }
}