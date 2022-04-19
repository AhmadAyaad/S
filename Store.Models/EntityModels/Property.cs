using System;
using System.Collections.Generic;

namespace Store.Models.EntityModels
{
    public class Property
    {
        public Guid Id { get; set; }
        public string NameEN { get; set; }
        public string NameAR { get; set; }
        public string ValueEN { get; set; }
        public string ValueAR { get; set; }
        public virtual ICollection<ProductProperty> ProductProperties { get; set; }
    }
}
