using data_medical_softwere.Modals;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace data_medical_softwere.Pages.Vendors
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<Vendor> VendorList { get; set; } = new List<Vendor>();
        public ICollection<Group> Groups { get; set; } = new List<Group>();

        public async Task OnGetAsync()
        {
            VendorList = await _context.Vendors
        .Include(v => v.Groups)
        .Include(v => v.Division) 
        .ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var vendor = await _context.Vendors.FindAsync(id);
            if (vendor != null)
            {
                _context.Vendors.Remove(vendor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }

    }


}