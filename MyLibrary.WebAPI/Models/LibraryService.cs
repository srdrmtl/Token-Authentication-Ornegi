using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace MyLibrary.WebAPI.Models
{
    public class LibraryService :DbContext
     {
        public LibraryService() : base("name = MyLibraryEntity")
        {

        }
        public DbSet<Rezervasyon> Rezervasyonlar { get; set; }

    }
}