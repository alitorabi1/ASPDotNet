using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebToDo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DataGrid1_EditCommand(object source, DataGridCommandEventArgs e)
        {
            //DataGrid1.EditItemIndex = e.Item.ItemIndex;
            //BindData();
            int id = e.Item.ItemIndex;
            Response.Redirect("Edit.aspx?ToDoID=" + id);
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" + e.Row.RowIndex);
                e.Row.Attributes["style"] = "cursor:pointer";
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = GridView1.SelectedRow.RowIndex;
            string name = GridView1.SelectedRow.Cells[0].Text;
            string country = GridView1.SelectedRow.Cells[1].Text;
            string message = "Row Index: " + index + "\\nName: " + name + "\\nCountry: " + country;
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + message + "');", true);

        }
    }
}