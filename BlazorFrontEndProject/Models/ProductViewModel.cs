using System.ComponentModel.DataAnnotations;

namespace BlazorFrontEndProject.Models
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Product Name is required.")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Quantity Per Unit is required.")]
        public string QuantityPerUnit { get; set; }
        [Required(ErrorMessage = "Unit Price is required.")]
        public decimal UnitPrice { get; set; }
        [Required(ErrorMessage = "Units In Stock is required.")]
        [Range(0,1000)]
        public int UnitsInStock { get; set; }
    }
}
