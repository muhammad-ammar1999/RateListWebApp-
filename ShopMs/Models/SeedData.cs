//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;
//using ShopMs.Data;
//using ShopMs.Models;
//namespace ShopMs.Models
//{
//    public class SeedData
//    {
//        public static void Initialize(IServiceProvider serviceProvider)
//        {
//            using (var context = new ShopMsContext(
//                ServiceProvider.GetRequiredService<
//                    DbContextOptions<ShopMsContext>>()))
//            {
//                // Look for any movies.
//                if (context.Ratelist.Any())
//                {
//                    return;   // DB has been seeded
//                }

//                context.Ratelist.AddRange(
//                    new Ratelist
//                    {
//                        DName = "Molfix",
//                        DSize = "Large",
//                        Price = 7M
//                    },

//                       new Ratelist
//                       {
//                           DName = "Molfix",
//                           DSize = "Large",
//                           Price = 7M
//                       },

//} } }
//}

    
