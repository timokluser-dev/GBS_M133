using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TimoKluser.SessionHandling
{
    public partial class WebFormMyCookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SetText();
        }

        protected void btnCreateCookie_Click(object sender, EventArgs e)
        {
            Response.Cookies["MyFirstCookie"].Value = txtCookieValue.Text;
            Response.Cookies["MyFirstCookie"].Expires = DateTime.Now.AddMinutes(1);
            Response.Cookies["MyFirstCookie"].Domain = "localhost";

            SetText();
        }

        protected void SetText()
        {
            if (Request.Cookies["MyFirstCookie"] != null)
            {
                lblStatus.Text = Request.Cookies["MyFirstCookie"].Value;
            }
        }
    }
}