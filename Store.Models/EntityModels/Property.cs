using System;
using System.Collections.Generic;

namespace Store.Models.EntityModels
{
    public class Property
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public virtual ICollection<ProductProperty> ProductProperties { get; set; }
    }
}
