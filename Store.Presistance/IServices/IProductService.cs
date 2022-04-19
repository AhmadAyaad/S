using Store.Common.Cross_Cutting;
using Store.Common.DTOS;
using System.Threading.Tasks;

namespace Store.Presistance.IServices
{
    public interface IProductService
    {
        Task<Response> AddProductAsync(ProductDTO productDTO);
    }
}
