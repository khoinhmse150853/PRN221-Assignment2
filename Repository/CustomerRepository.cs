using BusinessObject;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public void AddCustomer(Customer customer)
        {
            CustomerDAO.Instance.AddNew(customer);
        }

        public Customer GetCustomerById(string customerID)
        {
            return CustomerDAO.Instance.GetCustomerById(customerID);
        }

        public IEnumerable<Customer> GetCustomerList()
        {
            return CustomerDAO.Instance.GetCustomerList();
        }

        public Customer LoginByCustomerAccount(string email, string password)
        {
            return CustomerDAO.Instance.LoginByCustomerAccount(email, password);
        }

        public void UpdateCustomer(Customer customer)
        {
            CustomerDAO.Instance.Update(customer);
        }

        public IEnumerable<CarRental> ViewRentingHistory(string customerID)
        {
            return CustomerDAO.Instance.ViewRentingHistory(customerID);
        }
    }
}
