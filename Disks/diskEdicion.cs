using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disks
{
    public class diskEdicion
    {

        public int id { get; set; }
        public string description { get; set; }

        public override string ToString()
        {
            return description;
        }
    }
}
