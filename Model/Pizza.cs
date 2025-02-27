using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaApp.Model
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        [Column(TypeName = "decimal(10,2)")]  
        public decimal Price { get; set; }
    }
}
