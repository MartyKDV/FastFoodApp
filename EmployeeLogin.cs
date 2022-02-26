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
        DB db;
        public EmployeeLogin(DB db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void btnEmployeeLogin_Click(object sender, EventArgs e)
        {
            PasswordHashing hasher = new PasswordHashing();
            string savedPass;

            if (db.Open())
            {

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employees WHERE EmployeeId = '" + tbEmployeeID.Text + "';", db.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Read();
                if (dataReader.HasRows)
                {
                    savedPass = dataReader["Password"].ToString();
                    if (hasher.ComparePasswords(tbEmployeePassword.Text, savedPass))
                    {
                        MessageBox.Show("Success!");
                        // Account Authenticated
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password!");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Employee ID!");
                }

                dataReader.Close();
                db.Close();
            }
        }
    }
}
