# Kentico MVC Widget Showcase

## OVERVIEW
This project details creating a sample MVC site using Kentico 12, as documented in the article series below. This site will be continually updated with new functionality as new articles are published. Each branch of the repository corresponds to the matching article. 

## ASSOCIATED ARTICLE
This branch aligns with the following article: 

https://www.kentico.com/blog/creating-an-mvc-widget-showcase-site-with-kentico-ems-and-mvc-custom-widgets-and-inline-editors

Topics covered include:
- Adding DI
- Adding View Models
- Adding Caching
- Adding Repositories

**Admin Site - Part 4**

![Admin Site - Part 4](https://www.kentico.com/getattachment/Blog/2019-02/Creating-an-MVC-Widget-Showcase-Site-with-Kent-(1)/Testing2.png?lang=en-US&width=700&height=468)

**MVC Site - Part 4**

![MVC Site - Part 4](https://www.kentico.com/getattachment/Blog/2019-02/Creating-an-MVC-Widget-Showcase-Site-with-Kent-(1)/SiteDemo.gif?lang=en-US)


## PROJECT DETAILS

**Kentico Version**: 12.0.12

**Username/Password**: administrator/[BLANK PASSWORD]

## SETUP
### CMS App
1. Download/clone the repository to you local machine and unzip (if needed)

2. Open the **[PROJECTFOLDER]\WebApp.sln** in Visual Studio

3. Update Web settings (IIS) (OPTIONAL)

4. Clear the ConnectionStrings

   **EXAMPLE**
   ```
   <connectionStrings>
   </connectionStrings>
   ```
   
5. Build the project and run the site

   *If you recieve a Roslyn.exe related error, close VS, open project again, clean, and rebuild.*
   
6. On the setup page, create the database

7. Once the database is created, add your license for your development environment

8. Click the **Create a new or import an existing Kentico site** to bypass automatic site creation

9. Once the site is installed, confirm you are directed to the Applicaiton Dashboard

10. Open a Command Prompt in the **[ProjectName]/bin** folder and run **ci.exe**

    **MORE INFO**

    https://docs.kentico.com/k12/developing-websites/setting-up-continuous-integration/restoring-continuous-integration-files-to-the-database

11. Once **ci.exe** is complete, refresh the Application Dashboard to confirm the objects were properly restored 

12. In the **Sites** application, update the **Presentation URL / Domain** with your local path

13. Start the  site in the **Sites** module


### MVC App
1. Open the **[PROJECTFOLDER]\KenticoMVCWidgetShowcase.sln** in Visual Studio

2. Update Web settings (IIS) (OPTIONAL)

3. Update the ConnectionString

   *Use the CMSConnectionString value from the CMSApp.sln solution's web.config file.*

4. Build the site and run 
