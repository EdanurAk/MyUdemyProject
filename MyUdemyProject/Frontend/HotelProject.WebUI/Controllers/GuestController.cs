using HotelProject.WebUI.Dtos.GuestDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class GuestController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public GuestController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        //1)bir tane istemci oluşturdum 2)yazılan adrese istekte bulundum. 3)eğer o adresten başarılı bir durum kodu dönerse gelen veriyi jsonData diye bir değişkene atadım
        //4)JsonData daki veri json türünde, json türündeki veriyi de deserialize ederek normal benim tablomda gösterebileceğim formata dönüştürdüm
        //5)ve return view ile de values taşımış oldum.
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();//bir tane istemci oluştur
            var responseMessage = await client.GetAsync("https://localhost:44388/api/Guest");//verileri listelemek istediğimiz için getasync metodunu kullandık başka metodlar da var. İstek yapacağım adresi içine aldım.
            if (responseMessage.IsSuccessStatusCode)//eğer ki burada başarılı bir durum kodu dönerse
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();//responsemessage den gelen içeriği asenkronik olarak oku
                var values = JsonConvert.DeserializeObject<List<ResultGuestDto>>(jsonData);//json bir data geldiği için onu deserialize yapmak gerekiyo 
                return View(values);
            }
            return View();
        }
        [HttpGet]//sayfa yüklendiğinde yani geriye sadece view döndürcek
        public IActionResult AddGuest()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddGuest(CreateGuestDto createGuestDto)
        {
            if (ModelState.IsValid)
            {
                var client = _httpClientFactory.CreateClient();//istemci oluşturuldu.
                var jsonData = JsonConvert.SerializeObject(createGuestDto);//yukarıdaki kodda deserialize etmiştik çünkü json türünde bir data geliyodu biz o datayı listelemek istiyorduk bu kez biz bir data göndericez ve bu data json a dönüşcek o yüzden serialize edicez.  
                                                                           //stringcontent ilk parametresi benden content istiyo 2.parametresi göndermiş olduğum bu içeriği türkçe karakteri destekleyecek şekilde getir.  
                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");//stringcontent içeriğimizin dönüşümü için kullanacağımız bir sınıf  
                var responseMessage = await client.PostAsync("https://localhost:44388/api/Guest", stringContent);//Eklemek için postasync kullanıyoruz
                if (responseMessage.IsSuccessStatusCode)//başarılı bir durum kodu dönerse
                {

                    return RedirectToAction("Index");
                }
                return View();
            }
            else
            {
                return View();
            }
        }
        public async Task<IActionResult> DeleteGuest(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:44388/api/Guest/{id}");//Silme işlemi olduğu için DeleteAsync kulandık. Apinin sonunda parametrede verilen id ye ait olan değeri sil demiş oluyoruz. 
            if (responseMessage.IsSuccessStatusCode)//başarılı bir durum kodu dönerse
            {

                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]//sayfa yüklendiğinde çalışcak olan metod için
        public async Task<IActionResult> UpdateGuest(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:44388/api/Guest/{id}");//Güncellemek istediğim verileri getirmek istediğim için getasync kullandık. ve id ye göre getireceimiz için yine {id} yazdık. 
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();//listeleme işlemindeki gibi
                var values = JsonConvert.DeserializeObject<UpdateGuestDto>(jsonData);//bana sadece bir verinin verileri geleceği için liste içine almıyoruz.
                return View(values);
            }
            return View();
        }
        [HttpPost]//sayfada bir post işlemi gerçekleştiğinde çalışacak kısım
        public async Task<IActionResult> UpdateGuest(UpdateGuestDto updateGuestDto)
        {
            if (ModelState.IsValid)
            {
                var client = _httpClientFactory.CreateClient();
                var jsonData = JsonConvert.SerializeObject(updateGuestDto);//model parametresi jsonformatına dönüşmesi için serialize ettik
                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var responseMessage = await client.PutAsync("https://localhost:44388/api/Guest", stringContent);//Güncelleme işlemi olduğu için Putasync kullandık
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                return View();
            }
            else
            {
                return View();
            }
        }
    }
}
