using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ShopMs.Controllers
{
    public class ButtonController : Controller
    {
        public ActionResult PredefinedTypes()
        {
            return View();
        }
    }
}