using System.Data.SqlClient;

namespace P01_SqlBaglantiOlusturma;
class Program
{
    static void Main(string[] args)
    {
        GetSqlConnection();
    }
    static void GetSqlConnection()
    {
        /*  1. ADIM
            ConnectionString oluşturmak
        */
        string connectionString = "Server = DESKTOP-OFVK2FD; DataBase = NorthWind; User Id = sa; Password = 123;";
        using (var connection = new SqlConnection(connectionString))
        {
            //connection nesnesi sadece bu scope içinde yaşayıp, scope bitişinde bellekten kaldırılmış olacak!
            try
            {
                connection.Open();
                Console.WriteLine("Bağlantı Sağlandı...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
