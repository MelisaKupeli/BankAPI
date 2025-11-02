namespace BankAPI.Models
{
    public class Customer
    {
        public Customer(){}
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal Balance { get; set; }
    }
}
