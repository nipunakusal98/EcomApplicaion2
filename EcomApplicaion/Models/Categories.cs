using System.ComponentModel.DataAnnotations;

namespace EcomApplicaion.Models
{
    public class Categories
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryPictureURL { get; set; }

        // Navigation properties
        public List<Series> Series { get; set; }

    }
}
