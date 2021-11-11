## Description

Trevor's Book Store

## Theme

United - [from bootswatch](https://bootswatch.com/united/)

## Task Log

***[Thursday, Nov 4, 2021]***

*11:45AM*

- Created the project
- Made the changes in Startup.cs
- One of the changes caused an error, UseSqlServer, there is a red line underneath and on hovering,
says that it cannot be found, I will try installing the SqlServer package later to see if that fixes the issue
- Created a git repository, linked it to github

*12:15PM*

- Installed the SqlServer Package
- After installing the package, I hovered over the error again and it displayed the same message,
but this time I had the option "Show Potential Fixes". I clicked that and clicked on the first fix
it recommended, "UseSqlServer" instead of "UseSqlServer", the red line is gone

*12:30PM*

- Got my style from bootswatch
- Made all necessary style changes in the project
- Successfully built/ran the project

*12:45PM*

- Linked additional stylesheets and scripts in _Layout.cshtml
- Added the dropdown menu to the nav
- Some of the code got cropped out so it wasnt working properly, but I googled
Dropdown Bootstrap and it had the rest of the properties/values

***[Friday, Nov 5, 2021]***

*12:00pm*

- Added the bootswatch name to the README.md

*12:25pm*

- Added 3 projects

*1:00pm*

- Moved data folder to TrevorsBooks.DataAccess
- Installed Relational and SqlServer in DataAccess
- Deleted the Migrations folder
- Changed namespace to reflect project
- Deleted class files

***[Tuesday, Nov 9, 2021]***

*10:00am*

- Moved Models to TrevorsBooks.Models
- Added project reference
- I realised I was commiting under my personal account, so I changed to my school account
- Renamed Models folder to ViewModels
- Changed ErrorViewModel namespace

*10:30am*

- Resolved all errors that had to do with accessing the classes that were moved
- Built and ran the project successfully
- Area is not appearing in the context menu, I will try updating visual studio

*11:30am*

- Updating did nothing, google searches show that it is not possible to do Add > Areas
- Added new Instructions folder to hold any resources I need to complete the parts to this assignment,
makes transitioning between machines much easier

***[Wednesday, Nov 10, 2021]***

*7:00pm*

- Added Customers and Admin Areas to project
- Moved the Home folder to Areas > Customer > Views > Home
- Copied View cshtml files to proper locations
- Successfully built/ran the project
- Finished Part 1

*7:45pm*

- Started Part 2

*8:00pm*

- Removed app.db, this was created on mac because sqlite was default
- Updated "DefaultConnection" in appsettings.json to match the slides
- Migration Name: 20211111010147_AddDefaultIdentityMigration
- Built the project with no errors
- Updated database, forgot to add Server= to the first part of the
"DefaultConnection" in appsettings.json but once added it ran fine

*8:30pm*

- Created the Category model and migration
- Updated ApplicationDbContext

*9:00pm*

- Created the repo interface and category repo interface
- Implemented them with their own class files
- Successfully built the project

*9:30pm*

- found out I had a typo in the DataAccess namespace where I forgot the s on TrevorsBooks,
went back into all the files and fixed that
- Finished writing ISP_Call.cs 

*10:00pm*

- Finished writing SP_Call.cs
- Finished writing IUnitOfWork.cs

*10:30pm*

- Added UnitOfWork to Startup.cs
- Successfully built project
- Completed part 2