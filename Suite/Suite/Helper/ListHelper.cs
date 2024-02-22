namespace Suite.Helper
{
    public static class ListHelper
    {
        public static bool HasData<T>(this IReadOnlyCollection<T> dataList) => dataList is { Count: > 0 };
    }
}