﻿﻿Name: Patricia Bialek
Project: Assignment #1: Luksus (ASP.NET Core MVC NET.3.1)
Date: 2023-10-10 IS0 8601 1012

2023-10-10 1013:
Created my ASP.NET Core MVC project, added a text file README, and created a Git repo. 

2023-10-10 1017:
In Properties > launchSetting.json - comment out sslport, will have to uncomment before I submit the project.
//,
      //"sslPort": 44345

2023-10-10 1020:
Run the project to test if it will run. 
Project ran properly. 

2023-10-10 1024:
Commented out what was left on the home page and added my company name and a button to link to the catalog page.
*Have to figure out the link to the catalog page and add an image. 
Run the project - no issues.

2023-10-10 1031:
Deleted the commented out section in the home page.
Changed the privacy page to the about page.
Changed the Views > Shared > Layout page to replace privacy with about us.
Run project - no issues.
Figure out how to change the url to replace Privacy to AboutUs.

2023-10-10 1101:
All inside the wwwrootfolder > css + images
Created a css file for my About us page styles, and a css reset.
Created an image folder.
Added content to the html page, and added styles to the about us page.
Still need to update the navigation and footer.
Run project - no issues.

2023-10-10 1110:
Editing the footer and almost complete, need to change the color for when you hover and click on the about us link.
Figure out how to update the 2023 to be auto. 

2023-10-10 1147:
Having a hard time removing the default header. 

2023-10-10 1244:
Completed header, footer, content.
Still need to add auto date to footer.
Run project - no issues.

2023-10-10 1252:
Used the (@DateTime.Now.Year) to get the current year without updating manually.
Run project - no issues.

2023-10-10 1353:
Updated the about page.
Completed the home page and added a button link to the catalog (still need to input the link).
Run project - no issues.

2023-10-10 1406:
Now in the URL it says AboutUs when we click on the about us page.
Did this by changing the Privacy.cshtml file to AboutUs.cshtml, changed the Layout privacy attributes to AboutUs,
and in the HomeController.cs page, I changed the Privacy() method name to AboutUs() name.

2023-10-10 1430:
Added a model class named - Perfume.cs
Inside the class I added 7 properties and their validation but commented that out for the time being.
*Need to figure out how to add data validation for integer values.
Run project - no issues.

2023-10-11 1257:
Installed the NuGet package: Microsoft.EntityFrameworkCore.SqlServer(3.0.0).
Created a Data folder and added a file named LuksusContext.cs.
Included the following using statments at the top of the startup.cs : 
using Luksus.Data;
using Microsoft.EntityFrameworkCore;
And updated the Startup.cs config service. 

2023-10-11 1312:
Created a connection string in appsetting.json
Scaffold the perfume pages and a PerfumeController.cs file was created in the Controller folder

2023-10-11 1316:
For initial migration, in the PMC i entered the following commands: 
Add-Migration InitialCreate
Update-Database
A TimeStamp file was created in the Migrations folder.
Run project - Cannont open the index of the DB.

2023-10-11 1346:
Linked the DB to the Home page by changing the Layout file.
Run project - no issues.

2023-10-11 1422:
Created the SeedData file in the Models folder and added perfume data.
Updated the data validation in Perfume.cs file in the Models folder.
Updated the program.cs file to add the seed initializer.
Run the program - seeded data did not show up. 

2023-10-11 1503:
Error: InvalidCastException: Unable to cast object of type 'System.Int32' to type 'System.String'.

2023-10-11 1522:
Looked at the database and it said "volume" was type int when I had put it to string.
Changed the validation and type to int for "volume", and changed the seeddata.
run the program - no issues. 

2023-10-13 1120:
Run the program - no issues. 
Created a button on the home page where users can click and it leads them to the Catalog page.
Beginning the styles for the CRUD pages.

2023-10-13 1202:
Finished the css for the index page.

2023-10-13 1218:
Completed the css for the Create and Edit page.

2023-10-13 1241:
Completed the css for the Details and Delete page.

2023-10-13 1250:
Run the program - no issues.
Uncommented the sslport.
Completed the project.
