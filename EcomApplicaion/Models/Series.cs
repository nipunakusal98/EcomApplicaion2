﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcomApplicaion.Models
{
    public class Series
    {
        [Key]
        public int SeriesID { get; set; }
        public string SeriesName { get; set; }
        public string SeriesPictureURL { get; set; }

        // Foreign key

        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public Categories Categories { get; set; } // Navigation properties

        // Navigation properties
        public List<Models> Models { get; set; }

    }
}