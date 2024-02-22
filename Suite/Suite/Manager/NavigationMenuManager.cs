using Suite.Models.Navigation;
using Suite.Pages.Tags;

namespace Suite.Manager
{
    public static class NavigationMenuManager
    {
        private static List<NavigationItem> HomeNavigationItems =
        [
            new NavigationItem("Home", GenerateManageItems())
        ];

        private static List<NavigationItem> IntegrationNavigationItems =
        [
            new NavigationItem("Manage", GenerateManageItems()) { IconName = "feather" },
            new NavigationItem("PokeAPI", "https://www.google.com") { IconName = "feather" },
        ];

        public static List<NavigationSection> NavigationSections =
        [
            new NavigationSection { Items = HomeNavigationItems },
            new NavigationSection { Name = "Integrations", Items = IntegrationNavigationItems }
        ];

        private static List<NavigationItem> GenerateManageItems()
        {
            return
            [
                new NavigationItem("Notes", "https://www.google.com"),
                new NavigationItem("Tags", IndexModel.URL) { ShowNewBadge = true, IconName = "phone" },
            ];
        }
    }
}
