using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using TestApp.Models;

namespace TestApp.ViewModels
{
    public class StudentsViewModel: ObservableObject
    {
        public ObservableCollection<StudentViewModel> Students { get; set; }

        public StudentsViewModel(IEnumerable<Student> students)
        {
            Students = new ObservableCollection<StudentViewModel>(
                students.Select(st => new StudentViewModel(st))
            );
        }
    }
}
