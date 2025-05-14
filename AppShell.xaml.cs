using TestApp.Views;

namespace TestApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(GetStartedPage), typeof(GetStartedPage));
            Routing.RegisterRoute(nameof(AttendancePage), typeof(AttendancePage));
            Routing.RegisterRoute(nameof(LeaveFormPage), typeof(LeaveFormPage));
        }
    }
}
