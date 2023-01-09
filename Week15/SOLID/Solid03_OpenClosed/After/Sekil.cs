using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid03_OpenClosed.After
{
    public abstract class Sekil //Eğer bir methodların bir kısmının içeriği yeniden yazılsın, içeriğini yazdığım kısımlar olduğu gibi kalsın istiyorsak abstract class tanımlayabiliriz.
        //Interface yapsaydık her methodun içerisine kod yazmamız gerekir.
    {
        public abstract double AlanHesapla();
        public void SelamVer()
        {
            Console.WriteLine("Merhaba");
        }
    }
}
