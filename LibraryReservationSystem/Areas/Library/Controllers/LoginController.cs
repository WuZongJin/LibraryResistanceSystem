using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryEntities.Models;
using LibraryFramework.AdminAuth;
using LibraryServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace LibraryReservationSystem.Areas.Library.Controllers
{
    [Area("Library")]
    public class LoginController : Controller
    {
        private const string R_KEY = "R_KEY";
        private ISysUserService _sysUserService;
        private IAdminAuthService _adminAuthService;
        private IMemoryCache _memoryCache;

        public LoginController(ISysUserService sysUserService,IAdminAuthService adminAuthService,IMemoryCache memoryCache)
        {
            _sysUserService = sysUserService;
            _adminAuthService = adminAuthService;
            _memoryCache = memoryCache;
        }


        public IActionResult Index()
        {
            if (_adminAuthService.GetCurrentUser() != null)
                return RedirectToAction("index", "Home", "Library");

            string r = Guid.NewGuid().ToString();
            HttpContext.Session.SetString(R_KEY, r);
            LoginModel loginModel = new LoginModel() { R = r };

            return View(loginModel);
        }

        [HttpPost]
        public IActionResult Login(LoginModel loginModel)
        {
            if (!ModelState.IsValid)
            {
                ViewData["ErrorMessage"] = "请输入正确的账号和密码！";
                return RedirectToAction("Index",ViewData);
            }
            var result = _sysUserService.AvailableDataUser(loginModel.Account, loginModel.Password, loginModel.R);

            if(result.status)
            {
                _adminAuthService.SignIn(result.token, result.user.Name);
                return RedirectToAction("index", "Home", "Library");
            }

            ViewData["ErrorMessage"] = result.message;
            return RedirectToAction("Index",ViewData);
        }

        
    }
}