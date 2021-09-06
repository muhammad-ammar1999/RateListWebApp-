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
        public RateListsController()
        {
            _context = new ShopMsContext();
        }
      
    
        public IActionResult Index()
        {
            var rateList = new RateList()
            {
                DName = "Good care",
                DSize = "M",
                DPrice = 650,
            };
          
           
            ViewData["RateList"] = rateList;
            return View();
            
        }
        // GET: Movies1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var rateList = new RateList()
            {
                DName = "Good care",
                DSize = "M",
                DPrice = 650,
            };
            ViewData["RateList"] = rateList;

           

            return View();
            //    {
            //        if (id == null)
            //        {
            //            return View();
            //        }

            //        var rateList = await _context.RateList
            //            .FirstOrDefaultAsync(m => m.Id == id);
            //        if (rateList == null)
            //        {
            //            return View();
            //        }

            //        return View(rateList);
            //    }
            }

            // GET: Movies/Create
            public IActionResult Create()
        {
            return View();
        }
        // POST: Movies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RateList objRateList)
        {
            return Content(objRateList.DName + " " + objRateList.DSize + " " + objRateList.DPrice);
        }
        // GET: Movies1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            return View();
        }

        // POST: Movies1/Edit/5
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
