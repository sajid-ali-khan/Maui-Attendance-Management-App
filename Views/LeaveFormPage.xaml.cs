namespace TestApp.Views;

public partial class LeaveFormPage : ContentPage
{
	public LeaveFormPage()
	{
		InitializeComponent();
	}

    private async void GoBack(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}