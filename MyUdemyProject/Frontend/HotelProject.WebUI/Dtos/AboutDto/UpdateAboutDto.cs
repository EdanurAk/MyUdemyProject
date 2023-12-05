using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.AboutDto
{
    public class UpdateAboutDto//resultaboutdtoda da aynı propertyler vardı neden o zaman iki tane ayrı sınıf oluşturduk birinde kalsa olmaz mıydı?
    {//olmazdı çünkü yaptıkları işleri farklı, işler farklı olduğu için içerik aynı olsa da farklı alanlarda tutulması gerekiyo. 
        public int AboutID { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Content { get; set; }
        public int RoomCount { get; set; }
        public int StaffCount { get; set; }
        public int CustomerCount { get; set; }
    }
}
