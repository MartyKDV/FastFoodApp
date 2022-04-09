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

            /*_context.Ingredients.Add(new Ingredient("Lukanka", 1.2f, "test.jpg"));
            _context.SaveChanges();

            Product product = new Product("Sandwich");
            List<Ingredient> ingredients = new List<Ingredient>() { new Ingredient("Lukanka", 1.2f, "test.jpg") };
            product.CalculatePrice(ingredients);

            _context.Products.Add(product);
            _context.SaveChanges();

            var test = _context.Ingredients.Where(b => b.Name == "Lukanka");
            var a = test.First();

            _context.ProductIngredients.Add(new ProductIngredients(product.Id, a.Id));
            _context.SaveChanges();*/
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            var user = customerManager.Find(tbUsername.Text, tbPassword.Text);
            if (user != null)
            {
                this.Hide();
                CustomerLobby customerLobby = new CustomerLobby();
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
            EmployeeLogin employeeLogin = new EmployeeLogin(_contextIdentity);
            employeeLogin.ShowDialog();
        }

        private void btnManagerLogin_Click(object sender, EventArgs e)
        {
            ManagerLogin managerLogin = new ManagerLogin(_contextIdentity);
            managerLogin.ShowDialog();
        }
    }

    
}
