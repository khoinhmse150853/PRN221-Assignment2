using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BusinessObject;
using Repository;
using Microsoft.AspNetCore.Http;
using NguyenHuynhMinhKhoiRazorPages.Validation;

namespace NguyenHuynhMinhKhoiRazorPages.Pages.CustomerInfo
{
    public class CreateModel : PageModel
    {
        private ICustomerRepository customerRepository;

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Customer Customer { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            customerRepository = new CustomerRepository();
            DataValidation validation = new DataValidation();

            ViewData["Pass"] = Customer.CustomerPassword;

            if (!ModelState.IsValid)
            {
                return Page();
            }
            else if (HttpContext.Session.GetString("Role") != "Customer")
            {
                return Redirect("/Error/AuthorizedError"); ;
            }
            else
            {
                if (!validation.IsDigitsOnly(Customer.LicenceNumber))
                {
                    ModelState.AddModelError("Customer.LicenceNumber", "Licence number is not valid");
                    return Page();
                }
                else if (!validation.IsDigitsOnly(Customer.IdentityCard))
                {
                    ModelState.AddModelError("Customer.IdentityCard", "Identity card is not valid");
                    return Page();
                }
                else if (!validation.IsValidFormatCustomerId(Customer.CustomerId))
                {
                    ModelState.AddModelError("Customer.CustomerId", "Customer Id must start with C");
                    return Page();
                }
                else if (customerRepository.GetCustomerById(Customer.CustomerId) != null)
                {
                    ModelState.AddModelError("Customer.CustomerId", "Customer Id was existed");
                    return Page();
                }
                else
                {
                    customerRepository.AddCustomer(Customer);
                    ViewData["Message"] = "Register account successfully!";
                    return Page();
                }
            }
        }
    }
}
