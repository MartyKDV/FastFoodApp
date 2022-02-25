using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.AspNet.Identity;

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
            string uname = tbUsername.Text;
            string pass = tbPassword.Text;
            PasswordHashing hasher = new PasswordHashing();
            string hashedPass = hasher.HashPassword(pass);     

            if(db.Open() == true)
            {

                MySqlCommand cmd = new MySqlCommand("INSERT INTO customers (id, first_name, last_name, username, password) " +
                    "VALUES (NULL, 'Martin', 'Kadrev', '" + uname + "', '" + hashedPass + "');", db.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                /*string queryCustomers = "SELECT * FROM customers WHERE username = " + uname + " AND password = " + hashedPass;
                string queryEmployees = "SELECT * FROM testtable;";
                string queryManagers = "SELECT * FROM testtable;";
                */

                List<Customer> list = new List<Customer>();

                while (dataReader.Read())
                {
                    list.Add(new Customer(dataReader["first_name"].ToString(), dataReader["last_name"].ToString(),
                        dataReader["username"].ToString(), dataReader["password"].ToString()));
                }

                dataReader.Close();
                db.Close();

                for(int i = 0; i < list.Count; i++)
                {
                    MessageBox.Show("First Name: " + list[i].FirstName + "\nLast Name: " + list[0].LastName + "\nUsername: " +
                        list[0].UserName + "\nPassword: " + list[0].PasswordHash);
                }
            }
        }

        private void registerCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterCustomer regCustomer = new RegisterCustomer();
            regCustomer.ShowDialog();
        }
    }

    class DB
    {
        public MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;

        public DB()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "fastfooddb";
            user = "root";
            password = "password";

            string connectString = "Datasource = " + server + ";" + "username=" + user + ";" + "password=" + ";" + "database=" + database;

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
