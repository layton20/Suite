using Suite.Models.Navigation;

namespace Suite.Manager
{
    public static class NavigationMenuManager
    {
        public static List<NavigationSection> NavigationSections = new List<NavigationSection>()
        {
            new NavigationSection { Items = HomeNavigationItems ?? [] },
            new NavigationSection { Name = "Integrations", Items = IntegrationNavigationItems ?? [] }
        };

        private static List<NavigationItem> HomeNavigationItems = new List<NavigationItem>()
        {
            new NavigationItem("Home", GenerateManageItems()),
        };

        private static List<NavigationItem> IntegrationNavigationItems =
        [
            new NavigationItem("Manage", GenerateManageItems()),
            new NavigationItem("PokeAPI", "https://www.google.com"),
        ];

        private static List<NavigationItem> GenerateManageItems()
        {
            return
            [
                new NavigationItem("Notes", "https://www.google.com"),
                new NavigationItem("Tags", "https://www.google.com") { ShowNewBadge = true, IconName = "phone" },
            ];
        }
    }
}
