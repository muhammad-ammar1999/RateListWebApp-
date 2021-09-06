using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopMs.Models
{
    public class Sales
    {
        public int Id { get; set; }
        public string DName { get; set; }
        public string DSize { get; set; }
        public int DPrice { get; set; }
        public int DQty { get; set; }
    }
}
