using LibraryEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryServices
{
    public interface ISysUserService
    {
        IList<SysUser> GetAllSysUser();     //获取所有用户

        (bool state, string message, SysUser sysUser) RegisterUser(RegisterModel model);        //组测

        SysUser GetByAccount(string account);

        SysUser GetById(Guid id);

        SysUser GetLogined(string token);

        (bool status, string message, string token, SysUser user) AvailableDataUser(string account, string passworld, string R);
    }
}
