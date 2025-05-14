using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public record Leave(
        string LeaveType,
        string Description,
        DateOnly FromDate,
        DateOnly ToDate
    );
}
