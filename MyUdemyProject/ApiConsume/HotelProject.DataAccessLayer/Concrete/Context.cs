using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;//dbcontext sınıfından miras alabilmek için kullandık.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Concrete
{
    //DbContext sınıfından değil, IdentityDbContext sınıfından türetilmiştir.
    //Bunun sebebi Identity içerisindeki yapıların ve tabloların normal 
    //DbContext sınıfından farklı olması ve içerisinde bulunmamasıdır.
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-ENO0AVRU;initial catalog=ApiDb; integrated security=true");//bağlantı adresini tanımlıyoruz.
        }
        public DbSet<Room> Rooms { get; set; }//sol taraftaki sınıfımızın ismi sağ taraftaki sql e yansıyacak tablomuzun ismi
        public DbSet<Service> Services { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Contact> Contacts { get; set; }

    }
}
