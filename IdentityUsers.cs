using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
namespace FastFoodApp
{
    public class Customer : IdentityUser
    {
        public Customer(string fName, string lName, string uName, string pass)
        {
            UserName = uName;
            PasswordHash = pass;
            FirstName = fName;
            LastName = lName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class Employee : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public float Wage { get; set; }
        public string Position { get; set; }
        public string SSN { get; set; }

    }
    public class Manager : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public float Wage { get; set; }
        public string SSN { get; set; }
    }

}
