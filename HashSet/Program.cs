using System.Collections.Generic;

namespace HashSet
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var hashSet1 = new HashSet<int>();

            // Initialize the set using object initialization syntax
            var hashSet = new HashSet<int> { 1, 2, 3, 4 };

            var another = new HashSet<int> { 1, 6, 7 };

            // Add an object to the set

            // Remove an object
            hashSet.Remove(3);

            // Remove all objects
            hashSet.Clear();

            // Check to see if the set contains an object
            var contains = hashSet.Contains(1);

            // Return the number of objects in the set
            var count = hashSet.Count;

            // Modify the set to include only the objects present in the set and the other set
            hashSet.IntersectWith(another);

            // Remove all objects in "another" set from "hashSet"
            hashSet.ExceptWith(another);

            // Modify the set to include all objects included in itself, in "another" set, or both
            hashSet.UnionWith(another);

            var isSupersetOf = hashSet.IsSupersetOf(another);
            var isSubsetOf = hashSet.IsSubsetOf(another);
            var equals = hashSet.SetEquals(another);
        }
    }
}