using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Navigation;

namespace WPFTest.Converters;

public class YesNoBoolConvert : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return value.ToString().ToLower() switch
        {
            "yes" => true,
            "no" => false,
            _ => false,
        };
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if(parameter.ToString().ToLower() == "farsi")
        {
            if (value is bool result)
                return result switch
                {
                    true => "بله",
                    false => "خیر"
                };
        }
        else
        {
            if (value is bool result)
                return result switch
                {
                    true => "Yes",
                    false => "No"
                };
        }
        
        return "";
    }
}
