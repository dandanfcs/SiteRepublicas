using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SiteRepublicas.DataContext;
using SiteRepublicas.Models;

namespace SiteRepublicas.Controllers
{
    public class RepublicasController : Controller
    {
        private readonly ContextDb _context;

        public RepublicasController(ContextDb context)
        {
            _context = context;
        }

        // GET: Republicas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Republicas.ToListAsync());
        }

        // GET: Republicas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var republicas = await _context.Republicas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (republicas == null)
            {
                return NotFound();
            }

            return View(republicas);
        }

        // GET: Republicas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Republicas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Quartos,Salas,Banheiros,Cozinha,Numero_de_Vagas,Garagem,Valor,Tipo,Rua,Numero,Bairro")] Republicas republicas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(republicas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(republicas);
        }

        // GET: Republicas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var republicas = await _context.Republicas.FindAsync(id);
            if (republicas == null)
            {
                return NotFound();
            }
            return View(republicas);
        }

        // POST: Republicas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Quartos,Salas,Banheiros,Cozinha,Numero_de_Vagas,Garagem,Valor,Tipo,Rua,Numero,Bairro")] Republicas republicas)
        {
            if (id != republicas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(republicas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RepublicasExists(republicas.Id))
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
            return View(republicas);
        }

        // GET: Republicas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var republicas = await _context.Republicas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (republicas == null)
            {
                return NotFound();
            }

            return View(republicas);
        }

        public async Task<IActionResult> Filter(string filter)
        {

           var repulicas = await _context.Republicas.ToListAsync();
           var teste = repulicas.Where(rep => rep.Tipo == filter);

            return View(teste);
        }


        // POST: Republicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var republicas = await _context.Republicas.FindAsync(id);
            _context.Republicas.Remove(republicas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RepublicasExists(int id)
        {
            return _context.Republicas.Any(e => e.Id == id);
        }
    }
}
