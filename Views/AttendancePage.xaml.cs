using TestApp.Models;
using TestApp.ViewModels;

namespace TestApp.Views;

public partial class AttendancePage : ContentPage
{
	public StudentsViewModel viewModel { get; set; }
    public AttendancePage()
    {
        InitializeComponent();
        viewModel = new StudentsViewModel(new List<Student>
        {
            new Student("229X1A1001", "Alice Johnson"),
            new Student("229X1A1002", "Bob Smith"),
            new Student("229X1A1003", "Charlie Brown"),
            new Student("229X1A1004", "Daisy Miller"),
            new Student("229X1A1005", "Ethan Williams"),
            new Student("229X1A1006", "Fiona Davis"),
            new Student("229X1A1007", "George Clark"),
            new Student("229X1A1008", "Hannah Lewis"),
            new Student("229X1A1009", "Ian Walker"),
            new Student("229X1A1010", "Julia Hall"),
            new Student("229X1A1011", "Kevin Young"),
            new Student("229X1A1012", "Lily Allen"),
            new Student("229X1A1013", "Michael Scott"),
            new Student("229X1A1014", "Nina Perez"),
            new Student("229X1A1015", "Oscar Turner"),
            new Student("229X1A1016", "Paula Adams"),
            new Student("229X1A1017", "Quentin Brooks"),
            new Student("229X1A1018", "Rachel Evans"),
            new Student("229X1A1019", "Sam Carter"),
            new Student("229X1A1020", "Tina Morris")
        });
        BindingContext = viewModel;
    }



}