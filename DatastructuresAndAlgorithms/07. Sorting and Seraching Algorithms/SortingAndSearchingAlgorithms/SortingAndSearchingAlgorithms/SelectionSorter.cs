/namespace SortingAndSearchingAlgorithms
{
    using System;
    using System.Collections.Generic;
    
    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            if (collection.Count == 0)
            {
                return;
            }
            
            for (int i = 0; i < collection.Count; i++)
            {
                T minElement = collection[i];
                int minElementIndex = i;

                // Find current min
                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (collection[j].CompareTo(minElement) < 0)
                    {
                        minElement = collection[j];
                        minElementIndex = j;
                    }
                }

                // Swap
                if (minElementIndex != i)
                {
                    var temp = collection[i];
                    collection[i] = collection[minElementIndex];
                    collection[minElementIndex] = temp;
                }
            }
        }
    }
}