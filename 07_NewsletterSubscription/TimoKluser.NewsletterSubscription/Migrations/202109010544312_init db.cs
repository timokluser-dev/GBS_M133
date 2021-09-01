namespace TimoKluser.NewsletterSubscription.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewsletterSubscribers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Firstname = c.String(),
                        Lastname = c.String(),
                        Email = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        Interest = c.Int(nullable: false),
                        AcceptedTermsOfServices = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NewsletterSubscribers");
        }
    }
}
