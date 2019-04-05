using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace QuickKartCoreMVCApp.Models
{
    public class Products
    {
        public Nullable<byte> CategoryId { get; set; }
        
        [Required(ErrorMessage = "Price is mandatory.")]
        [DisplayName("Price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "ProductId is mandatory.")]
        [DisplayName("Product Id")]
        public string ProductId { get; set; }

        [Required(ErrorMessage = "ProductName is mandatory.")]
        [StringLength(maximumLength: int.MaxValue, MinimumLength=3)]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [Range(minimum:1,maximum: int.MaxValue)]
        [Required(ErrorMessage = "QuantityAvailable is mandatory.")]
        [DisplayName("Qunatity Available")]
        public int QuantityAvailable { get; set; }


    }
}
