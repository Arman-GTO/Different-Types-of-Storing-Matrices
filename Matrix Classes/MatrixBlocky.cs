namespace Matrix_Classes
{
    public class MatrixBlocky
    {
        public MatrixBlocky(int[][] Matrix, int Rows, int Columns)
        {
            this.Matrix = new int[Rows * Columns / 4, 2, 2];
            this.Columns = Columns;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    int index = i * Columns + j;
                    this.Matrix[index / 4, (index % 4 < 2) ? 0 : 1, (index % 2 == 1) ? 0 : 1] = Matrix[i][j];
                }
            }
        }

        private int[,,] Matrix { get; set; }

        private int Columns { get; }

        public int getCell(int x, int y)
        {
            int index = x * Columns + y;
            return Matrix[index / 4, (index % 4 < 2) ? 0 : 1, (index % 2 == 1) ? 0 : 1];
        }
    }
}
