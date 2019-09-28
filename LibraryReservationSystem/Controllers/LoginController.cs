using LibraryEntities.Models;
using LibraryFramework.AdminAuth;
using LibraryServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryReservationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        #region Property

        private const string R_KEY = "rnd_key";
        private AjaxResult _ajaxResult = new AjaxResult();
        private ISysUserService _sysUserService;
        private IAdminAuthService _adminAuthService;


        public AjaxResult AjaxResult
        {
            get { return _ajaxResult; }
        }

        #endregion

        #region Constructor

        public LoginController(ISysUserService sysUserService,IAdminAuthService adminAuthService)
        {
            _sysUserService = sysUserService;
            _adminAuthService = adminAuthService;
        }

        #endregion

        #region api
        [HttpGet]
        public IActionResult Get()
        {
            var sysUsers = _sysUserService.GetAllSysUser();
            return Ok(sysUsers);
        }

        // POST: api/Login
        [HttpPost]
        public IActionResult Login(LoginModel loginModel)
        {
            if (!ModelState.IsValid)
            {
                _ajaxResult.Status = false;
                _ajaxResult.Message = "数据不合法";
                return Ok(_ajaxResult);
            }

            var result = _sysUserService.AvailableDataUser(loginModel.Account, loginModel.Password, loginModel.R);

            if (result.status)
            {
                _adminAuthService.SignIn(result.token, result.user.Name);
            }

            return Ok(result);
        }


        #endregion

    }
}
