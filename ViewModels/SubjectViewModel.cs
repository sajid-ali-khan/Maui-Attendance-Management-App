using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TestApp.Models;
using TestApp.Views;

namespace TestApp.ViewModels
{
    public class SubjectViewModel
    {
        public string Name { get; set; }
        public string Branch { get; set; }
        public string Section { get; set; }

        public Command ClickCommand { get; private set; }

        public SubjectViewModel(Subject subject)
        {
            Name = subject.Name;
            Branch = subject.Branch;
            Section = subject.Section;
            ClickCommand = new Command(GoToAttendancePage);
        }

        private async void GoToAttendancePage()
        {
            await Shell.Current.GoToAsync(nameof(AttendancePage));
        }
    }
}
