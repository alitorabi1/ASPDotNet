using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HWorld
{
    public partial class start : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string data = "pageB.aspx?name=" + txtInput.Text +
                            "&company=" + Server.UrlEncode(rdlLanguage.SelectedItem.ToString()) +
                            "&lang=" + Server.UrlEncode(DropDownList1.SelectedItem.ToString());



            Response.Redirect(data);
            
            //lblOutput.Text = "Hello " + txtInput.Text  + ". Thanks for the information." + "<br />" + "Favorite language: " + rdlLanguage.SelectedItem.ToString() + "<br /> " +
            //                    "Company Size: " + DropDownList1.SelectedItem.ToString();
        }
    }
}