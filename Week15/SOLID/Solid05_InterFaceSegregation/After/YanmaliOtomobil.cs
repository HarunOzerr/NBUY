using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid05_InterFaceSegregation.After
{
    public class YanmaliOtomobil : IOtomobilOrtak, IYanmaliMotor
    {
        public int KapiSayisiniGetir()
        {
            throw new NotImplementedException();
        }

        public int UretimYili()
        {
            throw new NotImplementedException();
        }
    }
}
