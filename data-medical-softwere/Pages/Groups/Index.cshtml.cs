using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using data_medical_softwere.Modals; // Adjust this based on your actual namespace

namespace data_medical_softwere.Pages.Groups
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Group> Groups { get; set; } = new();

        public async Task<IActionResult> OnGetAsync()
        {
            Groups = await _context.Groups.ToListAsync();

            if (Groups.Count == 0)
            {
                return RedirectToPage("/Groups/Create");
            }

            return Page();
        }
    }
}