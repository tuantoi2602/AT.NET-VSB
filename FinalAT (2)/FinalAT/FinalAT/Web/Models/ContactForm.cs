using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class ContactForm
    {
        [Required]
        [Display(Name ="Your Name")]
        public string name { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Your Email")]
        public string email { get; set; }
        [Required]
        public Gender gender { get; set; }
        [Required]
        public string text { get; set; }

    }
    public enum Gender
    {
        Male,
        Female
    }
}
