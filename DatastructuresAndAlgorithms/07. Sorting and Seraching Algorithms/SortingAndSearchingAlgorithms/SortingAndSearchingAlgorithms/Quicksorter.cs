namespace SortingAndSearchingAlgorithms
{
    using System;
    using System.Collections.Generic;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            var orderedCollection = this.QuickSort(collection);

            collection.Clear();
            foreach (T item in orderedCollection)
            {
                collection.Add(item);
            }
        }

        public IList<T> QuickSort(IList<T> collection)
        {
            if (collection.Count < 1)
            {
                return collection;
            }

            int pivotIndex = collection.Count / 2;
            T pivot = collection[pivotIndex];

            IList<T> left = new List<T>();
            IList<T> right = new List<T>();

            for (int i = 0; i < collection.Count; i++)
            {
                if (i == pivotIndex)
                {
                    continue;
                }

                if (collection[i].CompareTo(pivot) <= 0)
                {
                    left.Add(collection[i]);
                }
                else
                {
                    right.Add(collection[i]);
                }
            }

            return this.ConcatenateResult(this.QuickSort(left), pivot, this.QuickSort(right));
        }

        private IList<T> ConcatenateResult(IList<T> leftList, T pivot, IList<T> rightList)
        {
            List<T> result = new List<T>();

            result.AddRange(leftList);
            result.Add(pivot);
            result.AddRange(rightList);

            return result;
        }
    }
}