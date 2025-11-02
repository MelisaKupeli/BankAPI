using BankAPI.Models;
using BankAPI.Dal.BankDAL.Infrastructure;

namespace BankAPI.Dal.BankDAL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private IGenericRepository<Customer> _customerRepository;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public IGenericRepository<Customer> CustomerRepository
        {
            get
            {
                return _customerRepository ??= new GenericRepository<Customer>(_context);
            }
        }
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
