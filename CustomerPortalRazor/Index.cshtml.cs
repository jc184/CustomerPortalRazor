using CustomerPortalRazor.Data.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomerPortalRazor
{
    public class IndexModel : PageModel
    {
        private readonly CustomerPortalRazor.Data.ApplicationDbContext _context;

        public IndexModel(CustomerPortalRazor.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get; set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customers.ToListAsync();
        }
    }
}
