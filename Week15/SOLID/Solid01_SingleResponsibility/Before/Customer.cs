using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid01_SingleResponsibility.Before
{
    public class Customer
    {
        void Login(string username, string password)
        {
            //Login işlemleriyle ilgili kodlar
        }

        void Register(string username, string password, string mail)
        {
            //Register işlemleri
            SendMail("Kaydınız başarıyla gerçekleşmiştir.");
        }
        void SendMail(string text)
        {
            //Mail göndrme işlemleri ile ilgili kodlar.
        }
    }
}
