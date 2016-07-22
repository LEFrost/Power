using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace Power.Converter
{
    class PowerColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            Color red = new Color();
            red.R = 255;
            red.G = red.B = 0;
    
    
            double Num = (double)Int32.Parse(value.ToString()) / App.ViewModel.PowerTotal;
            if (Num > 0 && Num <= 0.2)
                return red;
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
