using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopMs.Models;

namespace ShopMs.Data
{
    public class ShopMsContext : DbContext
    {
        public ShopMsContext (DbContextOptions<ShopMsContext> options)
            : base(options)
        {
        }


            public DbSet<ShopMs.Models.RateList> RateList { get; set; }
            public object Ratelist { get; internal set; }
    }
}
