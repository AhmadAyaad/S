using System;
using System.Collections.Generic;

namespace Store.Models.EntityModels
{
    public class Brand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
