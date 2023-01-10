using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid05_InterFaceSegregation.After
{
    public class ElektrikliOtomobil : IOtomobilOrtak, IElektrikliMotor
    {
        public string BataryaTipiniGetir()
        {
            throw new NotImplementedException();
        }

        public int KapiSayisiniGetir()
        {
            throw new NotImplementedException();
        }

        public int UretimYili()
        {
            throw new NotImplementedException();
        }

        public decimal VoltajDegeriniGetir()
        {
            throw new NotImplementedException();
        }

        public string YakitTipiniGetir()
        {
            throw new NotImplementedException();
        }
    }
}
