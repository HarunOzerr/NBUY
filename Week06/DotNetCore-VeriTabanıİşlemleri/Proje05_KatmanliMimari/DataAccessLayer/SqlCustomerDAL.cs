using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Proje05_KatmanliMimari.DataAccessLayer.Entities;

namespace Proje05_KatmanliMimari.DataAccessLayer
{
    public class SqlCustomerDAL : ICustomerDAL
    {
        private SqlConnection GetSqlConnection()
        {
            string connectionString = @"Server=DESKTOP-OFVK2FD; Database=Northwind; User=sa; Pwd=123;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }
        public void CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void deleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Customer GetByCustomerId(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GettAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            using (var connection = GetSqlConnection())
            {
                try
                {
                    connection.Open();
                    string queryString = "SELECT CustomerId, CompanyName, ContactName, Country FROM Customers";
                    SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        customers.Add(new Customer(){
                            Id = sqlDataReader["CustomerId"].ToString(),
                            CompanyName = sqlDataReader["CompanyName"].ToString(),
                            ContactName = sqlDataReader["ContactName"].ToString(),
                            Country = sqlDataReader["Country"].ToString()
                        });
                    }
                    sqlDataReader.Close();
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Bir Hata Oluştu!");
                }
                finally
                {
                    connection.Close();
                }
            }
            return customers;
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}