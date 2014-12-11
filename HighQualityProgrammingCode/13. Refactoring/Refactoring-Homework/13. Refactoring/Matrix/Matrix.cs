namespace Matrix
{
    using System;
    using System.Linq;
    using System.Text;

    public class Matrix
    {
        private const int PossibleDirsCount = 8;
        private int dimensions = 3;

        private int[,] matrix;

        private int row = 0;
        private int col = 0;

        public Matrix(int dimensions)
        {
            this.Dimensions = dimensions;

            this.matrix = new int[this.dimensions, this.dimensions];

            this.FindAvailableCell();
            this.FillAvailableCells();
        }

        public int Dimensions
        {
            get
            {
                return this.dimensions;
            }

            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Dimentions value can only be between 1 and 100!");
                }

                this.dimensions = value;
            }
        }

        private void GetDirection(ref int dirRow, ref int dirCol)
        {
            int[] directionRow = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionCol = { 1, 0, -1, -1, -1, 0, 1, 1 };

            int currentDir = 0;

            for (int i = 0; i < PossibleDirsCount; i++)
            {
                if (directionRow[i] == dirRow && directionCol[i] == dirCol)
                {
                    currentDir = i;
                    break;
                }
            }

            if (currentDir == PossibleDirsCount - 1)
            {
                dirRow = directionRow[0];
                dirCol = directionCol[0];
                return;
            }

            dirRow = directionRow[currentDir + 1];
            dirCol = directionCol[currentDir + 1];
        }

        private bool IsCellAvailable(int row, int col)
        {
            int[] directionRow = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionCol = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < PossibleDirsCount; i++)
            {
                int nextRow = row + directionRow[i];

                if (!this.IsInRange(nextRow))
                {
                    directionRow[i] = 0;
                }

                int nextCol = col + directionCol[i];

                if (!this.IsInRange(nextCol))
                {
                    directionCol[i] = 0;
                }
            }

            return this.IsNextCellEmpty(row, col, directionRow, directionCol);
        }

        private void FindAvailableCell()
        {
            this.row = 0;
            this.col = 0;

            for (int currentRow = 0; currentRow < this.dimensions; currentRow++)
            {
                for (int currentCol = 0; currentCol < this.dimensions; currentCol++)
                {
                    if (this.matrix[currentRow, currentCol] == 0)
                    {
                        this.row = currentRow;
                        this.col = currentCol;

                        return;
                    }
                }
            }
        }

        private void FillAvailableCells()
        {
            int directionRow = 1;
            int directionCol = 1;
            int number = 1;

            while (true)
            {
                this.matrix[this.row, this.col] = number;

                if (!this.IsCellAvailable(this.row, this.col))
                {
                    this.FindAvailableCell();
                    if (this.IsCellAvailable(this.row, this.col))
                    {
                        number++;
                        this.matrix[this.row, this.col] = number;
                        directionRow = 1;
                        directionCol = 1;
                    }
                    else
                    {
                        break;
                    }
                }

                int nextRow = this.row + directionRow;
                int nextCol = this.col + directionCol;

                if (!this.IsInRange(nextRow) || !this.IsInRange(nextCol) || this.matrix[nextRow, nextCol] != 0)
                {
                    while (!this.IsInRange(nextRow) || !this.IsInRange(nextCol) || this.matrix[nextRow, nextCol] != 0)
                    {
                        this.GetDirection(ref directionRow, ref directionCol);

                        nextRow = this.row + directionRow;
                        nextCol = this.col + directionCol;
                    }
                }

                this.row = nextRow;
                this.col = nextCol;
                number++;
            }
        }

        private bool IsNextCellEmpty(int row, int col, int[] directionRow, int[] directionCol)
        {
            for (int i = 0; i < PossibleDirsCount; i++)
            {
                int nextRow = row + directionRow[i];
                int nextCol = col + directionCol[i];

                if (this.matrix[nextRow, nextCol] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsInRange(int value)
        {
            if (this.dimensions <= value || value < 0)
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder matrixAsStirng = new StringBuilder();

            for (int row = 0; row < this.dimensions; row++)
            {
                for (int col = 0; col < this.dimensions; col++)
                {
                    matrixAsStirng.AppendFormat("{0,3}", this.matrix[row, col]);
                }

                matrixAsStirng.Append("\r\n");
            }

            return matrixAsStirng.ToString();
        }
    }
}
