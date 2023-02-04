using Microsoft.EntityFrameworkCore;
using TestWEbApi2.Context;
using TestWEbApi2.Interface;
using TestWEbApi2.Models;

namespace TestWebApp.Implementation
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerContext _customerContext;

        public CustomerRepository(CustomerContext customerContext)
        {
            _customerContext = customerContext;
        }

        public Customer RegisterCustomer(Customer customer)
        {
           
            _customerContext.Customers.Add(customer);
            _customerContext.SaveChanges();
           
           
            return customer;
        }
           public IList<Customer> ListOfCustomer()
        {
           
            return _customerContext.Customers.ToList();
            
        }


    
    }
}
