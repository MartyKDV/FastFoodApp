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
        public string Name { get; set; }
        public float Price { get; set; } = 0;
        public string Type { get; set; }
        public List<int> Ingredients { get; set; }

        public Product()
        {
            Ingredients = new List<int>();
        }
        public Product(string type)
        {
            Ingredients = new List<int>();
            this.Type = type;
        }
        public Product(string type, string name)
        {
            Ingredients = new List<int>();
            this.Type = type;
            this.Name = name;
        }
        public Product(string type, string name, List<int> ingredients)
        {
            this.Type = type;
            this.Name = name;
            this.Ingredients = ingredients;

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
