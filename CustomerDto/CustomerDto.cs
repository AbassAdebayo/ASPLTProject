using System.ComponentModel.DataAnnotations;


namespace TestWEbApi2.CustomerDto
{
    public class CustomerDto1
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }



    }

    public class CreateCustomerRequestModel
    {
        [Required]
        public string CustomerName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

    }

}
