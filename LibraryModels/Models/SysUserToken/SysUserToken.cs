using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibraryEntities.Models
{
    [Serializable]
    [Table("SysUserToken")]
    public class SysUserToken
    {
        public Guid Id { get; set; }
        public Guid SysUserId { get; set; }
        public DateTime ExpireTime { get; set; }
        [ForeignKey("SysUserId")]
        public virtual SysUser SysUser { get; set; }
    }
}
