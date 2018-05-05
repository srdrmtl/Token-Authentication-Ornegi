using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyLibrary.WebAPI.Models;
namespace MyLibrary.WebAPI.Controllers
{
    [Authorize]//Burası Önemli Buradan Erişimi Kısıtlıyoruz.
    public class ReservationController : ApiController
    {
        private LibraryService db = new LibraryService();

        [HttpGet]
        public IQueryable<Rezervasyon> GetReservation()
        {
            return db.Rezervasyonlar;
        }
        [HttpPost]
        public IHttpActionResult AddReservation(Rezervasyon entity)
        {
            db.Rezervasyonlar.Add(entity);
            db.SaveChanges();
            return Json("Yeni Rezervasyon Eklendi");
        }

        [HttpPut]
        public IHttpActionResult UpdateReservation(Rezervasyon entity)
        {
            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return Json("Başarıyla Güncellendi");

        }

        [HttpDelete]
        public IHttpActionResult DeleteReservation(int Id)
        {
            var temp = db.Rezervasyonlar.FirstOrDefault(x => x.Id == Id);
            db.Rezervasyonlar.Remove(temp);
            db.SaveChanges();
            return Json("Başarıyla Silindi");
        }

    }
}
