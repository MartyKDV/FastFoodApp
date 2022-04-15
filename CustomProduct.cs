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
    public partial class CustomProduct : Form
    {
        private DatabaseContextStandard _context;
        private Product product;
        private CustomerLobby.Cart cart;
        public CustomProduct(DatabaseContextStandard context, CustomerLobby.Cart cart)
        {
            _context = context;
            product = new Product();
            product.Name = "Custom Product";
            product.Price = 0f;
            this.cart = cart;
            InitializeComponent();
        }
        private void addProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();

            foreach (var i in product.Ingredients)
            {
                _context.ProductIngredients.Add(new ProductIngredients(product.Id, i));
                _context.SaveChanges();
            }
        }
        private void addIngredient(Ingredient ingredient)
        {
            product.Ingredients.Add(ingredient.Id);
            product.Price += ingredient.Price;
            lblPrice.Text = product.Price.ToString();
        }
        private void removeIngredient(Ingredient ingredient)
        {
            product.Ingredients.Remove(ingredient.Id);
            product.Price -= ingredient.Price;
            lblPrice.Text = product.Price.ToString();
        }
        private void CustomProduct_Load(object sender, EventArgs e)
        {
            var query = _context.Ingredients;
            foreach(var i in query)
            {
                comboBoxIngredients.Items.Add(i.Name);
            }
            lblPrice.Text = product.Price.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ingredientName = comboBoxIngredients.SelectedItem.ToString();
            var ingredient = _context.Ingredients.Where(i => i.Name == ingredientName).First();
            if(!product.Ingredients.Exists(i => i == ingredient.Id))
            {
                addIngredient(ingredient);
                ListViewItem item = new ListViewItem(ingredientName);
                item.Name = ingredientName;
                viewIngredients.Items.Add(item);
                MessageBox.Show("Ingredient added.");
            }
            else
            {
                MessageBox.Show("Ingredient is already added.");
            }       
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string ingredientName = comboBoxIngredients.SelectedItem.ToString();
            var ingredient = _context.Ingredients.Where(i => i.Name == ingredientName).First();
            if(product.Ingredients.Exists(i => i == ingredient.Id))
            {
                removeIngredient(ingredient);
                ListViewItem it = viewIngredients.Items.Find(ingredientName, false).First();
                viewIngredients.Items.Remove(it);
                
                MessageBox.Show("Ingredient removed.");
            }
            else
            {
                MessageBox.Show("Ingredient is not found.");
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            product.Type = comboBoxType.SelectedItem.ToString();
            addProduct(product);
            cart.AddProduct(product.Id);
            MessageBox.Show("Product added to cart.");
            this.Close();
        }
    }
}
