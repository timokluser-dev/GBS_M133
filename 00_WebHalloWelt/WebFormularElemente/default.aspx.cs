using System;
using System.Web.UI.WebControls;

namespace WebFormularElemente
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                ausgabe.Text = "Wir bieten ein Hotel in " + "<b>" + ziel.Value + "</b>";
                if (allinc.Checked)
                {
                    ausgabe.Text += "<br />all Inclusive";
                }
                if (bett2.Checked)
                {
                    ausgabe.Text += "<br />mit 2 Betten";
                }
                else
                {
                    ausgabe.Text += "<br />mit 3 Betten";
                }
                ausgabe.Font.Italic = false;
            }
            else
            {
                ziel.Items.Clear();
                ziel.Items.Add(new ListItem("Russland", "Moskau"));
                ziel.Items.Add(new ListItem("Schweiz", "Genf"));
                ziel.Items.Add(new ListItem("Frankreich", "Grenoble"));
                ziel.Items.Add(new ListItem("Österreich", "Graz"));
                ziel.Items.Add(new ListItem("Spanien", "Barcelona"));
                ziel.SelectedIndex = 1;
                ausgabe.Text = "Bitte wählen Sie Ihr Hotel";
                ausgabe.Font.Italic = true;
            }
        }
    }
}