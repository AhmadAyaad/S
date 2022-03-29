using System;

namespace Store.Models.EntityModels
{
    public class ProductProperty
    {
        public Guid PropertyId { get; set; }
        public virtual Property Property { get; set; }
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
