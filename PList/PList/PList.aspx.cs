using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PList
{
    public partial class PList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (txtName.Text.Length < 2)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Name Error", "alert('Name must be at least 2 characters length.');", true);
            }
            else if (txtAge.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Age Error", "alert('Age can not be empty.');", true);
            }
            else if ((int.Parse(txtAge.Text) < 0) || (int.Parse(txtAge.Text) > 150))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Age Error", "alert('Age must be between 0 and 150 y/o.');", true);
            }
            else
            {
                //lstPeople.Items.Add(new ListBoxItem(txtName.Text, int.Parse(txtAge.Text)).ToString());
                string connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\ipd\\Documents\\Persons.mdf;Integrated Security=True;Connect Timeout=30";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Persons (name, age) VALUES (@name, @age)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@age", int.Parse(txtAge.Text));
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                GridView1.DataBind();
                txtName.Text = "";
                txtAge.Text = "";
                txtName.Focus();
            }

        }

        protected string onselectedindexchanged()
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowIndex == GridView1.SelectedIndex)
                {
                    row.BackColor = ColorTranslator.FromHtml("#a1dcf2");
                    row.ToolTip = string.Empty;
                }
                else
                {
                    row.BackColor = ColorTranslator.FromHtml("#ffffff");
                    row.ToolTip = "click to select this row.";
                }
            }
            return "HHH";

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = onselectedindexchanged();
                    //ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click to select this row.";
            }

        }

    }
}