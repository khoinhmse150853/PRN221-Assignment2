using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject;
using Repository;
using Microsoft.AspNetCore.Http;
using NguyenHuynhMinhKhoiRazorPages.Ultils;

namespace NguyenHuynhMinhKhoiRazorPages.Pages.CustomerInfo
{
    public class DetailsModel : PageModel
    {
        private ICustomerRepository customerRepository;

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            customerRepository = new CustomerRepository();
            HidePassword hide = new HidePassword();

            if (id == null)
            {
                return Redirect("/Error/AuthorizedError");
            }
            else if(HttpContext.Session.GetString("Role") != "Customer")
            {
                return Redirect("/Error/AuthorizedError");
            }
            else
            {
                Customer = customerRepository.GetCustomerById(id);
                Customer.CustomerPassword = hide.NotShowPassword(Customer.CustomerPassword);

                if (Customer == null)
                {
                    return Redirect("/Error/AuthorizedError");
                }
                return Page();
            }
        }
    }
}
