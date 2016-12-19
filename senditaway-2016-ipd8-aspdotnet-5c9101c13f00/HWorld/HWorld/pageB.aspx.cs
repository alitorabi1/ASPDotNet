using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HWorld
{
    public partial class pageB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string recievedText = "Hello " + Request.QueryString["name"] + ". Thanks for the information."
                    + "<br />" + "Favorite language: " + Request.QueryString["lang"] + "<br /> " 
                    + "Company Size: " + Request.QueryString["company"];


            lblInfo.Text = recievedText;
        }
    }
}