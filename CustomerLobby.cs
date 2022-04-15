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
    public partial class CustomerLobby : Form
    {
        private Customer user;
        public Cart userCart;
        private DatabaseContextStandard _context;
        private bool viewOrderInitialised = false;
        public CustomerLobby(DatabaseContextStandard _context, Customer user)
        {
            this._context = _context;
            this.user = user;
            userCart = new Cart(user.Id, this._context);
            InitializeComponent();
        }

        private void CustomerLobby_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CustomerLobby_Load(object sender, EventArgs e)
        {
            List<Product> productsList = new List<Product>();
            //var productsQuery = _context.Products.Take(_context.Products.Count());
            var productsQuery = _context.Products.Where(p => p.Name != "Custom Product");
            foreach (var i in productsQuery)
            {
                productsList.Add(i);
            }

            List<ListViewItem> items = new List<ListViewItem>();
            foreach (var i in productsList)
            {
                string[] array = new string[2];
                array[0] = i.Name;
                string ingredients = "";

                var productIngredientsQuery = _context.ProductIngredients.Where(b => b.ProductId == i.Id);

                if (productIngredientsQuery.Count() > 0)
                {
                    int element = 0;
                    foreach (var j in productIngredientsQuery)
                    {
                        element++;
                        if (element == productIngredientsQuery.Count())
                        {
                            ingredients += _context.Ingredients.Where(b => b.Id == j.IngredientId).First().Name;
                        }
                        else
                        {
                            ingredients += _context.Ingredients.Where(b => b.Id == j.IngredientId).First().Name + ", ";
                        }
                    }
                }

                array[1] = ingredients;
                items.Add(new ListViewItem(array));
            }
            foreach (var i in items)
            {
                listViewProducts.Items.Add(i);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void viewOrder_Enter(object sender, EventArgs e)
        {
            if (!viewOrderInitialised)
            {

                var productsQuery = _context.Products.Where(p => p.Name != "Custom Product");
                int j = 1, k = 1;
                foreach (var i in productsQuery)
                {
                    OrderProduct oP = new OrderProduct(i.Id, i.Name, j * 140 + 20, k * 24 + 20, flowLayoutOrders, new OrderButton());
                    oP.orderButton.Click += new EventHandler(orderButton_Click);
                    if (j % 5 == 0 && j > 0)
                    {
                        k++;
                    }
                    j++;
                    
                }
                viewOrderInitialised = true;
            }
        }

        private void viewProducts_Enter(object sender, EventArgs e)
        {
            
            
        }
        public class Cart
        {
            private DatabaseContextStandard _context;

            public List<int> Products { get; set; }
            public float TotalPrice { get; set; }

            public string userId { get; set; }

            public Cart(string userId, DatabaseContextStandard con)
            {
                _context = con;
                Products = new List<int>();
                this.userId = userId;
                TotalPrice = 0f;
            }
            public void AddProduct(int id)
            {
                Products.Add(id);
                TotalPrice += _context.Products.Where(p => p.Id == id).First().Price;
            }

        }

        public void orderButton_Click(object sender, System.EventArgs e)
        {
            OrderButton oBtn = (sender as OrderButton);
            userCart.AddProduct(oBtn.ProductId);
            MessageBox.Show("Product Added to Cart.");
        }
        public class OrderButton : Button
        {
            public int ProductId { get; set; }
            public OrderButton() : base()
            {
                this.Text = "Add";
            }
        }


        private void btnCart_Click(object sender, EventArgs e)
        {
            string productList = "";
            foreach(var i in userCart.Products)
            {
                productList += i.ToString() + "\n";
            }
            if(productList == "")
            {
                MessageBox.Show("Empty.");
            }
            else
            {
                MessageBox.Show(productList);
            }        
        }

        private void btnEmptyCart_Click(object sender, EventArgs e)
        {
            userCart.Products.Clear();
            userCart.TotalPrice = 0f;
            MessageBox.Show("Cart Emptied.");
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order(userCart.userId, userCart.TotalPrice);
            _context.Orders.Add(order);
            _context.SaveChanges();

            foreach (var p in userCart.Products)
            {
                OrderProducts oP = new OrderProducts(order.Id, p);
                _context.OrderProducts.Add(oP);
                _context.SaveChanges();           
            }

            MessageBox.Show("Order placed successfully!");
        }

        private void btnAddCustom_Click(object sender, EventArgs e)
        {
            CustomProduct customProductForm = new CustomProduct(_context, userCart);
            customProductForm.ShowDialog();
        }
    }




    public class OrderProduct
    {
        private int width = 100;
        private int height = 24;
        private int x;
        private int y;
        public CustomerLobby.OrderButton orderButton { get; set; }

        public OrderProduct()
        {

        }
        
        public OrderProduct(int productId, string name, int xPos, int yPos, object sender, CustomerLobby.OrderButton button)
        {
            x = xPos;
            y = yPos;

            orderButton = button;
            orderButton.ProductId = productId;
            orderButton.Location = new Point(0 + width, 0);
            orderButton.Size = new Size(40, height);

            Label label = new Label();
            label.Text = name;
            label.Location = new Point(0, 0);
            label.Size = new Size(width, height);
            label.TextAlign = ContentAlignment.MiddleCenter;

            FlowLayoutPanel panel = (sender as FlowLayoutPanel);
            Panel pane = new Panel();
            pane.Size = new Size(140, 24);
            pane.Location = new Point(x, y);
            pane.Controls.Add(label);
            pane.Controls.Add(orderButton);
            panel.Controls.Add(pane);
        }
    }
}

