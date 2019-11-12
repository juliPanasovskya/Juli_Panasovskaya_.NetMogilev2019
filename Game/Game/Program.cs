using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] fieldTr;
            char[,] field;
            int k = 0;
            int j = 0;

            Field.CreateFieldWithTrap(out fieldTr);
            // Field.DisplayField(fieldTr);
            Console.WriteLine();
            Field.CreateField(out field, ref k, ref j);
            //  Field.DisplayField(field);
            // Console.ReadLine();
            ConsoleKeyInfo input;

            do
            {
                Console.Clear();
                Field.DisplayField(field);
                Logic.HaveTrap(ref Gamer.life, ref fieldTr, ref field, ref k, ref j);
                Console.WriteLine("\n Up \n Left \n Right \n Down ");
                Console.WriteLine("life: {0}", Gamer.life);
                if (k == 9 && j == 9)
                {
                    Console.WriteLine("\t\t\tYou are the winner!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.DownArrow:
                        Logic.MoveToDown(field, ref k, ref j);
                        break;
                    case ConsoleKey.RightArrow:
                        Logic.MoveToRight(field, ref k, ref j);
                        break;
                    case ConsoleKey.LeftArrow:
                        Logic.MoveToLeft(field, ref k, ref j);
                        break;
                    case ConsoleKey.UpArrow:
                        Logic.MoveToUp(field, ref k, ref j);
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("Exit!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong item");
                        break;
                }

            } while (input.Key != ConsoleKey.Escape);
            Console.ReadLine();

        }
    }
}
