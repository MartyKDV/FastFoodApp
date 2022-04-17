using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodApp
{
    public partial class EmployeeLobby : Form
    {
        private DatabaseContext _contextIdentity;
        private DatabaseContextStandard _context;
        UserManager<Employee> employeeManager;
        private Employee user;
        private bool ingredientsViewInitialised = false;
        private List<int> displayedOrders;
        public EmployeeLobby(DatabaseContext _contextIdentity, DatabaseContextStandard _context, UserManager<Employee> employeeManager, Employee user)
        {
            this._contextIdentity = _contextIdentity;
            this._context = _context;
            this.employeeManager = employeeManager;
            this.user = user;
            displayedOrders = new List<int>();
            InitializeComponent();
        }

        private void EmployeeLobby_Load(object sender, EventArgs e)
        {

            // Initialise order view grid
            DataGridView grid = dataGridViewOrders;
            var orders = _context.Orders;
            foreach (var o in orders)
            {
                displayedOrders.Add(o.Id);
                CompleteOrderButton btn = new CompleteOrderButton();
                btn.employeeId = user.Id;
                btn.orderId = o.Id;
                btn.Size = new Size(70, 24);
                var customer = _contextIdentity.Customers.Where(c => c.Id == o.CustomerId).First();
                var productsQuery = _context.OrderProducts.Where(op => op.OrderId == o.Id);
                string[] products = new string[productsQuery.Count()];
                int productIndex = 0;
                foreach (var pq in productsQuery)
                {
                    var product = _context.Products.Where(p => p.Id == pq.ProductId).First();
                    if (product.Name == "Custom Product")
                    {
                        var ingredientsQuery = _context.ProductIngredients.Where(pi => pi.ProductId == product.Id);
                        string[] ingredients = new string[ingredientsQuery.Count()];
                        int ingredientIndex = 0;
                        foreach (var iq in ingredientsQuery)
                        {
                            var ingredient = _context.Ingredients.Where(ing => ing.Id == iq.IngredientId).First();
                            ingredients[ingredientIndex] = ingredient.Name;
                            ingredientIndex++;
                        }
                        products[productIndex] = "Custom Product (";
                        products[productIndex] += string.Join(", ", ingredients);
                        products[productIndex] += ")";
                    }
                    else
                    {
                        products[productIndex] = product.Name;
                    }
                    productIndex++;
                }
                string order = string.Join(", ", products);
                btn.rowIndex = grid.Rows.Add(customer.FirstName, customer.LastName, order, o.TotalPrice.ToString(), btn);
                grid.Rows[btn.rowIndex].Tag = btn.orderId;
                btn.Click += new EventHandler(completeOrderButton_Click);
            }
        }
        public class CompleteOrderButton : Button
        {
            public int orderId { get; set; }
            public string employeeId { get; set; } = "";
            public int rowIndex { get; set; }
            public CompleteOrderButton() : base()
            {
                this.Text = "Complete";
            }
        }
        public void completeOrderButton_Click(object sender, System.EventArgs e)
        {
            CompleteOrderButton cOBtn = (sender as CompleteOrderButton);
            MessageBox.Show("Clicked.");         
        }

        private void viewOrders_Enter(object sender, EventArgs e)
        {
            var orders = _context.Orders;
            foreach(var o in orders)
            {
                if (!displayedOrders.Contains(o.Id))
                {
                    displayedOrders.Add(o.Id);
                    CompleteOrderButton btn = new CompleteOrderButton();
                    btn.employeeId = user.Id;
                    btn.orderId = o.Id;
                    btn.Size = new Size(70, 24);
                    var customer = _contextIdentity.Customers.Where(c => c.Id == o.CustomerId).First();
                    var productsQuery = _context.OrderProducts.Where(op => op.OrderId == o.Id);
                    string[] products = new string[productsQuery.Count()];
                    int productIndex = 0;
                    foreach (var pq in productsQuery)
                    {
                        var product = _context.Products.Where(p => p.Id == pq.ProductId).First();
                        if (product.Name == "Custom Product")
                        {
                            var ingredientsQuery = _context.ProductIngredients.Where(pi => pi.ProductId == product.Id);
                            string[] ingredients = new string[ingredientsQuery.Count()];
                            int ingredientIndex = 0;
                            foreach (var iq in ingredientsQuery)
                            {
                                var ingredient = _context.Ingredients.Where(ing => ing.Id == iq.IngredientId).First();
                                ingredients[ingredientIndex] = ingredient.Name;
                                ingredientIndex++;
                            }
                            products[productIndex] = "Custom Product (";
                            products[productIndex] += string.Join(", ", ingredients);
                            products[productIndex] += ")";
                        }
                        else
                        {
                            products[productIndex] = product.Name;
                        }
                        productIndex++;
                    }
                    string order = string.Join(", ", products);
                    btn.rowIndex = dataGridViewOrders.Rows.Add(customer.FirstName, customer.LastName, order, o.TotalPrice.ToString(), btn);
                    dataGridViewOrders.Rows[btn.rowIndex].Tag = btn.orderId;
                    btn.Click += new EventHandler(completeOrderButton_Click);
                }
            }
        }

        private void EmployeeLobby_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataGridViewOrders.Columns[columnButton.Index].Index)
            {

                var orderId = (int)dataGridViewOrders.Rows[e.RowIndex].Tag;
                var productsQuery = _context.OrderProducts.Where(op => op.OrderId == orderId);

                Dictionary<int, int> ingredients = new Dictionary<int, int>();
                foreach (var op in productsQuery.ToList())
                {
                    var product = _context.Products.Where(p => p.Id == op.ProductId).First();
                    var ingredientQuery = _context.ProductIngredients.Where(pi => pi.ProductId == product.Id);
                    foreach (var pi in ingredientQuery.ToList())
                    {
                        var ingredient = _context.Ingredients.Where(i => i.Id == pi.IngredientId).First();
                        if (!ingredients.ContainsKey(ingredient.Id))
                        {
                            ingredients[ingredient.Id] = 1;
                        }
                        else
                        {
                            ingredients[ingredient.Id] += 1;
                        }

                    }
                }

                string message = "";
                bool ableToMakeIt = true;
                List<Ingredient> ingredients1 = new List<Ingredient>();
                foreach (var i in ingredients)
                {
                    var ingredient = _context.Ingredients.Where(ing => ing.Id == i.Key).First();
                    ingredients1.Add(ingredient);
                    if(ingredient.Quantity < i.Value)
                    {
                        message += "Not Enough " + ingredient.Name + "!\n";
                        ableToMakeIt = false;
                    }
                }
                if (ableToMakeIt)
                {
                    foreach (var i in ingredients1.ToList())
                    {
                        i.Quantity -= ingredients[i.Id];
                        _context.SaveChanges();
                    }
                        
                    listViewIngredients.Items.Clear();
                    ingredientsViewInitialised = false;
                    var order = _context.Orders.Where(o => o.Id == orderId).First();
                    OrderHistory orderHistory = new OrderHistory(order.Id, order.CustomerId, user.Id, order.TotalPrice);
                    _context.OrderHistory.Add(orderHistory);
                    _context.SaveChanges();

                    _context.Orders.Remove(order);
                    _context.SaveChanges();
                    displayedOrders.Remove(orderId);
                    dataGridViewOrders.Rows.RemoveAt(e.RowIndex);
                }
                else
                {
                    MessageBox.Show(message);
                }
                     
            }
        }

        private void viewIngredients_Enter(object sender, EventArgs e)
        {
            if (!ingredientsViewInitialised)
            {
                var ingredientsQuery = _context.Ingredients;
                List<ListViewItem> items = new List<ListViewItem>();
                foreach (var i in ingredientsQuery)
                {
                    string[] array = new string[3];
                    array[0] = i.Name;
                    array[1] = i.Quantity.ToString();
                    items.Add(new ListViewItem(array));
                    comboBoxRestock.Items.Add(i.Name);
                }
                foreach (var i in items)
                {
                    listViewIngredients.Items.Add(i);
                }
                ingredientsViewInitialised = true;
            }          
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var orders = _context.Orders;
            foreach (var o in orders)
            {
                if (!displayedOrders.Contains(o.Id))
                {
                    displayedOrders.Add(o.Id);
                    CompleteOrderButton btn = new CompleteOrderButton();
                    btn.employeeId = user.Id;
                    btn.orderId = o.Id;
                    btn.Size = new Size(70, 24);
                    var customer = _contextIdentity.Customers.Where(c => c.Id == o.CustomerId).First();
                    var productsQuery = _context.OrderProducts.Where(op => op.OrderId == o.Id);
                    string[] products = new string[productsQuery.Count()];
                    int productIndex = 0;
                    foreach (var pq in productsQuery)
                    {
                        var product = _context.Products.Where(p => p.Id == pq.ProductId).First();
                        if (product.Name == "Custom Product")
                        {
                            var ingredientsQuery = _context.ProductIngredients.Where(pi => pi.ProductId == product.Id);
                            string[] ingredients = new string[ingredientsQuery.Count()];
                            int ingredientIndex = 0;
                            foreach (var iq in ingredientsQuery)
                            {
                                var ingredient = _context.Ingredients.Where(ing => ing.Id == iq.IngredientId).First();
                                ingredients[ingredientIndex] = ingredient.Name;
                                ingredientIndex++;
                            }
                            products[productIndex] = "Custom Product (";
                            products[productIndex] += string.Join(", ", ingredients);
                            products[productIndex] += ")";
                        }
                        else
                        {
                            products[productIndex] = product.Name;
                        }
                        productIndex++;
                    }
                    string order = string.Join(", ", products);
                    btn.rowIndex = dataGridViewOrders.Rows.Add(customer.FirstName, customer.LastName, order, o.TotalPrice.ToString(), btn);
                    dataGridViewOrders.Rows[btn.rowIndex].Tag = btn.orderId;
                    btn.Click += new EventHandler(completeOrderButton_Click);
                }
            }
        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            var item = comboBoxRestock.SelectedItem;
            if (item == null)
            {
                MessageBox.Show("Ingredient not Selected!");
            }
            else
            {
                var ingredient = _context.Ingredients.Where(i => i.Name == item.ToString()).First();
                var requestExists = _context.RestockRequests.Where(rr => rr.IngredientId == ingredient.Id);
                if (requestExists.Count() == 0)
                {
                    RestockRequest restockRequest = new RestockRequest(user.Id, ingredient.Id, ingredient.Quantity);
                    _context.RestockRequests.Add(restockRequest);
                    _context.SaveChanges();
                    MessageBox.Show("Restock Request Sent.");
                }
                else
                {
                    MessageBox.Show("There is Already a Request For This Ingredient!");
                }
            }
        }
    }
}
