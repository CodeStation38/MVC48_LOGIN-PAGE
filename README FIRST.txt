Previous requirements:

DEFAULT BROWSER, GOOGLE CHROME.
Visual Studio 2022.
SQL Server 19.1
SQL Express 2012 LocalDb
SQL Server Management Studio.
Owin nuget packages.

DANGER, VERY IMPORTANT!!

This application won't write data to the database unless you uninstall 
SQL EXPRESS 2019 LOCALDB and install SQL Express 2012 LocalDb.
I can't do that because I have newer projects currently running on my computer
which need the newer version of SQL EXPRESS LocalDb.

----------------------

WHAT'S THIS APPLICATION ABOUT?

I built this application to analyze the basic LOGIN Mechanisms included in the 
ASP.NET Web Application MVC 4 project template of Visual Studio 2013. 
I've recently upgraded this application so it can run on Visual Studio 2022.

----------------------

HOW TO RUN IT LOCALLY?

DANGER: YOU WON'T BE ABLE TO PROPERLY RUN THIS APPLICATION. 
        YOU'LL GET AN ERROR SCREEN WHEN TRYING TO TEST THE LOGIN PAGE, 
        UNLESS YOU UNINSTALL YOUR CURRENT VERSION OF SQL EXPRESS 2019 LOCALDB AND INSTALL SQL EXPRESS 2012 LOCALDB.
        IN CASE YOU DECIDE TO GO AHEAD AND DO IT BE ADVISED THAT YOUR APPLICATIONS CURRENTLY USING THE SQL EXPRESS 2019 LOCALDB MAY FAIL.

1- Open the Visual Studio solution 
    "\\MVC48_LOGIN PAGE\DEMO LOGIN PAGE MVC\MvcPWy.sln"

2- Run the solution.

3- DANGER: YOU MAY HAVE AN ERROR SCREEN WHEN TRYING TO WRITE DATA TO THE DATABASE.



----------------------

Highlights:


    - This a monolithic 3-tier application. However, since I intended to only
      analyze the Login mechanisms I removed all the functionalities of the 3-Tier architecture and left only the MVC default architecture provided with the Visual Studio ASP.NET MVC template.

    - This application implements Owin Nuget packages.

    - The ASP.NET MVC Template creates a set of default components to give you a 
      headstart for your new MVC Architecture-based Web Application.

    - The UI is written entirely with RAZOR

    - The images contained in the "Screen Captures" folder were taking in 2016 when I  
      had my local environment properly configured to run SQL EXPRESS 2012 LocalDb. I've change my computer several times since that year and my local environment no longer fully supports this application.

      

