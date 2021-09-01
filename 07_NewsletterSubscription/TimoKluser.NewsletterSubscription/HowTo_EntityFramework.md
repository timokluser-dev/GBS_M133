# HowTo `Entity Framework` without .NET Core

## 0. Add some Models

Things to have a look at:
- Create `Models` folder
- Add Id based on `Guid` or `int` to each Model
- For object references:
  - Add Id named `<reference class>Id`
  - Add `virtual` attribute based of the reference class

```csharp
internal class User 
{
  public Guid SupervisorId { get; set; }
  public virtual Supervisor Supervisor { get; set; }
}
```

## 1. Add NuGet Package

```ps
Install-Package EntityFramework -Version 6.4.4
```

:arrow_right: Run in package manager console

## 2. Register ConnectionString

File: **Web.config**

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <!-- ... -->
  <connectionStrings>
    <add name="DefaultConnection" connectionString="Server=localhost,14330;User ID=sa;Password=DEV_1234;Initial Catalog=NewsletterSubs;" providerName="System.Data.SqlClient" />
  </connectionStrings>
  <!-- ... -->
</configuration>
```

Make sure that providerName attribute is set.

## 3. Create Context

```csharp
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TimoKluser.NewsletterSubscription.Models
{
    # class must inherit `DbContext`
    public class NewsletterContext : DbContext
    {
        # create db set for every model
        public DbSet<NewsletterSubscriber> NewsletterSubscribers { get; set; }

        # call base class constructor and pass name attribute of 
        # the connectionString defined in Web.config
        public NewsletterContext() : base("DefaultConnection")
        {

        }
    }
}
```

## 4. Add Migration

```ps
Enable-Migrations

Add-Migration -Name 'Init Db'
```

:arrow_right: Run in package manager console

Run `Add-Migration` every time when Model has changed.

## 5. Update Database

```ps
Update-Database
```

:arrow_right: Run in package manager console

## 6. Use Context

```csharp
  using (NewsletterContext context = new NewsletterContext())
  {
      try
      {
          # add record based on the corresponding db set
          context.NewsletterSubscribers.Add(Subscriber);
          context.SaveChanges();
      }
      catch (Exception)
      {
          # writing to Db failed
      }
  }
```
