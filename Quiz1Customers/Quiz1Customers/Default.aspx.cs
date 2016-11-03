using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz1Customers
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbFemales.Text = SqlDataSource2.SelectParameters.ToString();
            lbMales.Text = SqlDataSource3.SelectParameters.ToString();

        }

        protected void gvCustomers_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onmouseover"] = "this.style.backgroundColor='green';this.style.color='white';";
                e.Row.Attributes["onmouseout"] = "this.style.backgroundColor='white';this.style.color='black';";
                e.Row.ToolTip = "Click to view the details";
                e.Row.Attributes["style"] = "cursor:pointer";

                e.Row.Attributes["onclick"] = string.Format("window.location = 'View.aspx?CustomerID={0}';", DataBinder.Eval(e.Row.DataItem, "Id"));

            }

        }
    }
}