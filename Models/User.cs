using System;
using System.ComponentModel.DataAnnotations;

namespace QuotingDojo.Models
{
    public class User
    {
        [Required]
        [MinLength(3, ErrorMessage="Name must be at least 3 characters long.")]
        public string Name {get;set;}
        [Required]
        [MaxLength(120, ErrorMessage="Maximum 120 characters.")]
        public string Quote {get;set;}
    }
}