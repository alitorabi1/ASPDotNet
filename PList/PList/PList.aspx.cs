using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PList
{
    public partial class PList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length < 2)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Name Error", "alert('Name must be at least 2 characters length.');", true);
            }
            else if (txtAge.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Age Error", "alert('Age can not be empty.');", true);
            }
            else if ((int.Parse(txtAge.Text) < 0) || (int.Parse(txtAge.Text) > 150))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Age Error", "alert('Age must be between 0 and 150 y/o.');", true);
            }
            else
            {
                lstPeople.Items.Add(new ListBoxItem(txtName.Text, int.Parse(txtAge.Text)).ToString());
            }

        }
    }
}