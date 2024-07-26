using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Threading;
using Hardcodet.Wpf.TaskbarNotification;

namespace BatteryOptimizer
{
    public partial class MainWindow : Window
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr SetThreadExecutionState(ExecutionState esFlags);

        [Flags]
        enum ExecutionState : uint
        {
            ES_CONTINUOUS = 0x80000000,
            ES_SYSTEM_REQUIRED = 0x00000001,
            ES_AWAYMODE_REQUIRED = 0x00000040
        }

        private DispatcherTimer _timer;
        private TaskbarIcon _notifyIcon;

        public MainWindow()
        {
            InitializeComponent();
            _notifyIcon = new TaskbarIcon
            {
                Icon = System.Drawing.SystemIcons.Information,
                ToolTipText = "Battery Optimizer"
            };

            _timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(30)
            };
            _timer.Tick += Timer_Tick;
            _timer.Start();
            UpdateBatteryStatus();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateBatteryStatus();
        }

        private void UpdateBatteryStatus()
        {
            var batteryStatus = SystemInformation.PowerStatus;
            BatteryProgressBar.Value = batteryStatus.BatteryLifePercent * 100;
            BatteryStatusText.Text = $"Battery Life: {batteryStatus.BatteryLifePercent * 100}%\nBattery Status: {batteryStatus.BatteryChargeStatus}";

            if (batteryStatus.BatteryLifePercent * 100 <= 20 && batteryStatus.PowerLineStatus != PowerLineStatus.Online)
            {
                ShowNotification("Battery Low", "Your battery is running low. Please plug in your charger.");
            }

            if (batteryStatus.BatteryLifePercent * 100 >= 100 && CutPowerCheckBox.IsChecked == true)
            {
                CutPower();
                ShowNotification("Battery Full", "Your battery is fully charged. Power has been cut.");
            }
        }

        private void ShowNotification(string title, string message)
        {
            _notifyIcon.ShowBalloonTip(title, message, BalloonIcon.Info);
        }

        private void CutPower()
        {
            SetThreadExecutionState(ExecutionState.ES_CONTINUOUS | ExecutionState.ES_AWAYMODE_REQUIRED | ExecutionState.ES_SYSTEM_REQUIRED);
        }
    }
}
