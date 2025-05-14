using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Converters
{
    class BoolColorConverter : IValueConverter
    {
        public Color PresentColor { get; } = Colors.Gainsboro;
        public Color AbsentColor { get; } = Colors.White;
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return value is bool b && b ? PresentColor : AbsentColor;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return value is Color col && col.Equals(PresentColor) ? true : false;
        }
    }
}
