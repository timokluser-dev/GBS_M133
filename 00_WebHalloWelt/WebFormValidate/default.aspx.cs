using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormValidate
{
    public partial class _default : System.Web.UI.Page
    {
        protected override void OnInit(System.EventArgs e)
        {
            base.OnInit(e);

            //load Scriptmanager at Applicytion Start (jquery used in ASP-Validator-Controls)
            // https://msdn.microsoft.com/de-de/library/system.web.ui.scriptmanager.scriptresourcemapping(v=vs.110).aspx            
            //
            ScriptResourceDefinition myScriptResDef = new ScriptResourceDefinition();
            myScriptResDef.Path = "~/Scripts/jquery-1.4.2.min.js";
            myScriptResDef.DebugPath = "~/Scripts/jquery-1.4.2.js";
            myScriptResDef.CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.min.js";
            myScriptResDef.CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.js";
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", null, myScriptResDef);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Resultat.InnerText = "...............";
            }
            else
            {
                Resultat.InnerText = "Bitte Formular ausfüllen und abschicken";
            }


        }

        protected void customValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            int value;
            if (int.TryParse(args.Value, out value))
            {
                args.IsValid = value % 2 == 0;
            }
            else
                args.IsValid = false;
        }

        protected void Versand(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                //Do Verarbeitung
                //
                string ausgabe;
                ausgabe  = "<h2>Resultat valid, Verarbeitung erfolgt <br/> </h2>";
                ausgabe += "Ereignis:  " + Ereignis.Text + "<br/>";
                ausgabe += "Monat:     " + Monat.Text + "<br/>";
                ausgabe += "Passwort1: " + Passwort1.Text + "<br/>";
                ausgabe += "Passwort2: " + Passwort2.Text + "<br/>";
                ausgabe += "ArtikelNr: " + ArtikelNr.Text + "<br/>";
                ausgabe += "Lagerfach: " + Lagerfach.Text + "<br/>";
                Resultat.InnerHtml = ausgabe;

                form1.Visible = false;
            }
            else
            {
                Resultat.InnerText = "Resultat invalid, keine Verarbeitung";
            }

        }
    }
}