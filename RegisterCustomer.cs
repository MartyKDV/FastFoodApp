using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodApp
{
    public partial class RegisterCustomer : Form
    {
        UserManager<Customer> userManager;
        public RegisterCustomer(UserManager<Customer> userManager)
        {
            this.userManager = userManager;
            
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate
            string[] validationErrors = new string[5];
            string errors = "";
            validationErrors[0] = isFNValid(tbFirstName.Text);
            validationErrors[1] = isLNValid(tbLastName.Text);
            validationErrors[2] = isUNValid(tbUsername.Text);
            validationErrors[3] = isPasswordValid(tbPassword.Text);
            validationErrors[4] = isEmailValid(tbEmail.Text);

            foreach (var err in validationErrors)
            {
                if (err != "OK")
                {
                    errors += err + "\n";
                }
            }
            if (errors != "")
            {
                MessageBox.Show(errors, "Input Error!");
            }
            else
            {
                var user = new Customer()
                {
                    UserName = tbUsername.Text,
                    Email = tbEmail.Text,
                    FirstName = tbFirstName.Text,
                    LastName = tbLastName.Text
                };

                IdentityResult result = userManager.Create(user, tbPassword.Text);
                if (result.Succeeded)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show(result.Errors.FirstOrDefault());
                }

                this.Close();
            }  
        }
        private string isUNValid(string un)
        {
            if (un.Length == 0)
            {
                return "First Name Field Must Not be Empty!";
            }
            var user = userManager.Users.Where(u => u.UserName == un);
            if(user.Count() > 0)
            {
                return "Username is Already Taken!";
            }

            return "OK";
        }
        private string isFNValid(string fn)
        {
            if (fn.Length == 0)
            {
                return "First Name Field Must Not be Empty!";
            }

            return "OK";
        }
        private string isLNValid(string ln)
        {
            if (ln.Length == 0)
            {
                return "Last Name Field Must Not be Empty!";
            }

            return "OK";
        }

        private string isPasswordValid(string pass)
        {
            if (pass.Length == 0)
            {
                return "Password Field Must Not be Empty!";
            }
            if (pass.Length < 8)
            {
                return "Password Must be at Least 8 Characters Long!";
            }
            if (pass.Length > 16)
            {
                return "Password Must be Less Than 17 Characters!";
            }
            int numbersCount = 0;
            var includesSpecialChars = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            foreach (var c in pass)
            {
                if((int)c >= 48 && (int)c <= 57){
                    numbersCount++;
                }
            }
            if(numbersCount == 0)
            {
                return "Password Must Include at Least 1 Number!";
            }
            if (numbersCount == pass.Length)
            {
                return "Password Must Include at Least 1 Letter!";
            }
            if (!includesSpecialChars.IsMatch(pass))
            {
                return "Password Must Include at Least 1 Special Case Character!";
            }

            return "OK";
        }

        private string isEmailValid(string email)
        {

            try
            {
                MailAddress m = new MailAddress(email);
            }
            catch (FormatException)
            {
                return "Email Format is not Valid!";
            }

            return "OK";
        }

        private void RegisterCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {

            this.Close();
        }
    }
}
