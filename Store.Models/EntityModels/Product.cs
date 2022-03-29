using System;
using System.Collections.Generic;

namespace Store.Models.EntityModels
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual ICollection<ProductProperty> ProductProperties { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
    }
}
