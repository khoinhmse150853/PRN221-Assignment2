using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject;

namespace NguyenHuynhMinhKhoiRazorPages.Pages.CarRentalInfo
{
    public class DetailsModel : PageModel
    {
        private readonly BusinessObject.CarRentalSystemDBContext _context;

        public DetailsModel(BusinessObject.CarRentalSystemDBContext context)
        {
            _context = context;
        }

        public CarRental CarRental { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CarRental = await _context.CarRentals
                .Include(c => c.Car)
                .Include(c => c.Customer).FirstOrDefaultAsync(m => m.CustomerId == id);

            if (CarRental == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
