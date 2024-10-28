using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MateoSantosExam1P.Data;
using MateoSantosExam1P.Models;

namespace MateoSantosExam1P.Controllers
{
    public class MS_CervezaController : Controller
    {
        private readonly MateoSantosExam1PContext _context;

        public MS_CervezaController(MateoSantosExam1PContext context)
        {
            _context = context;
        }

        // GET: MS_Cerveza
        public async Task<IActionResult> Index()
        {
            return View(await _context.MS_Cerveza.ToListAsync());
        }

        // GET: MS_Cerveza/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mS_Cerveza = await _context.MS_Cerveza
                .FirstOrDefaultAsync(m => m.MS_CervezaId == id);
            if (mS_Cerveza == null)
            {
                return NotFound();
            }

            return View(mS_Cerveza);
        }

        // GET: MS_Cerveza/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MS_Cerveza/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MS_CervezaId,MS_CervezaName,MS_CervezaDescription,MS_Escarchada,MS_Price,MS_Date")] MS_Cerveza mS_Cerveza)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mS_Cerveza);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mS_Cerveza);
        }

        // GET: MS_Cerveza/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mS_Cerveza = await _context.MS_Cerveza.FindAsync(id);
            if (mS_Cerveza == null)
            {
                return NotFound();
            }
            return View(mS_Cerveza);
        }

        // POST: MS_Cerveza/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MS_CervezaId,MS_CervezaName,MS_CervezaDescription,MS_Escarchada,MS_Price,MS_Date")] MS_Cerveza mS_Cerveza)
        {
            if (id != mS_Cerveza.MS_CervezaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mS_Cerveza);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MS_CervezaExists(mS_Cerveza.MS_CervezaId))
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
            return View(mS_Cerveza);
        }

        // GET: MS_Cerveza/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mS_Cerveza = await _context.MS_Cerveza
                .FirstOrDefaultAsync(m => m.MS_CervezaId == id);
            if (mS_Cerveza == null)
            {
                return NotFound();
            }

            return View(mS_Cerveza);
        }

        // POST: MS_Cerveza/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mS_Cerveza = await _context.MS_Cerveza.FindAsync(id);
            if (mS_Cerveza != null)
            {
                _context.MS_Cerveza.Remove(mS_Cerveza);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MS_CervezaExists(int id)
        {
            return _context.MS_Cerveza.Any(e => e.MS_CervezaId == id);
        }
    }
}
