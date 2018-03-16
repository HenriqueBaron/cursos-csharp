using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DataBindingMultiPropApp
{
    public class MyClass
    {
        private static SolidColorBrush backColorName = new SolidColorBrush(Colors.LightBlue);
        private static SolidColorBrush foreColorName = new SolidColorBrush(Colors.Yellow);

        public static SolidColorBrush BackColorName { get => backColorName; set => backColorName = value; }
        public static SolidColorBrush ForeColorName { get => foreColorName; set => foreColorName = value; }
    }
}
