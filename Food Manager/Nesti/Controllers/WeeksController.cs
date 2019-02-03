using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nesti.Business.Interfaces;
using Nesti.Data;
using Nesti.Data.Entities;

namespace Nesti.Controllers
{
    public class WeeksController : Controller
    {
        private readonly NsContext _context;
        private readonly IWeekServices _service;

        public WeeksController(NsContext context, IWeekServices service)
        {
            _context = context;
            _service = service;
        }

        // GET: Weeks
        public IActionResult Index()
        {
            return View(_service.getWeek());
        }

        // GET: Weeks/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var week = await _context.Weeks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (week == null)
            {
                return NotFound();
            }

            return View(week);
        }

        // GET: Weeks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Weeks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StartDate,EndDate")] Week week)
        {
            if (ModelState.IsValid)
            {
                week.Id = Guid.NewGuid();
                _context.Add(week);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(week);
        }

        // GET: Weeks/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var week = await _context.Weeks.FindAsync(id);
            if (week == null)
            {
                return NotFound();
            }
            return View(week);
        }

        // POST: Weeks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,StartDate,EndDate")] Week week)
        {
            if (id != week.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(week);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WeekExists(week.Id))
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
            return View(week);
        }

        // GET: Weeks/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var week = await _context.Weeks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (week == null)
            {
                return NotFound();
            }

            return View(week);
        }

        // POST: Weeks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var week = await _context.Weeks.FindAsync(id);
            _context.Weeks.Remove(week);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WeekExists(Guid id)
        {
            return _context.Weeks.Any(e => e.Id == id);
        }
    }
}
