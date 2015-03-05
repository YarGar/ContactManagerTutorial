# ContactManagerTutorial
Tutorial site found here: http://azure.microsoft.com/en-us/documentation/articles/web-sites-dotnet-deploy-aspnet-mvc-app-membership-oauth-sql-database/

What I learned:
> - Reinforced previous lessons about updating a databases using migrations. I’m feeling a little more comfortable with this 

> - Learned that if there are multiple context classes within the same project, you must specify which context you want to apply the database migration to, otherwise it throws an error. The syntax is like this: 
  1) enable-migrations -ContextTypeName <DbContext-Name-with-Namespaces> -MigrationsDirectory:<Migrations-Directory-Name> 
  2) add-migration -configuration <DbContext-Migrations-Configuration-Class-with-Namespaces> <Migrations-Name> 
  3) Update-Database -configuration <DbContext-Migrations-Configuration-Class-with-Namespaces>

> - How to set up authorization to a website using google. 

> - How to add a global filter to force users to log in before they can access controllers

> - How to add the [AllowAnonymous] annotation to allow anonymous users to view certain controlers or methods after a global filter has been applied

>- How to deploy to an Azure website. There is still a ton more to learn here but it was awesome being able to access my site from the internet.

Things that still confuse me:
> - Spent a lot of time trying to understand how to have the google ClientID and ClientSecret information without improperly exposing that information in my site files. I was not successful and I still don’t understand how to do this.

> - I’d like to be able to use my own domain name for the azure websites, but I’m not yet sure how to do this. 

> - Azure in general can be pretty complex. I still have a lot of learning to do before I feel fully comfortable using this tool.

> - Using google to sign in was a little troublesome. Once I logged in, I could not log out using the site I built. From reading the comments of the tutorial, it seems that a user would have to go to google and log out before the site would log them out. However I tried this and I was still logged into the site.  


Summary:
>This is the second MVC based tutorial I've done. It was nice seeing some processes during the development that were familiar. MVC is starting to make a lot of sense. Overall, authentication is still a little confusing to me, but I’m confident I’ll get it with more practice. On to the next one! 
