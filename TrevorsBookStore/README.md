## Description

Trevor's Book Store

## Theme

United - [from bootswatch](https://bootswatch.com/united/)

## Time

***Time Spent on project***

Total Time Spent: 16 hours

## Task Log

***[Thursday, Nov 4, 2021]***

Start Time: 11:00am

End Time: 1:00pm

Time spent today: 2 hours

Summary:
- Created the project
- Made the changes in Startup.cs
- One of the changes caused an error, UseSqlServer, there is a red line underneath and on hovering,
says that it cannot be found, I will try installing the SqlServer package later to see if that fixes the issue
- Created a git repository, linked it to github
- Installed the SqlServer Package
- After installing the package, I hovered over the error again and it displayed the same message,
but this time I had the option "Show Potential Fixes". I clicked that and clicked on the first fix
it recommended, "UseSqlServer" instead of "UseSqlServer", the red line is gone
- Got my style from bootswatch (united)
- Made all necessary style changes in the project
- Linked additional stylesheets and scripts in _Layout.cshtml
- Added the dropdown menu to the nav
- Some of the code got cropped out so it wasnt working properly, but I googled
Dropdown Bootstrap and it had the rest of the properties/values

_ _ _

***[Friday, Nov 5, 2021]***

Start Time: 12:00pm

End Time: 1:00pm

Time spent today: 1 hour

Summary:
- Added the bootswatch name to the README.md
- Added 3 projects
- Moved data folder to TrevorsBooks.DataAccess
- Installed Relational and SqlServer in DataAccess
- Deleted the Migrations folder
- Changed namespace to reflect project
- Deleted class files

_ _ _

***[Tuesday, Nov 9, 2021]***

Start Time: 10:00am

End Time: 11:30am

Time spent today: 1 hour 30 minutes

Summary:
- Moved Models to TrevorsBooks.Models
- I realised I was commiting under my personal account, so I changed to my school account
- Renamed Models folder to ViewModels
- Changed ErrorViewModel namespace
- Officially switched to working on a Windows computer, no more Mac

_ _ _

***[Wednesday, Nov 10, 2021]***

Start Time: 7:00pm

End Time: 11:00pm

Time spent today: 4 hours

Summary:
- Added Customers and Admin Areas to project
- Moved the Home folder to Areas > Customer > Views > Home
- Copied View cshtml files to proper locations
- Removed app.db, this was created on mac because sqlite was default
- Updated "DefaultConnection" in appsettings.json to match the slides
- Migration Name: 20211111010147_AddDefaultIdentityMigration
- Built the project with no errors
- Updated database, forgot to add Server= to the first part of the
"DefaultConnection" in appsettings.json but once added it ran fine
- Created the Category model and migration, Updated ApplicationDbContext
- Created the repo interface and category repo interface
- Implemented them with their own class files
- found out I had a typo in the DataAccess namespace where I forgot the s on TrevorsBooks,
went back into all the files and fixed that
- Finished writing ISP_Call.cs, SP_Call.cs, IUnitOfWork.cs
- Added UnitOfWork to Startup.cs
- Part 2 completed

_ _ _

***[Thursday, Nov 18, 2021]***

Start Time: 2:45pm

End Time: 5:25pm

Time spent today: ~ 2 hours 30 mins

Summary:
- Added functionality to the create new category button.
- Added functionality to the edit category button. This was giving me an error saying Model.get was returning null, after a long time of debugging I noticed I forgot to pass category into return View()
- Added functionality to the delete button.

_ _ _

***[Saturday, Nov 20, 2021]***

Start Time: 6:00pm

End Time: 7:30pm

Time spent today: ~ 1 hour 30 minutes

Summary:
- Added Cover Type Model
- Added CoverType repository, Migration (20211120232721_AddCoverTypeToDB), and updated the database
- Added CRUD for CoverType
- Added covertype.js instead of category.js (swapped category for covertype in the script)
- Added Product Model
- Added Product Migration (20211121000632_AddProductToDB) and updated the database
- Added Required statements to the requested fields in the Product Model and applied migration (20211121001118_AddValidationToProduct) and then updated the database
- Added Product to the repository

_ _ _

***[Wednesday, Nov 24, 2021]***

Start Time: 5:00pm

End Time: 6:30pm

Time spent today: 1 hour 30 minutes

Summary:
- Added Product Controller/Index View, can now see the product list page but I received an exception (which was noted in the slides)
- Created the Create/View/Update Product page
- Section 3 is done but I am still getting an exception when clicking products in the nav

_ _ _

***[Thursday, Dec 2, 2021]***

Start Time: 1:00pm

End Time: 2:00pm

Time spent today: 1 hour 30 minutes

Summary:
- Fixed the exception in the Product Upsert. The problem was that it was looking for a property named " CoverType", so I had to remove the space in ProductController
- I also had to change the column names of the items that were not displaying in the product.js file
- Also I did all of part 4 in part 3, so all of my commits are there
- took time to edit previous task log entries so they are easier to read and take up less space

_ _ _

***[Thursday, Dec 2, 2021]***

Start Time: 11:00pm

End Time: 11:30pm

Time spent today: 30 minutes

Summary:
- I got the products to display on the home page with no exceptions (I was getting one at school)
- No images were displaying, so I looked into it and found out that I wasnt saving the image url,
once I made those changes, the images are now being saved and deleted properly.