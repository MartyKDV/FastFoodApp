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
        public EmployeeLogin(DatabaseContext _contextIdentity)
        {
            this._contextIdentity = _contextIdentity;
            InitializeComponent();
        }

        private void btnEmployeeLogin_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
