namespace EcomApplicaion.Models
{
    public class Memory
    {
        public int MemoryID { get; set; }
        public string MemoryDescription { get; set; }
        public string MemoryPictureURL { get; set; }
        public decimal Price { get; set; }

        // Navigation properties
        public List<CustomerConfiguration> CustomerConfigurations { get; set; }

    }
}
