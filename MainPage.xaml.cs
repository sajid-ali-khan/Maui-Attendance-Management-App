using View = Microsoft.Maui.Controls.View;

namespace TestApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ResetSheetPosition(BottomSheet);
            ResetSheetPosition(SignUpSheet);
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

        private async Task HideAllSheetsAsync()
        {
            await Task.WhenAll(
                HideSheetAsync(BottomSheet),
                HideSheetAsync(SignUpSheet)
            );
        }

        private async void ShowLoginSheet(object sender, EventArgs e)
        {

            Overlay.IsVisible = true;
            await Overlay.FadeTo(0.4, 200);


            ResetSheetPosition(BottomSheet);
            BottomSheet.IsVisible = true;

            await ShowSheetAsync(BottomSheet);
        }

        private async void OnOverlayTapped(object sender, EventArgs e)
        {
            await HideAllSheetsAsync();

            Overlay.IsVisible = false;
            BottomSheet.IsVisible = false;
            SignUpSheet.IsVisible = false;
        }

        private async void SignUpClicked(object? sender, TappedEventArgs e)
        {
            await HideSheetAsync(BottomSheet);
            BottomSheet.IsVisible = false;

            ResetSheetPosition(SignUpSheet);
            SignUpSheet.IsVisible = true;

            await ShowSheetAsync(SignUpSheet);
        }

        private async void LoginClicked(object? sender, TappedEventArgs e)
        {
            await HideSheetAsync(SignUpSheet);
            SignUpSheet.IsVisible = false;

            ResetSheetPosition(BottomSheet);
            BottomSheet.IsVisible = true;

            await ShowSheetAsync(BottomSheet);
        }
    }
}
