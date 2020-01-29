using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class User
    {
        public int Id { get; }
        public string Login { get; }
        public string Password { get; }
        public User(int id, string login, string password)
        {
            Id = id;
            Login = login;
            Password = password;
        }
        public override string ToString()
        {
            char separator = Repository.separator;
            return Id.ToString() + separator + Login + separator + Password;
        }

    }
}
