using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrochetApp2._0.Models
{
    // Class used by Ravelry API patterns
    internal class Pattern
    {
        public bool free { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string permalink { get; set; }

        public Designer designer { get; set; } // nested object
    }
}
