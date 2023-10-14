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
    public class WorkModelsController : Controller
    {
        private readonly Portfolio_WebsiteContext _context;

        public WorkModelsController(Portfolio_WebsiteContext context)
        {
            _context = context;
        }

        // GET: WorkModels
        public IActionResult Index()
        {
            string path = Directory.GetCurrentDirectory() + @"\wwwroot\json\Work_JSON.json";

            string readText = System.IO.File.ReadAllText(path);
            JArray convert = JArray.Parse(readText);
            List<WorkModel> data = new List<WorkModel>();
            data = convert.ToObject<List<WorkModel>>();
            data.Reverse();
            return View(data);
        }
    }
}
