using ECommerce.Data.Base;
using ECommerce.Enums.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class Product :IBaseEntity
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public double Price { get; set; }
        public String ImagrURL { get; set; }
        public ProductColor ProductColor { get; set; }

        //Navigational Property
        public int CategoryId { get; set; }
        
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }

    }
}
