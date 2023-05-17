using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EcomApplicaion.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ShippingAddress { get; set; }
        public string BillingAddress { get; set; }


        // Navigation properties
        public List<CustomerConfiguration> CustomerConfigurations { get; set; }
        public List<Order> Orders { get; set; }


    }
}
