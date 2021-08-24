using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;
using System.IO;

namespace WebFormCoockies
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Schreiben von drei Cookies
        protected void Cookie_setzen_Click(object sender, EventArgs e)
        {
            //Cookie mit einem Wert
            Response.Cookies["MyCookie"].Value = TBCookie.Text;
            double ablauf;
            if (double.TryParse(TBAblauf.Text, out ablauf))
              Response.Cookies["MyCookie"].Expires = DateTime.Now.AddDays(ablauf);

            //Cookie mit Schlüssel - Wertepaaren
            Response.Cookies["MyCookie2"]["User"] = User.Text;
            Response.Cookies["MyCookie2"]["Passwort"] = Passwort.Text;

            //Cookie mit Klasse
            HttpCookie myCookie = new HttpCookie("MyCookie3");
            myCookie.Values.Add("Vorname", "Tobias");
            myCookie.Values.Add("Name", "Meier");
            myCookie.Values.Add("Id", "100");
            myCookie.Expires = DateTime.Now.AddDays(10.0);
            Response.AppendCookie(myCookie);

            //Cookie mit serialisierter Liste
            List<string> tage = new List<string>();
            tage.Add("Montag");
            tage.Add("Dienstag");
            tage.Add("Mittwoch");
            tage.Add("Donnerstag");
            tage.Add("Freitag");

            XmlSerializer serializer = new XmlSerializer(typeof(List<string>));
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, tage);
            writer.Close();
            String str = writer.ToString();
            str = str.Replace("\r\n", "");
            myCookie = new HttpCookie("MyCookie4");
            myCookie.Value = str;
            myCookie.Expires= DateTime.Now.AddDays(10.0);
            Response.AppendCookie(myCookie);


            //weiterleiten auf nächste Seite, die dann Cooukies liest und anzeigt
            Response.Redirect("cookie_ausgeben.aspx");
        }

    }
}