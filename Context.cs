using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace _36504122010.Models.sınıflar
{
    public class Context:DbContext
    {
        public DbSet<Otomobil> Otomabils { get; set; }
    }
}