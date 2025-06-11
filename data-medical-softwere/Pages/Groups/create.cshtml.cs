using data_medical_softwere.Modals; // ✅ updated from YourApp.Models
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace data_medical_softwere.Pages.Groups
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _context;

        public CreateModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Group Group { get; set; } = new Group(); // ✅ prevents non-nullable warning

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Groups.Add(Group);
            await _context.SaveChangesAsync();
            return RedirectToPage("/Groups/Index");
        }
    }
}