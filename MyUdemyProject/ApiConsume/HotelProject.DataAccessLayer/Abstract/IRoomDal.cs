using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IRoomDal:IGenericDal<Room> //neden böyle yapıyorum sadece GenericDal bana yetmiyor çünkü her bir entity e(room) özgü metodlar olcak ve Room entity se genericdal dan haberdar olması için
    {

    }
}
