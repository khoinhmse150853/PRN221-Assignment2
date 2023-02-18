using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BusinessObject;
using Repository;
using Microsoft.AspNetCore.Http;
using NguyenHuynhMinhKhoiRazorPages.Validation;

namespace NguyenHuynhMinhKhoiRazorPages.Pages.CustomerInfo
{
    public class EditModel : PageModel
    {
        private ICustomerRepository customerRepository;

        [BindProperty]
        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            customerRepository = new CustomerRepository();

            if (id == null)
            {
                return Redirect("/Error/AuthorizedError");
            }
            else if (HttpContext.Session.GetString("Role") != "Customer")
            {
                return Redirect("/Error/AuthorizedError"); ;
            }
            else
            {
                Customer = customerRepository.GetCustomerById(id);
                ViewData["Pass"] = Customer.CustomerPassword;

                if (Customer == null)
                {
                    return Redirect("/Error/AuthorizedError");
                }
                return Page();
            }
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
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
                else
                {
                    customerRepository.UpdateCustomer(Customer);
                    return Redirect("/CustomerInfo/Details?id=" + HttpContext.Session.GetString("CustomerId"));
                }
            }
        }
    }
}
