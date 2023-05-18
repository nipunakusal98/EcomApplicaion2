using System.ComponentModel.DataAnnotations;

namespace EcomApplicaion.Models
{
    public class Memory
    {
        [Key]
        public int MemoryID { get; set; }
        public string MemoryDescription { get; set; }
        public string MemoryPictureURL { get; set; }
        public decimal Price { get; set; }

        // Navigation properties
        public List<CustomerConfiguration> CustomerConfigurations { get; set; }

    }
}
