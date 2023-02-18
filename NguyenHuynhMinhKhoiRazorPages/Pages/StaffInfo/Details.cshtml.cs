using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject;

namespace NguyenHuynhMinhKhoiRazorPages.Pages.Staff
{
    public class DetailsModel : PageModel
    {
        private readonly BusinessObject.CarRentalSystemDBContext _context;

        public DetailsModel(BusinessObject.CarRentalSystemDBContext context)
        {
            _context = context;
        }

        public StaffAccount StaffAccount { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            StaffAccount = await _context.StaffAccounts.FirstOrDefaultAsync(m => m.StaffId == id);

            if (StaffAccount == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
