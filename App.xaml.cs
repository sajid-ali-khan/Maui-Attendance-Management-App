using TestApp.Resources.Styles;
using TestApp.Views;

namespace TestApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            SetTheme();
            MainPage = new GetStartedPage();
        }

        private void SetTheme()
        {
            if (Application.Current?.Resources == null)
                return;

            //Application.Current.Resources.MergedDictionaries.Clear();

            if (AppInfo.RequestedTheme == AppTheme.Dark)
            {
                Application.Current.Resources.MergedDictionaries.Add(new LightTheme());
            }
            else
            {
                Application.Current.Resources.MergedDictionaries.Add(new LightTheme());
            }
        }
    }
}
