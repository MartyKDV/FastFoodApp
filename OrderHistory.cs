using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodApp
{
    public class OrderHistory
    {
        [Key]
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public float TotalPrice { get; set; }
        public string EmployeeId { get; set; }
        public OrderHistory()
        {

        }
        public OrderHistory(int orderId, string customerId, string employeeId , float totalPrice)
        {
            this.Id = orderId;
            this.CustomerId = customerId;
            this.TotalPrice = totalPrice;
            this.EmployeeId = employeeId;
        }
    }
}
