using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FutureMe.Models
{
    public class Letter
    {
        [Required]
        public string Content { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime? DeliverDate { get; set; }
        [Required]
        public PrivacyMode Privacy { get; set; } = 0;
    }
}
