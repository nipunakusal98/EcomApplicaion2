using System.ComponentModel.DataAnnotations;

namespace EcomApplicaion.Models
{
    public class VGA
    {
        [Key]
        public int VGAID { get; set; }
        public string VGADescription { get; set; }

        public string VGAPictureURL { get; set; }
        public decimal Price { get; set; }


        // Navigation properties
        public List<CustomerConfiguration> CustomerConfigurations { get; set; }
    }
}
