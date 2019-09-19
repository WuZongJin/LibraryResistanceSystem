using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryEntities;
using LibraryEntities.Models;
using LibraryServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryReservationSystem.Controllers
{
    public class ScheduleModel
    {
        public Guid userId { get; set; }
        public Guid seatId { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private ISysUserService _userService;
        private ILibrarySeatService _librarySeatService;
        
        public ScheduleController(ISysUserService userService,ILibrarySeatService librarySeatService)
        {
            _userService = userService;
            _librarySeatService = librarySeatService;
        }

        [HttpGet]
        public IActionResult GetfloorSeatInfo(int floor)
        {
            var result = _librarySeatService.GetLibrarySeatCount(floor);
            return Ok(result);
        }


        [HttpPost]
        public IActionResult Schedule(ScheduleModel model)
        {
            var muserId = model.userId;
            var mseatId = model.seatId;
            var user = _userService.GetById(muserId);
            if (user == null)
                return Ok("查询不到用户");

            var result = _librarySeatService.Schedule(mseatId, muserId);
            return Ok(result);
        }




    }
}