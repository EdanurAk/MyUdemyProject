﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {//bize register sırasında ne gerekiyorsa o proeprtyleri tanımlıyoruz.
       
        [Required(ErrorMessage ="Ad alanı gereklidir.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad alanı gereklidir.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı Adı alanı gereklidir.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Mail alanı gereklidir.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre alanı gereklidir.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre Tekrar alanı gereklidir.")]
        [Compare("Password", ErrorMessage ="Şifreler Uyuşmuyor.")]
        public string ConfirmPassword { get; set; }
    }
}
