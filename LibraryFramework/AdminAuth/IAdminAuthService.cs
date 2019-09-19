using LibraryEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryFramework.AdminAuth
{
    public interface IAdminAuthService
    {
        void SignIn(string token, string mame);

        SysUser GetCurrentUser();
    }
}
