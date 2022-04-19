using Store.Common.Cross_Cutting;
using Store.Common.DTOS;
using Store.Presistance.IServices;
using System.Threading.Tasks;

namespace Store.Core.Services
{
    public class ProductService : IProductService
    {
        public Task<Response> AddProductAsync(ProductDTO productDTO)
        {
            throw new System.NotImplementedException();
        }
    }
}
