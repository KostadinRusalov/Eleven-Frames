using System;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public abstract class User
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public UserRole Role { get; set; }

        public string Bio { get; set; }
    }
}
