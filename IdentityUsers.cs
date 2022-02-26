using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
namespace FastFoodApp
{
    public class Person : IdentityUser
    {
        public Person()
        {

        }
        public Person(int id, string fName, string lName, string email, string pass)
        {
            PasswordHash = pass;
            FirstName = fName;
            LastName = lName;
            Email = email;
            Id = id.ToString();
        }
        public Person(string id, string fName, string lName, string email, string pass)
        {
            PasswordHash = pass;
            FirstName = fName;
            LastName = lName;
            Email = email;
            Id = id.ToString();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class Customer : Person
    {
        public Customer()
        {

        }
        public Customer(int id, string fName, string lName, string email, string uName, string pass) :
            base(id, fName, lName, email, pass)
        {           
            UserName = uName;
        }
    }
    public class Employee : Person
    {
        public Employee()
        {

        }
        public Employee(string employeeId, string fname, string lName, string email, string pass,
            string address, int age, float wage, string ssn) :
                base(employeeId, fname, lName, email, pass)
        {
            Address = address;
            Age = age;
            Wage = wage;
            SSN = ssn;
        }
        public string Address { get; set; }
        public int Age { get; set; }
        public float Wage { get; set; }
        public string SSN { get; set; }

    }
    public class Manager : Employee
    {

    }

}
