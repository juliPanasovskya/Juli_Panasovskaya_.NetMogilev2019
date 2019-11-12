using System;

namespace Game
{
    public static class Field
    {

        public static void CreateField(out char[,] field, ref int k, ref int j)
        {
            field = new char[10, 10];
            k = 0;
            j = 0;
            field[k, j] = '*';
            field[9, 9] = '$';
        }
        public static void CreateFieldWithTrap(out int[,] fieldTr)
        {
            fieldTr = new int[10, 10];
            Random rnd = new Random();
            for (int m = 0; m <= 10; m++)
            {
                int i = rnd.Next(0, 10);
                int j = rnd.Next(0, 10);
                fieldTr[i, j] = Convert.ToChar(rnd.Next(1, 10));
            }
        }

        public static void DisplayField(char[,] field)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("\t{0}", field[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static void DisplayField(int[,] field)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("\t{0}", field[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
