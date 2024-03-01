using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZencareLTE.Data;
using ZencareLTE.Models;

namespace ZencareLTE.Controllers
{
    public class CalendarSchedulerEvents : Controller
    {
        private readonly CalendarSchedulerDbcontext _context;

        public CalendarSchedulerEvents(CalendarSchedulerDbcontext context)
        {
            _context = context;
        }

        // GET: CalendarSchedulerEvents
        public async Task<IActionResult> Index()
        {
            return _context.Events != null ?
                        View(await _context.Events.ToListAsync()) :
                        Problem("Entity set 'CalendarSchedulerDbcontext.Events'  is null.");
        }

        // GET: CalendarSchedulerEvents/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Events == null)
            {
                return NotFound();
            }

            var calendarSchedulerEvent = await _context.Events
                .FirstOrDefaultAsync(m => m.Id == id);
            if (calendarSchedulerEvent == null)
            {
                return NotFound();
            }

            return View(calendarSchedulerEvent);
        }

        // GET: CalendarSchedulerEvents/Create
        public IActionResult ViewCalendar()
        {
            return View();
        }

        // POST: CalendarSchedulerEvents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ViewCalendar([Bind("Id,Text,StartDate,EndDate")] CalendarSchedulerEvent calendarSchedulerEvent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(calendarSchedulerEvent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(calendarSchedulerEvent);
        }

        // GET: CalendarSchedulerEvents/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Events == null)
            {
                return NotFound();
            }

            var calendarSchedulerEvent = await _context.Events.FindAsync(id);
            if (calendarSchedulerEvent == null)
            {
                return NotFound();
            }
            return View(calendarSchedulerEvent);
        }

        // POST: CalendarSchedulerEvents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Text,StartDate,EndDate")] CalendarSchedulerEvent calendarSchedulerEvent)
        {
            if (id != calendarSchedulerEvent.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(calendarSchedulerEvent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CalendarSchedulerEventExists(calendarSchedulerEvent.Id))
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
            return View(calendarSchedulerEvent);
        }

        // GET: CalendarSchedulerEvents/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Events == null)
            {
                return NotFound();
            }

            var calendarSchedulerEvent = await _context.Events
                .FirstOrDefaultAsync(m => m.Id == id);
            if (calendarSchedulerEvent == null)
            {
                return NotFound();
            }

            return View(calendarSchedulerEvent);
        }

        // POST: CalendarSchedulerEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Events == null)
            {
                return Problem("Entity set 'CalendarSchedulerDbcontext.Events'  is null.");
            }
            var calendarSchedulerEvent = await _context.Events.FindAsync(id);
            if (calendarSchedulerEvent != null)
            {
                _context.Events.Remove(calendarSchedulerEvent);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CalendarSchedulerEventExists(string id)
        {
            return (_context.Events?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
