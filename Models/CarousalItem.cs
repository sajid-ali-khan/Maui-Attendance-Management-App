using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Models
{
    internal class CarousalItem
    {
        public string Image { get; set; }
        public string HeadLine { get; set; }
        public string TagLine { get; set; }

        public CarousalItem(string image, string headline, string tagline)
        {
            this.Image = image;
            this.HeadLine = headline;
            this.TagLine = tagline;
        }
    }
}
