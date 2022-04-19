namespace Store.Common.DTOS
{
    public class ProductPropertyDTO
    {
        public virtual PropertyDTO Property { get; set; }
        public virtual ProductDTO Product { get; set; }
    }
}
