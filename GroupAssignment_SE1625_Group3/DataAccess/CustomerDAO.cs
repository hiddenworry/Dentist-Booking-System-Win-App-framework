using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;

namespace DataAccess
{
    public class CustomerDAO
    {

        private static CustomerDAO instance;
        private static readonly object InstanceLock = new object();
        private CustomerDAO() { }
        public static CustomerDAO Instance
        {
            get
            {
                lock (InstanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CustomerDAO();
                    }
                    return instance;
                }
            }
        }

        public void UpdateCustomer(Customer newCustomer)
        {
            try
            {
                using (var context = new DBSContext())
                {
                    var cus = context.Customers.Where(x => x.Phone == newCustomer.Phone && x.Id != newCustomer.Id).FirstOrDefault();
                    if (cus == null)
                    {
                        context.Customers.Update(newCustomer);
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Phone is already in use");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Customer GetCustomerById(int id)
        {
            try
            {
                using (var context = new DBSContext())
                {
                    var customer = context.Customers.Where(x => x.Id == id).FirstOrDefault();
                    return customer;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void AddCustomer(Customer newCustomer)
        {
            try
            {
                using (var context = new DBSContext())
                {
                    var cus = context.Customers.Where(x => x.Phone == newCustomer.Phone).FirstOrDefault();
                    if(cus == null)
                    {
                        context.Customers.Add(newCustomer);
                        context.SaveChanges();
                    } else
                    {
                        throw new Exception("Phone is already in use");
                    }
                   
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Customer> GetAllCustomer()
        {
            try
            {
                using (var context = new DBSContext())
                {
                    return context.Customers.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Customer> GetCustomerByName(string name)
        {
            try
            {
                using (var context = new DBSContext())
                {
                    return context.Customers.Where(x => x.Name.Contains(name)).ToList();
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Customer> GetCustomerByPhone(string phone)
        {
            try
            {
                using (var context = new DBSContext())
                {
                    return context.Customers.Where(x => x.Phone.Contains(phone)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Customer CheckCustomerByPhone(string phone)
        {
            try
            {
                using (var context = new DBSContext())
                {
                    return context.Customers.FirstOrDefault(x => x.Phone.Equals(phone));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Customer> GetCustomerByNameAndPhone(string name, string phone)
        {
            try
            {

                using (var context = new DBSContext())
                {
                    return context.Customers.Where(x => x.Phone.Contains(phone) && x.Name.Contains(name)).ToList();
                }
                //var listName = GetCustomerByName(name);
                //var listPhone = GetCustomerByPhone(phone);
                //return (from n in listName
                //        join p in listPhone
                //        on n.Id equals p.Id 
                //        select n).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
