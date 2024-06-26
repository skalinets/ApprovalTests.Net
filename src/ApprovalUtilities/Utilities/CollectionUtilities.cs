namespace ApprovalUtilities.Utilities;

// ReSharper disable once PartialTypeWithSinglePart
public static partial class CollectionUtilities
{
    public static ICollection<T> AddAll<T>(this ICollection<T> collection, IEnumerable<T> additions) =>
        additions.OrEmpty().Aggregate(collection, AddItem);

    public static ICollection<T> AddItem<T>(this ICollection<T> source, T item)
    {
        source.Add(item);
        return source;
    }

    public static void ForEach<T>(this IEnumerable<T> ie, Action<T> action)
    {
        foreach (var i in ie)
        {
            action(i);
        }
    }

    public static IEnumerable<T> OrEmpty<T>(this IEnumerable<T> source) =>
        source ?? [];
}