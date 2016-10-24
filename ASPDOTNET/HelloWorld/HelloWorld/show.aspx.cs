using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class show : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblOutput.Text = "Hello " + Request.QueryString["name"] + ". Thanks for the information. <br>Favorite language: " + Request.QueryString["language"] + "<br>Company size: " + Request.QueryString["company"];
        }
    }
}