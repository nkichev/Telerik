using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.NewQueue
{
    class NewQueue<T>
    {
        private QueueNode<T> head;
        private QueueNode<T> tail;
        private int count = 0;

        public NewQueue()
        {
        }

        public void Enqueue(T data) 
        {
            QueueNode<T> newNode = new QueueNode<T>(data);

            if (head == null)
            {
                head = newNode;
                tail = head;
            }
            else
            {
                tail.NextNode = newNode;
                tail = newNode;
            }

            count++;
        }

        public T Dequeue()
        {
            if (head == null)
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            else
            {
                T result = head.Data;
                head = head.NextNode;
                count--;
                return result;
            }
        }

        public int Count 
        {
            get 
            {
                return this.count;
            }
        }
    }
}