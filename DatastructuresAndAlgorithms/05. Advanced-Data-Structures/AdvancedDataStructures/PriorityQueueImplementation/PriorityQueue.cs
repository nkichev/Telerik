namespace PriorityQueueImplementation
{
    using System;

    public class PriorityQueue<T> where T : IComparable<T>
    {
        private static int DEFAULT_ARRAY_SIZE = 16;

        private T[] queue;

        private int lastElementIndex = -1;

        public PriorityQueue()
        {
            this.queue = new T[DEFAULT_ARRAY_SIZE];
        }

        public int Count
        {
            get
            {
                return this.lastElementIndex;
            }
        }

        private int NextFreeIndex
        {
            get
            {
                return this.lastElementIndex + 1;
            }
        }

        public void Enqueue(T element)
        {
            if (this.Count == this.queue.Length - 1)
            {
                this.AutoGrow();
            }

            this.queue[this.NextFreeIndex] = element;
            this.lastElementIndex = this.NextFreeIndex;
            this.ShiftUp(this.lastElementIndex);
        }
  
        public T Dequeue()
        {
            var element = this.queue[0];
            this.queue[0] = this.queue[this.lastElementIndex];
            this.queue[this.lastElementIndex] = (dynamic)null;
            this.lastElementIndex--;
            this.ShiftDown(0);
            return element;
        }

        public T Peek()
        {
            return this.queue[0];
        }

        public void ShiftDown(int index) 
        {
            while (index <= this.lastElementIndex)
            {
                if (GetRightChildIndex(index) <= this.lastElementIndex)
                {
                    T biggerChild = this.GetBiggerChild(index);
                    T currentElement = this.queue[index];

                    if (currentElement.CompareTo(biggerChild) <= 0)
                    {
                        var biggerChildIndex = this.GetBiggerChildIndex(index);
                        this.Swap(biggerChildIndex, index);
                        index = biggerChildIndex;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
        }

        private static int GetParentIndex(int childIndex)
        {
            var parentIndex = (childIndex - 1) / 2;
            return parentIndex;
        }

        private static int GetLeftChildIndex(int parentIndex)
        {
            var leftChildIndex = (parentIndex * 2) + 1;
            return leftChildIndex;
        }

        private static int GetRightChildIndex(int parentIndex)
        {
            var rightChildIndex = (parentIndex * 2) + 2;
            return rightChildIndex;
        }

        private T GetBiggerChild(int index)
        {
            int biggerChildIndex = this.GetBiggerChildIndex(index);
            return this.queue[biggerChildIndex];
        }

        private int GetBiggerChildIndex(int index)
        {
            int biggerChildIndex = GetLeftChildIndex(index);
            if (this.GetLeftChild(index).CompareTo(this.GetRightChild(index)) < 0)
            {
                biggerChildIndex = GetRightChildIndex(index);
            }

            return biggerChildIndex;
        }

        private void ShiftUp(int index)
        {
            while (index != 0)
            {
                if (this.queue[index].CompareTo(this.GetParent(index)) > 0)
                {
                    this.Swap(index, GetParentIndex(index));
                    index = GetParentIndex(index);
                }
                else
                {
                    break;
                }
            }
        }

        private void Swap(int sourceIndex, int destinationIndex)
        {
            T tempElement = this.queue[destinationIndex];
            this.queue[destinationIndex] = this.queue[sourceIndex];
            this.queue[sourceIndex] = tempElement;
        }

        private T GetParent(int childIndex)
        {
            return this.queue[GetParentIndex(childIndex)];
        }

        private T GetLeftChild(int parentIndex)
        {
            return this.queue[GetLeftChildIndex(parentIndex)];
        }

        private T GetRightChild(int parentIndex)
        {
            return this.queue[GetRightChildIndex(parentIndex)];
        }

        private void AutoGrow()
        {
            T[] largerQueue = new T[this.lastElementIndex * 2];
            Array.Copy(this.queue, largerQueue, this.queue.Length);
            this.queue = largerQueue;
        }
    }
}