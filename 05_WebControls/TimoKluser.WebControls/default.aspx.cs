using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TimoKluser.WebControls
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // jquery is required in order to use ASP validators
            // => make sure to install using NuGet package `jQuery`
            // see: https://stackoverflow.com/a/37230089
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery",
            new ScriptResourceDefinition
            {
                Path = "~/Scripts/jquery-3.6.0.min.js",
                DebugPath = "~/Scripts/jquery-3.6.0.js"
            });

            if (Page.IsPostBack)
            {
                // check for valid form (form1)
                Page.Validate();
                if (Page.IsValid)
                {
                    Response.Redirect("success.aspx");
                }
            }
            else
            {
                drpCountry.SelectedValue = "switzerland";
            }


        }

        protected void Country_Validator(object source, ServerValidateEventArgs args)
        {
            args.IsValid = drpCountry.SelectedValue != "other";
        }

        protected void AcceptedTerms_Validator(object source, ServerValidateEventArgs args)
        {
            args.IsValid = chkAcceptedTerms.Checked;
        }
    }
}