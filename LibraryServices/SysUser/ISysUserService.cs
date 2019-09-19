using LibraryEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryServices
{
    public interface ISysUserService
    {
        IList<SysUser> GetAllSysUser();

        (bool state, string message, SysUser sysUser) RegisterUser(RegisterModel model);

        SysUser GetByAccount(string account);

        SysUser GetById(Guid id);

        SysUser GetLogined(string token);

        (bool status, string message, string token, SysUser user) AvailableDataUser(string account, string passworld, string R);
    }
}
