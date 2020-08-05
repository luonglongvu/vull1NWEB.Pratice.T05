using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NWEB.Pratice.T05.Core.Model
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "The {0} must Category name is required.")]
        [StringLength(255, ErrorMessage = "The {0} must at lest {1} character and {2} character", MinimumLength = 3)]
        public string CategoryName { get; set; }
        [StringLength(1024, ErrorMessage = "The {0} must at lest {1} character and {2} character", MinimumLength = 3)]
        public string Description { get; set; }
        public virtual IList<Flower> Flowers { get; set; }
    }
}
