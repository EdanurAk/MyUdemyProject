using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Models.Staff
{
    public class StaffViewModel
    {//Ana kısımda neyi listelemek istiyorsam onu burda çağırmam gerekiyo
        public int StaffID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }

    }
}
