using Solid06_DependencyInversion.After;

namespace Solid06_DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Before
            //MailService mailService = new MailService();
            //mailService.SendMail(new GmailServer());
            #endregion

            #region After
            MailService mailService = new MailService();
            mailService.SendMail(new GmailServer(), "harun@gmail.com", "selam");
            mailService.SendMail(new HotmailServer(), "harun@hotmail.com", "Merhaba");
            #endregion
        }
    }
}