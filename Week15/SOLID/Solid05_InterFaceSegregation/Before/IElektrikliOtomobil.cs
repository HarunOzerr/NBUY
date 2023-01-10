using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid05_InterFaceSegregation.Before
{
    public interface IElektrikliOtomobil
    {
        public string BataryaTipi { get; set; }
        public string BataryaTipiniGetir();
        public decimal VoltajDegeriniGetir();
    }
}
