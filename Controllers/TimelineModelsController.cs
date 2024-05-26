using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Portfolio_Website.Data;
using Portfolio_Website.Models;

namespace Portfolio_Website.Controllers
{
    public class TimelineModelsController : Controller
    {
        private readonly Portfolio_WebsiteContext _context;

        public TimelineModelsController(Portfolio_WebsiteContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            string path = Directory.GetCurrentDirectory() + @"\wwwroot\json\Timeline_JSON.json";

            string readText = System.IO.File.ReadAllText(path);
            JArray convert = JArray.Parse(readText);
            List<TimelineModel> data = new List<TimelineModel>();
            data = convert.ToObject<List<TimelineModel>>();

            return View(data);
        }

        //    // GET: TimelineModels
        //    public async Task<IActionResult> Index()
        //    {
        //          return _context.TimelineModel != null ? 
        //                      View(await _context.TimelineModel.ToListAsync()) :
        //                      Problem("Entity set 'Portfolio_WebsiteContext.TimelineModel'  is null.");
        //    }

        //    // GET: TimelineModels/Details/5
        //    public async Task<IActionResult> Details(int? id)
        //    {
        //        if (id == null || _context.TimelineModel == null)
        //        {
        //            return NotFound();
        //        }

        //        var timelineModel = await _context.TimelineModel
        //            .FirstOrDefaultAsync(m => m.Id == id);
        //        if (timelineModel == null)
        //        {
        //            return NotFound();
        //        }

        //        return View(timelineModel);
        //    }

        //    // GET: TimelineModels/Create
        //    public IActionResult Create()
        //    {
        //        return View();
        //    }

        //    // POST: TimelineModels/Create
        //    // To protect from overposting attacks, enable the specific properties you want to bind to.
        //    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> Create([Bind("Id,Title,Description")] TimelineModel timelineModel)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            _context.Add(timelineModel);
        //            await _context.SaveChangesAsync();
        //            return RedirectToAction(nameof(Index));
        //        }
        //        return View(timelineModel);
        //    }

        //    // GET: TimelineModels/Edit/5
        //    public async Task<IActionResult> Edit(int? id)
        //    {
        //        if (id == null || _context.TimelineModel == null)
        //        {
        //            return NotFound();
        //        }

        //        var timelineModel = await _context.TimelineModel.FindAsync(id);
        //        if (timelineModel == null)
        //        {
        //            return NotFound();
        //        }
        //        return View(timelineModel);
        //    }

        //    // POST: TimelineModels/Edit/5
        //    // To protect from overposting attacks, enable the specific properties you want to bind to.
        //    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description")] TimelineModel timelineModel)
        //    {
        //        if (id != timelineModel.Id)
        //        {
        //            return NotFound();
        //        }

        //        if (ModelState.IsValid)
        //        {
        //            try
        //            {
        //                _context.Update(timelineModel);
        //                await _context.SaveChangesAsync();
        //            }
        //            catch (DbUpdateConcurrencyException)
        //            {
        //                if (!TimelineModelExists(timelineModel.Id))
        //                {
        //                    return NotFound();
        //                }
        //                else
        //                {
        //                    throw;
        //                }
        //            }
        //            return RedirectToAction(nameof(Index));
        //        }
        //        return View(timelineModel);
        //    }

        //    // GET: TimelineModels/Delete/5
        //    public async Task<IActionResult> Delete(int? id)
        //    {
        //        if (id == null || _context.TimelineModel == null)
        //        {
        //            return NotFound();
        //        }

        //        var timelineModel = await _context.TimelineModel
        //            .FirstOrDefaultAsync(m => m.Id == id);
        //        if (timelineModel == null)
        //        {
        //            return NotFound();
        //        }

        //        return View(timelineModel);
        //    }

        //    // POST: TimelineModels/Delete/5
        //    [HttpPost, ActionName("Delete")]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> DeleteConfirmed(int id)
        //    {
        //        if (_context.TimelineModel == null)
        //        {
        //            return Problem("Entity set 'Portfolio_WebsiteContext.TimelineModel'  is null.");
        //        }
        //        var timelineModel = await _context.TimelineModel.FindAsync(id);
        //        if (timelineModel != null)
        //        {
        //            _context.TimelineModel.Remove(timelineModel);
        //        }

        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }

        //    private bool TimelineModelExists(int id)
        //    {
        //      return (_context.TimelineModel?.Any(e => e.Id == id)).GetValueOrDefault();
        //    }
    }
}
