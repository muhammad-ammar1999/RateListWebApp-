using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopMs.Models
{
    public class RatelistViewModel
    {
      

            public List<RateList> RateLists { get; set; }
            public SelectList DName { get; set; }
            public string shopRatelist { get; set; }
            public string SearchString { get; set; }
        }
    }


