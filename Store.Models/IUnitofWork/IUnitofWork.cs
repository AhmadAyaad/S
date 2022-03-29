using System.Threading.Tasks;

namespace Store.Models.IUnitofWork
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();
    }
}
