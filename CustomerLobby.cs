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
        DB db;
        public CustomerLobby(DB db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void CustomerLobby_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
