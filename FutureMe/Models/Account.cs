using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FutureMe.Models
{
    public class Account
    {
        [Required(ErrorMessage = "Bạn cần nhập email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Bạn cần nhập mật khẩu")]
        [StringLength(15, ErrorMessage = "Mật khẩu của bạn phải có độ dài trong khoảng 6 đến 15 chữ cái", MinimumLength = 6)]
        public string Password { get; set; }
        public string Username { get; set; }
    }
}
