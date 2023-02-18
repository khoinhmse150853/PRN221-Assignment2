using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessObject;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Repository;

namespace NguyenHuynhMinhKhoiRazorPages.Pages.CustomerInfo
{
    public class RentingHistoryModel : PageModel
    {
        private ICustomerRepository customerRepository;

        public IList<CarRental> RentingHistory { get; set; }

        public IActionResult OnGet()
        {
            customerRepository = new CustomerRepository();
            if (HttpContext.Session.GetString("Role") != "Customer")
            {
                return Redirect("/Error/AuthorizedError");
            }
            else
            {
                RentingHistory = customerRepository.ViewRentingHistory(HttpContext.Session.GetString("CustomerId")).ToList();
                return Page();
            }
            
        }
    }
}
