using data_medical_softwere.Modals;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace data_medical_softwere.Pages.Vendors
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _context;

        public CreateModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Vendor Vendor { get; set; } = new Vendor();

        public SelectList DivisionList { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            DivisionList = new SelectList(await _context.Divisions.ToListAsync(), "Id", "Name");

            if (id.HasValue)
            {
                Vendor = await _context.Vendors.FirstOrDefaultAsync(v => v.Id == id.Value);
                if (Vendor == null)
                {
                    return NotFound();
                }
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            DivisionList = new SelectList(await _context.Divisions.ToListAsync(), "Id", "Name");

            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Vendor.Id > 0)
            {
                var existingVendor = await _context.Vendors
                    .FirstOrDefaultAsync(v => v.Id == Vendor.Id);

                if (existingVendor == null) return NotFound();

                // Only update scalar fields
                existingVendor.Name = Vendor.Name;
                existingVendor.NtnNumber = Vendor.NtnNumber;
                existingVendor.Address = Vendor.Address;
                existingVendor.Phone = Vendor.Phone;
                existingVendor.DivisionId = Vendor.DivisionId;
            }
            else
            {
                _context.Vendors.Add(Vendor);
            }

            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}