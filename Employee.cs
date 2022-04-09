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
        public string Address { get; set; }

        public int Age { get; set; }

        public float Wage { get; set; }

        [StringLength(9)]
        public string SSN { get; set; }
    }
}

