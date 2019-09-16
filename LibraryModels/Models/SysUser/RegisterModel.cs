using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryEntities.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "请输入账号")]
        public string Account { get; set; }

        [Required(ErrorMessage ="请输入姓名")]
        public string Name { get; set; }

        [Required(ErrorMessage = "请输入密码")]
        public string Password { get; set; }

        [Required(ErrorMessage = "请再次输入密码")]
        public string RePassword { get; set; }

    }
}
