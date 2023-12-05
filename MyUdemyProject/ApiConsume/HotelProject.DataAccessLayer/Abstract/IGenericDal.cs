using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Abstract
{
   public interface IGenericDal<T> where T : class//t degerim bir class olacak koşul yazdık
    {
        void Insert(T t);//dışardan gelen T sınıfı üzerinde ekleme işlemi yapabilmek için
        void Delete(T t);// dışardan gelen sınıf için silme işlemi yapabilmek için
        void Update(T t);//Dışardan gelen T sınıfı üzerinde güncelleme işlemi yapabilmek için
        List<T> GetList();//T dsınıfından gelen verilerin tamamını listeler. aşağıdaki fonksiyonda ise tek bir değer getirir.
        T GetByID(int id);//id ye göre tek bir değer getirmek için
    }
}
