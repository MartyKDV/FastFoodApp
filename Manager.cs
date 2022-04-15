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
    public partial class Manager : IdentityUser
    {
        [StringLength(200)]
        public string ManagerFirstName { get; set; }

        [StringLength(200)]
        public string ManagerLastName { get; set; }

        [StringLength(200)]
        public string ManagerAddress { get; set; }

        public int ManagerAge { get; set; }

        public float ManagerWage { get; set; }

        [StringLength(9)]
        public string ManagerSSN { get; set; }
    }
}

