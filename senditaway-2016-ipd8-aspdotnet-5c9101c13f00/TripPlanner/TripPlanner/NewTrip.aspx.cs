using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
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
            if (!Page.IsValid) return;

            string name = tbFullName.Text;
            string gender = rblGender.SelectedValue.ToString() == "null" ? "null":
                string.Format("'{0}'", rblGender.SelectedValue.ToString());
            string passportNo = tbPassport.Text;
            string date = tbDate.Text;
            string airportFrom = airportsFromList.SelectedValue.ToString();
            string airportTo = airportsToList.SelectedValue.ToString();

              /*
              if(name.Length <2 || name.Length > 100)
            {
               return;
            }
            Match match = Regex.Match(passportNo, @"^[A-Z]{2}[0-9]{6}$");
            if (!match.Success)
            {
               return;
            }
            DateTime date;
            if (!DateTime.TryParse(dateString, out date)
                            || date < DateTime.Today)
            {
                return;
            }
            if(airportFrom.Equals(airportTo))
            {
                //Response.Write("<script>alert('Airports are the same');</script>");
                return;
            }
            */
            try
            {

                SqlDataSource.InsertCommand = "INSERT INTO Trips VALUES(@Name, " + gender + ", @Passport, @Date, @From, @To)";
                SqlDataSource.InsertParameters.Add("Name", name );
               // SqlDataSource.InsertParameters.Add("Gender", gender);
                SqlDataSource.InsertParameters.Add("Passport", passportNo);
                SqlDataSource.InsertParameters.Add("Date", date);
                SqlDataSource.InsertParameters.Add("From", airportFrom);
                SqlDataSource.InsertParameters.Add("To", airportTo);

                SqlDataSource.Insert();
                Response.Write("<script>"
                             + "alert('Your trip registered successfully'); "
                             + "document.location = '/Default.aspx'; </script>");


            }
            catch (SqlException ex)
            {
                Response.Write("<script>alert('Failed inserting record in the database');</script>");

                //Response.Write("<script>alert('Failed inserting record in the database. "
                //   + ex.Message + "');</script>");
                throw;

            }
            catch (InvalidOperationException)
            {
                Response.Write("<script>alert('Failed inserting record in the database');</script>");
            }
        }

        protected void valDate_ServerValidate(object source, ServerValidateEventArgs args)
        {
            DateTime minDate = DateTime.Today;
            DateTime selectedDate;

            args.IsValid = (DateTime.TryParse(args.Value, out selectedDate)
                            && selectedDate >= minDate);

        }
    }
}