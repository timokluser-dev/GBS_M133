using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TimoKluser.NewsletterSubscription.Models;

namespace TimoKluser.NewsletterSubscription
{
    public partial class _default : System.Web.UI.Page
    {
        private NewsletterSubscriber subscriber = new NewsletterSubscriber();

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
                Page.Validate();
                if (Page.IsValid)
                {
                    var subscriber = GetModel();
                    Response.Cookies["subscriber_firstname"].Value = subscriber.Firstname;
                    Response.Cookies["subscriber_lastname"].Value = subscriber.Lastname;
                    Session.Add("subscriber", subscriber);

                    Response.Redirect("confirm.aspx");
                }
            }
            else
            {
                if (Session["subscriber"] != null)
                {
                    SetModel();
                }
                else
                {
                    // Get First & Lastname from Cookie if set
                    inpFirstname.Value = (Request.Cookies["subscriber_firstname"] != null) ? Request.Cookies["subscriber_firstname"].Value : "";
                    inpLastname.Value = (Request.Cookies["subscriber_lastname"] != null) ? Request.Cookies["subscriber_lastname"].Value : "";
                }
            }
        }

        protected NewsletterSubscriber GetModel()
        {
            this.subscriber.Firstname = inpFirstname.Value;
            this.subscriber.Lastname = inpLastname.Value;
            this.subscriber.Email = inpEmail.Value;
            this.subscriber.Birthdate = DateTime.Parse(inpBirthdate.Value);
            this.subscriber.Interest = GetInterest();
            this.subscriber.AcceptedTermsOfServices = cbxAcceptedTermsOfService.Checked;

            return this.subscriber;
        }

        protected void SetModel()
        {
            this.subscriber = (NewsletterSubscriber)Session["subscriber"];

            inpFirstname.Value = subscriber.Firstname;
            inpLastname.Value = subscriber.Lastname;
            inpEmail.Value = subscriber.Email;
            inpBirthdate.Value = subscriber.Birthdate.ToString("yyyy-MM-dd");
            cbxAcceptedTermsOfService.Checked = subscriber.AcceptedTermsOfServices;
        }

        protected Interests GetInterest()
        {
            return (Interests)Enum.Parse(typeof(Interests), rdoInterests.SelectedValue, true);
        }

        protected void CustomValidatorBirthdate_ServerValidate(object source, ServerValidateEventArgs args)
        {
            try
            {
                DateTime.Parse(inpBirthdate.Value);

                args.IsValid = true;
            }
            catch (Exception)
            {
                args.IsValid = false;
            }
        }

        protected void CustomValidatorMustAcceptTermsOfService_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = cbxAcceptedTermsOfService.Checked;
        }
    }
}