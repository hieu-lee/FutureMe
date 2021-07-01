using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FutureMe.Models
{
    public class Letter
    {
        public string Id { get; init; } = Guid.NewGuid().ToString();
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
        public string OwnerUsername { get; set; }
        public string OwnerEmail { get; set; }
        public DateTime DateCreate { get; init; } = DateTime.Now.Date;
        public int Likes { get; set; } = 0;
        public int WordNum { get; set; } = 0;
        public int WordCount()
        {
            string text = Content;
            int wordCount = 0, index = 0;

            // skip whitespace until first word
            while (index < text.Length && char.IsWhiteSpace(text[index]))
                index++;

            while (index < text.Length)
            {
                // check if current char is part of a word
                while (index < text.Length && !char.IsWhiteSpace(text[index]))
                    index++;

                wordCount++;

                // skip whitespace until next word
                while (index < text.Length && char.IsWhiteSpace(text[index]))
                    index++;
            }
            if (wordCount != WordNum) 
            {
                WordNum = wordCount;
            }
            return wordCount;
        }

        public override bool Equals(object obj)
        {
            var other = (Letter)obj;
            return Id.Equals(other.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
