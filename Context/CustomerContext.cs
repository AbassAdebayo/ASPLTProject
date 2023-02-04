using Microsoft.EntityFrameworkCore;
using TestWEbApi2.Models;

namespace TestWEbApi2.Context
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options): base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }
}
