namespace WebApplication1.Services
{
    public interface IEmailService
    {
        void Send(string to, string message, string topic);
    }
}
