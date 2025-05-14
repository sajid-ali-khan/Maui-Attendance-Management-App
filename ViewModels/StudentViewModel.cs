using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using TestApp.Models;

namespace TestApp.ViewModels;

[INotifyPropertyChanged]
public partial class StudentViewModel
{
    private Student _student;
    public string Name { get; set; }
    public string Roll { get; set; }
    public string ImagePath { get; set; }

    [ObservableProperty]
    private bool _isPresent;

    public ICommand ClickCommand { get; private set; }

    public StudentViewModel(Student student)
    {
        _student = student;
        Name = student.Name;
        Roll = student.Roll;
        ImagePath = student.ImagePath;
        _isPresent = _student.IsPresent;
        ClickCommand = new Command(TogleStatus);
    }

    private void TogleStatus()
    {
        IsPresent = !_isPresent;
    }
}