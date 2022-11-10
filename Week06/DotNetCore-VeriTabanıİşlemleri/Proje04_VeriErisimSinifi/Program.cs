using System.Data.SqlClient;

namespace Proje04_VeriErisimSinifi;
class Program
{
    static void Main(string[] args)
    {
        int secim;
       do
       {
        Console.Clear();
        Console.WriteLine("1 - Products");
        Console.WriteLine("2 - Customers");
        Console.WriteLine("0 - Exit");
        Console.Write("Seçiminizi Giriniz:");
        secim = Convert.ToInt32(Console.ReadLine());
        // List<Customer> customers = GetAllCustomers();
        if (secim == 1)
        {
            ProductList();
            Console.ReadLine();
        }
        // else if(secim == 2)
        // {
        //     CustomerList();
            // Console.ReadLine();
        // }
        else if (secim != 0)
        {
            Console.WriteLine("Lütfen geçerli bir seçim yapınız!");
            Console.ReadLine();
        }
       } while (secim != 0);
    }
    static void ProductList()
    {
        // SqlProductDAL sqlProductDAL = new SqlProductDAL();
        // List<Product> products = sqlProductDAL.GetAllProducts();
        SqliteProductDal sqliteProductDAL = new SqliteProductDal();
        List<Product> products = sqliteProductDAL.GetAllProducts();
        foreach (var product in products)
        {
            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
        }
    }
    // static void CustomerList()
    // {
    //     List<Customer> customers = GetAllCustomers();
    //     foreach (var customer in customers)
    //     {
    //         Console.WriteLine($"Id: {customer.Id}, Company Name: {customer.CompanyName}, Contact Name: {customer.ContactName}, Country: {customer.Country}");
    //     }
    // }
    // static List<Customer> GetAllCustomers()
    // {
    //     List<Customer> customers = new List<Customer>();
    //     using (var connection = GetSqlConnection())
    //     {
    //         try
    //         {
    //         connection.Open();
    //         string queryString = "SELECT CustomerID, CompanyName, ContactName, Country FROM Customers";
    //         SqlCommand sqlCommand = new SqlCommand(queryString, connection);
    //         SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
    //         while (sqlDataReader.Read())
    //         {
    //             customers.Add(new Customer {
    //                 Id = sqlDataReader["CustomerID"].ToString(), //String olarak belirterekte index sayısı vermeden hangi satırdan alacağını belirtebiliriz.
    //                 CompanyName = sqlDataReader["CompanyName"].ToString(),
    //                 ContactName = sqlDataReader[2].ToString(),
    //                 Country = sqlDataReader[3].ToString()
    //             });
    //         }
    //         sqlDataReader.Close();
    //         }
    //         catch (Exception)
    //         {
    //             Console.WriteLine("Bir sorun oluştu!");
    //         }
    //         finally
    //         {
    //             connection.Close();
    //         }
    //     }
    //     return customers;
    // }
}
