using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;

namespace DataAccess
{
    public interface ICustomerRepository
    {
        void AddNewCustomer(Customer newCustomer);
        Customer GetById(int id);
        void UpdateCustomer(Customer customer);

        List<Customer> GetAll();
        List<Customer> SearchCustomerByName(string name);
        List<Customer> SearchCustomerByPhone(string phone);
        List<Customer> SearchCustomerByNameAndPhone(string name, string phone);

        Customer CheckCustomerByPhone(string phone);
    }
}
