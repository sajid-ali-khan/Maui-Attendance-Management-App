using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.ViewModels
{
    public class LeaveTypeViewModel
    {
        public ObservableCollection<string> LeaveTypes { get; set; }

        public LeaveTypeViewModel()
        {
            LeaveTypes =
            [
                "Sick Leave",
                "Paternal Leave",
                "Casual Leave",
                "Medical Leave",
                "Emergency Leave",
                "Marriage Leave"
            ];
        }
    }
}
