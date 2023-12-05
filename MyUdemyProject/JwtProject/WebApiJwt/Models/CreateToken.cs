using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace WebApiJwt.Models
{
    public class CreateToken
    {//JWT'ler, kimlik doğrulama ve yetkilendirme gibi güvenlik senaryolarında sıklıkla kullanılır.
        public string TokenCreate()
        {
            var bytes = Encoding.UTF8.GetBytes("aspnetcoreapiapi");//tokenin keyi start up da önce onu geçtik aspnet..
            SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);

            //alttaki kodda da kimlik işlemini yapıyoruz
            SigningCredentials credentials = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);//ikinci parametre bir şifreleme algoritması
           //Token oluşturmak için gerekli parametreleri aşağıda verdim
            JwtSecurityToken token = new JwtSecurityToken(issuer:"http://localhost",audience: "http://localhost"
                ,notBefore:DateTime.Now,expires:DateTime.Now.AddSeconds(30), signingCredentials:credentials);
           
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();//oluşturucu
            return handler.WriteToken(token);//handler aracılığı ile token yaz token oluştur.
        }
        public string TokenCreateAdmin()//Admin için bir token oluşturucam.
        {
            var bytes = Encoding.UTF8.GetBytes("aspnetcoreapiapi");
            SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);
            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            List<Claim> claims = new List<Claim>()//claim burda rollerimizin içeriğini tutacak
            { //ilgili claimin name i ve id si vermesek de çalışırız ama eklersek daha güzel olur
                new Claim(ClaimTypes.NameIdentifier,Guid.NewGuid().ToString()),//Claim nesnesi, bir kullanıcının veya nesnenin sahip olduğu bir hak veya kimlik doğrulama bilgisini temsil eder. İki parametre alır:
                new Claim(ClaimTypes.Role,"Admin"),//1.rolüm admin
                new Claim(ClaimTypes.Role,"Visitor")//istemcilerin rolleri
            };
            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(issuer: "http://localhost", audience: "http://localhost"
                , notBefore: DateTime.Now, expires: DateTime.Now.AddMinutes(30), signingCredentials: credentials,claims:claims);
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            return handler.WriteToken(jwtSecurityToken);
        }
    }
}
