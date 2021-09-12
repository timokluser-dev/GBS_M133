# Sending Mail using SendGrid

1. Create an account  
   :arrow_right: [https://signup.sendgrid.com](https://signup.sendgrid.com)

2. Add a single sender in SendGrid  
   :arrow_right: [https://app.sendgrid.com/settings/sender_auth/senders](https://app.sendgrid.com/settings/sender_auth/senders)

> :warning:: if no sender was registered, the SendGrid API will return `403 Forbidden`.

3. Follow the integration guide  
   :arrow_right: [https://app.sendgrid.com/guide/integrate/langs/csharp](https://app.sendgrid.com/guide/integrate/langs/csharp)

> :information_source:: add implementation into [`IIdentityMessageService.SendAsync(IdentityMessage)`](https://docs.microsoft.com/en-us/previous-versions/aspnet/mt173623(v=vs.108))
