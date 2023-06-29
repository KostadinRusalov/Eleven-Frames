using System;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class Review
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public Critic Author { get; set; }

        [Required]
        public string Opinion { get; set; }

        public double ReviewRating { get; set; }
    }
}
