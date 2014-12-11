using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class GenericList<T>
{
    private T[] array;
    private int size;
    private int position = 0;
    private T[] rubber = new T[1];

    public GenericList(int size)
    {
        array = new T[size];
        this.size = size;
    }

    public T this[int index]
    {
        get
        {
            if (isInside(index))
            {
                return array[index];
            }
            else
            {
                string exception = String.Format("Index is out of range!", this.size);
                throw new IndexOutOfRangeException(exception);
            }
        }

        set
        {
            if (isInside(index))
            {
                array[index] = value;

                if (index > position)
                {
                    position = index + 1; //we ensure that we will .Add() after the last element
                }
            }
            else
            {
                string exception = String.Format("Index is out of range!", this.size);
                throw new IndexOutOfRangeException(exception);
            }

        }
    }
    public void Add(T element)
    {
        if (isInside(position))
        {
            array[position] = element;
            position++;
        }
        else
        {
            SizeDouble();
            array[position] = element;
            position++;
        }

    }

    public void RemoveAt(int target)
    {
        if (isInside(target))
        {
            while (target <= position && target < size)
            {
                if (target + 1 < size)
                {
                    this.array[target] = this.array[target + 1];
                }

                target++;
            }
            position--;

        }

        else
        {
            string exception = String.Format("Index is out of range!", this.size);
            throw new IndexOutOfRangeException(exception);
        }
    }

    public void Clear()
    {
        array = new T[this.size];
        position = 0;
    }

    public void InsertAt(T insertion, int target)
    {
        if (isInside(target))
        {
            if (position >= size)
            {
                SizeDouble();
            }
            if (target > position)
            {
                array[target] = insertion;
                position = target + 1;
            }
            else
            {

                int temp = position;
                while (temp >= target)
                {
                    array[temp + 1] = array[temp];
                    temp--;
                }
                array[target] = insertion;
                position++;
            }
        }
        else
        {
            string exception = String.Format("Index is out of range!", this.size);
            throw new IndexOutOfRangeException(exception);
        }
    }

    public int Find(T element)
    {
        for (int i = 0; i < this.position; i++)
        {
            if (element.Equals(array[i]))
            {
                return i;
            }
        }

        return -1;
    }

    public override string ToString()
    {
        StringBuilder currentArray = new StringBuilder();

        foreach (T item in array)
        {

            currentArray.Append(item);
            currentArray.Append(", ");
        }

        return currentArray.ToString();
    }

    public T Min()
    {
        dynamic minValue = array[0];

        for (int i = 0; i < position; i++)
        {
            if (array[i] != null && minValue.CompareTo(array[i]) > 0)
            {
                minValue = array[i];
            }
        }

        return minValue;
    }

    public T Max()
    {
        dynamic maxValue = array[0];

        for (int i = 0; i < position; i++)
        {
            if (array[i] != null && maxValue.CompareTo(array[i]) < 0)
            {
                maxValue = array[i];
            }
        }

        return maxValue;
    }
    private bool isInside(int target)
    {
        return (target < size && target >= 0) ? true : false;
    }

    private void SizeDouble()
    {
        T[] copy = new T[size];
        for (int i = 0; i < size; i++)
        {
            copy[i] = array[i];
        }

        this.size = this.size * 2;

        this.array = new T[size];
        for (int i = 0; i < size / 2; i++)
        {
            array[i] = copy[i];
        }

    }
}

