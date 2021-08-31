using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormSessions
{
    public partial class Session2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Werte aus Session laden
            if (Session["Artikel"] != null)
                artikel.Text = Session["Artikel"].ToString();
            if (Session["Anzahl"] != null)
                anzahl.Text  = Session["Anzahl"].ToString();

            //alle Session Key - Value - Paare anzeigen
            foreach (string key in Session.Contents)
            {
                liste.Text += key + ": " + Session[key] + "<br />";
            }
        }

        protected void btnSessionQuit_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("default.aspx");
        }
    }
}