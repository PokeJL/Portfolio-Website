using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NuGet.Protocol;
using Portfolio_Website.Data;
using Portfolio_Website.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Portfolio_Website.Controllers
{
    public class LinkModelsController : Controller
    {
        private readonly Portfolio_WebsiteContext _context;

        public LinkModelsController(Portfolio_WebsiteContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            string path = Directory.GetCurrentDirectory() + @"\wwwroot\json\Link_JSON.json";

            string readText = System.IO.File.ReadAllText(path);
            JArray convert = JArray.Parse(readText);
            List<LinkModel> data = new List<LinkModel>();
            data = convert.ToObject<List<LinkModel>>();

            return View(data);
        }

        // GET: LinkModels
        //public async Task<IActionResult> Index()
        //{
        //    using FileStream fStream =
        //        new FileStream(path, FileMode.Open, FileAccess.Read);

        //    //var options = new JsonSerializerOptions { IncludeFields = true, WriteIndented = true };
        //    return _context.LinkModel != null ?
        //        View(await _context.LinkModel =
        //        JsonSerializer.Deserialize<LinkModel>(fStream)) :
        //                Problem("Entity set 'Portfolio_WebsiteContext.LinkModel'  is null.");
        //    //return _context.LinkModel != null ?
        //    //            View(await _context.LinkModel.ToListAsync()) :
        //    //            Problem("Entity set 'Portfolio_WebsiteContext.LinkModel'  is null.");
        //}

        //// GET: LinkModels/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null || _context.LinkModel == null)
        //    {
        //        return NotFound();
        //    }

        //    var linkModel = await _context.LinkModel
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (linkModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(linkModel);
        //}

        //// GET: LinkModels/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: LinkModels/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Name,Description,Url")] LinkModel linkModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(linkModel);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(linkModel);
        //}

        //// GET: LinkModels/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.LinkModel == null)
        //    {
        //        return NotFound();
        //    }

        //    var linkModel = await _context.LinkModel.FindAsync(id);
        //    if (linkModel == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(linkModel);
        //}

        //// POST: LinkModels/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Url")] LinkModel linkModel)
        //{
        //    if (id != linkModel.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(linkModel);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!LinkModelExists(linkModel.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(linkModel);
        //}

        //// GET: LinkModels/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.LinkModel == null)
        //    {
        //        return NotFound();
        //    }

        //    var linkModel = await _context.LinkModel
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (linkModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(linkModel);
        //}

        //// POST: LinkModels/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.LinkModel == null)
        //    {
        //        return Problem("Entity set 'Portfolio_WebsiteContext.LinkModel'  is null.");
        //    }
        //    var linkModel = await _context.LinkModel.FindAsync(id);
        //    if (linkModel != null)
        //    {
        //        _context.LinkModel.Remove(linkModel);
        //    }

        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool LinkModelExists(int id)
        //{
        //    return (_context.LinkModel?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
