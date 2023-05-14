namespace Matrix_Classes
{
    public class MatrixColumnMajor
    {
        public MatrixColumnMajor(int[][] Matrix, int Rows, int Columns)
        {
            this.Matrix = new int[Rows * Columns];
            this.Rows = Rows;
            for (int i = 0; i < Columns; i++)
                for (int j = 0; j < Rows; j++)
                    this.Matrix[j + Rows * i] = Matrix[j][i];
        }

        private int[] Matrix { get; }

        private int Rows { get; }

        public int getCell(int x, int y)
        {
            return Matrix[x + y * Rows];
        }
    }
}
