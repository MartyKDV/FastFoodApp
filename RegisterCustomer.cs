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
    public partial class RegisterCustomer : Form
    {
        DB db;
        public RegisterCustomer(DB db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            PasswordHashing hasher = new PasswordHashing();
            string hashedPass = hasher.HashPassword(tbPassword.Text);

            if (db.Open())
            {
                // Add Validation here ------
                MySqlCommand cmd = new MySqlCommand("INSERT INTO customers (Id, FirstName, LastName, UserName, Password) " +
                    "VALUES (NULL, '" + tbFirstName.Text + "', '" + tbLastName.Text + "', '" + tbUsername.Text + "', '" + hashedPass + "');", db.connection);
                
                cmd.ExecuteReader();

                MessageBox.Show("Account Successfully Registered!");

                db.Close();
            }

            //Form form = Application.OpenForms["Form1"];
            //form.Show();
            this.Close();

        }

        private void RegisterCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
           // Form form = Application.OpenForms["Form1"];
           // form.Show();
            this.Close();
        }
    }
}
