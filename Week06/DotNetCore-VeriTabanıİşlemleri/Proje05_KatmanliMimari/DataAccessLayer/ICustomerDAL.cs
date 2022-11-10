using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proje05_KatmanliMimari.DataAccessLayer.Entities;

namespace Proje05_KatmanliMimari.DataAccessLayer
{
    public interface ICustomerDAL
    {
        void CreateCustomer(Customer customer);
        List<Customer> GettAllCustomers();
        Customer GetByCustomerId(int Id);
        void UpdateCustomer(Customer customer);
        void deleteCustomer(int id);
    }
}