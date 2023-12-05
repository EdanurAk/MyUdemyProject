using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.RegisterDto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    //Register işlemi sırasında Api consume edilmeyecek çünkü
    //buranın zaten kendi registerı olacak kendi tüketilecek kodları olacak.
    public class RegisterController : Controller//bir kayıt işlemi için
    {
        private readonly UserManager<AppUser> _userManager;//bu sınıfta gerçekleşecek olan işlemler(register vs) hangi sınıf için yapılacak AppUser için yapılacağı için parametre olacak onu verdik.  

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateNewUserDto createNewUserDto)//metodum async olcak çünkü içerisinde async yapılar kullanıcam
        {
            if(!ModelState.IsValid)
            {
                return View();//Model geçerli değilse hata dönmesi gerekiyo bunun için front edn tarafında mapping klasöründe eşleştirmesini yapmam gerekiyo.
            }
            var appUser = new AppUser()//appuser sınıfından bir örnek alıyoruz
            {
                
                Name = createNewUserDto.Name,
                Email = createNewUserDto.Mail,
                Surname = createNewUserDto.Surname,
                UserName=createNewUserDto.UserName,//appuser sınıfımın içinde email ve username yok normalde appuser IdentityUser dan kalıtım aldığı için e mail ve username IdentityUser dan geliyo
                
            };
            //password değeri yukardaki gibi atanmaz. Aşağıdaki gibi tanımlanır
            var result = await _userManager.CreateAsync(appUser, createNewUserDto.Password);//CreateAsync, UserManager sınıfıyla gelen bir metod identity kütüphanesinde yeni bir kayıt oluşturmak için kullanılıyor 
           if(result.Succeeded)//başarılı dönerse yani true dönerse
            {
                return RedirectToAction("Index","Login");
            }
            return View();
        }
    }
}
