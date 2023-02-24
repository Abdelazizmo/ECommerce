using System;
using System.Collections.Generic;
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

        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }

        //Navigational Property
        public ICollection<Product> Products { get; set; }
    }
}
