using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class AuthForm : Form
    { 
        private List<User> users = new List<User>();
        private bool isConnectedToDatabase = false;
        public AuthForm()
        {
            InitializeComponent();
            try
            {
                Database.Connect();
                isConnectedToDatabase = true;
            }
            catch(Exception e)
            {
                AuthFormErrorStatus.Text = e.Message;
            }

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (!isConnectedToDatabase)
            {
                AuthFormErrorStatus.Text = "Couldn't connect to database";
                return;
            }
            if (LoginInput.Text == "" || PasswordInput.Text == "")
            {
                Repository.ShowStatus(AuthFormErrorStatus, "Type login and password");
                return;
            }
            string loginInput = LoginInput.Text;
            string passwordInput = PasswordInput.Text;
            User usr = Database.UserSignIn(loginInput, passwordInput);
            if (usr.Id == -1)
            {
                Repository.ShowStatus(AuthFormErrorStatus, "Couldn't find user");
                return;
            }

            ConverterForm newForm = new ConverterForm(usr);
            newForm.Show();

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (!isConnectedToDatabase)
            {
                AuthFormErrorStatus.Text = "Couldn't connect to database";
                return;
            }
            if (LoginInput.Text == "" || PasswordInput.Text == "" || !IsWordCorrect(LoginInput.Text) || !IsWordCorrect(PasswordInput.Text) || !Database.IsLoginUnique(LoginInput.Text))
            {
                Repository.ShowStatus(AuthFormErrorStatus, "Type login and password. They shouldn't include % symbol. \n Login also should be unique");
                return;
            }
            string login = LoginInput.Text;
            string password = PasswordInput.Text;
            //FileSystem.AddUserToFile(user);
            Database.AddUser(login, password);
            Repository.ShowStatus(AuthFormErrorStatus, "Success. Now Sign In!");
            LoginInput.Text = "";
            PasswordInput.Text = "";
        }
        private bool IsWordCorrect(string word)
        {
            return word.All(letter => letter != Repository.separator);
        }
    }
}
