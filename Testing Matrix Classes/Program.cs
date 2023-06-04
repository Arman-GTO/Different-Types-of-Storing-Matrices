using Matrix_Classes;

namespace Testing_Matrix_Classes
{
    class Programs
    {
        static void Main()
        {
            MatrixRowMajor rowMajor;
            MatrixColumnMajor columnMajor;
            MatrixBlocky blocky;
            int x, y; string[] s;

            Console.CursorVisible = false;
            int[][] matrix1 = { new int[] { 1, 2, 3, 4 },
                                new int[] { 5, 6, 7, 8 },
                                new int[] { 9, 10, 11, 12 }
                             };
            rowMajor = new MatrixRowMajor(matrix1, 3, 4);
            columnMajor = new MatrixColumnMajor(matrix1, 3, 4);
            blocky = new MatrixBlocky(matrix1, 3, 4);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n  Matrix:\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("  ");
                for (int j = 0; j < 4; j++)
                    Console.Write(matrix1[i][j] + " ");
                Console.Write("\n");
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n  Enter the coords of the element you want to get (e.g. 2 3): ");

            while (true) // geting input for the desired element in our matrix
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.CursorVisible = true;
                    s = Console.ReadLine()!.Split(" ");
                    Console.CursorVisible = false;
                    x = Convert.ToInt32(s[0]);
                    y = Convert.ToInt32(s[1]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n  Row Major: " + rowMajor.getCell(x, y) + "  |  Column Major: " + columnMajor.getCell(x, y) + "  |  Blocky: " + blocky.getCell(x, y) + "\n");
                    break;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("  Invalid coordinates! Try again: ");
                }
            }

            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("  _________________________________\n\n");

            int[][] matrix2 = { new int[] { 1, 2, 3, 4, 5, 6, 7, 8 },
                                new int[] { 9, 10, 11, 12, 13, 14, 15, 16 },
                                new int[] { 17, 18, 19, 20, 21, 22, 23, 24 },
                                new int[] { 25, 26, 27, 28, 29, 30, 31, 32 },
                                new int[] { 33, 34, 35, 36, 37, 38, 39, 40 },
                                new int[] { 41, 42, 43, 44, 45, 46, 47, 48 },
                                new int[] { 49, 50, 51, 52, 53, 54, 55, 56 },
                                new int[] { 57, 58, 59, 60, 61, 62, 63, 64 },
                                new int[] { 65, 66, 67, 68, 69, 70, 71, 72 },
                                new int[] { 73, 74, 75, 76, 77, 78, 79, 80 },
                                new int[] { 81, 82, 83, 84, 85, 86, 87, 88 },
                                new int[] { 89, 90, 91, 92, 93, 94, 95, 96 },
                             };
            rowMajor = new MatrixRowMajor(matrix2, 12, 8);
            columnMajor = new MatrixColumnMajor(matrix2, 12, 8);
            blocky = new MatrixBlocky(matrix2, 12, 8);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("  Matrix:\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < 12; i++)
            {
                Console.Write("  ");
                for (int j = 0; j < 8; j++)
                    Console.Write(matrix2[i][j] + " ");
                Console.Write("\n");
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n  Enter the coords of the element you want to get (e.g. 10 5): ");

            while (true) // geting input for the desired element in our matrix
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.CursorVisible = true;
                    s = Console.ReadLine()!.Split(" ");
                    Console.CursorVisible = false;
                    x = Convert.ToInt32(s[0]);
                    y = Convert.ToInt32(s[1]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n  Row Major: " + rowMajor.getCell(x, y) + "  |  Column Major: " + columnMajor.getCell(x, y) + "  |  Blocky: " + blocky.getCell(x, y) + "\n");
                    break;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("  Invalid coordinates! Try again: ");
                }
            }
            Console.ResetColor();
            Console.ReadKey(true);
        }
    }
}