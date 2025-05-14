using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using TestApp.Models;

namespace TestApp.ViewModels
{
    [INotifyPropertyChanged]
    public partial class LeaveViewModel
    {
        public string LeaveType { get; set; }
        public string Description { get; set; }
        public DateOnly FromDate { get; set; }
        public DateOnly ToDate { get; set; }

        [ObservableProperty] private bool isExpanded;
        public ICommand ClickCommand { get; private set; }

        public LeaveViewModel(Leave leave)
        {
            LeaveType = leave.LeaveType;
            Description = leave.Description;
            FromDate = leave.FromDate;
            ToDate = leave.ToDate;
            IsExpanded = false;
            ClickCommand = new Command(ToggleExpansion);
        }

        private void ToggleExpansion()
        {
            IsExpanded = !isExpanded;
        }
    }
}
