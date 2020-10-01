using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OrdersMVC.Data;
using OrdersMVC.Models;

namespace OrdersMVC.Controllers
{
    public class DeliveryLocationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DeliveryLocationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DeliveryLocations
        public async Task<IActionResult> Index()
        {
            return View(await _context.DeliveryLocations.ToListAsync());
        }

        // GET: DeliveryLocations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            
            var deliveryLocations = await _context.DeliveryLocations
                .FirstOrDefaultAsync(m => m.DLId == id);
           

            return View(deliveryLocations);
        }

        // GET: DeliveryLocations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DeliveryLocations/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DLId,LocationName,Address,City,State,TimeFrom,TimeTill,DayAvailable")] DeliveryLocations deliveryLocations)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deliveryLocations);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(deliveryLocations);
        }

        // GET: DeliveryLocations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
           
            var deliveryLocations = await _context.DeliveryLocations.FindAsync(id);
           
            return View(deliveryLocations);
        }
        private bool DeliveryLocationsExists(int id)
        {
            return _context.DeliveryLocations.Any(e => e.DLId == id);
        }
        // POST: DeliveryLocations/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DLId,LocationName,Address,City,State,TimeFrom,TimeTill,DayAvailable")] DeliveryLocations deliveryLocations)
        {
            

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(deliveryLocations);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                 
                }
                return RedirectToAction(nameof(Index));
            }
            return View(deliveryLocations);
        }

        // GET: DeliveryLocations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            

            var deliveryLocations = await _context.DeliveryLocations
                .FirstOrDefaultAsync(m => m.DLId == id);
            return View(deliveryLocations);
        }

        // POST: DeliveryLocations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var deliveryLocations = await _context.DeliveryLocations.FindAsync(id);
            _context.DeliveryLocations.Remove(deliveryLocations);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

     
    }
}
