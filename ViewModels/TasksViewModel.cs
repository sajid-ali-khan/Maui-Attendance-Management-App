using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static System.DateTime;
using TestApp.Models;
using Task = TestApp.Models.Task;
using System.ComponentModel;

namespace TestApp.ViewModels;

public class TasksViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged(string propertyName) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    private ObservableCollection<Task> tasks;
    public ObservableCollection<Task> Tasks
    {
        get => tasks;
        set
        {
            tasks = value;
            OnPropertyChanged(nameof(Tasks));
        }
    }

    public TasksViewModel()
    {
        LoadTasks();
    }

    public void LoadTasks()
    {
        Tasks = new ObservableCollection<Task>(Models.Task.LoadAll());
    }

    public void AddTask(Models.Task task)
    {
        task.Save();
        Tasks.Insert(0, task);
    }

    public void RemoveTask(Models.Task task)
    {
        task.Delete();
        Tasks.Remove(task);
    }
}
