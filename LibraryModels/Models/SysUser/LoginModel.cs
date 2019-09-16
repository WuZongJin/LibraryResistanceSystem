using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryEntities.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "请输入账号")]
        public string Account { get; set; }
        [Required(ErrorMessage = "请输入密码")]
        public string Password { get; set; }

        public string R { get; set; }
    }
}
