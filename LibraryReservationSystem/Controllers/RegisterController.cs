using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryEntities.Models;
using LibraryServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryReservationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private ISysUserService _sysUserService;
        private AjaxResult _ajaxResult = new AjaxResult();
        public AjaxResult AjaxResult
        {
            get { return _ajaxResult; }
        }

        public RegisterController(ISysUserService sysUserService)
        {
            _sysUserService = sysUserService;
        }

        #region api
        [HttpPost]
        public IActionResult Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                _ajaxResult.Status = false;
                _ajaxResult.Message = "数据不合法";
                return Ok(_ajaxResult);
            }

            var result = _sysUserService.RegisterUser(model);

            return Ok(result);
        }

        #endregion
    }
}