/*
1st query
Change the YourDatabaseName to database's randomly generated name 
(something like 3DDF3709418B7DB2C389C0C95050C47F_O-OBJECT-ORIENTED-PROGRAMMING-SEMESTER-2-ASSIGNMENT\IOOP ASSIGNMENT\MSSQLLOCALDB\DRDATABASE.MDF)
, after adding DRDatabase.mdf to Server Explorer
*/

USE master;
GO
ALTER DATABASE [21B669F01EDD206559E94F9F54B343CE_CT-ORIENTED-PROGRAMMING-SEMESTER-2-ASSIGNMENT-BODHI\IOOP ASSIGNMENT\MSSQLLOCALDB\DRDATABASE.MDF] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
GO
EXEC sp_detach_db '21B669F01EDD206559E94F9F54B343CE_CT-ORIENTED-PROGRAMMING-SEMESTER-2-ASSIGNMENT-BODHI\IOOP ASSIGNMENT\MSSQLLOCALDB\DRDATABASE.MDF';

/*
2nd query
Replace path_to_mdf_file & path_to_ldf_file with the paths, copy the paths by right clicking the file in File Explorer
*/

USE master;
GO
CREATE DATABASE DRDatabase ON 
(FILENAME = 'D:\skool\SEM 2\IOOP\Introduction-To-Object-Oriented-Programming-Semester-2-Assignment-bodhi\IOOP Assignment\MSSQLLocalDB\DRDatabase.mdf'), 
(FILENAME = 'D:\skool\SEM 2\IOOP\Introduction-To-Object-Oriented-Programming-Semester-2-Assignment-bodhi\IOOP Assignment\MSSQLLocalDB\DRDatabase.ldf') 
FOR ATTACH;
