using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodApp
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public float TotalPrice { get; set; }

        public Order()
        {

        }
        public Order(string customerId, float totalPrice)
        {
            this.CustomerId = customerId;
            this.TotalPrice = totalPrice;
        }
    }
}
