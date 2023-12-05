using HotelProject.WebUI.Dtos.ServiceDto;
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
    public class ServiceController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ServiceController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44388/api/Service");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData);
                return View(values);

            }
            return View();
        }
        [HttpGet]//sayfa yüklendiğinde yani geriye sadece view döndürcek
        public IActionResult AddService()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddService(CreateServiceDto createServiceDto)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            var client = _httpClientFactory.CreateClient();//istemci oluşturuldu.
            var jsonData = JsonConvert.SerializeObject(createServiceDto);//yukarıdaki kodda deserialize etmiştik çünkü json türünde bir data geliyodu biz o datayı listelemek istiyorduk bu kez biz bir data göndericez ve bu data json a dönüşcek o yüzden serialize edicez.  
            //stringcontent ilk parametresi benden content istiyo 2.parametresi göndermiş olduğum bu içeriği türkçe karakteri destekleyecek şekilde getir.  
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");//stringcontent içeriğimizin dönüşümü için kullanacağımız bir sınıf  
            var responseMessage = await client.PostAsync("https://localhost:44388/api/Service", stringContent);//Eklemek için postasync kullanıyoruz
            if (responseMessage.IsSuccessStatusCode)//başarılı bir durum kodu dönerse
            {

                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> DeleteService(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:44388/api/Service/{id}");//Silme işlemi olduğu için DeleteAsync kulandık. Apinin sonunda parametrede verilen id ye ait olan değeri sil demiş oluyoruz. 
            if (responseMessage.IsSuccessStatusCode)//başarılı bir durum kodu dönerse
            {

                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]//sayfa yüklendiğinde çalışcak olan metod için
        public async Task<IActionResult> UpdateService(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:44388/api/Service/{id}");//Güncellemek istediğim verileri getirmek istediğim için getasync kullandık. ve id ye göre getireceimiz için yine {id} yazdık. 
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();//listeleme işlemindeki gibi
                var values = JsonConvert.DeserializeObject<UpdateServiceDto>(jsonData);//bana sadece bir verinin verileri geleceği için liste içine almıyoruz.
                return View(values);
            }
            return View();
        }
        [HttpPost]//sayfada bir post işlemi gerçekleştiğinde çalışacak kısım
        public async Task<IActionResult> UpdateService(UpdateServiceDto updateServiceDto)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateServiceDto);//model parametresi jsonformatına dönüşmesi için serialize ettik
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:44388/api/Service", stringContent);//Güncelleme işlemi olduğu için Putasync kullandık
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
