using System;
using System.Collections.Generic;

namespace Store.Models.EntityModels
{
    public class Product : BaseEntity
    {
        public Guid Id { get; set; }
        public string NameEN { get; set; }
        public string NameAR { get; set; }
        public string DescriptionEN { get; set; }
        public string DescriptionAR { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public bool IsBestSeller { get; set; }
        public Guid UnitId { get; set; }
        public virtual Unit Unit { get; set; }
        public Guid BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual ICollection<ProductProperty> ProductProperties { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
    }
}
