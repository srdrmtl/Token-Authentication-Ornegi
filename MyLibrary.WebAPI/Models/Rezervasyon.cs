using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MyLibrary.WebAPI.Models
{
    public class Rezervasyon
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Tel { get; set; }
        public string Pansiyontipi { get; set; }

    }
}