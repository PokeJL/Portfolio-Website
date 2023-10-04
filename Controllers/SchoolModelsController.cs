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
    public class SchoolModelsController : Controller
    {
        private readonly Portfolio_WebsiteContext _context;

        public SchoolModelsController(Portfolio_WebsiteContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            string path = Directory.GetCurrentDirectory() + @"\wwwroot\json\School_JSON.json";

            string readText = System.IO.File.ReadAllText(path);
            JArray convert = JArray.Parse(readText);
            List<SchoolModel> data = new List<SchoolModel>();
            data = convert.ToObject<List<SchoolModel>>();

            return View(data);
        }

    //    // GET: SchoolModels
    //    public async Task<IActionResult> Index()
    //    {
    //          return _context.SchoolModel != null ? 
    //                      View(await _context.SchoolModel.ToListAsync()) :
    //                      Problem("Entity set 'Portfolio_WebsiteContext.SchoolModel'  is null.");
    //    }

    //    // GET: SchoolModels/Details/5
    //    public async Task<IActionResult> Details(int? id)
    //    {
    //        if (id == null || _context.SchoolModel == null)
    //        {
    //            return NotFound();
    //        }

    //        var schoolModel = await _context.SchoolModel
    //            .FirstOrDefaultAsync(m => m.Id == id);
    //        if (schoolModel == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(schoolModel);
    //    }

    //    // GET: SchoolModels/Create
    //    public IActionResult Create()
    //    {
    //        return View();
    //    }

    //    // POST: SchoolModels/Create
    //    // To protect from overposting attacks, enable the specific properties you want to bind to.
    //    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Create([Bind("Id,Degree,School,Time_Frame,Description")] SchoolModel schoolModel)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            _context.Add(schoolModel);
    //            await _context.SaveChangesAsync();
    //            return RedirectToAction(nameof(Index));
    //        }
    //        return View(schoolModel);
    //    }

    //    // GET: SchoolModels/Edit/5
    //    public async Task<IActionResult> Edit(int? id)
    //    {
    //        if (id == null || _context.SchoolModel == null)
    //        {
    //            return NotFound();
    //        }

    //        var schoolModel = await _context.SchoolModel.FindAsync(id);
    //        if (schoolModel == null)
    //        {
    //            return NotFound();
    //        }
    //        return View(schoolModel);
    //    }

    //    // POST: SchoolModels/Edit/5
    //    // To protect from overposting attacks, enable the specific properties you want to bind to.
    //    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Edit(int id, [Bind("Id,Degree,School,Time_Frame,Description")] SchoolModel schoolModel)
    //    {
    //        if (id != schoolModel.Id)
    //        {
    //            return NotFound();
    //        }

    //        if (ModelState.IsValid)
    //        {
    //            try
    //            {
    //                _context.Update(schoolModel);
    //                await _context.SaveChangesAsync();
    //            }
    //            catch (DbUpdateConcurrencyException)
    //            {
    //                if (!SchoolModelExists(schoolModel.Id))
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
    //        return View(schoolModel);
    //    }

    //    // GET: SchoolModels/Delete/5
    //    public async Task<IActionResult> Delete(int? id)
    //    {
    //        if (id == null || _context.SchoolModel == null)
    //        {
    //            return NotFound();
    //        }

    //        var schoolModel = await _context.SchoolModel
    //            .FirstOrDefaultAsync(m => m.Id == id);
    //        if (schoolModel == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(schoolModel);
    //    }

    //    // POST: SchoolModels/Delete/5
    //    [HttpPost, ActionName("Delete")]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> DeleteConfirmed(int id)
    //    {
    //        if (_context.SchoolModel == null)
    //        {
    //            return Problem("Entity set 'Portfolio_WebsiteContext.SchoolModel'  is null.");
    //        }
    //        var schoolModel = await _context.SchoolModel.FindAsync(id);
    //        if (schoolModel != null)
    //        {
    //            _context.SchoolModel.Remove(schoolModel);
    //        }
            
    //        await _context.SaveChangesAsync();
    //        return RedirectToAction(nameof(Index));
    //    }

    //    private bool SchoolModelExists(int id)
    //    {
    //      return (_context.SchoolModel?.Any(e => e.Id == id)).GetValueOrDefault();
    //    }
    }
}
