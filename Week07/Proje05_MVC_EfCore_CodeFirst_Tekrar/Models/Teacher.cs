using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje05_MVC_EfCore_CodeFirst_Tekrar.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Yas { get; set; }
        public int BolumId { get; set; }
        public Bolum Bolum { get; set; }
    }
}