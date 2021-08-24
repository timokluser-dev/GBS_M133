using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;
using System.IO;


namespace WebFormCoockies
{
    public partial class cookie_ausgeben : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Lesen und Anzeigen der Cookies
            //

            if (Request.Cookies["MyCookie"] != null)
            {
                string inhalt = Request.Cookies["MyCookie"].Value;
                string datum = Request.Cookies["MyCookie"].Expires.ToString();
                Ausgabe1.Text = "Das gesetzte Cookie hat den Wert: " + inhalt + "<br />" + "und Ablaufdatum: " + datum;
            }

            if (Request.Cookies["MyCookie2"] != null)
            {
                string user = Request.Cookies["MyCookie2"]["User"];
                string password = Request.Cookies["MyCookie2"]["Passwort"];
                string datum = Request.Cookies["MyCookie2"].Expires.ToString();
                Ausgabe2.Text = "User: " + user + "<br />" + "Passwort: " + password + "<br />" + "und Ablaufdatum: " + datum;
            }

            if (Request.Cookies["MyCookie3"] != null)
            {
                string ausgabe = "";
                HttpCookie c = Request.Cookies["MyCookie3"];
                foreach (string key in c.Values.AllKeys)
                {
                    ausgabe += key + "=" + c.Values[key] + "<br />";
                }
                Ausgabe3.Text = ausgabe;
            }

            // wirft HttpRequestValidationException wegen XML in Cookie
            // https://msdn.microsoft.com/de-de/library/system.web.httprequestvalidationexception(v=vs.110).aspx
            //
            //if (Request.Cookies["MyCookie4"] != null)
            //{
            //    HttpCookie c = Request.Cookies["MyCookie4"];
            //    string str = c.Value;
            //    List<string> tage;
            //    StringReader reader = new StringReader(str);
            //    XmlSerializer serializer = new XmlSerializer(typeof(List<string>));
            //    tage = (List<string>)serializer.Deserialize(reader);
            //    reader.Close();
            //    Ausgabe4.Text = "";
            //    foreach (string s in tage)
            //        Ausgabe4.Text += s;
            //}

        }

    }
}