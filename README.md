# Kentico MVC Widget Showcase

## OVERVIEW
This project details creating a sample MVC site using Kentico 12, as documented in the article series below. This site will be continually updated with new functionality as new articles are published. Each branch of the repository corresponds to the matching article. 

## ASSOCIATED ARTICLE
This branch aligns with the following article: 

https://www.kentico.com/blog/creating-an-mvc-widget-showcase-site-with-kentico-ems-and-mvc-adding-a-design-and-the-page-builder

Topics covered include:
- Applying a design to the site
- Adding Script Bundling
- Adding Page Builder support

**Admin Site - Part 2**

![Admin Site - Part 2](https://www.kentico.com/getattachment/532d88d5-3719-45b1-ae56-8711ad44f2b0/Demo4.png?lang=en-US&width=700&height=478)

**MVC Site - Part 1**

![MVC Site - Part 2](https://www.kentico.com/getattachment/2ebad391-3495-40fe-b4ef-32698d590b40/Demo1.png?lang=en-US&width=700&height=477)

## PROJECT DETAILS

**Kentico Version**

12.0.5

**Username/Password**

administrator/[BLANK PASSWORD]

**Prerequisites**
- Visual Sutdio 2017
- Access to SQL server

**Continuos Integration**

This project has Continuos Integration enabled. You will use the **ContinuousIntegration.exe** utility to restore data to your local database.

**Connection String**

The original project's Connection Strings have been encrypted. You will need to remove this section to set the project up locally.

  https://www.codeproject.com/Tips/795135/%2fTips%2f795135%2fEncrypt-ConnectionString-in-Web-Config

## SETUP
### CMS App
1. Download/clone the repository to you local machine and unzip (if needed).

2. Open the **[ProjectName]/WebApp.sln** in Visual Studio.

3. Update Web settings (IIS) to your preferred path. The article uses http://localhost/KenticoMVCWidgetShowcaseAdmin as the URL.

4. Clear the ConnectionStrings. (The new connection string will be set during the DB setup process.)

   **EXAMPLE**
   ```
   <connectionStrings>
   </connectionStrings>
   ```
   
5. Build the project and run the site. This will launch the database installtion utlity.

   *If you recieve a Roslyn.exe related error, close VS, open project again, clean, and rebuild.*

6. On **Step 1**, enter your SQL Server connection infomration and credentials.
7. On **Step 2**, enter your database name.
8. On **Step 3**, confirm the database was successfully created.
9. On **Step 4**, add your license for your development environment.
10. On **Step 5**, select **Create a new site or import an existing Kentico site** to bypass automatic site creation.
11. Once the process is complete, you should be directed to the **Sites** module. 
12. Click on the **Home** icon to exit to the **Application Dashboard**.
13. Open a Command Prompt in the **[ProjectName]/CMS/bin** folder and run **ContinuousIntegration.exe -r**.

    **MORE INFO**

    https://docs.kentico.com/k12/developing-websites/setting-up-continuous-integration/restoring-continuous-integration-files-to-the-database

    *If you receive an error about loading an assembly from a network location, you may need to modify the **[ProjectName]CMS/bin/ContinuousIntegration.exe.config** file to allow remote sources.*

    ```
    <runtime>
        <loadFromRemoteSources enabled="true"/>
	...
    </runtime>
    ````

    *See the following URL for details.*

    https://docs.microsoft.com/en-us/previous-versions/dotnet/netframework-4.0/dd409252(v=vs.100) 

14. Once **ContinuousIntegration.exe** is complete, refresh the Admin site to confirm the objects were properly restored. In the **Sites** application, confirm the **KenticoMVCWidgetShowcase** site is listed.

15. In the **Sites** application, select the **KenticoMVCWidgetShowcase** site and update the **Presentation URL** with your local path you will use for the MVC site.

    **NOTE**

    This value will be the same url as your MVC site.

16. Start the  site in the **Sites** application.


### MVC App
1. Open the **[PROJECTFOLDER]\KenticoMVCWidgetShowcase.sln** in Visual Studio.

2. Update Web settings (IIS) to your preferred path. The article uses http://localhost/KenticoMVCWidgetShowcase as the URL.

**NOTE**
This value will be the same url as your **Presentation URL** in your Admin site. 

3. Update the ConnectionString.

   *Use the CMSConnectionString value from the CMSApp.sln solution's web.config file.*

4. Build the site and run.

