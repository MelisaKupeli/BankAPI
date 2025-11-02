using SQLite;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using BankAPI.Applications.BLL.Service.IService;
using BankAPI.Models;
using BankAPI.Dal.BankDAL.Infrastructure;
using BankAPI.Dal.BankDAL.Repository;




namespace BankAPI.Applications.BLL.Service
{
    public class DatabaseService : IDatabaseService
    {
        private readonly SQLiteAsyncConnection _database;

        public DatabaseService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Customer>().Wait();
        }

        public Task<List<Customer>> GetCustomersAsync()
        {
            return _database.Table<Customer>().ToListAsync();
        }

        public Task<int> AddCustomerAsync(Customer customer)
        {
            return _database.InsertAsync(customer);
        }

        public Task<int> UpdateCustomerAsync(Customer customer)
        {
            return _database.UpdateAsync(customer);
        }

        public Task<int> DeleteCustomerAsync(Customer customer)
        {
            return _database.DeleteAsync(customer);
        }

    }
}
