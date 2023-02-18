using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject;
using Repository;

namespace NguyenHuynhMinhKhoiRazorPages.Pages.Staff
{
    public class IndexModel : PageModel
    {
        private IStaffAccountRepository staffAccountRepository;

        public IList<StaffAccount> StaffAccount { get;set; }

        public async Task OnGetAsync()
        {
            staffAccountRepository = new StaffAccountRepository();
            StaffAccount = staffAccountRepository.GetStaffAccountList().ToList();
        }
    }
}
