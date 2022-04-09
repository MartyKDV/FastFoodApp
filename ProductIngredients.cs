using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodApp
{
    public class ProductIngredients
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int IngredientId { get; set; }
        public ProductIngredients(int productId, int ingredientId)
        {
            this.ProductId = productId;
            this.IngredientId = ingredientId;
        }
    }
}
