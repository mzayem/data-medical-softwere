﻿using data_medical_softwere.Modals; // ✅ updated from YourApp.Models
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        public Group Group { get; set; } = new Group();

        public List<SelectListItem> VendorOptions { get; set; } = new();

        public void OnGet()
        {
            VendorOptions = _context.Vendors
        .Select(v => new SelectListItem { Value = v.Id.ToString(), Text = v.Name })
        .ToList();
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