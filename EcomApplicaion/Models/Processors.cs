using System.ComponentModel.DataAnnotations;

namespace EcomApplicaion.Models
{
    public class Processors
    {
            [Key]
            public int ProcessorID { get; set; }
            public string ProcessorDescription { get; set; }
            public string ProcessorPictureURL { get; set; }
            public decimal Price { get; set; }

        // Navigation properties
        public List<CustomerConfiguration> CustomerConfigurations { get; set; }


    }
}
