using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Database
    {
        public static MySqlConnection connection;
        public static void Connect()
        {
            string login = "";
            string password = "";
            string DBcon = $"server=localhost;database=currencyconverter;uid={login};pwd={password};";
            connection = new MySqlConnection(DBcon);
            try
            {
                connection.Open();
                connection.Close();
            }
            catch(Exception e)
            {
                throw new Exception("Couldn't connect to database");
            }
        }
        public static User UserSignIn(string login, string password)
        {
            connection.Open();
            var stm = $"select * from user u where u.login=\"{login}\" and u.password=\"{password}\";";
            var cmd = new MySqlCommand(stm, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            User usr = new User(-1, "-1", "-1");
            while (reader.Read())
            {
                string idStr = reader[0].ToString();
                int id = Convert.ToInt32(idStr);
                usr = new User(id, login, password);
            }
            connection.Close();
            return usr;
        }
        public static void AddUser(string login, string password)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"INSERT INTO user(login,password) VALUES(\"{login}\", \"{password}\");";
            cmd.ExecuteNonQuery();
            //int id = Convert.ToInt32(cmd.LastInsertedId);
            connection.Close();
        }
        public static bool IsLoginUnique(string login)
        {
            connection.Open();
            var stm = $"select count(*) from user where login=\"{login}\";";
            var cmd = new MySqlCommand(stm, connection);
            int mysqlint = int.Parse(cmd.ExecuteScalar().ToString());
            connection.Close();
            if (mysqlint > 0)
            {
                return false;
            }
            return true;
        }
        public static void AddCurrenciesToDatabase(Dictionary<string, double> currencies)
        {
            connection.Open();
            foreach (var currency in currencies)
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = $"INSERT INTO currency(name,rate) VALUES(\"{currency.Key}\", {currency.Value.ToString(System.Globalization.CultureInfo.InvariantCulture)}) ON DUPLICATE KEY UPDATE rate={currency.Value.ToString(System.Globalization.CultureInfo.InvariantCulture)};";
                cmd.ExecuteNonQuery();
            }
            connection.Close();
        }
        public static Dictionary<string, double> GetCurrenciesFromDatabase()
        {
            Dictionary<string, double> currencies = new Dictionary<string, double>();
            connection.Open();
            var stm = $"select * from currency;";
            var cmd = new MySqlCommand(stm, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader[0].ToString();
                string valueString = reader[1].ToString();
                double value = Convert.ToDouble(valueString);
                currencies.Add(name, value);
            }
            connection.Close();
            return currencies;
        }
        public static void AddTransactionToDatabase(Transaction transaction)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            DateTime now = DateTime.Now;
            string dateTimeForMysql = now.ToString("yyyy-MM-dd HH:mm:ss");
            cmd.CommandText = $"INSERT INTO transaction(userid, value, fromcurrency, tocurrency, date, coefficient) VALUES({transaction.User.Id}, {transaction.fromValue.ToString(System.Globalization.CultureInfo.InvariantCulture)}, \"{transaction.fromCurrency}\", \"{transaction.toCurrency}\", \"{dateTimeForMysql}\", {transaction.coefficient.ToString(System.Globalization.CultureInfo.InvariantCulture)});";
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public static List<Transaction> GetTransactionsFromCurrentuser(User user)
        {
            List<Transaction> transactions = new List<Transaction>();
            connection.Open();
            var stm = $"select * from transaction where userid={user.Id};";
            var cmd = new MySqlCommand(stm, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DateTime dt = DateTime.Parse(reader[5].ToString());
                double value = Convert.ToDouble(reader[2].ToString());
                double coefficient = Convert.ToDouble(reader[6].ToString());
                Transaction transaction = new Transaction(user, dt, reader[3].ToString(), reader[4].ToString(), value, coefficient);
                transactions.Add(transaction);
            }
            connection.Close();
            return transactions;
        }
    }
}
