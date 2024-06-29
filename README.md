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
![image](https://github.com/eduardoaalmeidaa/Angular-CRUD-Funcionarios/assets/89856553/9c871e1f-8dd0-4278-b037-96775c42a03a)
-
![image](https://github.com/eduardoaalmeidaa/Angular-CRUD-Funcionarios/assets/89856553/c1920c44-082f-4bb7-9ecb-3eb72b3478d6)
-
![image](https://github.com/eduardoaalmeidaa/Angular-CRUD-Funcionarios/assets/89856553/60f7b381-623e-42d3-b7cc-b2a808efc3f4)
-
![image](https://github.com/eduardoaalmeidaa/Angular-CRUD-Funcionarios/assets/89856553/b4a6bbb6-0308-41a0-aee9-33f6860b2a44)
-
![image](https://github.com/eduardoaalmeidaa/Angular-CRUD-Funcionarios/assets/89856553/64c1595e-adbb-4618-a0f8-cf982de32580)
-
