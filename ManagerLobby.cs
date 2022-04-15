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
        public ManagerLobby(DatabaseContext contextIdentity, DatabaseContextStandard context, UserManager<Manager> managerManager, UserManager<Employee> employeeManager, Manager user)
        {
            this._contextIdentity = contextIdentity;
            this._context = context;
            this.user = user;
            this.managerManager = managerManager;
            this.employeeManager = employeeManager;
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

                int k = 1;
                foreach (var i in managersQuery)
                {
                    EmployeeRowPanel eRP = new EmployeeRowPanel(i, 0, k * 24 + 20, flowLayoutPanelManageEmployees, new RemoveEmployeeButton());
                    eRP.removeEmployeeBtn.Click += new EventHandler(removeEmployeeButton_Click);              
                    k++;
                }
                foreach (var i in employeesQuery)
                {
                    EmployeeRowPanel eRP = new EmployeeRowPanel(i, 0, k * 24 + 20, flowLayoutPanelManageEmployees, new RemoveEmployeeButton());
                    eRP.removeEmployeeBtn.Click += new EventHandler(removeEmployeeButton_Click);
                    k++;
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
                MessageBox.Show("Employee Removed.");
            }
            else
            {
                var user = managerManager.FindById(rEBtn.managerId);
                managerManager.Delete(user);
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
    }
    public class EmployeeRowPanel
    {
        private int width = 400;
        private int height = 24;
        private int x = 20;
        private int y = 0;
        public ManagerLobby.RemoveEmployeeButton removeEmployeeBtn { get; set; }

        public EmployeeRowPanel()
        {

        }

        public EmployeeRowPanel(Manager manager, int xPos, int yPos, object sender, ManagerLobby.RemoveEmployeeButton button)
        {
            x += xPos;
            y += yPos;

            removeEmployeeBtn = button;
            removeEmployeeBtn.managerId = manager.Id;
            removeEmployeeBtn.Location = new Point(20 + width, 0);
            removeEmployeeBtn.Size = new Size(90, height);

            Label label = new Label();
            label.Text = manager.ManagerFirstName + " " + manager.ManagerLastName + " " + manager.UserName + " " + manager.ManagerAge + " " + "Manager";
            label.Location = new Point(0, 0);
            label.Size = new Size(width, height);
            label.TextAlign = ContentAlignment.MiddleCenter;

            FlowLayoutPanel panel = (sender as FlowLayoutPanel);
            Panel pane = new Panel();
            pane.Size = new Size(540, 24);
            pane.Location = new Point(x, y);
            pane.Controls.Add(label);
            pane.Controls.Add(removeEmployeeBtn);
            panel.Controls.Add(pane);
        }
        public EmployeeRowPanel(Employee employee, int xPos, int yPos, object sender, ManagerLobby.RemoveEmployeeButton button)
        {
            x += xPos;
            y += yPos;

            removeEmployeeBtn = button;
            removeEmployeeBtn.employeeId = employee.Id;
            removeEmployeeBtn.Location = new Point(20 + width, 0);
            removeEmployeeBtn.Size = new Size(90, height);

            Label label = new Label();
            label.Text = employee.EmployeeFirstName + " " + employee.EmployeeLastName + " " + employee.UserName + " " + employee.EmployeeAge + " " + "Employee";
            label.Location = new Point(0, 0);
            label.Size = new Size(width, height);
            label.TextAlign = ContentAlignment.MiddleCenter;

            FlowLayoutPanel panel = (sender as FlowLayoutPanel);
            Panel pane = new Panel();
            pane.Size = new Size(540, 24);
            pane.Location = new Point(x, y);
            pane.Controls.Add(label);
            pane.Controls.Add(removeEmployeeBtn);
            panel.Controls.Add(pane);
        }
    }
}
