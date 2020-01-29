using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    class Repository
    {
        public static char separator = '%';
        public static Random rnd = new Random();
        public static int N = 10000;
        public static void ShowStatus(Label label, string text)
        {
            label.Text = text;
        }
    }
}
