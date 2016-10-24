using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class start : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //lblOutput.Text = "Hello " + txtName.Text + ". Thanks for the information. <br>Favorite language: " + rblLanguage.SelectedItem.ToString() + "<br>Company size: " + ddlCompanySize.SelectedItem.ToString();

            Response.Redirect("show.aspx?name=" + txtName.Text + "&language=" + Server.UrlEncode(rblLanguage.SelectedItem.ToString()) + "&company=" + ddlCompanySize.SelectedItem.ToString());
        }

       
    }
}