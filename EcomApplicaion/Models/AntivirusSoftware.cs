using System.ComponentModel.DataAnnotations;

namespace EcomApplicaion.Models
{
    public class AntivirusSoftware
    {
        [Key]
        public int AntivirusID { get; set; }
        public string AntivirusDescription { get; set; }
        public decimal Price { get; set; }

        // Navigation properties
        public List<CustomerConfiguration> CustomerConfigurations { get; set; }
    }
}
