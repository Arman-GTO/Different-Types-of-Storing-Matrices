namespace Matrix_Classes
{
    public class MatrixRowMajor
    {
        public MatrixRowMajor(int[][] Matrix, int Rows, int Columns)
        {
            this.Matrix = new int[Rows * Columns];
            this.Columns = Columns;
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                    this.Matrix[Columns * i + j] = Matrix[i][j];
        }

        private int[] Matrix { get; }

        private int Columns { get; }

        public int getCell(int x, int y)
        {
            return Matrix[Columns * x + y];
        }
    }
}