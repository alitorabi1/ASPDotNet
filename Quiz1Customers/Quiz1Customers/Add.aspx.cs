using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz1Customers
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btAddCustomer_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            string name = tbName.Text;
            string postalCode = tbPostalCode.Text;
            string province = ddlProvince.SelectedValue;
            string email = tbEmail.Text;
            string gender = rblGender.SelectedValue;


            //Server Side validation
            if (name.Length < 2 || postalCode == "" || email == "")
            {
                return;
            }

            try
            {
                //Insert into the database
                SqlDataSource1.InsertCommand = "INSERT INTO Customers VALUES(@Name, @PostalCode, @Province, @Email, @Gender)";

                SqlDataSource1.InsertParameters.Add("Name", name);
                SqlDataSource1.InsertParameters.Add("PostalCode", postalCode);
                SqlDataSource1.InsertParameters.Add("Province", province);
                SqlDataSource1.InsertParameters.Add("Email", email);
                SqlDataSource1.InsertParameters.Add("Gender", gender);
                SqlDataSource1.Insert();
            }
            catch (SqlException ex)
            {
                Response.Write("<script>alert('Error: Can not insert record in the database');</script>");
                throw;

            }
            catch (InvalidOperationException)
            {
                Response.Write("<script>alert('Error: Can not insert record in the database');</script>");
            }

            Response.Redirect("Default.aspx");

        }

    }
}