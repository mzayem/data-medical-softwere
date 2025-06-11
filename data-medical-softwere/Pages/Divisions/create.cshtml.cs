using data_medical_softwere.Modals; // ✅ updated from YourApp.Models
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace data_medical_softwere.Pages.Divisions
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _context;

        public CreateModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Division Division { get; set; } = new Division(); // ✅ prevents non-nullable warning

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Divisions.Add(Division);
            await _context.SaveChangesAsync();
            return RedirectToPage("/Divisions/Index");
        }
    }
}