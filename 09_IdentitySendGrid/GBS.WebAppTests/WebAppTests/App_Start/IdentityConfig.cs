using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using WebAppTests.Models;

using SendGrid;
using System.Net;
using System.Configuration;
using System.Diagnostics;
using SendGrid.Helpers.Mail;

namespace WebAppTests
{
    public class EmailService : IIdentityMessageService
    {
        public async Task SendAsync(IdentityMessage message)
        {
            // Hier den E-Mail-Dienst einfügen, um eine E-Mail-Nachricht zu senden.
            //return Task.FromResult(0);
            await configSendGridasync(message);
        }
        // Use NuGet to install SendGrid (Basic C# client lib) 
        private async Task configSendGridasync(IdentityMessage message)
        {
            // see: https://app.sendgrid.com/guide/integrate
            var emailFrom = new EmailAddress("timo.kluser@edu.gbssg.ch", "Contoso Noreply");
            var emailTo = new EmailAddress(message.Destination);
            var emailSubject = message.Subject;
            var emailTextPlain = message.Body;
            var emailTextHtml = message.Body;
            var sendGridMessage = MailHelper.CreateSingleEmail(emailFrom, emailTo, emailSubject, emailTextPlain, emailTextHtml);

            // Create a Web transport for sending email.
            var sendGridClient = new SendGridClient(ConfigurationManager.AppSettings["SendGridApiKey"]);

            // Send the email.
            if (sendGridClient != null)
            {
                var response = await sendGridClient.SendEmailAsync(sendGridMessage);
            }
            else
            {
                Trace.TraceError("Failed to create Web transport.");
                await Task.FromResult(0);
            }
        }


    }

    public class SmsService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            // Hier den SMS-Dienst einfügen, um eine Textnachricht zu senden.
            return Task.FromResult(0);
        }
    }

    // Konfigurieren des in dieser Anwendung verwendeten Anwendungsbenutzer-Managers. UserManager wird in ASP.NET Identity definiert und von der Anwendung verwendet.
    public class ApplicationUserManager : UserManager<ApplicationUser>
    {
        public ApplicationUserManager(IUserStore<ApplicationUser> store)
            : base(store)
        {
        }

        public static ApplicationUserManager Create(IdentityFactoryOptions<ApplicationUserManager> options, IOwinContext context)
        {
            var manager = new ApplicationUserManager(new UserStore<ApplicationUser>(context.Get<ApplicationDbContext>()));
            // Konfigurieren der Überprüfungslogik für Benutzernamen.
            manager.UserValidator = new UserValidator<ApplicationUser>(manager)
            {
                AllowOnlyAlphanumericUserNames = false,
                RequireUniqueEmail = true
            };

            // Konfigurieren der Überprüfungslogik für Kennwörter.
            manager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 6,
                RequireNonLetterOrDigit = true,
                RequireDigit = true,
                RequireLowercase = true,
                RequireUppercase = true,
            };

            // Registrieren von Anbietern für zweistufige Authentifizierung. Diese Anwendung verwendet telefonische und E-Mail-Nachrichten zum Empfangen eines Codes zum Überprüfen des Benutzers.
            // Sie können Ihren eigenen Anbieter erstellen und hier einfügen.
            manager.RegisterTwoFactorProvider("Telefoncode", new PhoneNumberTokenProvider<ApplicationUser>
            {
                MessageFormat = "Ihr Sicherheitscode lautet {0}"
            });
            manager.RegisterTwoFactorProvider("E-Mail-Code", new EmailTokenProvider<ApplicationUser>
            {
                Subject = "Sicherheitscode",
                BodyFormat = "Ihr Sicherheitscode lautet {0}"
            });

            // Standardeinstellungen für Benutzersperren konfigurieren
            manager.UserLockoutEnabledByDefault = true;
            manager.DefaultAccountLockoutTimeSpan = TimeSpan.FromMinutes(5);
            manager.MaxFailedAccessAttemptsBeforeLockout = 5;

            manager.EmailService = new EmailService();
            manager.SmsService = new SmsService();
            var dataProtectionProvider = options.DataProtectionProvider;
            if (dataProtectionProvider != null)
            {
                manager.UserTokenProvider = new DataProtectorTokenProvider<ApplicationUser>(dataProtectionProvider.Create("ASP.NET Identity"));
            }
            return manager;
        }
    }

    public class ApplicationSignInManager : SignInManager<ApplicationUser, string>
    {
        public ApplicationSignInManager(ApplicationUserManager userManager, IAuthenticationManager authenticationManager) :
            base(userManager, authenticationManager)
        { }

        public override Task<ClaimsIdentity> CreateUserIdentityAsync(ApplicationUser user)
        {
            return user.GenerateUserIdentityAsync((ApplicationUserManager)UserManager);
        }

        public static ApplicationSignInManager Create(IdentityFactoryOptions<ApplicationSignInManager> options, IOwinContext context)
        {
            return new ApplicationSignInManager(context.GetUserManager<ApplicationUserManager>(), context.Authentication);
        }
    }
}
