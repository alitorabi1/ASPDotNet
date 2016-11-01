using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebToDo
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            if (txtDesc.Text.Length < 2)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Name Error", "alert('Name must be at least 2 characters length.');", true);
            }
            else
            {
                //lstPeople.Items.Add(new ListBoxItem(txtName.Text, int.Parse(txtAge.Text)).ToString());
                string connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\ipd\\Documents\\WebToDo.mdf;Integrated Security=True;Connect Timeout=30";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO ToDos (description, dueDate, isDone) VALUES (@description, @dueDate, @isDone)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@description", txtDesc.Text);
                    cmd.Parameters.AddWithValue("@dueDate", Calendar1.SelectedDate);
                    cmd.Parameters.AddWithValue("@isDone", "n");
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                Response.Redirect("Default.aspx");
            }

        }

    }
}