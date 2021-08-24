using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormSessions
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                //Werte in Session speichern
                Session["Artikel"] = artikelName.Text;
                Session["Anzahl"] = artikelAnzahl.Text;

                //weitere Werte fix in Session aufnehmen
                for (int i = 0; i < 5; i++)
                {
                    string key = "Key_" + i.ToString();
                    string value = "Value_" + i.ToString();
                    Session.Add(key, value);
                }
            }
            else
            {
                //Werte aus Session laden
                if (Session["Artikel"] != null)
                    artikelName.Text = Session["Artikel"].ToString();
                if (Session["Anzahl"] != null)
                    artikelAnzahl.Text = Session["Anzahl"].ToString();
            }
        }

        protected void Session_speichern_Click(object sender, EventArgs e)
        {
            //weiterleiten auf nächste Seite, die Session liest und anzeigt
            Response.Redirect("Session2.aspx");
        }
    }
}