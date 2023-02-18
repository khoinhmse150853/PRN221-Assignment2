using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BusinessObject;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Repository;

namespace NguyenHuynhMinhKhoiRazorPages.Pages.Login
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        [BindProperty]
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [BindProperty]
        [Required]
        public string Password { get; set; }

        private ICustomerRepository customerRepository;

        private bool LoginByAdminAccount(String email, String password)
        {
            String _email, _password;

            using (StreamReader r = new StreamReader("appsettings.json"))
            {
                string json = r.ReadToEnd();
                IConfiguration config = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("appsettings.json", true, true)
                                        .Build();
                _email = config["account:defaultAccount:email"];
                _password = config["account:defaultAccount:password"];
            }

            if (email.Equals(_email) && password.Equals(_password))
            {
                HttpContext.Session.SetString("Role", "Admin");
                return true;
            }
            else
            {
                return false;
            }
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            customerRepository = new CustomerRepository();

            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                if (LoginByAdminAccount(Email, Password))
                {
                    return Redirect("/StaffInfo/Index");
                }
                else if (customerRepository.LoginByCustomerAccount(Email, Password) != null)
                {
                    Customer customer = customerRepository.LoginByCustomerAccount(Email, Password);

                    HttpContext.Session.SetString("Role", "Customer");
                    HttpContext.Session.SetString("CustomerId", customer.CustomerId);

                    return Redirect("/CustomerInfo/Details?id=" + customer.CustomerId);
                }
                else
                {
                    ViewData["Message"] = "Username or Password is not correct!";
                    ViewData["Email"] = Email;
                    return Page();
                }
            }
        }
    }
}
