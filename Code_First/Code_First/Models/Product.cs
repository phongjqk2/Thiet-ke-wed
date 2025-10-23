using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code_First.Models
{
    [Table(name: "Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public bool Name { get; set; }
        public bool Quantily { get; set; }
        public string Image { get; set; }
        
        public decimal Price { get; set; }
        public string Description { get; set; }
        
        public virtual ICollection<Category> Categories { get; set; }

    }
}
