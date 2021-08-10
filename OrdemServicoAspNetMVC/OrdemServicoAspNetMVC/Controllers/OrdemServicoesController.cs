using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OrdemServicoAspNetMVC.Models;

namespace OrdemServicoAspNetMVC.Controllers
{
    public class OrdemServicoesController : Controller
    {
        private readonly Context _context;

        public OrdemServicoesController(Context context)
        {
            _context = context;
        }

        // GET: OrdemServicoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ordensServicos.ToListAsync());
        }

        // GET: OrdemServicoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordemServico = await _context.ordensServicos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ordemServico == null)
            {
                return NotFound();
            }

            return View(ordemServico);
        }

        // GET: OrdemServicoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OrdemServicoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdCliente,idTipoServico,idTipoContrato,idColaborador,idDefeitoReclamado,idDefeitoIdentificado,idSolucaoAplicada,DataAbertura,DataFechamento,status")] OrdemServico ordemServico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ordemServico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ordemServico);
        }

        // GET: OrdemServicoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordemServico = await _context.ordensServicos.FindAsync(id);
            if (ordemServico == null)
            {
                return NotFound();
            }
            return View(ordemServico);
        }

        // POST: OrdemServicoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdCliente,idTipoServico,idTipoContrato,idColaborador,idDefeitoReclamado,idDefeitoIdentificado,idSolucaoAplicada,DataAbertura,DataFechamento,status")] OrdemServico ordemServico)
        {
            if (id != ordemServico.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ordemServico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdemServicoExists(ordemServico.Id))
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
            return View(ordemServico);
        }

        // GET: OrdemServicoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordemServico = await _context.ordensServicos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ordemServico == null)
            {
                return NotFound();
            }

            return View(ordemServico);
        }

        // POST: OrdemServicoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ordemServico = await _context.ordensServicos.FindAsync(id);
            _context.ordensServicos.Remove(ordemServico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrdemServicoExists(int id)
        {
            return _context.ordensServicos.Any(e => e.Id == id);
        }
    }
}
