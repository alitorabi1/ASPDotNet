using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Convert
{
    public partial class Convert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double celsius = double.Parse(txtCelsius.Text);
            double fahrenheit = (celsius * 9/5) + 32;
            txtFahrenheit.Text = fahrenheit.ToString();

        }

        protected void btnChangeToCelsius_Click(object sender, EventArgs e)
        {
            double fahrenheit = double.Parse(txtFahrenheit.Text);
            double celsius = (fahrenheit - 32) * 5/9;
            txtCelsius.Text = celsius.ToString();

        }
    }
}