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
using Microsoft.AspNet.Identity.EntityFramework;
using MySqlConnector;

namespace FastFoodApp
{

    
    public partial class MainLogin : Form
    {
        
        DatabaseContextStandard _context;
        DatabaseContext _contextIdentity;
        UserStore<Customer> customerStore;
        UserManager<Customer> customerManager;
        UserStore<Manager> managerStore;
        UserManager<Manager> managerManager;
        UserStore<Employee> employeeStore;
        UserManager<Employee> employeeManager;
        public MainLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _context = new DatabaseContextStandard();
            _contextIdentity = new DatabaseContext();
            customerStore = new UserStore<Customer>(_contextIdentity);
            customerManager = new UserManager<Customer>(customerStore);
            managerStore = new UserStore<Manager>(_contextIdentity);
            managerManager = new UserManager<Manager>(managerStore);
            employeeStore = new UserStore<Employee>(_contextIdentity);
            employeeManager = new UserManager<Employee>(employeeStore);

        }

        /* -- Used to add products to the database table
         
        private void addProduct(string type, string name, List<int> list)
        {
            Product product = new Product(type, name, list);

            foreach (var i in product.Ingredients)
            {
                var query = _context.Ingredients.Where(b => b.Id == i).First();
                product.Price += query.Price;
            } 

            _context.Products.Add(product);
            _context.SaveChanges();

            foreach (var i in product.Ingredients)
            {
                _context.ProductIngredients.Add(new ProductIngredients(product.Id, i));
                _context.SaveChanges();
            }
        }*/

        private void btnLogin_Click(object sender, EventArgs e)
        {

            var user = customerManager.Find(tbUsername.Text, tbPassword.Text);
            if (user != null)
            {
                this.Hide();
                CustomerLobby customerLobby = new CustomerLobby(_context, user);
                customerLobby.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password!");
            }

        }

        private void registerCustomer_Click(object sender, EventArgs e)
        {
            RegisterCustomer regCustomer = new RegisterCustomer(customerManager);
            regCustomer.ShowDialog();
        }

        private void btnEmployeeLogin_Click(object sender, EventArgs e)
        {
            EmployeeLogin employeeLogin = new EmployeeLogin(_contextIdentity, _context, employeeManager, this);
            employeeLogin.ShowDialog();
        }

        private void btnManagerLogin_Click(object sender, EventArgs e)
        {
            ManagerLogin managerLogin = new ManagerLogin(_contextIdentity, _context, managerManager, employeeManager, this);
            managerLogin.ShowDialog();
        }
    }

    
}
