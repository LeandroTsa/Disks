using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disks
{
    public class domDisks
    {
        [DisplayName("Title 🤓")]
        public string Title { get; set; }
        public DateTime release { get; set; }
        [DisplayName("Cantidad @")]
        public int mount { get; set; }
        public string URLdisks { get; set; }
        public diskEdicion Descripcion { get; set; }


    }
}
