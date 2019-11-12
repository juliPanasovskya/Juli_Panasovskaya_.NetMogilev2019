using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Logic
    {
        public static void GetArrayColumn(char[,] array, out int columns)
        {
            columns = array.GetUpperBound(1) + 1;
        }
        public static void GetArrayRow(char[,] array, out int rows)
        {
            rows = array.GetUpperBound(0) + 1;
        }
        public static void GetArrayColumn(int[,] array, out int columns)
        {
            columns = array.GetUpperBound(1) + 1;
        }
        public static void GetArrayRow(int[,] array, out int rows)
        {
            rows = array.GetUpperBound(0) + 1;
        }

        public static void MoveToRight(char[,] array, ref int k, ref int j)
        {
            char temp;
            int columns;
            GetArrayColumn(array, out columns);

            if ((j + 1) > columns - 1)
            {
                Console.WriteLine("\t\t\tYou can't going out!!!!!");
                Console.ReadKey();
            }
            else
            {
                temp = array[k, j];
                array[k, j] = '-';
                j = j + 1;
                array[k, j] = temp;
            }
        }
        public static void MoveToLeft(char[,] array, ref int k, ref int j)
        {
            char temp;
            if ((j - 1) < 0)
            {
                Console.WriteLine("\t\t\tYou can't going out!!!!!");
                Console.ReadKey();
            }
            else
            {
                temp = array[k, j];
                array[k, j] = '-';
                j = j - 1;
                array[k, j] = temp;
            }
        }
        public static void MoveToUp(char[,] array, ref int k, ref int j)
        {
            char temp;

            if ((k - 1) < 0)
            {
                Console.WriteLine("\t\t\tYou can't going out!!!!!");
                Console.ReadKey();
            }
            else
            {
                temp = array[k, j];
                array[k, j] = '-';
                k = k - 1;
                array[k, j] = temp;
            }
        }
        public static void MoveToDown(char[,] array, ref int k, ref int j)
        {
            char temp;
            int rows;
            GetArrayRow(array, out rows);
            if ((k + 1) > rows - 1)
            {
                Console.WriteLine("\t\t\tYou can't going out!!!!!");
                Console.ReadKey();
            }
            else
            {
                temp = array[k, j];
                array[k, j] = '-';
                k = k + 1;
                array[k, j] = temp;
            }
        }

        public static void HaveTrap(ref int life,ref int[,] fieldTr,ref char[,] field, ref int k, ref int j)
        {
            life = life - fieldTr[k, j];
            
            if (fieldTr[k, j] > 0)
            {
                if (life > 0)
                {
                    Console.WriteLine("You have {0} demage! Life is {1} ", fieldTr[k, j], life);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("You have {0} demage! You haven't any lifes! Game over!", fieldTr[k, j]);
                    Console.ReadKey();
                    field[k, j] = ' ';
                    Restart(ref life, ref k, ref j, out fieldTr, out field);
                    field[k, j] = '*';
                }

            }
            fieldTr[k, j] = 0;
        }

        public static void Restart(ref int life, ref int k, ref int j, out int[,] fieldTr, out char[,] field)
        {
            life = 10;
            k = 0;
            j = 0;
            Field.CreateFieldWithTrap(out fieldTr);
            Field.CreateField(out field, ref k, ref j);
            field[k, j] = '*';
        }
        

    }
}
