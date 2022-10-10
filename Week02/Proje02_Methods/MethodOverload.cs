using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proje02_Methods
{
    public class MethodOverload
    {
        public void DenemeMetodu()
        {
            Console.WriteLine("Merhaba. Ben MethodOverload classındayım!");
        }
        //Gönderilen üç sayı arasında istersem toplama, istersem çarpma yapsın
        public int Topla(int s1, int s2, int s3 = 0, bool islemTuru=true)
        {
            if(islemTuru == true)
            {
                return s1 + s2 + s3;
            }
            else
            {
                if (s3 == 0) s3 = 1;
                return s1 * s2 * s3;
            }
        }
        public int Topla(int[] sayilar)
        {
            int sonuc = sayilar.Sum();
            return sonuc;
        }


    }
}
