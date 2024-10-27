using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace BTVN08
{
    public class CreditsToPercentageConverter: IValueConverter
    {
        public int Max { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int credits = (int)value;
            double percentage = (double)credits / Max * 100;
            return $"{credits}/{Max} => {percentage: 0.00}%";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
