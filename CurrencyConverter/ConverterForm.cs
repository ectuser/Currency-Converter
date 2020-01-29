using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CurrencyConverter
{
    public partial class ConverterForm : Form
    {
        private User currentUser;
        private Dictionary<string, double> currencies = new Dictionary<string, double>();
        public ConverterForm(User user)
        {
            TryToGetCurrencies();
            InitializeComponent();
            currentUser = user;
            InitCurrencies();
            ShowCurrencies();
        }
        private void InitCurrencies()
        {
            currencies = Database.GetCurrenciesFromDatabase();

        }
        private void ShowCurrencies()
        {
            List<string> needCurencies = new List<string>();
            needCurencies.Add("EUR");
            needCurencies.Add("USD");
            needCurencies.Add("RUB");
            needCurencies.Add("JPY");
            needCurencies.Add("CNY");
            foreach (KeyValuePair<string, double> el in currencies)
            {
                if (needCurencies.Contains(el.Key))
                {
                    FromCurrencyList.Items.Add(el.Key);
                }
            }
            foreach (KeyValuePair<string, double> el in currencies)
            {
                if (needCurencies.Contains(el.Key))
                {
                    ToCurrencyList.Items.Add(el.Key);
                }
            }
        }

        private void TryToGetCurrencies()
        {
            string json = Network.GetRequest("http://data.fixer.io/api/latest?access_key=0b9b562eec577b98d38254155f31efef");
            if (json == "error")
            {
                ConvertFormErrorStatus.Text = "Couldn't connect";
                return;
            }
            else
            {
                var currenciesResponse = JsonConvert.DeserializeObject<CurrenciesResponse>(json); // need fix
                Console.WriteLine(currenciesResponse.success.ToString());
                Database.AddCurrenciesToDatabase(currenciesResponse.rates);
            }
        }

        private void CountCurrencyButton_Click(object sender, EventArgs e)
        {
            if (FromCurrencyList.SelectedItem == null || ToCurrencyList.SelectedItem == null || !CheckNumberInput(AmountInput.Text))
            {
                Repository.ShowStatus(ConvertFormErrorStatus, "Choose both currencies and amount correct number");
                return;
            }
            string fromCurr = FromCurrencyList.SelectedItem.ToString();
            double fromValue = DefineCurrencyValue(fromCurr);
            string toCurr = ToCurrencyList.SelectedItem.ToString();
            double toValue = DefineCurrencyValue(toCurr);
            string amountStr = AmountInput.Text;
            double amount = double.Parse(amountStr, System.Globalization.CultureInfo.InvariantCulture);
            double result = Count(amount, fromValue, toValue);
            OutputLabel.Text = result.ToString(CultureInfo.InvariantCulture);
            double coeffitient = toValue / fromValue;
            Transaction transaction = new Transaction(currentUser, DateTime.Now, fromCurr, toCurr, amount, coeffitient);
            Database.AddTransactionToDatabase(transaction);
        }
        private bool CheckNumberInput(string str)
        {
            double.TryParse(str, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out double num);
            if (num == 0 && str != "0")
            {
                return false;
            }
            return true;
        }
        private double DefineCurrencyValue(string name)
        {
            return currencies[name];

        }
        private double Count(double amount, double fromValue, double toValue)
        {
            Console.WriteLine(amount + " " + toValue + " " + fromValue);
            return amount * toValue / fromValue;
        }

        private void OpenTransactionsForm_Click(object sender, EventArgs e)
        {
            TransactionsForm newForm = new TransactionsForm(currentUser);
            newForm.Show();
        }
    }
}
