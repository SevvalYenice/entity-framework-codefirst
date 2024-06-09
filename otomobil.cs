using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _36504122010.Models.sınıflar
{
    public class Otomobil
    {
        [Key]
        public int Id { get; set; }
        public string Model { get; set; }
        public int Kodu { get; set; }
        public int Fiyat { get; set; }
        public string Aciklama { get; set; }
        public bool SatistaMi { get; set; }
         
       
    }
}