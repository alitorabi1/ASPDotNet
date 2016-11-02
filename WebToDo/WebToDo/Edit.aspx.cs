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
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ToDoID"]);
            txtDescEdit.Text = id.ToString();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\lenovo\\Documents\\WebToDoH.mdf; Integrated Security = True; Connect Timeout = 30";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM ToDos WHERE ID=" + id);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                connection.Open();
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                txtDescEdit.Text = reader.GetString(1);
                Calendar2.SelectedDate = reader.GetDateTime(2);
                String isDone = reader.GetString(3);
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}