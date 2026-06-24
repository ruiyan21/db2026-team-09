# db2026-team-09
# University Management System - Team 09

## Team Members
| Name | Student ID |
|---|---|
| 步怡欣 | 25101319 |
| 徐蕾莎 | 25101325 |
| 林芮妍 | 25101332 |
| 沈天君 | 25101337 |

## Features
- **Student Management**: Add, update, and delete student records.
- **Course Management**: Manage course offerings, descriptions, and prerequisites.
- **Enrollment System**: Facilitate student enrollment in courses.
- **Grade Management**: Record and manage student grades for various courses.
- **Reporting**: Generate reports on student performance and course enrollment.

## Tech Stack
- Language: C# / .NET Framework
- Database: MS-SQL Server
- IDE: Visual Studio 2022

## System Architecture
The system follows a multi-tiered architecture, separating concerns into presentation, business logic, and data access layers. The front-end is built using C# with .NET Framework, interacting with a SQL Server database for data persistence. Visual Studio 2022 is used as the integrated development environment.

## Prerequisites
Before running the application, ensure you have the following installed:
- **.NET Framework**: Version 4.7.2 or higher.
- **SQL Server**: A running instance of MS-SQL Server (e.g., SQL Server 2019 or later).
- **Visual Studio 2022**: With the necessary workloads for .NET desktop development and data storage and processing.

## How to Run
1. Restore NuGet packages: Open the solution in Visual Studio and allow it to restore any missing NuGet packages.
2. Update connection string in `appsettings.json`: Modify the database connection string to point to your local or remote SQL Server instance.
3. Run `database/schema.sql` on your SQL Server: Execute the provided SQL script to create the necessary database schema and tables.
4. Press F5 in Visual Studio: Start the application in debug mode from Visual Studio.
