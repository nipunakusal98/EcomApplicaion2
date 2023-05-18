using EcomApplicaion.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcomApplicaion.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public string ShippingAddress { get; set; }
        public string BillingAddress { get; set; }
        public ShippingMethod ShippingMethod { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string OrderStatus { get; set; }

        // Foreign keys
        public int CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public int CustomerConfigID { get; set; }
        [ForeignKey("CustomerConfigID")]

        // Navigation properties
        public Customer Customer { get; set; }
        public CustomerConfiguration CustomerConfiguration { get; set; }
        public List<Payment> Payments { get; set; }

    }
}
