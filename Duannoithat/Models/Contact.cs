﻿using System.ComponentModel.DataAnnotations;

namespace Duannoithat.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "Vui lòng nhập tên.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập email.")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập nội dung.")]
        public string Message { get; set; }
    }
}
