using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TimoKluser.ASPXWebToday
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var formatedDate = DateTime.Now.ToString("dddd dd.MM.yyyy HH:mm:ss", new CultureInfo("en-US"));
            lblToday.InnerText = $"Today: {formatedDate}";
        }
    }
}