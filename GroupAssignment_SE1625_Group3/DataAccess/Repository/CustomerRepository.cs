using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;
namespace DataAccess
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer CheckCustomerByPhone(string phone) => CustomerDAO.Instance.CheckCustomerByPhone(phone);

        void ICustomerRepository.AddNewCustomer(Customer newCustomer) => CustomerDAO.Instance.AddCustomer(newCustomer);

        List<Customer> ICustomerRepository.GetAll() => CustomerDAO.Instance.GetAllCustomer();

        Customer ICustomerRepository.GetById(int id) => CustomerDAO.Instance.GetCustomerById(id);

        List<Customer> ICustomerRepository.SearchCustomerByName(string name) => CustomerDAO.Instance.GetCustomerByName(name);

        List<Customer> ICustomerRepository.SearchCustomerByNameAndPhone(string name, string phone) => CustomerDAO.Instance.GetCustomerByNameAndPhone(name, phone);

        List<Customer> ICustomerRepository.SearchCustomerByPhone(string phone) => CustomerDAO.Instance.GetCustomerByPhone(phone);

        void ICustomerRepository.UpdateCustomer(Customer customer) => CustomerDAO.Instance.UpdateCustomer(customer);
    }
}
