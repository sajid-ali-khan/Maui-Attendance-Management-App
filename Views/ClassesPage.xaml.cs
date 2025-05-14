using TestApp.Models;
using TestApp.ViewModels;
using TestApp.Views.Controls;

namespace TestApp.Views;

public partial class ClassesPage : BasePage
{
	public ClassesViewModel viewModel { get; set; }
	public ClassesPage()
	{
		InitializeComponent();
        viewModel = new ClassesViewModel([
            new Subject("Maths", "CSE", "A"),
            new Subject("Engineering Drawing", "MEC", "B"),
            new Subject("Thermodynamics", "CIV", "A"),
            new Subject("Optical Physics", "MEC", "A")
        ]);

        BindingContext = viewModel;
    }
}