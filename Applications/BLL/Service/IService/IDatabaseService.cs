using SQLite;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using BankAPI.Models;

namespace BankAPI.Applications.BLL.Service.IService
{
    public interface IDatabaseService 
    {
        Task<List<Customer>> GetCustomersAsync();
        Task<int> AddCustomerAsync(Customer customer);
        Task<int> UpdateCustomerAsync(Customer customer);
        Task<int> DeleteCustomerAsync(Customer customer);
    }
}
