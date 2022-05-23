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
    public partial class ManagerLobby : Form
    {
        private DatabaseContext _contextIdentity;
        private DatabaseContextStandard _context;
        UserManager<Manager> managerManager;
        UserManager<Employee> employeeManager;
        private Manager user;
        private bool viewManageEmployeesInitialised = false;
        private bool viewRequestsInitialised = false;
        private bool viewOrderHistoryInitialised = false;
        private List<int> displayedRequests;
        private List<int> displayedOrderHistory;
        public ManagerLobby(DatabaseContext contextIdentity, DatabaseContextStandard context, UserManager<Manager> managerManager, UserManager<Employee> employeeManager, Manager user)
        {
            this._contextIdentity = contextIdentity;
            this._context = context;
            this.user = user;
            this.managerManager = managerManager;
            this.employeeManager = employeeManager;
            this.displayedRequests = new List<int>();
            this.displayedOrderHistory = new List<int>();
            InitializeComponent();
        }

        private void ManagerLobby_Load(object sender, EventArgs e)
        {

        }

        private void ManagerLobby_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void viewManageEmployees_Enter(object sender, EventArgs e)
        {
            if (!viewManageEmployeesInitialised)
            {

                var managersQuery = managerManager.Users;
                var employeesQuery = employeeManager.Users;

                foreach (var i in managersQuery)
                {
                    EmployeeRowPanel eRP = new EmployeeRowPanel(i, flowLayoutPanelManageEmployees, new RemoveEmployeeButton());
                    eRP.removeEmployeeBtn.Click += new EventHandler(removeEmployeeButton_Click);              
                }
                foreach (var i in employeesQuery)
                {
                    EmployeeRowPanel eRP = new EmployeeRowPanel(i, flowLayoutPanelManageEmployees, new RemoveEmployeeButton());
                    eRP.removeEmployeeBtn.Click += new EventHandler(removeEmployeeButton_Click);
                }
                viewManageEmployeesInitialised = true;
            }
        }
        public void removeEmployeeButton_Click(object sender, System.EventArgs e)
        {
            RemoveEmployeeButton rEBtn = (sender as RemoveEmployeeButton);
            if(rEBtn.employeeId != "")
            {
                var user = employeeManager.FindById(rEBtn.employeeId);
                employeeManager.Delete(user);

                var panels = flowLayoutPanelManageEmployees.Controls.OfType<Panel>();
                foreach(var i in panels)
                {
                    var button = i.Controls.OfType<RemoveEmployeeButton>();
                    if(button.First().employeeId == rEBtn.employeeId)
                    {
                        flowLayoutPanelManageEmployees.Controls.Remove(i);
                    }
                }
              
                MessageBox.Show("Employee Removed.");
            }
            else
            {
                var user = managerManager.FindById(rEBtn.managerId);
                managerManager.Delete(user);

                var panels = flowLayoutPanelManageEmployees.Controls.OfType<Panel>();
                foreach (var i in panels)
                {
                    var button = i.Controls.OfType<RemoveEmployeeButton>();
                    if (button.First().managerId == rEBtn.managerId)
                    {
                        flowLayoutPanelManageEmployees.Controls.Remove(i);
                    }
                }

                MessageBox.Show("Manager Removed.");
            }        
        }
        public class RemoveEmployeeButton : Button
        {
            public string employeeId { get; set; } = "";
            public string managerId { get; set; } = "";
            public RemoveEmployeeButton() : base()
            {
                this.Text = "Remove";
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            RegisterEmployee registerEmployee = new RegisterEmployee(managerManager, employeeManager);
            registerEmployee.ShowDialog();
            if(registerEmployee.managerId != "")
            {
                var manager = managerManager.Users.Where(m => m.Id == registerEmployee.managerId).First();
                EmployeeRowPanel eRP = new EmployeeRowPanel(manager, flowLayoutPanelManageEmployees, new RemoveEmployeeButton());
                eRP.removeEmployeeBtn.Click += new EventHandler(removeEmployeeButton_Click);
            }
            else
            {
                if(registerEmployee.employeeId != "")
                {
                    var employee = employeeManager.Users.Where(em => em.Id == registerEmployee.employeeId).First();
                    EmployeeRowPanel eRP = new EmployeeRowPanel(employee, flowLayoutPanelManageEmployees, new RemoveEmployeeButton());
                    eRP.removeEmployeeBtn.Click += new EventHandler(removeEmployeeButton_Click);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var requests = _context.RestockRequests;
            foreach (var r in requests)
            {
                if (!displayedRequests.Contains(r.Id))
                {
                    displayedRequests.Add(r.Id);
                    var employee = _contextIdentity.Employees.Where(em => em.Id == r.EmployeeId).First();
                    var ingredient = _context.Ingredients.Where(i => i.Id == r.IngredientId).First();
                    int rowIndex = dataGridViewRestock.Rows.Add(employee.EmployeeFirstName, employee.EmployeeLastName, ingredient.Name, ingredient.Quantity, new Button(), new Button());
                    dataGridViewRestock.Rows[rowIndex].Tag = r.Id;
                }
            }
        }

        private void tabPageViewRequests_Enter(object sender, EventArgs e)
        {
            if (!viewRequestsInitialised)
            {
                var requests = _context.RestockRequests;
                foreach (var r in requests)
                {
                    displayedRequests.Add(r.Id);
                    var employee = _contextIdentity.Employees.Where(em => em.Id == r.EmployeeId).First();
                    var ingredient = _context.Ingredients.Where(i => i.Id == r.IngredientId).First();
                    int rowIndex = dataGridViewRestock.Rows.Add(employee.EmployeeFirstName, employee.EmployeeLastName,
                        ingredient.Name, ingredient.Quantity, new Button(), new Button());
                    dataGridViewRestock.Rows[rowIndex].Tag = r.Id;
                }
                viewRequestsInitialised = true;
            }
            else
            {
                var requests = _context.RestockRequests;
                foreach(var r in requests)
                {
                    if (!displayedRequests.Contains(r.Id))
                    {
                        displayedRequests.Add(r.Id);
                        var employee = _contextIdentity.Employees.Where(em => em.Id == r.EmployeeId).First();
                        var ingredient = _context.Ingredients.Where(i => i.Id == r.IngredientId).First();
                        int rowIndex = dataGridViewRestock.Rows.Add(employee.EmployeeFirstName, employee.EmployeeLastName,
                            ingredient.Name, ingredient.Quantity, new Button(), new Button());
                        dataGridViewRestock.Rows[rowIndex].Tag = r.Id;
                    }
                }
            }
            
        }

        private void dataGridViewRestock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewRestock.Columns[columnButton.Index].Index)
            {
                var requestId = (int)dataGridViewRestock.Rows[e.RowIndex].Tag;
                var request = _context.RestockRequests.Where(r => r.Id == requestId).First();

                var ingredient = _context.Ingredients.Where(i => i.Id == request.IngredientId).First();
                ingredient.Quantity = 50;
                _context.SaveChanges();

                _context.RestockRequests.Remove(request);
                _context.SaveChanges();

                displayedRequests.Remove(requestId);
                dataGridViewRestock.Rows.RemoveAt(e.RowIndex);
            }
            if (e.ColumnIndex == dataGridViewRestock.Columns[columnButtonDismiss.Index].Index)
            {
                var requestId = (int)dataGridViewRestock.Rows[e.RowIndex].Tag;
                var request = _context.RestockRequests.Where(r => r.Id == requestId).First();

                _context.RestockRequests.Remove(request);
                _context.SaveChanges();

                displayedRequests.Remove(requestId);
                dataGridViewRestock.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void tabPageOrderHistory_Enter(object sender, EventArgs e)
        {
            if (!viewOrderHistoryInitialised)
            {
                var history = _context.OrderHistory;
                foreach (var h in history)
                {
                    displayedOrderHistory.Add(h.Id);
                    var employee = _contextIdentity.Employees.Where(em => em.Id == h.EmployeeId).First();
                    var customer = _contextIdentity.Customers.Where(c => c.Id == h.CustomerId).First();
                    var productsQuery = _context.OrderProducts.Where(op => op.OrderId == h.Id);
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
                    int rowIndex = dataGridViewOrderHistory.Rows.Add(customer.FirstName + " " + customer.LastName, order, h.TotalPrice, employee.EmployeeFirstName + " " + employee.EmployeeLastName);
                }
                viewOrderHistoryInitialised = true;
            }
            else
            {
                var history = _context.OrderHistory;
                foreach (var h in history)
                {
                    if (!displayedOrderHistory.Contains(h.Id))
                    {
                        displayedOrderHistory.Add(h.Id);
                        var employee = _contextIdentity.Employees.Where(em => em.Id == h.EmployeeId).First();
                        var customer = _contextIdentity.Customers.Where(c => c.Id == h.CustomerId).First();
                        var productsQuery = _context.OrderProducts.Where(op => op.OrderId == h.Id);
                        string[] products = new string[productsQuery.Count()];
                        int productIndex = 0;
                        foreach(var pq in productsQuery)
                        {
                            var product = _context.Products.Where(p => p.Id == pq.ProductId).First();
                            if (product.Name == "Custom Product")
                            {
                                var ingredientsQuery = _context.ProductIngredients.Where(pi => pi.ProductId == product.Id);
                                string[] ingredients = new string[ingredientsQuery.Count()];
                                int ingredientIndex = 0;
                                foreach(var iq in ingredientsQuery)
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
                        int rowIndex = dataGridViewOrderHistory.Rows.Add(customer.FirstName + " " + customer.LastName, order, h.TotalPrice, employee.EmployeeFirstName + " " + employee.EmployeeLastName);
                    } 
                }
            }
        }
    }
    public class EmployeeRowPanel
    {
        private int width = 400;
        private int height = 24;
        public ManagerLobby.RemoveEmployeeButton removeEmployeeBtn { get; set; }

        public EmployeeRowPanel()
        {

        }

        public EmployeeRowPanel(Manager manager, object sender, ManagerLobby.RemoveEmployeeButton button)
        {
            removeEmployeeBtn = button;
            removeEmployeeBtn.managerId = manager.Id;
            removeEmployeeBtn.Location = new Point(20 + width, 0);
            removeEmployeeBtn.Size = new Size(90, height);

            Label labelFN = new Label();
            Label labelLN = new Label();
            Label labelUN = new Label();
            Label labelAge = new Label();
            Label labelPos = new Label();

            labelFN.Text = manager.ManagerFirstName;
            labelFN.Location = new Point(0, 0);
            labelFN.Size = new Size(80, height);
            labelFN.Margin = new Padding(0);
            labelFN.TextAlign = ContentAlignment.MiddleCenter;

            labelLN.Text = manager.ManagerLastName;
            labelLN.Location = new Point(80, 0);
            labelLN.Size = new Size(80, height);
            labelLN.Margin = new Padding(0);
            labelLN.TextAlign = ContentAlignment.MiddleCenter;

            labelUN.Text = manager.UserName;
            labelUN.Location = new Point(160, 0);
            labelUN.Size = new Size(100, height);
            labelUN.Margin = new Padding(0);
            labelUN.TextAlign = ContentAlignment.MiddleCenter;

            labelAge.Text = manager.ManagerAge.ToString();
            labelAge.Location = new Point(240, 0);
            labelAge.Size = new Size(80, height);
            labelAge.Margin = new Padding(0);
            labelAge.TextAlign = ContentAlignment.MiddleCenter;

            labelPos.Text = "Manager";
            labelPos.Location = new Point(320, 0);
            labelPos.Size = new Size(80, height);
            labelPos.Margin = new Padding(0);
            labelPos.TextAlign = ContentAlignment.MiddleCenter;

            FlowLayoutPanel panel = (sender as FlowLayoutPanel);
            Panel pane = new Panel();
            pane.Size = new Size(540, 24);
            pane.Location = new Point(0, 0);
            pane.Controls.Add(labelFN);
            pane.Controls.Add(labelLN);
            pane.Controls.Add(labelUN);
            pane.Controls.Add(labelAge);
            pane.Controls.Add(labelPos);
            pane.Controls.Add(removeEmployeeBtn);
            panel.Controls.Add(pane);
        }
        public EmployeeRowPanel(Employee employee, object sender, ManagerLobby.RemoveEmployeeButton button)
        {

            removeEmployeeBtn = button;
            removeEmployeeBtn.employeeId = employee.Id;
            removeEmployeeBtn.Location = new Point(20 + width, 0);
            removeEmployeeBtn.Size = new Size(90, height);

            Label labelFN = new Label();
            Label labelLN = new Label();
            Label labelUN = new Label();
            Label labelAge = new Label();
            Label labelPos = new Label();

            labelFN.Text = employee.EmployeeFirstName;
            labelFN.Location = new Point(0, 0);
            labelFN.Size = new Size(80, height);
            labelFN.Margin = new Padding(0);
            labelFN.TextAlign = ContentAlignment.MiddleCenter;

            labelLN.Text = employee.EmployeeLastName;
            labelLN.Location = new Point(80, 0);
            labelLN.Size = new Size(80, height);
            labelLN.Margin = new Padding(0);
            labelLN.TextAlign = ContentAlignment.MiddleCenter;

            labelUN.Text = employee.UserName;
            labelUN.Location = new Point(160, 0);
            labelUN.Size = new Size(100, height);
            labelUN.Margin = new Padding(0);
            labelUN.TextAlign = ContentAlignment.MiddleCenter;

            labelAge.Text = employee.EmployeeAge.ToString();
            labelAge.Location = new Point(240, 0);
            labelAge.Size = new Size(80, height);
            labelAge.Margin = new Padding(0);
            labelAge.TextAlign = ContentAlignment.MiddleCenter;

            labelPos.Text = "Employee";
            labelPos.Location = new Point(320, 0);
            labelPos.Size = new Size(80, height);
            labelPos.Margin = new Padding(0);
            labelPos.TextAlign = ContentAlignment.MiddleCenter;

            FlowLayoutPanel panel = (sender as FlowLayoutPanel);
            Panel pane = new Panel();
            pane.Size = new Size(540, 24);
            pane.Location = new Point(0, 0);
            pane.Controls.Add(labelFN);
            pane.Controls.Add(labelLN);
            pane.Controls.Add(labelUN);
            pane.Controls.Add(labelAge);
            pane.Controls.Add(labelPos);
            pane.Controls.Add(removeEmployeeBtn);
            panel.Controls.Add(pane);
        }
    }
}
