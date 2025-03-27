using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfApp_Demo_Github.ValueConverters
{
    class TextToColorConverter : IValueConverter

    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is ComboBoxItem c)
            {
                switch(c.Content)
                {
                    case "Rood":
                        return "#FF0000";
                    case "Groen":
                        return "#00FF00";
                    case "Blauw":
                        return "#0000FF";
                    default:
                        return "#000000";
                }
            }
            return "#000000";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
