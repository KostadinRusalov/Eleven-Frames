using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class PicDescription
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public List<Category> Categories { get; set; }

        [Required]
        public Photographer Photographer { get; set; }

        public DateTime ShotDate { get; set; }

        public string Comment { get; set; }
    }
}