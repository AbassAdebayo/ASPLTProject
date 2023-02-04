using TestWEbApi2.CustomerDto;
using TestWEbApi2.Interface;
using TestWEbApi2.Models;

namespace TestWebApp.Implementation
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer CreateCustomer(CreateCustomerRequestModel model)
        {
            var customer = new Customer
            {
                CustomerName = model.CustomerName,
                PhoneNumber = model.PhoneNumber,
                Password = model.Password
            };

            _customerRepository.RegisterCustomer(customer);
            return customer;
        }
        public IList<CustomerDto1> ListOfCustomers()
        {
           return _customerRepository.ListOfCustomer().Select(a => new CustomerDto1
           {
                CustomerName = a.CustomerName,
                PhoneNumber = a.PhoneNumber,
                Id = a.Id
           }).ToList();
        }
    }
}
