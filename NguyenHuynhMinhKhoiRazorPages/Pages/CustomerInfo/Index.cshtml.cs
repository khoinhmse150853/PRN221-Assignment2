using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject;
using Repository;

namespace NguyenHuynhMinhKhoiRazorPages.Pages.CustomerInfo
{
    public class IndexModel : PageModel
    {
        private ICustomerRepository customerRepository;

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            customerRepository = new CustomerRepository();
            Customer = customerRepository.GetCustomerList().ToList();
        }
    }
}
