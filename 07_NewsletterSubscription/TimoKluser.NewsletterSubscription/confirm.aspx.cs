using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TimoKluser.NewsletterSubscription.Models;

namespace TimoKluser.NewsletterSubscription
{
    public partial class confirm : System.Web.UI.Page
    {
        NewsletterSubscriber Subscriber;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Subscriber = (NewsletterSubscriber)Session["subscriber"];
                if (Subscriber != null)
                {
                    pConfirmText.InnerText = $"{Subscriber.Firstname}, please confirm your newsletter subscription";
                    liNewsletter.InnerText = Subscriber.Interest.ToString();
                }
                else
                {
                    Response.Redirect("default.aspx");
                }
            }
            catch (Exception)
            {
                Response.Redirect("default.aspx");
            }
        }

        protected void btnConfirmSubscription_Click(object sender, EventArgs e)
        {
            using (NewsletterContext context = new NewsletterContext())
            {
                try
                {
                    context.NewsletterSubscribers.Add(Subscriber);
                    context.SaveChanges();

                    Response.Redirect("success.aspx");
                }
                catch (Exception)
                {
                    pConfirmText.InnerText = "Oops, an error occured. Please try again later.";
                }
            }
        }

        protected void btnGoBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}