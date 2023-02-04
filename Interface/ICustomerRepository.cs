
using TestWEbApi2.CustomerDto;
using TestWEbApi2.Models;

namespace TestWEbApi2.Interface
{
    public interface ICustomerRepository
    {
        public Customer RegisterCustomer(Customer customer);
        
        public IList<Customer> ListOfCustomer();
    }
}
