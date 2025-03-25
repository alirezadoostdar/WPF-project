using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WPFTest.Converters;

public class ResultColorConvert : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if( value is int result)
        {
            if (result >= 70)
                return new SolidColorBrush(Color.FromRgb(0, 150, 100));
        }
        return new SolidColorBrush(Color.FromRgb(255, 255, 255));

    }


    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
