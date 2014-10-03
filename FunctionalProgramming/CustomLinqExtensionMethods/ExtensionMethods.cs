namespace CustomLinqExtensionMethods
{
    using System;
    using System.Collections.Generic;

    public static class ExtensionMethods
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            foreach (var member in collection)
            {
                if (!predicate(member))
                {
                   yield return member;
                }
            }
        }

        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count)
        {
            
           

                for (int i = 0; i < count; i++)
                {
                    foreach (var member in collection)
                    {
                        yield return member;
                    }
                }
            
        }

        public static IEnumerable<string> WhereEndsWith(this IEnumerable<string> collection, IEnumerable<string> suffixes)
        {
            foreach (var member in collection)
            {
                foreach (var item in suffixes)
                {
                    if (member.ToString().Trim().EndsWith(item))
                    {
                        yield return member.Trim();
                    }
                }
            }
        }
    }
}
