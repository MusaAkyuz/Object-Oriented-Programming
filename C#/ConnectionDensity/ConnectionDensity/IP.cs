using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionDensity
{
    internal class IP
    {
        public IP()
        {
            DestIP = "";
            Count = 0;
        }

        public string? DestIP { get; set; }
        public int? Count { get; set; }
    }
}
