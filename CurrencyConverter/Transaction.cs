using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Transaction
    {
        public User User { get; }
        public DateTime time { get; }
        public string fromCurrency { get; }
        public string toCurrency { get; }
        public double fromValue { get; }
        public double coefficient { get; }

        public Transaction(User user, DateTime newTime, string newFrom, string newTo, double newFromValue, double newCoefficient)
        {
            User = user;
            time = newTime;
            fromCurrency = newFrom;
            toCurrency = newTo;
            fromValue = newFromValue;
            coefficient = newCoefficient;
        }
        public override string ToString()
        {
            char separator = Repository.separator;
            string timeStr = time.ToString();
            string from = fromCurrency.ToString();
            string to = toCurrency.ToString();
            string fromValueStr = fromValue.ToString(CultureInfo.InvariantCulture);
            return timeStr + separator + from + separator + to + separator + fromValueStr + separator + User.Id;
        }
    }
}
