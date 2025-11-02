using BankAPI.Models;

namespace BankAPI.Dal.BankDAL.Repository
{
    public interface IUnitOfWork
    {
        IGenericRepository<Customer> CustomerRepository { get; }
        Task<int> SaveAsync();

    }
}
