using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryCore;
using LibraryFramework.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace LibraryReservationSystem.Areas.Library.Controllers
{
    [Area("Library")]
    public class HomeController : Controller
    {

        private IWorkContext _workContext;

        public HomeController(IWorkContext workContext)
        {
            _workContext = EngineContext.Current.Resolve<IWorkContext>();
        }

        public IActionResult Index()
        {
            ViewBag.SysUser = _workContext.Current;
            return View();
        }

        //public IActionResult Schedule(int seatNumber)
        //{

        //}

    }
}