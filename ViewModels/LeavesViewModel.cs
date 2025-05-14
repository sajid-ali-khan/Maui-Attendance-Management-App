using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using TestApp.Models;

using Plugin.Maui.Calendar.Models;
using System.Globalization;
using Task = System.Threading.Tasks.Task;

namespace TestApp.ViewModels;

public class LeavesViewModel : ObservableObject
{
    public ObservableCollection<LeaveViewModel> Leaves { get; set; }

    public LeavesViewModel(IEnumerable<Leave> leaves)
    {
        StoreLeavesAsync(leaves);
    }

    private async void StoreLeavesAsync(IEnumerable<Leave> leaves)
    {
        Leaves = await Task.Run(() => new ObservableCollection<LeaveViewModel>(
            leaves.Select(leave => new LeaveViewModel(leave)).OrderByDescending(l => l.ToDate).Take(10)
        ));
    }
}