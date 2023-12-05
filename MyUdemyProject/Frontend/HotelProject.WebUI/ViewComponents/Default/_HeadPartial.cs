using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _HeadPartial:ViewComponent
    {
        public IViewComponentResult Invoke()//default olarak Invoke olarak adlandırılıyor çağırmak anlamında kullanılıyor.
        {
            return View();
        }
    }
}
