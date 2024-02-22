using Microsoft.AspNetCore.Mvc.RazorPages;
using Suite.Manager;
using Suite.Models;

namespace Suite.Pages.Tags
{
    public class IndexModel : PageModel
    {
        private readonly ITagManager __TagManager;
        public static string URL = "/index";
        public static string TITLE = "Tags";

        public IndexModel(ITagManager tagManager) => __TagManager = tagManager;

        public List<TagModel> Tags { get;set; }

        public async Task OnGetAsync() => Tags = await __TagManager.GetTags();
    }
}