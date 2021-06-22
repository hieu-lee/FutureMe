using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FutureMe.Models
{
    public class Letter
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [Required(ErrorMessage = "Bạn cần phải nhập tiêu đề")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Bạn cần phải nhập nội dung thư")]
        public string Content { get; set; }
        [Required(ErrorMessage = "Bạn cần phải nhập email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Bạn cần phải nhập ngày gửi thư")]
        public DateTime? DeliverDate { get; set; }
        [Required]
        public PrivacyMode Privacy { get; set; } = 0;
        public DateTime DateCreate { get; init; } = DateTime.Now.Date;
        public int Likes { get; set; } = 0;
    }
}
