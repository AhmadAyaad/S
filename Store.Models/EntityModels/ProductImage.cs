using System;

namespace Store.Models.EntityModels
{
    public class ProductImage
    {
        public Guid Id { get; set; }
        public string URL { get; set; }
        public Product ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
