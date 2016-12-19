using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChangeToUpper
{
    public partial class Convert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConvertToFahr_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid) return; 
            string celsString = txtCelcius.Text;
            double celcius;
            if (!Double.TryParse(celsString, out celcius))
            {
                Response.Write("<script>alert('Please enter a valid number');</script>");
                txtCelcius.Text = "";
                return;
            }
            double fahrenheit = celcius*1.8+32;
            txtFahrenheit.Text = fahrenheit.ToString("#.##");

        }

        protected void btnConverToCel_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid) return; 

            string fahrString = txtFahrenheit.Text;
            double fahrenheit;
            if (!Double.TryParse(fahrString, out fahrenheit))
            {
                Response.Write("<script>alert('Please enter a valid number');</script>");
                txtFahrenheit.Text = "";
                return;
            }
            double celcius = (fahrenheit -32)/1.8;
            txtCelcius.Text = celcius.ToString("#.##");
        }

       
    }
}