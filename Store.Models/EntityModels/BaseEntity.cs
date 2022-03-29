using System;

namespace Store.Models.EntityModels
{
    public class BaseEntity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
