using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace Assos.Services.ProductAPI.Model
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }
        [Range(1,1000)]
        public double Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }
        
    
    
    }


}
