using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibraryEntities.Models
{
    [Table("sysuser")]
    public class SysUser
    {

        public SysUser()
        {
            SysUserTokens = new HashSet<SysUserToken>();
        }
        public Guid Id { get; set; }                    //数据库主键
        [Required]
        public string Account { get; set; }             //账户
        [Required]
        public string Name { get; set; }                //学生姓名
        [Required]
        public string Password { get; set; }            //密码
        [Required]
        public string Salt { get; set; }                //盐值
        public bool IsAdmin { get; set; }               //是否为管理员
        public DateTime CreationTime { get; set; }      //账号创建时间
        public int LoginFailedNum { get; set; }         //登录失败次数
        public DateTime? AllowLoginTime { get; set; }   //允许登录时间
        public bool LoginLock { get; set; }             //登录锁
        public DateTime? LastLoginTime { get; set; }    //最后登录时间
        public int ViolationNum { get; set; }           //违规次数
        public bool ScheduledLock { get; set; }         //预定锁
        public DateTime? AllowScheduleTime { get; set; }    //允许预定时间

        public virtual ICollection<SysUserToken> SysUserTokens { get; set; }
    }
}
