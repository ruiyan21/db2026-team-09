**UMS 2026 - University Management System: Architecture Document**

**1. Introduction**

This document outlines the architectural design of UMS 2026, a desktop-based University Management System. Developed using C# Windows Forms, the application aims to provide a robust and intuitive platform for university administrators to manage various aspects of academic operations, including student, instructor, course, and scheduling management, along with reporting and analytics capabilities.

**2. Overall Architecture: Three-Tier Design**

UMS 2026 adheres to a classic **three-tier architectural pattern**, which promotes a clear separation of concerns, enhances maintainability, and facilitates scalability. This layered approach ensures that changes in one tier have minimal impact on others, simplifying development and future enhancements.

|**Layer**|**Primary Technologies**|**Responsibilities**|
| :- | :- | :- |
|**Presentation Layer**|C# Windows Forms, MaterialSkin UI|User interface rendering, user input handling, display of information.|
|**Business Logic Layer**|C# Classes (.cs files)|Implements core business rules, data validation, and orchestrates operations between the presentation and data access layers.|
|**Data Access Layer**|Entity Framework, SQL Server|Manages connections to the database, performs CRUD (Create, Read, Update, Delete) operations, and maps database entities to C# objects.|

**3. Technology Stack**

The system is built upon the following core technologies:

- **Programming Language**: C#
- **Framework**: .NET Framework 4.7.2
- **User Interface**: Windows Forms (WinForms)
- **UI Library**: MaterialSkin (for modern visual styling)
- **Database**: SQL Server (specifically .\sqlexpress for local development)
- **Object-Relational Mapping (ORM)**: Entity Framework (utilizing UniversityModel.edmx for database-first approach)

**4. Database Design and Entity Model**

The UMS 2026 database is structured around a set of interconnected entities, designed to represent the fundamental components of a university. Entity Framework is used to map these database tables to C# classes, providing a strongly-typed object model for data interaction.

**Core Entities:**

- **Student**: Manages student records, including ID, name, department, and total credits. (e.g., student.cs)
- **Instructor**: Stores instructor details such as ID, name, department, and salary. (e.g., instructor.cs)
- **Department**: Defines university departments with names, building locations, and budgets. (e.g., department.cs)
- **Course**: Contains course information like course ID, title, department, and credits. (e.g., course.cs)
- **Section**: Represents specific offerings of courses, including semester, year, room, and time slot. (e.g., section.cs)
- **Take (Enrollment)**: Links students to sections they are enrolled in, tracking grades. (e.g., take.cs)
- **Classroom**: Manages classroom details such as building, room number, and capacity. (e.g., classroom.cs)
- **Time Slot**: Defines available time blocks for scheduling sections, including day and start/end times. (e.g., time\_slot.cs)
- **User**: Handles user authentication with ID, username, password, and role for access control. (e.g., user.cs)

Relationships between these entities are defined within the Entity Data Model, enabling complex data queries and operations.

**5. User Interface (UI) Design Principles**

The UI of UMS 2026 is designed for a modern enterprise aesthetic, ensuring consistency and usability across all forms. Key design principles are documented in DESIGN\_NOTES.md and include:

- **Modern Enterprise Theme**: A clean, professional look suitable for administrative tasks.
- **Color Palette**: A semantic color scheme is employed, using specific colors for different actions and elements (e.g., Primary Blue for headers, Success Green for 'ADD', Danger Red for 'DELETE').
  - Primary Blue: RGB(30, 58, 95)
  - Secondary Blue: RGB(59, 130, 246)
  - Success Green: RGB(34, 197, 94)
  - Warning Orange: RGB(217, 119, 6)
  - Danger Red: RGB(239, 68, 68)
  - Purple: RGB(168, 85, 247)
- **Typography**: Consistent use of 'Segoe UI' font family for readability, with defined sizes for headers, labels, body text, and buttons.
- **Layout Consistency**: Standardized layouts for data management forms (Header Panel, Action Button Bar, Input Fields, DataGridView) to reduce user learning curve.
- **Interactive Elements**: Implementation of hover effects on buttons and hand cursors for improved user feedback.

**6. Application Modules**

The application is modularized into several functional areas, accessible via the Admin Dashboard:

- **Login (Form1)**: Secure user authentication.
- **Admin Dashboard (AdminForm)**: Central navigation hub with 2x4 grid of module buttons.
- **Data Management Forms**: Dedicated forms for Students, Instructors, Departments, Courses, Enrollment, and Scheduling, all following a consistent CRUD pattern.
- **Report & Analysis (Report\_Analysis)**: Provides tabular data and dynamic chart visualizations (e.g., Students by Department pie chart).

