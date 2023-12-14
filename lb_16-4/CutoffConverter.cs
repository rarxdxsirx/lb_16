using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace lb_16_4
{
    public class CutoffConverter : IValueConverter
    {
        public int Cutoff { get; set; } = 0;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((double)value) > Cutoff;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
