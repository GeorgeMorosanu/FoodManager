using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nesti.Data;
using Nesti.Data.Entities;

namespace Nesti.Controllers
{
    public class GenericProductsController : Controller
    {
        private readonly NsContext _context;

        public GenericProductsController(NsContext context)
        {
            _context = context;
        }

        // GET: GenericProducts
        public async Task<IActionResult> Index()
        {
            return View(await _context.GenericProducts.ToListAsync());
        }

        // GET: GenericProducts/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genericProduct = await _context.GenericProducts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (genericProduct == null)
            {
                return NotFound();
            }

            return View(genericProduct);
        }

        // GET: GenericProducts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GenericProducts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] GenericProduct genericProduct)
        {
            if (ModelState.IsValid)
            {
                genericProduct.Id = Guid.NewGuid();
                _context.Add(genericProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(genericProduct);
        }

        // GET: GenericProducts/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genericProduct = await _context.GenericProducts.FindAsync(id);
            if (genericProduct == null)
            {
                return NotFound();
            }
            return View(genericProduct);
        }

        // POST: GenericProducts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name")] GenericProduct genericProduct)
        {
            if (id != genericProduct.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(genericProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GenericProductExists(genericProduct.Id))
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
            return View(genericProduct);
        }

        // GET: GenericProducts/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genericProduct = await _context.GenericProducts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (genericProduct == null)
            {
                return NotFound();
            }

            return View(genericProduct);
        }

        // POST: GenericProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var genericProduct = await _context.GenericProducts.FindAsync(id);
            _context.GenericProducts.Remove(genericProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GenericProductExists(Guid id)
        {
            return _context.GenericProducts.Any(e => e.Id == id);
        }
    }
}
