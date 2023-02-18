using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICustomerRepository
    {
        Customer LoginByCustomerAccount(String email, String password);
        IEnumerable<Customer> GetCustomerList();
        Customer GetCustomerById(String customerID);
        void UpdateCustomer(Customer customer);
        void AddCustomer(Customer customer);
        IEnumerable<CarRental> ViewRentingHistory(String customerID);
    }
}
