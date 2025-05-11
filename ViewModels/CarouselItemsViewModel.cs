using System.Collections.ObjectModel;
using TestApp.Models;

namespace TestApp.ViewModels
{
    internal class CarouselItemsViewModel
    {
        public ObservableCollection<CarousalItem> CarouselItems { get; }

        public CarouselItemsViewModel()
        {
            CarouselItems = new ObservableCollection<CarousalItem>
            {
                new CarousalItem("img1", "Efficient Class Monitoring",
                    "Easily manage and monitor classes with real-time data and insights."),

                new CarousalItem("img1", "Instant Attendance Tracking",
                    "Take attendance quickly and accurately with just a few taps."),

                new CarousalItem("img1", "Detailed Attendance Reports",
                    "Access visual statistics and reports to understand student attendance trends."),

                new CarousalItem("img1", "Leave Management Simplified",
                    "Track student leave requests and approvals seamlessly."),

                new CarousalItem("img1", "Smart Class Analytics",
                    "Make informed decisions with AI-driven attendance and performance analytics."),

                new CarousalItem("img1", "Secure and Reliable",
                    "All your class data is securely stored and easily accessible.")
            };
        }
    }
}