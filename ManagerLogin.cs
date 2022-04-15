using Microsoft.AspNet.Identity;
using MySqlConnector;
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
    public partial class ManagerLogin : Form
    {

        DatabaseContext _contextIdentity;
        DatabaseContextStandard _context;
        UserManager<Manager> userManager;
        UserManager<Employee> employeeManager;
        public ManagerLogin(DatabaseContext contextIdentity, DatabaseContextStandard context, UserManager<Manager> userManager, UserManager<Employee> employeeManager)
        {
            this._contextIdentity = contextIdentity;
            this._context = context;
            this.userManager = userManager;
            this.employeeManager = employeeManager;
            InitializeComponent();
        }

        private void btnManagerLogin_Click(object sender, EventArgs e)
        {
            var user = userManager.Find(tbManagerID.Text, tbManagerPassword.Text);
            if (user != null)
            {
                this.Hide();
                ManagerLobby managerLobby = new ManagerLobby(_contextIdentity, _context, userManager, employeeManager, user);
                managerLobby.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect ID or Password!");
            }

        }
    }
}
