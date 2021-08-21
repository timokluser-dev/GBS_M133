using System;

namespace TimoKluser.ASPXWeb
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                // bei Submit ausgeführt
                try
                {
                    double z = double.Parse(zahl1.Value);
                    ergebnis.InnerHtml = $"Die Eingabe ist: {z}";
                    ergebnis.Style.Remove("color");
                }
                catch (Exception)
                {
                    ergebnis.InnerHtml = $"No valid input";
                    ergebnis.Style.Add("color", "#ff0000");
                }
            }
            else
            {
                // bei Seitenanforderung ausgeführt
                ergebnis.InnerHtml = "Hier kommt das Ergebnis";
            }

        }
    }
}