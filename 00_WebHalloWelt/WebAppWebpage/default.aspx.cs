using System;

namespace WebAppWebpage
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                // bei Submit ausgeführt
                double z = double.Parse(zahl1.Value);
                ergebnis.InnerHtml = "Die Eingabe ist: " + z.ToString();
            }
            else
            {
                // bei Seitenanforderung ausgeführt
                ergebnis.InnerHtml = "Hier kommt das Ergebnis";

            }
        }
    }
}