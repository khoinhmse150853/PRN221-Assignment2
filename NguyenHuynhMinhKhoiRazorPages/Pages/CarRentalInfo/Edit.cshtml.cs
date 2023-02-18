using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BusinessObject;

namespace NguyenHuynhMinhKhoiRazorPages.Pages.CarRentalInfo
{
    public class EditModel : PageModel
    {
        private readonly BusinessObject.CarRentalSystemDBContext _context;

        public EditModel(BusinessObject.CarRentalSystemDBContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["CarId"] = new SelectList(_context.Cars, "CarId", "CarId");
           ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerId");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CarRental).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarRentalExists(CarRental.CustomerId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CarRentalExists(string id)
        {
            return _context.CarRentals.Any(e => e.CustomerId == id);
        }
    }
}
