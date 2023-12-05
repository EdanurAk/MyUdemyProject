using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{//her entitye özgü metotların olduğunu düşünerek bu class oluşturuldu.
    public class EfAboutDal : GenericRepository<About>,IAboutDal
    {
        public EfAboutDal(Context context) : base(context)//GenericRepository öbür tarafta contexti constructor üzerine geçmişti o zaman bizde burda contexti constructora geçmemiz gerekiyo base(context) diyerek örneklemiş olduk 
    {

    }
    
    }
}
