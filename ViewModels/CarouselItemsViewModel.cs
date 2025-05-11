using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp.ViewModels
{
    internal class CarouselItemsViewModel
    {
        public ObservableCollection<CarousalItem> CarouselItems { get; }

        public CarouselItemsViewModel()
        {
            CarouselItems =
            [
                new CarousalItem("img1", "Efficient Class Monitoring",
                    "Monitoring the class made easy with Smart Attendance Tracking and Class Statistics"),
                new CarousalItem("img1", "Headline goes here",
                    "Hello my dear friends, I don't give a fuck about you guys doing stupid fucking internships"),
                new CarousalItem("img1", "Headline goes here",
                    "Hello my dear friends, I don't give a fuck about you guys doing stupid fucking internships")
            ];
        }
    }
}
