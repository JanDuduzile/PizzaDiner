using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaDiner.Models;

namespace PizzaDiner.Pages
{
    public class IndexModel : PageModel
    {
        private readonly PizzaDiner.Data.PizzaDinerContext _context;

        public IndexModel(PizzaDiner.Data.PizzaDinerContext context)
        {
            _context = context;
        }

        public IList<Pizza> Pizza { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Pizza != null)
            {
                Pizza = await _context.Pizza.ToListAsync();
            }
        }
    }
}
