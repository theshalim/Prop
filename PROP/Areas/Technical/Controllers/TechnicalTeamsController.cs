using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PROP.Areas.Technical.Models;
using PROP.Data;

namespace PROP.Areas.Technical.Controllers
{
    [Area("Technical")]
    [Route("Technical/[controller]/[action]")]
    public class TechnicalTeamsController : Controller
    {
        private readonly PropContext _context;

        public TechnicalTeamsController(PropContext context)
        {
            _context = context;
        }

        // GET: Technical/TechnicalTeams
        public async Task<IActionResult> Index()
        {
            return View(await _context.TechnicalTeam.ToListAsync());
        }

        // GET: Technical/TechnicalTeams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var technicalTeam = await _context.TechnicalTeam
                .FirstOrDefaultAsync(m => m.Id == id);
            if (technicalTeam == null)
            {
                return NotFound();
            }

            return View(technicalTeam);
        }

        // GET: Technical/TechnicalTeams/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Technical/TechnicalTeams/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Department,Contact")] TechnicalTeam technicalTeam)
        {
            if (ModelState.IsValid)
            {
                _context.Add(technicalTeam);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(technicalTeam);
        }

        // GET: Technical/TechnicalTeams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var technicalTeam = await _context.TechnicalTeam.FindAsync(id);
            if (technicalTeam == null)
            {
                return NotFound();
            }
            return View(technicalTeam);
        }

        // POST: Technical/TechnicalTeams/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Department,Contact")] TechnicalTeam technicalTeam)
        {
            if (id != technicalTeam.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(technicalTeam);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TechnicalTeamExists(technicalTeam.Id))
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
            return View(technicalTeam);
        }

        // GET: Technical/TechnicalTeams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var technicalTeam = await _context.TechnicalTeam
                .FirstOrDefaultAsync(m => m.Id == id);
            if (technicalTeam == null)
            {
                return NotFound();
            }

            return View(technicalTeam);
        }

        // POST: Technical/TechnicalTeams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var technicalTeam = await _context.TechnicalTeam.FindAsync(id);
            _context.TechnicalTeam.Remove(technicalTeam);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TechnicalTeamExists(int id)
        {
            return _context.TechnicalTeam.Any(e => e.Id == id);
        }
    }
}
