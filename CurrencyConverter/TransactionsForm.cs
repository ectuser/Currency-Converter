using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class TransactionsForm : Form
    {
        private List<Transaction> transactions = new List<Transaction>();
        private User currentUser;
        public TransactionsForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            InitTransactions();
            ShowTransactions();

        }
        private void ShowTransactions()
        {
            for (int i = 0; i < transactions.Count(); i++)
            {
                Transaction transaction = transactions[i];

                string[] row = { transaction.fromCurrency, transaction.fromValue.ToString(), transaction.toCurrency, (transaction.fromValue * transaction.coefficient).ToString(), transaction.coefficient.ToString(), transaction.time.ToString() };
                var lvi = new ListViewItem(row);

                TransactionsList.Items.Add(lvi);
            }
        }
        private void InitTransactions()
        {
            transactions = Database.GetTransactionsFromCurrentuser(currentUser);
        }
    }
}
