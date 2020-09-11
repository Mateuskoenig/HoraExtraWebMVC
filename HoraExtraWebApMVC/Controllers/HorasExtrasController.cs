using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HoraExtraWebApMVC.Data;
using HoraExtraWebApMVC.Models;

namespace HoraExtraWebApMVC.Controllers
{
    public class HorasExtrasController : Controller
    {
        private readonly HoraExtraWebApMVCContext _context;

        public HorasExtrasController(HoraExtraWebApMVCContext context)
        {
            _context = context;
        }

        // GET: HorasExtras
        public async Task<IActionResult> Index()
        {
            return View(await _context.HorasExtras.ToListAsync());
        }

        // GET: HorasExtras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var horasExtras = await _context.HorasExtras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (horasExtras == null)
            {
                return NotFound();
            }

            return View(horasExtras);
        }

        // GET: HorasExtras/Create
        public IActionResult Novo()
        {
            return View();
        }

        // POST: HorasExtras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Novo([Bind("Id,Departamento,Descricao,Matricula,Data,Periodo,Transporte,Horas")] HorasExtras horasExtras)
        {
            if (ModelState.IsValid)
            {
                _context.Add(horasExtras);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(horasExtras);
        }

        // GET: HorasExtras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var horasExtras = await _context.HorasExtras.FindAsync(id);
            if (horasExtras == null)
            {
                return NotFound();
            }
            return View(horasExtras);
        }

        // POST: HorasExtras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Departamento,Descricao,Matricula,Data,Periodo,Transporte,Horas")] HorasExtras horasExtras)
        {
            if (id != horasExtras.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(horasExtras);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HorasExtrasExists(horasExtras.Id))
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
            return View(horasExtras);
        }

        // GET: HorasExtras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var horasExtras = await _context.HorasExtras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (horasExtras == null)
            {
                return NotFound();
            }

            return View(horasExtras);
        }

        // POST: HorasExtras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var horasExtras = await _context.HorasExtras.FindAsync(id);
            _context.HorasExtras.Remove(horasExtras);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HorasExtrasExists(int id)
        {
            return _context.HorasExtras.Any(e => e.Id == id);
        }
    }
}
