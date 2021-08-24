using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormularPaswort
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                anmeldung.InnerText = "User: " + user.Value + "Password: " + password.Value;
            }
        }

        protected void show_CheckedChanged(object sender, EventArgs e)
        {
            if (show.Checked)
                hint.Text = password.Value;
            else
                hint.Text = "";
        }
    }
}