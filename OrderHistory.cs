using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodApp
{
    public class OrderHistory
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public float TotalPrice { get; set; }
        public OrderHistory()
        {

        }
        public OrderHistory(int orderId, string customerId, float totalPrice)
        {
            this.Id = orderId;
            this.CustomerId = customerId;
            this.TotalPrice = totalPrice;
        }
    }
}
