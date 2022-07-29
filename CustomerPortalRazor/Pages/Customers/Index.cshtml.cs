using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CustomerPortalRazor.Data;
using CustomerPortalRazor.Data.Models;

namespace CustomerPortalRazor.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly CustomerPortalRazor.Data.ApplicationDbContext _context;

        public IndexModel(CustomerPortalRazor.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customers.ToListAsync();
        }
    }
}
