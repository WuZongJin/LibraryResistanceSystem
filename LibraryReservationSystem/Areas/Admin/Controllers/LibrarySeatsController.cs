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
    public class LibrarySeatsController : Controller
    {
        private readonly MyDbContext _context;

        public LibrarySeatsController(MyDbContext context)
        {
            _context = context;
        }

        // GET: Admin/LibrarySeats
        public async Task<IActionResult> Index()
        {
            return View(await _context.LibrarySeats.ToListAsync());
        }

        // GET: Admin/LibrarySeats/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var librarySeat = await _context.LibrarySeats
                .FirstOrDefaultAsync(m => m.Id == id);
            if (librarySeat == null)
            {
                return NotFound();
            }

            return View(librarySeat);
        }

        // GET: Admin/LibrarySeats/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/LibrarySeats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SeatNumber,Floor,SeatState")] LibrarySeat librarySeat)
        {
            if (ModelState.IsValid)
            {
                librarySeat.Id = Guid.NewGuid();
                _context.Add(librarySeat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(librarySeat);
        }

        // GET: Admin/LibrarySeats/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var librarySeat = await _context.LibrarySeats.FindAsync(id);
            if (librarySeat == null)
            {
                return NotFound();
            }
            return View(librarySeat);
        }

        // POST: Admin/LibrarySeats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,SeatNumber,Floor,SeatState")] LibrarySeat librarySeat)
        {
            if (id != librarySeat.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(librarySeat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LibrarySeatExists(librarySeat.Id))
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
            return View(librarySeat);
        }

        // GET: Admin/LibrarySeats/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var librarySeat = await _context.LibrarySeats
                .FirstOrDefaultAsync(m => m.Id == id);
            if (librarySeat == null)
            {
                return NotFound();
            }

            return View(librarySeat);
        }

        // POST: Admin/LibrarySeats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var librarySeat = await _context.LibrarySeats.FindAsync(id);
            _context.LibrarySeats.Remove(librarySeat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LibrarySeatExists(Guid id)
        {
            return _context.LibrarySeats.Any(e => e.Id == id);
        }
    }
}
