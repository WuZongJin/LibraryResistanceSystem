using System;
using System.Collections.Generic;
using System.Text;
using LibraryEntities.Models;
using LibraryServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace LibraryFramework.AdminAuth
{
    public class AdminAuthService : IAdminAuthService
    {
        private IHttpContextAccessor _httpContextAccessor;
        private ISysUserService _sysUserService;

        public AdminAuthService(IHttpContextAccessor httpContextAccessor,ISysUserService sysUserService)
        {
            _httpContextAccessor = httpContextAccessor;
            _sysUserService = sysUserService;
        }

        public SysUser GetCurrentUser()
        {
            var result = _httpContextAccessor.HttpContext.AuthenticateAsync(AdminAuthInfo.AuthenticationScheme).Result;
            if (result.Principal == null)
                return null;

            var token = result.Principal.FindFirst(ClaimTypes.Sid).Value;
            var user = _sysUserService.GetLogined(token);

            return user;
        }

        public void SignIn(string token, string name)
        {
            ClaimsIdentity claimsIdentity = new ClaimsIdentity("Form");
            claimsIdentity.AddClaim(new Claim(ClaimTypes.Sid, token));
            claimsIdentity.AddClaim(new Claim(ClaimTypes.Name, name));
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            _httpContextAccessor.HttpContext.SignInAsync(claimsPrincipal);
        }
    }
}
