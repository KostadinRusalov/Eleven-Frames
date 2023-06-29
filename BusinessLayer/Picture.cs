using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class Picture
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public byte Pic { get; set; }

        [Required]
        public PicDescription Description { get; set; }

        public double PictureRating { get; set; }

        public List<Review> Reviews { get; set; }
    }
}
