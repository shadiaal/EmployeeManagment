# Employee Management System

## Introduction
This is a simple Employee Management System built with ASP.NET Core MVC and Entity Framework. It allows users to perform CRUD operations on employee data.

## Prerequisites
Before running this project, ensure you have the following installed:

- [.NET SDK](https://dotnet.microsoft.com/en-us/download/dotnet)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Git](https://git-scm.com/downloads)
- [Visual Studio](https://visualstudio.microsoft.com/) 

## Setup Instructions
### 1️⃣ Clone the Repository
```sh
git clone https://github.com/shadiaal/EmployeeManagment.git
cd EmployeeManagment
```

### 2️⃣ Configure the Database
1. Open the `appsettings.json` file and update the database connection string if necessary:
   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER;Database=EFProjects;Trusted_Connection=True;MultipleActiveResultSets=true"
   }
   ```
2. Run the following command to apply migrations and create the database:
   ```sh
   dotnet ef database update
   ```

### 3️⃣ Run the Application
```sh
dotnet run
```


## Features
** Add new employees  
** Edit employee details  
** Delete employees  
** View employee list  


