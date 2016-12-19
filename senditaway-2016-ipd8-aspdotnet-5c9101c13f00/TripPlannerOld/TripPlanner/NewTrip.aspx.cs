using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TripPlanner
{
    public partial class NewTrip : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnAddTrip_Click(object sender, EventArgs e)
        {
            string name = tbFullName.Text;
            string gender = rblGender.SelectedValue.ToString();
            string passportNo = tbPassport.Text;
            string date = tbDate.Text;
            string airportFrom = airportsFromList.SelectedValue.ToString();
            string airportTo = airportsToList.SelectedValue.ToString();

              //FIXME: Validate input

            try
            {

                SqlDataSource.InsertCommand = "INSERT INTO Trips VALUES(@Name, @Gender, @Passport, @Date, @From, @To)";
                SqlDataSource.InsertParameters.Add("Name", name );
                SqlDataSource.InsertParameters.Add("Gender", gender);
                SqlDataSource.InsertParameters.Add("Passport", passportNo);
                SqlDataSource.InsertParameters.Add("Date", date);
                SqlDataSource.InsertParameters.Add("From", airportFrom);
                SqlDataSource.InsertParameters.Add("To", airportTo);

                SqlDataSource.Insert();
            }
            catch (SqlException ex)
            {

                Response.Write("<script>alert('Failed inserting record in the database');</script>");
                //Response.Write("<script>alert('Failed inserting record in the database. "
                //    + ex.Message + "');</script>");
                throw;

            }
            catch (InvalidOperationException)
            {
                Response.Write("<script>alert('Failed inserting record in the database');</script>");
            }
          




        }
    }
}