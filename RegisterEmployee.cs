using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodApp
{
    public partial class RegisterEmployee : Form
    {
        private UserManager<Manager> managerManager;
        private UserManager<Employee> employeeManager;
        public string managerId = "";
        public string employeeId = "";
        public RegisterEmployee(UserManager<Manager> managerManager, UserManager<Employee> employeeManager)
        {
            this.managerManager = managerManager;
            this.employeeManager = employeeManager;
            InitializeComponent();
        }
       
        private string isSSNValid(string ssn)
        {
            if(ssn.Length == 0)
            {
                return "SSN Field Must Not be Empty!";
            }
            else
            {
                if (ssn.Length != 8)
                {
                    return "Incorrect SSN length!";
                }
                else
                {
                    foreach (var c in ssn)
                    {
                        if (!((int)c >= 48 && (int)c <= 57))
                        {
                            return "SSN Must Contain Numbers Only!";
                        }
                    }
                }
            }
      
            return "OK";
        }
        private string isAgeValid(string age)
        {
            if(age.Length == 0)
            {
                return "Age Field Must Not be Empty!";
            }
            else
            {
                foreach (var c in age)
                {
                    if (!((int)c >= 48 && (int)c <= 57))
                    {
                        return "Age Must Contain Numbers Only!";
                    }
                }
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
        private string isAddressValid(string address)
        {
            if (address.Length == 0)
            {
                return "Address Field Must Not be Empty!";
            }

            return "OK";
        }
        private string isWageValid(string wage)
        {

            if(wage.Length == 0)
            {
                return "Wage Field Must Not be Empty!";
            }
            else
            {
                int commaCount = 0;
                for(int i = 0; i < wage.Length; i++)
                {
                    if(wage[i] == ',')
                    {
                        if(commaCount > 0 || i == 0 || i == (wage.Length -1))
                        {
                            return "Wage Incorrect Value!";
                        }
                        else
                        {
                            commaCount++;
                        }
                    }
                    else
                    {
                        if(!((int)wage[i] >= 48 && (int)wage[i] <= 57))
                        {
                            return "Wage Must Contain Numbers Only!";
                        }
                    }
                    
                }
            }

            return "OK";
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            // Validate
            string[] validationErrors = new string[6];
            string errors = "";
            validationErrors[0] = isFNValid(tbFirstName.Text);
            validationErrors[1] = isLNValid(tbLastName.Text);
            validationErrors[2] = isAddressValid(tbAddress.Text);
            validationErrors[3] = isAgeValid(tbAge.Text);
            validationErrors[4] = isSSNValid(tbSSN.Text);
            validationErrors[5] = isWageValid(tbWage.Text);

            foreach(var err in validationErrors)
            {
                if(err != "OK")
                {
                    errors += err + "\n";
                }
            }
            if(errors != "")
            {
                MessageBox.Show(errors, "Input Error!");
            }
            else
            {
                string id = "";
                Random rnd = new Random();
                string numbers = rnd.Next(1000, 9999).ToString();
                switch (comboBoxPosition.SelectedItem.ToString())
                {
                    case "Manager":
                        {
                            id += tbFirstName.Text.ToString()[0];
                            id += tbFirstName.Text.ToString()[(tbFirstName.Text.Length - 1)];
                            id += tbLastName.Text.ToString()[0];
                            id += tbLastName.Text.ToString()[tbLastName.Text.Length - 1];
                            id += numbers;
                            string randomString = "";
                            for (int i = 0; i < 4; i++)
                            {
                                int r = rnd.Next(65, 123);
                                while (r > 90 && r < 97)
                                {
                                    r = rnd.Next(65, 123);
                                }
                                char randomChar = (char)r;
                                randomString += randomChar.ToString();
                            }
                            id += randomString;
                            Manager manager = new Manager()
                            {
                                UserName = id,
                                ManagerFirstName = tbFirstName.Text,
                                ManagerLastName = tbLastName.Text,
                                ManagerAddress = tbAddress.Text,
                                ManagerSSN = tbSSN.Text,
                                ManagerWage = float.Parse(tbWage.Text, CultureInfo.InvariantCulture),
                                ManagerAge = int.Parse(tbAge.Text)
                            };
                            string password = generatePassword();
                            managerManager.Create(manager, password);
                            MessageBox.Show("Manager added.\n" + id + "\n" + password);
                            managerId = manager.Id;
                        }
                        break;
                    case "Employee":
                        {
                            id += tbFirstName.Text.ToString()[0];
                            id += tbFirstName.Text.ToString()[(tbFirstName.Text.Length - 1)];
                            id += tbLastName.Text.ToString()[0];
                            id += tbLastName.Text.ToString()[tbLastName.Text.Length - 1];
                            id += numbers;
                            string randomString = "";
                            for (int i = 0; i < 4; i++)
                            {
                                int r = rnd.Next(65, 123);
                                while (r > 90 && r < 97)
                                {
                                    r = rnd.Next(65, 123);
                                }
                                char randomChar = (char)r;
                                randomString += randomChar.ToString();
                            }
                            id += randomString;
                            Employee employee = new Employee()
                            {
                                UserName = id,
                                EmployeeFirstName = tbFirstName.Text,
                                EmployeeLastName = tbLastName.Text,
                                EmployeeAddress = tbAddress.Text,
                                EmployeeSSN = tbSSN.Text,
                                EmployeeWage = float.Parse(tbWage.Text),
                                EmployeeAge = int.Parse(tbAge.Text)
                            };
                            string password = generatePassword();
                            employeeManager.Create(employee, password);
                            MessageBox.Show("Employee added.\n" + id + "\n" + password);
                            employeeId = employee.Id;
                        }
                        break;
                }
                this.Close();
            }
            
            
        }
        private string generatePassword()
        {
            string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()";
            string password = "";
            Random rnd = new Random();
            for (int i = 0; i < 8; i++)
            {
                int randomIndex = rnd.Next(0, allowedChars.Length);
                password += allowedChars[randomIndex];
            }

            return password;
        }
    }
}
