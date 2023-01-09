using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid04_LiskovsSubstition.Before
{
    public class Kus
    {
        public int KanatAraligi { get; set; }
        public string? LatinceAdi { get; set; }
        public virtual double UcmaMesafesi() //Eğer kuşu miras verdiğim tüm sınıflarda UcmaMesafesi yeniden yazılmak zorunda olsaydı abstract yapardık. 
        {
            return 0;
        }
    }
}
