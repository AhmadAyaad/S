using Store.Common.Cross_Cutting;
using Store.Identity.DTOS;
using System.Threading.Tasks;

namespace Store.Identity.IServices
{
    public interface IAccountService
    {
        Task<Response> RegisterUserAsync(ReigsterUserDTO reigsterUserDTO);
        Task<Response<UserDTO>> LoginAsync(LoginDTO loginDTO);
    }
}
