using TestApp.ViewModels;
using TestApp.Views.Controls;

namespace TestApp.Views;

public partial class TasksPage : BasePage
{
    private TasksViewModel viewModel;
	public TasksPage()
	{
		InitializeComponent();
        viewModel = new TasksViewModel();
        BindingContext = viewModel;
    }

    private async void AnimateShine()
    {
        while (true)
        {
            ShineEffect.TranslationX = -ShineEffect.Width;
            await ShineEffect.TranslateTo(NotificationCard.Width, 0, 2000, Easing.Linear);
            await Task.Delay(3000);
        }
    }


    protected override void OnAppearing()
    {
        base.OnAppearing();

        AnimateShine();
        ResetSheetPosition(TaskSheet);

    }

    private async void OnOverlayTapped(object? sender, TappedEventArgs e)
    {
        DismissKeyboard();

        await HideSheetAsync(TaskSheet);
        Overlay.IsVisible = false;
        TaskSheet.IsVisible = false;
    }


    private void ResetSheetPosition(View sheet)
    {
        sheet.TranslationY = sheet.Height;
    }

    private async Task HideSheetAsync(View sheet)
    {
        if (sheet.IsVisible)
        {
            await sheet.TranslateTo(0, sheet.Height, 200, Easing.SinIn);
            sheet.IsVisible = false;
        }
    }

    private async Task ShowSheetAsync(View sheet)
    {
        ResetSheetPosition(sheet);
        sheet.IsVisible = true;
        await sheet.TranslateTo(0, 0, 300, Easing.SinOut);
    }

    private async void ShowTaskSheet(object? sender, EventArgs e)
    {
        Overlay.IsVisible = true;
        await Overlay.FadeTo(0.4, 200);

        ResetSheetPosition(TaskSheet);
        TaskSheet.IsVisible = true;

        await ShowSheetAsync(TaskSheet);
        TaskEntry.Focus();
    }

    private void DismissKeyboard()
    {
        #if ANDROID
                Android.Views.InputMethods.InputMethodManager inputMethodManager =
                    (Android.Views.InputMethods.InputMethodManager)Android.App.Application.Context.GetSystemService(Android.Content.Context.InputMethodService);
                var currentFocus = Platform.CurrentActivity?.CurrentFocus;
                if (currentFocus != null)
                    inputMethodManager.HideSoftInputFromWindow(currentFocus.WindowToken, 0);
        #endif
    }

    private async void DoneClicked(object? sender, EventArgs e)
    {
        string taskText = TaskEntry.Text;
        var _task = new Models.Task(taskText);
        viewModel.AddTask(_task);
        TaskEntry.Text = "";

        DismissKeyboard();

        await HideSheetAsync(TaskSheet);
        Overlay.IsVisible = false;
        TaskSheet.IsVisible = false;
    }

    private void OnDeleteTaskClicked(object? sender, EventArgs e)
    {
        if (sender is ImageButton button && button.BindingContext is Models.Task task)
        {
            viewModel.RemoveTask(task);
        }
    }

    private void CloseNotification(object? sender, EventArgs e)
    {
        NotificationCard.IsVisible = false;
    }
}