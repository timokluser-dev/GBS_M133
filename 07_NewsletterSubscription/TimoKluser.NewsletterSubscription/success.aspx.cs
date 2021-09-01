using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TimoKluser.NewsletterSubscription.Models;

namespace TimoKluser.NewsletterSubscription
{
    public partial class success : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Remove("subscriber");
        }
    }
}