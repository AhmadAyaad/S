using System;
using System.Collections.Generic;

namespace Store.Common.DTOS
{
    public class ProductDTO
    {
        public Guid Id { get; set; }
        public string NameEN { get; set; }
        public string NameAR { get; set; }
        public string DescriptionEN { get; set; }
        public string DescriptionAR { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Guid UnitId { get; set; }
        public Guid BrandId { get; set; }
        public virtual ICollection<ProductPropertyDTO> ProductProperties { get; set; }
        public virtual ICollection<ProductImageDTO> ProductImages { get; set; }
    }
}
