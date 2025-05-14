using TestApp.Models;
using TestApp.ViewModels;
using TestApp.Views.Controls;
using Task = TestApp.Models;
using Microsoft.Maui.Dispatching;

namespace TestApp.Views;

public partial class LeavesPage : BasePage
{
    public LeavesViewModel viewModel { get; set; }
    public LeavesPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await LoadLeavesAsync();
        BindingContext = viewModel;
    }

    private async System.Threading.Tasks.Task LoadLeavesAsync()
    {
        viewModel = await System.Threading.Tasks.Task.Run(() => new LeavesViewModel(new List<Leave>
        {
            new("Sick Leave",
                "Was down with a severe flu and high fever, unable to attend college for a couple of days.",
                new DateOnly(2025, 3, 12), new DateOnly(2025, 3, 14)),
            new("Casual Leave",
                "Needed to attend a family function that required travel to another city. The event was on both days.",
                new DateOnly(2025, 2, 5), new DateOnly(2025, 2, 6)),
            new("Medical Leave",
                "Underwent a minor surgery and needed rest as prescribed by the doctor. Medical certificate submitted.",
                new DateOnly(2025, 1, 20), new DateOnly(2025, 1, 27)),
            new("Exam Leave", "Preparation leave granted before semester exams began to allow focus on studies.",
                new DateOnly(2024, 12, 1), new DateOnly(2024, 12, 10)),
            new("Maternity Leave", "Leave sanctioned due to maternity, as per college policy for female students.",
                new DateOnly(2025, 1, 1), new DateOnly(2025, 2, 28)),
            new("Paternity Leave",
                "Leave taken for the birth of my child, spent time supporting my partner and newborn.",
                new DateOnly(2025, 3, 1), new DateOnly(2025, 3, 7)),
            new("Emergency Leave",
                "There was a medical emergency in the family, and I had to travel urgently to my hometown.",
                new DateOnly(2025, 2, 14), new DateOnly(2025, 2, 15)),
            new("Personal Leave",
                "Needed a break due to mental health concerns. Informed department and was granted permission.",
                new DateOnly(2025, 3, 8), new DateOnly(2025, 3, 10)),
            new("Festival Leave", "Diwali celebrations at home with family. Extended travel also needed.",
                new DateOnly(2024, 11, 10), new DateOnly(2024, 11, 14)),
            new("Marriage Leave",
                "Attending my cousin’s wedding, which involved ceremonies spread over several days.",
                new DateOnly(2025, 1, 10), new DateOnly(2025, 1, 15)),
            new("Bereavement Leave",
                "Leave taken due to the unfortunate passing of a close relative. Needed to be with family.",
                new DateOnly(2025, 2, 22), new DateOnly(2025, 2, 24)),
            new("Sports Leave",
                "Represented the college in the state-level football tournament. Missed classes with prior permission.",
                new DateOnly(2025, 2, 1), new DateOnly(2025, 2, 5)),
            new("Project Work",
                "Field visit required for a group project in Environmental Science. Approval obtained beforehand.",
                new DateOnly(2025, 3, 3), new DateOnly(2025, 3, 4)),
            new("Internship Leave",
                "Short-term internship opportunity aligned with academic goals. Coordinated with HOD.",
                new DateOnly(2024, 10, 20), new DateOnly(2024, 11, 5)),
            new("Training Leave",
                "Attended a certified AI training workshop organized by a reputed company in Bengaluru.",
                new DateOnly(2025, 1, 5), new DateOnly(2025, 1, 9)),
            new("Medical Review",
                "Needed to undergo follow-up medical tests and consultation after earlier surgery.",
                new DateOnly(2025, 3, 18), new DateOnly(2025, 3, 18)),
            new("Visa Interview",
                "Had to travel to Chennai for my student visa interview for upcoming international studies.",
                new DateOnly(2025, 3, 21), new DateOnly(2025, 3, 21)),
            new("Blood Donation Drive",
                "Participated in a blood donation event organized by NSS. College permitted leave.",
                new DateOnly(2025, 2, 28), new DateOnly(2025, 2, 28)),
            new("Bank Work", "Bank-related formalities for education loan documentation. Could not be postponed.",
                new DateOnly(2025, 1, 16), new DateOnly(2025, 1, 16)),
            new("Cultural Event",
                "Performed in the inter-college cultural fest as a lead singer. Rehearsals and event days included.",
                new DateOnly(2025, 2, 10), new DateOnly(2025, 2, 12))
        }));
    }

    private async void GoToLeaveForm(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(LeaveFormPage));
    }
}