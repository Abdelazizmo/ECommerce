using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Name Is Required")]
        [StringLength(20, ErrorMessage ="This {0} Is Specific Between {2},{1}", MinimumLength = 5)]
        [Display(Name="Category Name")]
        public String Name { get; set; }
        [Required(ErrorMessage = "Description Is Required")]
        public String Description { get; set; }

        //Navigational Property
        public ICollection<Product> Products { get; set; }
    }
}
