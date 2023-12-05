using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult _AdminLayout()
        {
            return View();
        }
        //layout sayfamın tamamını partial ile çok küçük parçalara böldüm erişimi kolaylaşmış oldu.
        public PartialViewResult HeadPartial()
        {

            return PartialView();
        }
        public PartialViewResult PreloaderPartial()
        {

            return PartialView();
        }
        public PartialViewResult NavheaderPartial()
        {

            return PartialView();
        }
        public PartialViewResult HeaderPartial()
        {

            return PartialView();
        }
        public PartialViewResult SidebarPartial()
        {

            return PartialView();
        }
        public PartialViewResult FooterPartial()
        {

            return PartialView();
        } 
        public PartialViewResult ScriptPartial()
        {

            return PartialView();
        }
    }
}
