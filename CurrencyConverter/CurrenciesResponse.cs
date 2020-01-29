using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CurrencyConverter
{
    class CurrenciesResponse
    {
        public bool success { get; set; }
        public int timestamp { get; set; }
        public string BaseCurrency { get; set; }
        public string date { get; set;  }
        public Dictionary<string, double> rates { get; set; }

    }
}
