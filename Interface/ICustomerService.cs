
using TestWEbApi2.Models;
using TestWEbApi2.CustomerDto;

namespace TestWEbApi2.Interface
{
    public interface ICustomerService
    {
        public Customer CreateCustomer(CreateCustomerRequestModel model);
        public IList<CustomerDto1> ListOfCustomers();
    }
}
