**UMS 2026 - University Management System: User Guide**

**1. Introduction**

Welcome to the UMS 2026 User Guide. This document provides a comprehensive overview of the University Management System (UMS 2026), a desktop application designed to assist university administrators in managing various academic and administrative tasks efficiently. UMS 2026 offers modules for student, instructor, department, course, enrollment, and scheduling management, along with powerful reporting and analysis tools.

**2. System Requirements**

To ensure optimal performance and compatibility, please ensure your system meets the following requirements:

- **Operating System**: Windows 7 or higher (64-bit recommended)
- **.NET Framework**: Version 4.7.2 or later
- **Database**: SQL Server (SQL Server Express is sufficient for single-user or small-scale deployments)
- **Processor**: Dual-core processor or higher
- **RAM**: 4 GB or more
- **Storage**: 500 MB free disk space

**3. Installation Guide**

Follow these steps to install and set up UMS 2026:

1. **Database Setup**: Ensure SQL Server is installed and running. Attach the University.mdf database file (if provided) to your SQL Server instance, or create a new database and run the provided SQL scripts to set up the schema.
1. **Application Deployment**: Copy the UMS2026.exe and associated files (e.g., UMS2026.exe.config, EntityFramework.dll) to a desired directory on your local machine.
1. **Configuration**: Open UMS2026.exe.config in a text editor and verify the database connection string. Update the Data Source and Initial Catalog if your SQL Server instance or database name differs.

<connectionStrings>

`    `<add name="UniversityEntities" connectionString="metadata=res://\*/UniversityModel.csdl|res://\*/UniversityModel.ssdl|res://\*/UniversityModel.msl;provider=System.Data.SqlClient;provider connection string=&quot;Data Source=.\sqlexpress;Initial Catalog=University;Integrated Security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />

</connectionStrings>

1. **Run Application**: Double-click UMS2026.exe to launch the application.

**4. Getting Started: Login**

Upon launching UMS 2026, you will be presented with the Login screen.

1. **Enter Credentials**: Input your Username and Password. These credentials are validated against the User table in the database.
1. **Login**: Click the LOGIN button. If successful, you will be redirected to the Admin Dashboard. If login fails, an error message will be displayed.

**5. Admin Dashboard Overview**

The Admin Dashboard is the central navigation hub, providing access to all functional modules. It features a 2x4 grid of color-coded buttons:

- **Student**: Manage student records.
- **Instructors**: Manage instructor profiles.
- **Department**: Manage department information.
- **Course**: Manage course details.
- **Enrollment**: Handle student course enrollments.
- **Scheduling**: Manage time slots and class schedules.
- **Report & Analysis**: Generate various reports and analytics.
- **Logout**: Exit the Admin Dashboard and return to the Login screen.

**6. Module-Specific Guides**

All data management forms (Student, Instructor, Department, Course, Enrollment, Scheduling) follow a consistent layout:

- **Header Panel**: Displays the form title.
- **Action Button Bar**: Contains LOAD, ADD, UPDATE, DELETE, and BACK buttons.
- **Input Fields**: For entering or modifying data.
- **DataGridView**: Displays existing records in a tabular format.

**6.1. Student Management**

- **Purpose**: To manage student personal and academic records.
- **Actions**:
  - LOAD: Retrieve all student records.
  - ADD: Create a new student record.
  - UPDATE: Modify an existing student record.
  - DELETE: Remove a student record.
  - BACK: Return to the Admin Dashboard.
- **Usage**: Select a row in the DataGridView to populate input fields for updating or deleting. Enter new data in fields for adding.

**6.2. Scheduling Module (Advanced Feature)**

- **Purpose**: To manage time slots for courses and detect scheduling conflicts.
- **Conflict Detection**: After entering time\_slot\_id, day, start\_hr, start\_min, end\_hr, and end\_min, click the CHECK button to identify any overlapping time slots on the same day. Conflicts will be displayed in a message box.
- **Actions**: Standard CRUD operations (LOAD, ADD, UPDATE, DELETE), plus CHECK for conflicts and REFRESH to reload time slots.

**6.3. Report & Analysis Module**

- **Purpose**: To generate visual and tabular reports on university data.
- **Reports Available**:
  - Student List
  - Students by Department (Pie Chart)
  - Enrollment Reports
  - Instructor Reports
  - Course Reports
- **Usage**: Click on the respective buttons to generate the desired report. Charts are dynamically generated and displayed within the form.

**7. Troubleshooting**

- **Login Issues**: Verify username and password. Ensure the database is running and the connection string in App.config is correct.
- **Data Not Loading**: Check database connectivity and ensure tables contain data. Verify SQL queries in the application code if you are a developer.
- **Application Crashes**: Review system requirements. Consult the application logs (if any) for error details.

**8. Team Members**

- **[Team Member Name 1]** - [Role/Contribution]
- **[Team Member Name 2]** - [Role/Contribution]
- **[Team Member Name 3]** - [Role/Contribution]
- **Manus AI** - Documentation Generation
