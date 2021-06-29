using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FutureMe.Models
{
    public class Feedback
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime PostTime { get; set; } = DateTime.Now;
        public int Likes { get; set; } = 0;
        [Required(ErrorMessage = "Hãy đánh giá dịch vụ của FutureMe")]
        public int Rate { get; set; } = 5;
    }
}
