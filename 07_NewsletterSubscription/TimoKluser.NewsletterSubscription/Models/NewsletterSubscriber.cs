using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimoKluser.NewsletterSubscription.Models
{
    public class NewsletterSubscriber
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public Interests Interest { get; set; }
        public bool AcceptedTermsOfServices { get; set; }
    }
}