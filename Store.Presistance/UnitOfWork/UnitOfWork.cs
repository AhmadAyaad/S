using Store.Models.IUnitofWork;
using Store.Presistance.Data;
using System.Threading.Tasks;

namespace Store.Presistance.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StoreContext _context;

        public UnitOfWork(StoreContext context)
        {
            _context = context;
        }
        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
