# BE-challenge
Backend exercise


# Backend Challenge - Using EF to Interact With Data
Solution in .NET Framework 4.7.2 , C# and Entity Framework 6

### Solution

```
This solution includes three projects:

1. SchoolDomain.Classes: The Class library containing the Code-Based Model,

2. SchoolDomain.DataModel: The Class library for creating an Entity Framework Model,

3. The Console Application where the user enters the data requested, to be inserted into the Database.

```

### Validating the EF Model

```
To validate the EF Model based on the Schema of the Classes provided, we can use the Entity Framework Power Tools.


Usage:

Power Tools installation (NuGet alternative):

1. thedatafarm.com/data-access/installing-ef-power-tools-into-vs2015/


Validation:

1. Set up SchoolDomain.DataModel as the Startup Project,

2. Execute the View Entity Data Model command,

3. The SchoolDomainContext.edmx file showing up the Entity–relationship model, is created.

 Relationships:

 - One to Many relationship between School and Course
 - One to Many relationship between Course and Subject
 - One to Many relationship between Subject and Student
 - One to One relationship between Studen and Course
 - One to Many relationship between Student and Subject

```

### Creating the Database

```
To create the Database use EF Code First Migrations from the EF Model.

Usage:

On Package Manager Console hit the following commands:
 PM > enable-migrations 
 PM > add-migration <Initial>
 PM > update-database -script
 PM > update-database -verbose

```


### Starting the Application

```

Set the SchoolDomain Console as the Startup Project and Start (CTRL + F5).

```


### Additional Notes

```


```
