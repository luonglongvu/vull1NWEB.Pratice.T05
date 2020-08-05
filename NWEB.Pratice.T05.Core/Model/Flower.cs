using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NWEB.Pratice.T05.Core.Model
{
    public class Flower
    {
        public int FlowerId { get; set; }
        [Required(ErrorMessage = "The {0} must Category name is required.")]
        [StringLength(255, ErrorMessage = "The {0} must at lest {1} character and {2} character", MinimumLength = 3)]
        public string FlowerName { get; set; }
        [StringLength(255, ErrorMessage = "The {0} must at lest {1} character and {2} character", MinimumLength = 3)]
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public decimal SalePrice { get; set; }
        public DateTime? StoreDate { get; set; }
        public int StoreInventory { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}
