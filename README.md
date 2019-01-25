# KenticoMVCWidgetShowcase

## OVERVIEW
This project details creating a sample MVC site using Kentico 12, as documented in the article series below. This site will be continually updated with new functionality as new articles are published. Each branch of the repository corresponds to the matching article. 

## PROJECT DETAILS

**Kentico Version**

12.0.5

**Username/Password**

administrator/[BLANK PASSWORD]

**Continuos Integration**

This project has Continuos Integration enbaled. You will use the **ContinuousIntegration.exe** utility to restore data to your local database. The process to set up the site will be:

   1. Unzip repo to local machine
   2. Configure / Build / Launch the Admin site
   3. Create database using the web utility (autmatic when the connection string is cleared)
   4. Execute the ContinuousIntegration.exe command to restore objects

**Connection String**

The original project's Connection Strings have been encrypted. You will need to remove this section to set the project up locally.

  **MORE INFO**

  https://www.codeproject.com/Tips/795135/%2fTips%2f795135%2fEncrypt-ConnectionString-in-Web-Config

## SETUP
### CMS App
1. Download/clone the repository to you local machine and unzip (if needed).

2. Open the **[PROJECTFOLDER]\WebApp.sln** in Visual Studio.

3. Update Web settings (IIS) (OPTIONAL).

4. Clear the ConnectionStrings.

   **EXAMPLE**
   ```
   <connectionStrings>
   </connectionStrings>
   ```
   
5. Build the project and run the site.

   *If you recieve a Roslyn.exe related error, close VS, open project again, clean, and rebuild.*
   
6. On the setup page, create the database.

7. Once the database is created, add your license for your development environment.

8. Click the **Create a new site or import an existing Kentico site** to bypass automatic site creation.

9. Once the site is installed, confirm the site is running. You should be directed to the **Sites** module. 
10. Open a Command Prompt in the **[ProjectName]/bin** folder and run **ContinuousIntegration.exe -r**.

    **MORE INFO**

    https://docs.kentico.com/k12/developing-websites/setting-up-continuous-integration/restoring-continuous-integration-files-to-the-database

    *If you receive an error about loading an assembly from a network location, you may need to modify the **bin/COntinuousIntegration.exe.config** file to allow remote sources.*

    ```
    <runtime>
        <loadFromRemoteSources enabled="true"/>
	...
    </runtime>
    ````

    *See the following URL for details.*

    https://docs.microsoft.com/en-us/previous-versions/dotnet/netframework-4.0/dd409252(v=vs.100) 

11. Once **ContinuousIntegration.exe** is complete, refresh the Admin site to confirm the objects were properly restored. In the **Sites** module, confirm the **KenticoMVCWidgetShowcase** site is listed.

12. In the **Sites** application, select the **KenticoMVCWidgetShowcase** site and update the **Presentation URL / Domain** with your local path.

13. Start the  site in the **Sites** module.


### MVC App
1. Open the **[PROJECTFOLDER]\KenticoMVCWidgetShowcase.sln** in Visual Studio.

2. Update Web settings (IIS) (OPTIONAL)
.
3. Update the ConnectionString.

   *Use the CMSConnectionString value from the CMSApp.sln solution's web.config file.*

4. Build the site and run.
