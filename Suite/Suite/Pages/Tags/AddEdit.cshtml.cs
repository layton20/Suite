using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Suite.Manager;
using Suite.Models;

namespace Suite.Pages.Tags
{
    public class AddEditModel : PageModel
    {
        public static string URL = "/AddEdit";
        private readonly ITagManager __TagManager;

        public AddEditModel(ITagManager tagManager) => __TagManager = tagManager;

        public async Task<IActionResult> OnGet()
        {
            if (TagUid != Guid.Empty)
            {
                TagModel _Response = await __TagManager.GetTag(TagUid);

                if (_Response != null)
                {
                    Name = _Response.Name;
                }
            }

            return Page();
        }

        [BindProperty, DisplayName("Name"), Required]
        public string Name { get; set; }

        [BindProperty(SupportsGet = true)]
        public Guid TagUid { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            bool _Success = await __TagManager.AddAsync(Name);

            return _Success ? RedirectToPage("./Index") : Page();
        }

        public bool IsAdd => TagUid == Guid.Empty;

        public string PageTitle => IsAdd ? "Add Tag" : "Edit Tag";
    }
}
