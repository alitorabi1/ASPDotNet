using System;
using System.Collections.Generic;
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
            if (!Page.IsValid) return;
            string name = txtName.Text;
            string gender = rblGender.SelectedValue;
            string passport = txtPassport.Text;
            string date = Calendar1.SelectedDate.ToString();
            string departureAP = ddlDeparture.SelectedValue;
            string arrivalAP = ddlArrival.SelectedValue;


            //Server Side validation
            if (name.Length < 2)
            {
                return;
            }

            //Insert into the database
            SqlDataSource1.InsertCommand = "INSERT INTO Trips VALUES(@Name, @Gender, @Passport, @Date, @DepartureAP, @ArrivalAP)";

            SqlDataSource1.InsertParameters.Add("Name", name);
            SqlDataSource1.InsertParameters.Add("Gender", gender);
            SqlDataSource1.InsertParameters.Add("Passport", passport);
            SqlDataSource1.InsertParameters.Add("Date", date);
            SqlDataSource1.InsertParameters.Add("DepartureAP", departureAP);
            SqlDataSource1.InsertParameters.Add("ArrivalAP", arrivalAP);
            SqlDataSource1.Insert();

            Response.Redirect("Default.aspx");

        }

        protected void dateValidation(object source, ServerValidateEventArgs args)
        {
            DateTime minDate = DateTime.Today;
            DateTime selectedDate;

            args.IsValid = (DateTime.TryParse(args.Value, out selectedDate) && selectedDate >= minDate);
        }

    }
}