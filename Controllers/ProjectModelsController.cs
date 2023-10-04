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
    public class ProjectModelsController : Controller
    {
        private readonly Portfolio_WebsiteContext _context;

        public ProjectModelsController(Portfolio_WebsiteContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            string path = Directory.GetCurrentDirectory() + @"\wwwroot\json\Project_JSON.json";

            string readText = System.IO.File.ReadAllText(path);
            JArray convert = JArray.Parse(readText);
            List<ProjectModel> data = new List<ProjectModel>();
            data = convert.ToObject<List<ProjectModel>>();

            return View(data);
        }

        // GET: ProjectModels
    //    public async Task<IActionResult> Index()
    //    {
    //          return _context.ProjectModel != null ? 
    //                      View(await _context.ProjectModel.ToListAsync()) :
    //                      Problem("Entity set 'Portfolio_WebsiteContext.ProjectModel'  is null.");
    //    }

    //    // GET: ProjectModels/Details/5
    //    public async Task<IActionResult> Details(int? id)
    //    {
    //        if (id == null || _context.ProjectModel == null)
    //        {
    //            return NotFound();
    //        }

    //        var projectModel = await _context.ProjectModel
    //            .FirstOrDefaultAsync(m => m.Id == id);
    //        if (projectModel == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(projectModel);
    //    }

    //    // GET: ProjectModels/Create
    //    public IActionResult Create()
    //    {
    //        return View();
    //    }

    //    // POST: ProjectModels/Create
    //    // To protect from overposting attacks, enable the specific properties you want to bind to.
    //    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Create([Bind("Id,Name,Summary,Description,Project_Link,Picture_Link")] ProjectModel projectModel)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            _context.Add(projectModel);
    //            await _context.SaveChangesAsync();
    //            return RedirectToAction(nameof(Index));
    //        }
    //        return View(projectModel);
    //    }

    //    // GET: ProjectModels/Edit/5
    //    public async Task<IActionResult> Edit(int? id)
    //    {
    //        if (id == null || _context.ProjectModel == null)
    //        {
    //            return NotFound();
    //        }

    //        var projectModel = await _context.ProjectModel.FindAsync(id);
    //        if (projectModel == null)
    //        {
    //            return NotFound();
    //        }
    //        return View(projectModel);
    //    }

    //    // POST: ProjectModels/Edit/5
    //    // To protect from overposting attacks, enable the specific properties you want to bind to.
    //    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Summary,Description,Project_Link,Picture_Link")] ProjectModel projectModel)
    //    {
    //        if (id != projectModel.Id)
    //        {
    //            return NotFound();
    //        }

    //        if (ModelState.IsValid)
    //        {
    //            try
    //            {
    //                _context.Update(projectModel);
    //                await _context.SaveChangesAsync();
    //            }
    //            catch (DbUpdateConcurrencyException)
    //            {
    //                if (!ProjectModelExists(projectModel.Id))
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
    //        return View(projectModel);
    //    }

    //    // GET: ProjectModels/Delete/5
    //    public async Task<IActionResult> Delete(int? id)
    //    {
    //        if (id == null || _context.ProjectModel == null)
    //        {
    //            return NotFound();
    //        }

    //        var projectModel = await _context.ProjectModel
    //            .FirstOrDefaultAsync(m => m.Id == id);
    //        if (projectModel == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(projectModel);
    //    }

    //    // POST: ProjectModels/Delete/5
    //    [HttpPost, ActionName("Delete")]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> DeleteConfirmed(int id)
    //    {
    //        if (_context.ProjectModel == null)
    //        {
    //            return Problem("Entity set 'Portfolio_WebsiteContext.ProjectModel'  is null.");
    //        }
    //        var projectModel = await _context.ProjectModel.FindAsync(id);
    //        if (projectModel != null)
    //        {
    //            _context.ProjectModel.Remove(projectModel);
    //        }
            
    //        await _context.SaveChangesAsync();
    //        return RedirectToAction(nameof(Index));
    //    }

    //    private bool ProjectModelExists(int id)
    //    {
    //      return (_context.ProjectModel?.Any(e => e.Id == id)).GetValueOrDefault();
    //    }
    }
}
