namespace TestApp.Views.Controls;

public partial class CustomTitleView : ContentView
{
    public static readonly BindableProperty TitleTextProperty =
        BindableProperty.Create(nameof(TitleText), typeof(string), typeof(CustomTitleView), string.Empty);

    public string TitleText
    {
        get => (string)GetValue(TitleTextProperty);
        set => SetValue(TitleTextProperty, value);
    }

    public CustomTitleView()
    {
        InitializeComponent();
    }
}
