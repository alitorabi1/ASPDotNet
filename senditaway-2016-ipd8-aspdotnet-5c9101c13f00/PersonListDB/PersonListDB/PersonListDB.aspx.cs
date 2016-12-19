using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PersonListDB
{
    public partial class PersonListDB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            string name = txtName.Text;
            if (name.Length < 2)
            {
                //Response.Write("<script>alert('Name must be at least 2 characters long');</script>");
                txtName.Text = "";
                return;
            }
            int age;
            if (!Int32.TryParse(txtAge.Text, out age) || age < 0 || age > 150)
            {
                //Response.Write("<script>alert('Please enter a valid number between 0 and 150');</script>");
                txtAge.Text = "";
                return;
            }

            SqlDataSource1.InsertCommandType = SqlDataSourceCommandType.Text;
            SqlDataSource1.InsertCommand = "INSERT INTO Persons VALUES(@Name, @Age)";

            SqlDataSource1.InsertParameters.Add("Name", name);
            SqlDataSource1.InsertParameters.Add("Age", age.ToString());
            SqlDataSource1.Insert();

            txtName.Text = "";
            txtAge.Text = "";

        }
    }
}