
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using aspnetcoreapp.Data;
using aspnetcoreapp.Models;

namespace aspnetcoreapp.Pages.Customers
{
    public class CreateModel : PageModel
    {
        private readonly Data.CustomerDbContext _context;

        public CreateModel(Data.CustomerDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Customer? Customer { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Customer != null) _context.Customer.Add(Customer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}