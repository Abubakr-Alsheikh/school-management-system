# School Management System

This project is a Windows Forms application developed for a university assignment.  It provides a comprehensive system for managing various aspects of a school, including students, employees, classes, grades, and schedules, all powered by an Oracle database.

## Features

* **Student Management:** Add, edit, delete, and enroll students.
* **Employee Management:** Manage employee details, roles, and assignments.
* **Class Management:** Create, edit, and delete classes, grades, and sections.
* **Grade Management:** Record and manage student grades, including grade components.
* **Schedule Management:** Create and manage weekly class schedules.
* **Reporting:** Basic reporting features to view and analyze data. (Further development possible)
* **Oracle Database Integration:**  Utilizes Oracle database for robust data storage and retrieval.
* **User-Friendly Interface:**  Intuitive Windows Forms interface for easy navigation and data management.
* **Data Validation and Error Handling:** Prevents data corruption and provides informative error messages.


## Technologies Used

* C#
* Windows Forms
* Oracle Database 11g (or later)
* Oracle.ManagedDataAccess
* SQL Developer (for database administration)
* Visual Studio


## Installation

1. **Oracle Database:** Ensure you have Oracle Database installed and configured. Create a new user (e.g., "admin") and grant necessary privileges (CONNECT, RESOURCE, DBA recommended for testing).
2. **Visual Studio:** Open the project in Visual Studio.
3. **NuGet Packages:** Install the `Oracle.ManagedDataAccess` NuGet package.
4. **Connection String:** Update the connection string in the `SchoolDatabase.cs` file with your Oracle database credentials. Ensure the service name matches your Oracle instance. Example:

```csharp
private static string connectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=YourServiceName)));User Id=your_user;Password=your_password;";
```
5. **Database Schema:**  Execute the SQL scripts provided in the `database_scripts` directory (or create tables manually based on the ERD diagram in the documentation).  This will create the necessary tables and triggers in your Oracle database. Populate the database with sample data if needed.
6. **Build and Run:** Build the solution and run the application.

## Usage

The main form provides access to all the different modules of the system through the menu bar.  Navigate to the desired section to manage students, employees, classes, etc. Use the search functionality to quickly find specific records.


## Future Improvements

* Enhanced reporting capabilities with more detailed reports and data visualization.
* User roles and permissions for access control.
* Improved user interface design and aesthetics.
* Integration with other school systems (e.g., attendance tracking).


## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.






