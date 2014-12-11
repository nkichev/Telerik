using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions
{
    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> elements)
        {
            if (elements.Count() == 0)
            {
                throw new ArgumentNullException("No elements!");
            }

            T sum = default(T);
            foreach (T element in elements)
            {
                sum += (dynamic)element;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> elements) where T : IComparable, IComparable<T>
        {
            if (elements.Count() == 0)
            {
                throw new ArgumentNullException("No elements!");
            }

            T sum = (dynamic)1;
            foreach (T element in elements)
            {
                sum *= (dynamic)element;
            }
            return sum;
        }

        public static T Min<T>(this IEnumerable<T> elements) where T : IComparable, IComparable<T>
        {
            if (elements.Count() == 0)
            {
                throw new ArgumentNullException("No elements!");
            }

            T minEl = elements.First();
            foreach (T element in elements)
            {
                if (element.CompareTo(minEl) < 0)
                {
                    minEl = element;
                }
            }
            return minEl;
        }

        public static T Max<T>(this IEnumerable<T> elements) where T : IComparable, IComparable<T>
        {
            if (elements.Count() == 0)
            {
                throw new ArgumentNullException("No elements!");
            }

            T maxEl = elements.First();
            foreach (T element in elements)
            {
                if (maxEl.CompareTo(element) < 0)
                {
                    maxEl = element;
                }
            }
            return maxEl;
        }

        public static T Average<T>(this IEnumerable<T> elements) where T : IComparable, IComparable<T>
        {
            if (elements.Count() == 0)
            {
                throw new ArgumentNullException("No elements");
            }

            T sum = default(T);
            int count = 0;
            foreach (T element in elements)
            {
                count++;
                sum += (dynamic)element;
            }
            return sum / (dynamic)count;
        }
    }
}
