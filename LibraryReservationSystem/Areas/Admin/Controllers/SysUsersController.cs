using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LibraryEntities;
using LibraryEntities.Models;

namespace LibraryReservationSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SysUsersController : Controller
    {
        private readonly MyDbContext _context;

        public SysUsersController(MyDbContext context)
        {
            _context = context;
        }

        // GET: Admin/SysUsers
        public async Task<IActionResult> Index()
        {
            return View(await _context.SysUsers.ToListAsync());
        }

        // GET: Admin/SysUsers/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sysUser = await _context.SysUsers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sysUser == null)
            {
                return NotFound();
            }

            return View(sysUser);
        }

        // GET: Admin/SysUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/SysUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Account,Name,Password,Salt,IsAdmin,CreationTime,LoginFailedNum,AllowLoginTime,LoginLock,LastLoginTime,ViolationNum,ScheduledLock,AllowScheduleTime")] SysUser sysUser)
        {
            if (ModelState.IsValid)
            {
                sysUser.Id = Guid.NewGuid();
                _context.Add(sysUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sysUser);
        }

        // GET: Admin/SysUsers/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sysUser = await _context.SysUsers.FindAsync(id);
            if (sysUser == null)
            {
                return NotFound();
            }
            return View(sysUser);
        }

        // POST: Admin/SysUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Account,Name,Password,Salt,IsAdmin,CreationTime,LoginFailedNum,AllowLoginTime,LoginLock,LastLoginTime,ViolationNum,ScheduledLock,AllowScheduleTime")] SysUser sysUser)
        {
            if (id != sysUser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sysUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SysUserExists(sysUser.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(sysUser);
        }

        // GET: Admin/SysUsers/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sysUser = await _context.SysUsers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sysUser == null)
            {
                return NotFound();
            }

            return View(sysUser);
        }

        // POST: Admin/SysUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var sysUser = await _context.SysUsers.FindAsync(id);
            _context.SysUsers.Remove(sysUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SysUserExists(Guid id)
        {
            return _context.SysUsers.Any(e => e.Id == id);
        }
    }
}
