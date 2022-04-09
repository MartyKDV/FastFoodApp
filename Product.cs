using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodApp
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public float Price { get; set; }
        public string Type { get; set; }

        public Product()
        {

        }
        public Product(string type)
        {
            this.Type = type;
        }

        public void CalculatePrice(List<Ingredient> ingredients)
        {
            float total = 0f;
            foreach(var i in ingredients)
            {
                total += i.Price;
            }
            this.Price = total;
        }
    }
}
