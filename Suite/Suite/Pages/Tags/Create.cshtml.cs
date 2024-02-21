using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Suite.Data;
using Suite.Models;

namespace Suite.Pages.Tags
{
    public class CreateModel : PageModel
    {
        private readonly Suite.Data.SuiteContext _context;

        public CreateModel(Suite.Data.SuiteContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Tag Tag { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Tag.Add(Tag);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
