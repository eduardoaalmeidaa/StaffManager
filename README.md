# Employee Management System
## Introduction
### This is a simple CRUD (Create, Read, Update, Delete) application to manage employee data. It allows users to create, update, delete, activate, inactivate employees, and change their shift.

## Technologies Used
### Frontend:
- Angular
- TypeScript
- HTML
- CSS

### Backend:
- C# .NET Core 6.0
- Entity Framework Core
- SQL Server

### Features
- Add new employees
- Edit employee details
- Delete employees
- Activate/Inactivate employees
- Change employee shift

### Getting Started
### Prerequisites
- Node.js
- Angular CLI
- .NET Core SDK
- SQL Server

## Installation
### Backend
### 1. Clone the repository:
`` https://github.com/eduardoaalmeidaa/Angular-CRUD-Funcionarios.git
``
### 2. Restore the .NET dependencies:
``
cd FuncionariosCRUD_Angular.NET\backend\WebAPI_Funcionario\WebAPI_Funcionario --
dotnet restore
``

### 3. Update the database connection string in appsettings.json:
``
"DefaultConnection": "Data Source=your_data_source_name\\SQLEXPRESS;Database=Funcionario;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False"
``

### 4. Apply the migrations to create the database:
``
dotnet ef database update
``

### 5. Run the backend server:
``
dotnet run
``

### Frontend
### 1. Navigate to the frontend directory:
``
cd ../frontend
``

### 2. Install the npm packages:
``
npm install
``

### 3. Update the API URL in environment.ts:
``
export const environment = {
  production: false,
  apiUrl: 'http://localhost:7016/api'
};
``

### 4. Run the Angular development server:
``
ng serve
``

### 5. Open your browser and navigate to http://localhost:4200.
## Usage
### 1. Add Employee: Fill out the form and click the "Register new employee" button.
### 2. Edit Employee: Click the "Edit" button next to the employee you want to edit, update the details, and save.
### 3. Delete Employee: Click the "Delete" button next to the employee you want to remove.
### 4. Activate/Inactivate Employee: Toggle the "Active" status of an employee.
### 5. Change Shift: Update the shift details of an employee.

## Contributing
### 1. Fork the repository.
### 2. Create a new branch.
### 3. Make your changes and commit them.
### 4. Push to your branch.
### 5. Create a new Pull Request.

# WEB version images
![image](https://github.com/eduardoaalmeidaa/Angular-CRUD-Funcionarios/assets/89856553/84290cb7-6d1f-46b3-8334-23d962f0f25f)
-
![image](https://github.com/eduardoaalmeidaa/Angular-CRUD-Funcionarios/assets/89856553/76c7f0b4-27c4-4f47-bd52-8801b58c4a59)
-
![image](https://github.com/eduardoaalmeidaa/Angular-CRUD-Funcionarios/assets/89856553/cd49eea0-ecfa-47e9-8e21-8a9a3aba4a2e)
-
![image](https://github.com/eduardoaalmeidaa/Angular-CRUD-Funcionarios/assets/89856553/3e0d5f08-abc0-47f3-bffa-17b3a8ee7318)
-
![image](https://github.com/eduardoaalmeidaa/Angular-CRUD-Funcionarios/assets/89856553/ace93380-5c4f-4025-8c47-684bba0e12ae)
-
