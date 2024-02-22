namespace Suite.Models.Navigation
{
    public class NavigationItem
    {
        public NavigationItem(string name, List<NavigationItem> children)
        {
            Children = children;
            Name = name;
        }

        public NavigationItem(string name, string url)
        {
            Name = name;
            URL = url;
        }

        public bool IsExpander => !string.IsNullOrWhiteSpace(URL);

        public List<NavigationItem> Children { get; set; } = [];
        public string IconName { get; set; } = string.Empty;
        public string Name { get; }
        public bool ShowNewBadge { get; set; }
        public string? URL { get; }
    }
}
