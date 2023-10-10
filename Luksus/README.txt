﻿Name: Patricia Bialek
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
Deleted the commented out section in the hoem page.
Changed the privacy page to the about page.
Changed the Views > Shared > Layout page to replace privacy with about us.
Run project - no issues.
*figure out how to change the url to replace Privacy to AboutUs.

2023-10-10 1101:
All inside the wwwrootfolder > css + images
Created a css file for my About us page styles, and a css reset.
Created an image folder.
Added content to the html page, and added styles to the about us page.
*still need to update the navigation and footer.
Run project - no issues.

2023-10-10 1110:
Editing the footer and almost complete, need to change the color for when you hover and click on the about us link.
*figure out how to update the 2023 to be auto. 

2023-10-10 1147:
Having a hard time removing the default header. 

2023-10-10 1244:
Completed header, footer, content.
*still need to add auto date to footer.
Run project - no issues.

2023-10-10 1252:
Used the (@DateTime.Now.Year) to get the current year without updating.
Run project - no issues.

2023-10-10 1353:
Updated the about page.
Completed the home page and added a button link to the catalog (still need to input the link).
Run project - no issues.

2023-10-10 1406:
Now in the URL it says AboutUs when we click on the about us page.
Did this by changing the Privacy.cshtml file to AboutUs.cshtml, changed the Layout privacy attributes to AboutUs,
and in the HomeController.cs page, I changed the Privacy() method name to AboutUs() name.