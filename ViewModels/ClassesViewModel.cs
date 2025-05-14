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
    public class ClassesViewModel: ObservableObject
    {
        public ObservableCollection<SubjectViewModel> Classes { get; set; }

        public ClassesViewModel(IEnumerable<Subject> subjects)
        {
            Classes = new ObservableCollection<SubjectViewModel>(
                subjects.Select(subject => new SubjectViewModel(subject))
            );
        }
    }
}
