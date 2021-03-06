using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastFoodApp
{
    public class OrderProducts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public OrderProducts()
        {

        }
        public OrderProducts(int orderId, int productId)
        {
            this.OrderId = orderId;
            this.ProductId = productId;
        }
    }
}
