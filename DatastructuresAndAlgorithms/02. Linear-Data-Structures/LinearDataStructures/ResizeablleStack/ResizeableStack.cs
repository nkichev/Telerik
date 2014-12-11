using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResizeablleStack
{
    class ResizeableStack<T>
    {
        private const int InitialSize = 4;
        private T[] array;
        private int pointer;

        public ResizeableStack() 
            : this(InitialSize) 
        {
        }

        public ResizeableStack(int initialSize)
        {
            this.array = new T[initialSize];
            this.pointer = 0;
        }

        public void Push(T element)
        {
            if (this.pointer == this.array.Length)
            {
                AutoGrow();
            }

            array[pointer] = element;
            pointer++;
        }

        public T Peek()
        {
            if (this.pointer == 0)
            {
                throw new ArgumentException("The stack is empty");
            }

            T objectToReturn = this.array[this.pointer - 1];
            return objectToReturn;
        }

        public int Count 
        { 
            get 
            { 
                return this.pointer; 
            } 
        }
        
        public T Pop()
        {
            pointer--;
            return this.Peek();
        }

        private void AutoGrow()
        {
            T[] newArray = new T[2 * this.array.Length];
            Array.Copy(this.array, newArray, this.array.Length);
            this.array = newArray;
        }
    }
}
