using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Matrix<T>
{
    private T[,] array;
    private int height;
    private int width;

    public int Height
    {
        get
        {
            return this.height;
        }
    }

    public int Width
    {
        get
        {
            return this.width;
        }
    }

    public Matrix(int rows, int cols)
    {
        this.width = cols;
        this.height = rows;
        array = new T[this.height, this.width];
    }

    public T this[int rows, int cols]
    {
        get
        {
            return array[rows, cols];
        }
        set
        {
            array[rows, cols] = value;
        }
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        for (int rows = 0; rows < height; rows++)
        {
            result.Append("[ ");
            for (int cols = 0; cols < width; cols++)
            {
                result.Append(array[rows, cols]);
                if (cols != width - 1)
                {
                    result.Append(", ");
                }

            }
            result.Append(" ]");
            result.Append("\n");
        }

        return result.ToString();
    }

    public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
    {

        Matrix<T> result = new Matrix<T>(firstMatrix.Height, firstMatrix.Width);

        if (firstMatrix.Height != secondMatrix.Height || firstMatrix.Width != secondMatrix.Width)
        {
            throw new ArgumentException("The matrices are not equal!");
        }
        else
        {
            for (int rows = 0; rows < firstMatrix.Width; rows++)
            {
                for (int cols = 0; cols < firstMatrix.Width; cols++)
                {
                    result[rows, cols] = (dynamic)firstMatrix[rows, cols] + (dynamic)secondMatrix[rows, cols];
                }
            }
        }

        return result;
    }

    public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
    {

        Matrix<T> result = new Matrix<T>(firstMatrix.Height, firstMatrix.Width);

        if (firstMatrix.Height != secondMatrix.Height || firstMatrix.Width != secondMatrix.Width)
        {
            throw new ArgumentException("The matrices are not equal!");
        }
        else
        {
            for (int rows = 0; rows < firstMatrix.Width; rows++)
            {
                for (int cols = 0; cols < firstMatrix.Width; cols++)
                {
                    result[rows, cols] = (dynamic)firstMatrix[rows, cols] - (dynamic)secondMatrix[rows, cols];
                }
            }
        }

        return result;
    }

    public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
    {
        Matrix<T> result = new Matrix<T>(firstMatrix.Height, firstMatrix.Width);

        if (firstMatrix.Width != secondMatrix.Height)
        {
            throw new ArgumentException("The cols and rows count are not equal!");
        }
        else
        {
            for (int rows = 0; rows < firstMatrix.Height; rows++)
            {
                for (int cols = 0; cols < firstMatrix.Width; cols++)
                {
                    for (int leftCols = 0; leftCols < firstMatrix.Width; leftCols++)
                    {
                        result[rows, cols] += (dynamic)firstMatrix[rows, leftCols] * (dynamic)secondMatrix[leftCols, cols];
                    }
                }
            }
        }

        return result;
    }

    public static bool operator true(Matrix<T> currentMatrix)
    {
        for (int rows = 0; rows < currentMatrix.Height; rows++)
        {
            for (int cols = 0; cols < currentMatrix.Width; cols++)
            {
                if (currentMatrix[rows, cols] == (dynamic)default(T))
                {
                    return false; //return false if there is "zero" element
                }
            }
        }

        return true;
    }

    public static bool operator false(Matrix<T> currentMatrix)
    {
        for (int rows = 0; rows < currentMatrix.Height; rows++)
        {
            for (int cols = 0; cols < currentMatrix.Width; cols++)
            {
                if (currentMatrix[rows, cols] == (dynamic)default(T))
                {
                    return true; //return false if there is "zero" element
                }
            }
        }

        return false;
    }
}
