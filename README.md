# Battery-Optimization-App-Using-C-and-.NET-Framework

# Battery Optimizer

A Windows application that monitors battery status, provides notifications, and offers power management features. The app displays battery charging progress, remaining charge, and an option to cut power once the battery is fully charged.

## Requirements

- **Operating System**: Windows 10 or Windows 11
- **.NET Framework**: .NET Core 3.1 or .NET 5.0/6.0
- **IDE**: Visual Studio 2019 or later
- **NuGet Packages**:
  - `Hardcodet.NotifyIcon.Wpf` for system tray notifications

## Features

- Displays battery charging progress as a progress bar.
- Shows the remaining battery charge as a percentage.
- Provides notifications when the battery is low or fully charged.
- Includes an option to cut power when the battery is fully charged.
- Refresh button to manually update battery status.
- Exit button to close the application.

## How to Build

1. **Clone the Repository**

   ```sh
   git clone https://github.com/yourusername/battery-optimizer.git

Open the Project

Open the solution file (BatteryOptimizer.sln) in Visual Studio.

Install NuGet Packages

Right-click on the project in Solution Explorer and select "Manage NuGet Packages". Search for Hardcodet.NotifyIcon.Wpf and install it.

Build the Project

Build the project by selecting Build -> Build Solution from the top menu or by pressing Ctrl+Shift+B.

How to Run
Start the Application

Press F5 or select Debug -> Start Debugging from the top menu to run the application.

Using the Application

The application will show the battery status in the main window.
Use the "Refresh" button to manually update the battery status.
Check the "Cut Power When Fully Charged" checkbox to enable automatic power cut when the battery is fully charged.
Notifications will appear when the battery is low or fully charged.
Use the "Exit" button to close the application.
Known Issues
The power cut feature may not work on all hardware configurations or may require administrative privileges.
Ensure the application has necessary permissions to access battery information and notifications.
Contributing
Feel free to submit issues and pull requests. Please ensure that your changes are well-documented and tested.

License
This project is licensed under the GNU License. See the LICENSE file for details.
