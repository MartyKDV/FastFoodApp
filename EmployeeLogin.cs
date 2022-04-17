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
    public partial class EmployeeLogin : Form
    {
        DatabaseContext _contextIdentity;
        DatabaseContextStandard _context;
        UserManager<Employee> userManager;
        Form form;
        public EmployeeLogin(DatabaseContext contextIdentity, DatabaseContextStandard context, UserManager<Employee> userManager, Form form)
        {
            this._contextIdentity = contextIdentity;
            this._context = context;
            this.userManager = userManager;
            this.form = form;
            InitializeComponent();
        }

        private void btnEmployeeLogin_Click(object sender, EventArgs e)
        {
            var user = userManager.Find(tbEmployeeID.Text, tbEmployeePassword.Text);
            if (user != null)
            {
                this.Hide();
                form.Hide();
                EmployeeLobby employeeLobby = new EmployeeLobby(_contextIdentity, _context, userManager, user);
                employeeLobby.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect ID or Password!");
            }

        }
    }
}
