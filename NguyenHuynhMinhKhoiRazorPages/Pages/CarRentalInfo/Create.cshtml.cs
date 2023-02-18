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

namespace NguyenHuynhMinhKhoiRazorPages.Pages.CarRentalInfo
{
    public class CreateModel : PageModel
    {
        private ICarRepository carRepository;

        private ICustomerRepository customerRepository;

        private ICarRentalRepository carRentalRepository;

        public IActionResult OnGet()
        {
            carRepository = new CarRepository();
            customerRepository = new CustomerRepository();

            ViewData["CarId"] = new SelectList(carRepository.GetCarList(), "CarId", "CarName");
            ViewData["CustomerId"] = new SelectList(customerRepository.GetCustomerList(), "CustomerId", "CustomerName");
            return Page();
        }

        [BindProperty]
        public CarRental CarRental { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            carRentalRepository = new CarRentalRepository();
            carRepository = new CarRepository();
            customerRepository = new CustomerRepository();
            DataValidation validation = new DataValidation();

            ViewData["CarId"] = new SelectList(carRepository.GetCarList(), "CarId", "CarName");
            ViewData["CustomerId"] = new SelectList(customerRepository.GetCustomerList(), "CustomerId", "CustomerName");

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

                if (DateTime.Compare(CarRental.PickupDate, CarRental.ReturnDate) >= 0)
                {
                    ModelState.AddModelError("CarRental.ReturnDate", "Return date must be later than pick date");
                    return Page();
                }
                else if (carRentalRepository.CheckCarRentalBetweenDate(CarRental) != null)
                {
                    CarRental rental = carRentalRepository.CheckCarRentalBetweenDate(CarRental);
                    ModelState.AddModelError("CarRental.PickupDate", "Car was rent from: " + rental.PickupDate.ToString("dd/MM/yyyy") + " to: " + rental.ReturnDate.ToString("dd/MM/yyyy"));
                    ModelState.AddModelError("CarRental.ReturnDate", "Car was rent from: " + rental.PickupDate.ToString("dd/MM/yyyy") + " to: " + rental.ReturnDate.ToString("dd/MM/yyyy"));
                    return Page();
                }
                else
                {
                    carRentalRepository.AddCarRental(CarRental);
                    ViewData["Message"] = "Created successfully!";
                    return Page();
                }
            }
        }
    }
}
