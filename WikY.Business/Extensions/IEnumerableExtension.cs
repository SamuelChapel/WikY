namespace WikY.Repository.Extensions;

public static class IEnumerableExtension
{
    public static IEnumerable<T> Order<T, TKey>(this IEnumerable<T> source, Func<T, TKey> selector, bool ascending)
    {
        if (ascending)
        {
            return source.OrderBy(selector);
        }
        else
        {
            return source.OrderByDescending(selector);
        }
    }
}
