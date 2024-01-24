using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1.Models
{
    public class OrderForm
    {
        [Display(Name = "E-mail")]
        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Display(Name = "Your name")]
        [Required]
        public string name { get; set; }

        [Display(Name = "Your address")]
        [Required]
        public string address { get; set; }
    }
}
