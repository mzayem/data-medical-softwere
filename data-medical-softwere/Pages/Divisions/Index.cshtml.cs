using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using data_medical_softwere.Modals; // Adjust this based on your actual namespace

namespace data_medical_softwere.Pages.Divisions
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Division> Divisions { get; set; } = new();

        public async Task<IActionResult> OnGetAsync()
        {
            Divisions = await _context.Divisions.ToListAsync();

            if (Divisions.Count == 0)
            {
                return RedirectToPage("/Divisions/Create");
            }

            return Page();
        }
    }
}