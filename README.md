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

Set the SchoolDomain Console as the Startup Project and Start.

```


### Additional Notes

```


```
