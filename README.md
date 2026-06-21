# Fitness Planner

A simple Windows Forms (WinForms) personal fitness application written in C# that provides meal planning, workout tracking and progress logging. This repository contains a .NET Framework 4.7.2 WinForms application that uses a MySQL database to store users, meals, user meal plans, workouts and progress entries.

## Features

- User login and registration
- Meal database and meal planning (add/remove meals to daily plan)
- Workout planner and today's workout summary
- Progress logging with charts (weight, calories out)
- BMI calculator

## Technologies

- C# 7.3
- .NET Framework 4.7.2
- Windows Forms (WinForms)
- MySQL (via MySql.Data / MySqlConnector)

## Prerequisites

- Visual Studio (2017 or later) with .NET desktop development workload
- MySQL server (local or remote)
- NuGet package: MySql.Data (or MySqlConnector)

## Getting started / Setup

1. Clone this repository to your local machine.

2. Open the solution in Visual Studio.

3. Install the MySQL ADO.NET provider if not already installed:

   - Using Package Manager Console:
     - Install-Package MySql.Data

4. Configure the database connection in `DBConnection.cs` (project root). Update the following fields to match your MySQL server:

   - `server` (hostname or IP)
   - `database` (database name)
   - `uid` (username)
   - `password` (password)

   Example connection string constructed in DBConnection.cs:
   `SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};`

5. Create the required database and tables using the provided SQL file.


6. Build and run the application from Visual Studio. The app starts at `FormLogin`.

## Common customization

- Change UI labels, colors or button styles in the Designer files (.Designer.cs).
- To prevent users from editing message textboxes used for status/errors, set `ReadOnly = true` and `TabStop = false` on those TextBox controls.
- Column sizing and DataGridView layout is handled in meal/workout forms. If you encounter `InvalidOperationException` related to column resizing, defer column AutoSizeMode changes to the Form.Shown event or temporarily set `AutoSizeColumnsMode = None` before adjusting columns.

## Troubleshooting

- MySQL connection errors: verify credentials and that MySQL server accepts TCP connections. Check firewall rules.
- Missing NuGet packages: restore NuGet packages (right-click solution -> Restore NuGet Packages).
- DataGridView resizing exceptions: see customization note above.

## Contributing

Contributions are welcome. Please open an issue to discuss changes or submit a pull request.

## License

This project is provided as-is. Add a LICENSE file if you plan to make this public on GitHub.


---

Good luck and happy coding!
