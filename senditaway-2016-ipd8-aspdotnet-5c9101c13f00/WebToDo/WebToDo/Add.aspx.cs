using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebToDo
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void valDateRange_ServerValidate(object source, ServerValidateEventArgs args)
        {
            DateTime minDate = DateTime.Today;
            DateTime selectedDate;

            args.IsValid = (DateTime.TryParse(args.Value, out selectedDate)
                            && selectedDate >= minDate);
        }


        protected void btnAdd_Click(object sender, EventArgs e)
        {
             if (!Page.IsValid) return;
            string description = txtDescription.Text;

            //Server Side validation
            if (description.Length < 0 || description.Length > 100)
            {
                return;
            }
            DateTime dueDate;
            if (!DateTime.TryParse(txtDueDate.Text, out dueDate)
                            || dueDate < DateTime.Today)
            {
                return;
            }

            //Insert into the database
            SqlDS.InsertCommand = "INSERT INTO ToDoItems VALUES(@Description, @DueDate, 'false')";

            SqlDS.InsertParameters.Add("Description", description);
            SqlDS.InsertParameters.Add("DueDate", dueDate.ToString());
            SqlDS.Insert();

            txtDescription.Text = "";
            txtDueDate.Text = "";
        }

    }
}