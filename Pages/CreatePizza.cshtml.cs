using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaDiner.Models;
using PizzaDiner.Services;

namespace PizzaDiner.Pages
{
    public class CreatePizzaModel : PageModel
    {
        private readonly PizzaService _service;
        public Pizza NewPizza { get; set; } = default!;
        private readonly PizzaDiner.Data.PizzaDinerContext _context;

        public CreatePizzaModel(PizzaDiner.Data.PizzaDinerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Pizza Pizza { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid || NewPizza == null)
            {
                return Page();
            }
            _service.AddPizza(NewPizza);

            return RedirectToAction("Get");
        }
    }
}
