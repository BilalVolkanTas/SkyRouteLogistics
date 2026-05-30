using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SkyRouteLogistics.Models;

namespace SkyRouteLogistics.Controllers
{
    public class CargoContainersController : Controller
    {
        private readonly AppDbContext _context;

        public CargoContainersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: CargoContainers
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.CargoContainers.Include(c => c.Flight);
            return View(await appDbContext.ToListAsync());
        }

        // GET: CargoContainers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cargoContainer = await _context.CargoContainers
                .Include(c => c.Flight)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cargoContainer == null)
            {
                return NotFound();
            }

            return View(cargoContainer);
        }

        // GET: CargoContainers/Create
        public IActionResult Create()
        {
            ViewData["FlightId"] = new SelectList(_context.Flights, "Id", "Departure");
            return View();
        }

        // POST: CargoContainers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ContainerCode,Weight,ContentDescription,FlightId")] CargoContainer cargoContainer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cargoContainer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FlightId"] = new SelectList(_context.Flights, "Id", "Departure", cargoContainer.FlightId);
            return View(cargoContainer);
        }

        // GET: CargoContainers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cargoContainer = await _context.CargoContainers.FindAsync(id);
            if (cargoContainer == null)
            {
                return NotFound();
            }
            ViewData["FlightId"] = new SelectList(_context.Flights, "Id", "Departure", cargoContainer.FlightId);
            return View(cargoContainer);
        }

        // POST: CargoContainers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ContainerCode,Weight,ContentDescription,FlightId")] CargoContainer cargoContainer)
        {
            if (id != cargoContainer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cargoContainer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CargoContainerExists(cargoContainer.Id))
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
            ViewData["FlightId"] = new SelectList(_context.Flights, "Id", "Departure", cargoContainer.FlightId);
            return View(cargoContainer);
        }

        // GET: CargoContainers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cargoContainer = await _context.CargoContainers
                .Include(c => c.Flight)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cargoContainer == null)
            {
                return NotFound();
            }

            return View(cargoContainer);
        }

        // POST: CargoContainers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cargoContainer = await _context.CargoContainers.FindAsync(id);
            if (cargoContainer != null)
            {
                _context.CargoContainers.Remove(cargoContainer);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CargoContainerExists(int id)
        {
            return _context.CargoContainers.Any(e => e.Id == id);
        }
    }
}
