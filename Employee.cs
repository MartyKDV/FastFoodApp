using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace FastFoodApp
{
    public partial class Employee : IdentityUser
    {
        [StringLength(200)]
        public string EmployeeFirstName { get; set; }

        [StringLength(200)]
        public string EmployeeLastName { get; set; }

        [StringLength(200)]
        public string EmployeeAddress { get; set; }

        public int EmployeeAge { get; set; }

        public float EmployeeWage { get; set; }

        [StringLength(9)]
        public string EmployeeSSN { get; set; }
    }
}

