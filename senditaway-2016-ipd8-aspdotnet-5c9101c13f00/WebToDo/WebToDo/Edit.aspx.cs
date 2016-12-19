using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebToDo
{
    public partial class Edit : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    DataView dvSql = (DataView)SqlDS.Select(DataSourceSelectArguments.Empty);

                    txtDescription.Text = dvSql[0]["description"].ToString();
                    DateTime dueDate;
                    DateTime.TryParse(dvSql[0]["dueDate"].ToString(), out dueDate);
                    txtDueDate.Text = dueDate.ToString("yyyy-MM-dd");


                    bool isDone = Convert.ToBoolean(dvSql[0]["isDone"].ToString());
                    cbIsDone.Checked = isDone;
                }
                catch (NullReferenceException)
                {
                    Response.Write("<script>alert('No todo item id selected');</script>");
                }
            }

        }
        protected void valDateRange_ServerValidate(object source, ServerValidateEventArgs args)
        {
            DateTime minDate = DateTime.Today;
            DateTime selectedDate;

            args.IsValid = (DateTime.TryParse(args.Value, out selectedDate)
                            && selectedDate >= minDate);
        }


        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            string description = txtDescription.Text;

            //Server Side Validation
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

            bool isDone = cbIsDone.Checked;

            SqlDS.UpdateCommand = "UPDATE ToDoItems SET description = @Description, dueDate = @DueDate, isDone = @IsDone WHERE Id = @ID";

            SqlDS.UpdateParameters.Add("Description", description);
            SqlDS.UpdateParameters.Add("DueDate", dueDate.ToString());
            SqlDS.UpdateParameters.Add("IsDone", isDone.ToString());
            SqlDS.UpdateParameters.Add("ID", Request.QueryString["ID"]);


            SqlDS.Update();

            Response.Redirect(Page.ResolveClientUrl("/Default.aspx"));

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtDescription.Text = "";
            txtDueDate.Text = "";
            cbIsDone.Checked = false;
        }
    }
}