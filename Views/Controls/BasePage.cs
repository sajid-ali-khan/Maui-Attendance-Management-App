using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Views.Controls;

public class BasePage : ContentPage
{
    public BasePage()
    {
        var logoutItem = new ToolbarItem
        {
            Text = "Logout",
            IconImageSource = "logout",
            Order = ToolbarItemOrder.Secondary,
            Priority = 1
        };

        var aboutItem = new ToolbarItem
        {
            Text = "About us",
            IconImageSource = "about",
            Order = ToolbarItemOrder.Secondary,
            Priority = 0
        };

        logoutItem.Clicked += async (s, e) =>
        {
            bool confirm = await DisplayAlert("Logout", "Do you want to logout?", "Yes", "No");
            if (confirm)
            {
                Application.Current.MainPage = new GetStartedPage();
            }
        };

        ToolbarItems.Add(aboutItem);
        ToolbarItems.Add(logoutItem);
    }
}
