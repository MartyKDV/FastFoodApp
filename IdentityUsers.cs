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
        public Person(string uName, string fName, string lName, string email)
        {
            UserName = uName;
            FirstName = fName;
            LastName = lName;
            Email = email;
        }
        /*public Person(string id, string fName, string lName, string email)
        {
            FirstName = fName;
            LastName = lName;
            Email = email;
            Id = id.ToString();
        }*/

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class Customerr : Person
    {
        public Customerr()
        {

        }
        public Customerr(string uName, string email, string fName, string lName) :
            base(uName, fName, lName, email)
        {           
        }
    }
    public class Employee : Person
    {
       /* public Employee()
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
        public string SSN { get; set; }*/

    }
    public class Manager : Employee
    {

    }

}
