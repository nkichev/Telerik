namespace SortingAndSearchingAlgorithms
{
    using System;
    using System.Collections.Generic;
    using SortingAndSearchingAlgorithms;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            foreach (var element in this.Items)
            {
                if (element.CompareTo(item) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public bool BinarySearch(T item)
        {
            var elements = this.Items;
            int startIndex = 0;
            int endIndex = elements.Count;

            while (endIndex > startIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (elements[midIndex].CompareTo(item) < 0)
                {
                    startIndex = midIndex;
                }
                else if (elements[midIndex].CompareTo(item) < 0)
                {
                    endIndex = midIndex;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        public void Shuffle()
        {
            var n = this.Items.Count;
            var randomGenerator = new Random();
            for (var i = 0; i < n; i++)
            {
                // Exchange a[i] with random element in a[i..n-1]
                int r = i + randomGenerator.Next(0, n - i);

                this.Swap(i, r);
            }
        }
  
        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }

        private void Swap(int oldIndex, int newIndex)
        {
            var temp = this.Items[oldIndex];
            this.Items[oldIndex] = this.Items[newIndex];
            this.Items[newIndex] = temp;
        }
    }
}