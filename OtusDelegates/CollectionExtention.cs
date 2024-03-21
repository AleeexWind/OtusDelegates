namespace OtusDelegates
{
    public static class CollectionExtention
    {
        public static T GetMax<T>(this IEnumerable<T> collection, Func<T, float> convertToNumber) where T : class
        {

            if (collection == null)
            {
                throw new ArgumentNullException("Collection is null");
            }
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Collection is empty");
            }

            T result = collection.First();

            T? maxElem = collection.MaxBy(convertToNumber);
            if (maxElem != null)
            {
                result = maxElem;
            }

            return result;
        }
    }
}
