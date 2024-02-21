using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Suite.Data;
using Suite.Models;

namespace Suite.Pages.Tags
{
    public class IndexModel : PageModel
    {
        private readonly SuiteContext __Context;

        public IndexModel(SuiteContext context) => __Context = context;

        public IList<Tag> Tag { get;set; } = default!;

        public async Task OnGetAsync() => Tag = await __Context.Tag.ToListAsync();
    }
}