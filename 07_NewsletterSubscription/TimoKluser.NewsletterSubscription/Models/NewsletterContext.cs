using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TimoKluser.NewsletterSubscription.Models
{
    public class NewsletterContext : DbContext
    {
        public DbSet<NewsletterSubscriber> NewsletterSubscribers { get; set; }

        public NewsletterContext() : base("DefaultConnection")
        {

        }
    }
}