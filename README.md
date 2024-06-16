# Restaurant Management System (C# Windows Forms program)

This project is C#-based restaurant management system developed as part of the CT044-3-1-IOOP (Introduction to Object-Oriented Programming) group assignment for the Asia Pacific University (APU) in 2024.

## How to run the program
Using Visual Studio, open the solution `IOOP Assignment.sln` and you can either Run the solution with (F5) or without debugging (Ctrl + F5).

## Project description
The restaurant management system aims to provide functionalities for different types of users within the system, including administrator, mamager, chef, and customer. Each user role has specific tasks and features they can perform within the system.

## User Roles and Functionalities
### Administrator
- Manage users - Manager, Chef, Customer (Add, Edit, Delete)
- View sales report based on month, category, chef etc.
- View feedback sent by customers.
- Update own profile.
### Manager
- Manage menu categories and pricing (Add, Edit, Delete)
- Manage reservations for customer (Add, Edit, Delete)
- View reservation report based on month, customer, reservation type etc.
- Update own profile
### Tutor
- View orders placed by customers.
- Update orders as "In Progress" or "Completed.”
- Manage inventory of ingredients (Add, Edit, Delete, Search).
- Update own profile.
### Student
- Search food menu (filter based).
- Order food (Add, Edit, Delete) and pay to confirm.
- View order & reservation status.
- Send feedback(menu/reservation) to administrator.
- Update own profile.

## Neccessary pre-requisites before running the program
### Database configuration
1. On Server Explorer, click “Connect to new database”
2. Insert the path to the `DRDatabase.mdf` (at `Restaurant-Management-System/IOOP Assignment/MSSQLLocalDB`) on "Database File". Test connection first to ensure “Test Connection Succeeded” followed by proceeding to click OK.
3. Open SQL Server Object Explorer, then the `(localdb)\MSSQLLocalDB` local server, `Databases` folder. You’ll see a database with randomized name like “3DDF3709418B7DB2C389C0C95050C47F_O-OBJECT-ORIENTED-PROGRAMMING-SEMESTER-2-ASSIGNMENT\IOOP ASSIGNMENT\MSSQLLOCALDB\DRDATABASE.MDF" (for example). Right-click on that database, and click on properties. From properties copy the database name (Double click, Ctrl + A, Ctrl + C) as it will be used later on.
4. On `Restaurant-Management-System/IOOP Assignment/MSSQLLocalDB` there is an SQL file called `DatabaseAttachmentConfiguration.sql` in which you could replace the parts that should be replaced with your information (read the query’s comments).
5. Highlight the first query and press run (Ctrl + R), then do the same thing with the second query. `DRDatabase` should be created on `(localdb)\MSSQLLocalDB` server by then. Making all the scripts (.cs) that use connectionString relating to DRDatabase capable of accessing it for CRUD (Create-Read-Update-Delete) purposes.
   
### Packages that might be not installed 
For packages that are missing in your system or you could say are unrecognized by the client Visual Studio, for example `Microsoft.Identity.Client`. Perform the following:

Using Visual Studio:
1. Open the Solution Explorer.
2. Right-click on a project within the solution.
3. Click on Manage NuGet Packages...
4. Click on the Browse tab and search for `Microsoft.Identity.Client`
5. Click on the `Microsoft.Identity.Client` package and click Install.
