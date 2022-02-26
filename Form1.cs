using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNet.Identity;
using MySqlConnector;

namespace FastFoodApp
{

    
    public partial class Form1 : Form
    {
        User[] users = new User[1];
        DB db = new DB();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            users[0] = new User("martin", "12345");

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PasswordHashing hasher = new PasswordHashing();
            string savedPass;    

            if(db.Open())
            {

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM customers WHERE UserName = '" + tbUsername.Text + "';", db.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Read();
                if (dataReader.HasRows)
                {
                    savedPass = dataReader["Password"].ToString();
                    if (hasher.ComparePasswords(tbPassword.Text, savedPass))
                    {
                        MessageBox.Show("Success!");
                        // Account Authenticated

                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password!");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Username!");
                }

                dataReader.Close();
                db.Close();
            }
        }

        private void registerCustomer_Click(object sender, EventArgs e)
        {
            //this.Hide();
            RegisterCustomer regCustomer = new RegisterCustomer(db);
            regCustomer.ShowDialog();
        }

        private void btnEmployeeLogin_Click(object sender, EventArgs e)
        {
            EmployeeLogin employeeLogin = new EmployeeLogin(db);
            employeeLogin.ShowDialog();
        }

        private void btnManagerLogin_Click(object sender, EventArgs e)
        {
            ManagerLogin managerLogin = new ManagerLogin(db);
            managerLogin.ShowDialog();
        }
    }

    public class DB
    {
        public MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string connectString;

        public DB()
        {
            Initialize();
        }

        private void Initialize()
        {
            this.server = "localhost";
            this.database = "fastfooddb";
            this.user = "root";

            this.connectString = "Datasource = " + server + ";" + "username=" + user + ";" + "password=" + ";" + "database=" + database;
            connection = new MySqlConnection(connectString);
        }

        public bool Open()
        {

            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException e)
            {
                switch (e.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password.");
                        break;
                    default:
                        MessageBox.Show(e.Message);
                        break;
                }
                return false;
            }
        }

        public bool Close()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

    }

    class User
    {
        private string username;
        private string password;

        public string getPassword()
        {
            return this.password;
        }
        public string getUsername()
        {
            return this.username;
        }
        public void setUsername(string uname)
        {
            this.username = uname;
        }
        public void setPassword(string pass)
        {
            this.password = pass;
        }

        public User(string uname, string pass)
        {
            this.username = uname;
            this.password = pass;
        }
    }
}
