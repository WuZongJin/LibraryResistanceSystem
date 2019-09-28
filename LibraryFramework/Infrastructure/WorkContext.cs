using LibraryEntities.Models;
using LibraryFramework.AdminAuth;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryFramework.Infrastructure
{
    public class WorkContext:IWorkContext
    {
        private IAdminAuthService _adminAuthService;

        public WorkContext(IAdminAuthService adminAuthService)
        {
            _adminAuthService = adminAuthService; 
        }

        public SysUser Current
        {
            get { return _adminAuthService.GetCurrentUser(); }
        }
    }
}
