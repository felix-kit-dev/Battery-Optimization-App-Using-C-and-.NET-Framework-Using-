# Battery-Optimization-App-Using-C-and-.NET-Framework

To create a Windows application that optimizes battery usage, monitors charging progress, and handles notifications, you can use C# and the .NET framework. This example will use Windows Presentation Foundation (WPF) for the UI and the Windows API to interact with battery information and control power settings.

Here's a simplified version of the app:

Create a new WPF Application project in Visual Studio.
Install the Hardcodet.NotifyIcon.Wpf package for notifications.


**Steps to Run the Application**

Create a new WPF Project:

Open Visual Studio.
Go to File -> New -> Project.
Select "WPF App (.NET Core)" and name it BatteryOptimizer.
Install NuGet Package:

Right-click on your project in Solution Explorer and select "Manage NuGet Packages".
Search for Hardcodet.NotifyIcon.Wpf and install it.
Add XAML and Code:

Replace the content of MainWindow.xaml and MainWindow.xaml.cs with the code provided above.
Run the Application:

Build and run your project by pressing F5.
Explanation
The application uses a DispatcherTimer to periodically update the battery status.
The UpdateBatteryStatus method retrieves battery information and updates the UI.
The ShowNotification method displays notifications for low battery and full charge.
The CutPower method uses the Windows API to prevent the system from entering sleep mode when the battery is full.
Note
The code uses SetThreadExecutionState to manage the power settings, but actual hardware-specific power control might require additional configurations or administrative privileges which are beyond the scope of this example.
