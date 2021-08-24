using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// http://www.aspsnippets.com/Articles/Simple-User-Login-Form-example-in-ASPNet.aspx 

namespace WebFormLogin
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                user.InnerHtml = Login1.UserName;
                password.InnerHtml = Login1.Password;
            }
        }
    }
}