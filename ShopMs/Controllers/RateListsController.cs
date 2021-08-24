using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShopMs.Data;
using ShopMs.Models;

namespace ShopMs.Controllers
{   
    public class RateListsController : Controller
    {
        private readonly ShopMsContext _context;
        public RateListsController(ShopMsContext context)
        {
            _context = context;
        }
      
        public IActionResult Index()
        {
          //  ViewData["data"] = 

            return View();
        }
        // GET: Movies1/Details/5
        public async Task<IActionResult> Details(int? id)
        {


            if (id == null)
            {
                return NotFound();
            }

            var ratelist = await _context.RateList
                .FirstOrDefaultAsync(r => r.Id == id);
            if (ratelist == null)
            {
                return NotFound();
            }

            return View(ratelist);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }
        // POST: Movies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id)
        {
            return View();
        }
        // GET: Movies1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            return View();
        }

        // POST: Movies1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id)
        {

            return View();
        }

        // GET: Movies1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            return View();
        }

        // POST:// POST: Movies/Delete/6
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, bool notUsed)
        {
            return View();
        }


    }
}
