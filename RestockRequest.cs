using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodApp
{
    public class RestockRequest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public int IngredientId { get; set; }
        public int Quantity { get; set; }

        public RestockRequest()
        {

        }
        public RestockRequest(string employeeId, int ingredientId, int quantity)
        {
            this.EmployeeId = employeeId;
            this.IngredientId = ingredientId;
            this.Quantity = quantity;
        }
    }
}
