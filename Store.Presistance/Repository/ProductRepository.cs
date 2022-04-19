using Store.Models.EntityModels;
using Store.Models.IRepository;
using Store.Presistance.Data;

namespace Store.Presistance.Repository
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(StoreContext context) : base(context)
        {

        }
    }
}
