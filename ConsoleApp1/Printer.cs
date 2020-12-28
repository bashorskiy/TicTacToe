using System;

namespace TicTacToe
{
    public class Printer
    {
        public static void PrintTicField(int[,] arr, int minField, int maxField, ConsoleColor X_Color, ConsoleColor O_Color)
        {
            for (int i = 0; i < arr.GetUpperBound(0); i++)
            {
                if (i < 10)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{i} ");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{i}");
                    Console.ResetColor();
                }
                for (int j = 0; j < arr.GetUpperBound(1); j++)
                {
                    if ((i < minField) | (j < minField) | i > maxField | j > maxField)
                    {
                        Console.Write("%|"); // рисование символово блокированного поля
                    }
                    else if (arr[i, j] == 1)
                    {
                        Console.ForegroundColor = X_Color;
                        Console.Write("X");
                        Console.ResetColor();
                        Console.Write("|");
                    }
                    else if (arr[i, j] == 2)
                    {
                        Console.ForegroundColor = O_Color;
                        Console.Write("O");
                        Console.ResetColor();
                        Console.Write("|");
                    }
                    else
                        Console.Write(" |");
                }
                Console.WriteLine();
            }
        }
        public static void PrintTicField(int[,] arr, int minField, int maxField)
        {
            for (int i = 0; i < arr.GetUpperBound(0); i++)
            {
                if (i < 10)
                {
                    Console.Write($"{i} ");
                }
                else Console.Write(i);

                for (int j = 0; j < arr.GetUpperBound(1); j++)
                {
                    if ((i < minField) | (j < minField) | i > maxField | j > maxField)
                    {
                        Console.Write("-|");
                    }
                    else if (arr[i, j] == 1) // вывод красных крестиков
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("X");
                        Console.ResetColor();
                        Console.Write("|");
                    }
                    else if (arr[i, j] == 2) // вывод синих ноликов
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("O");
                        Console.ResetColor();
                        Console.Write("|");
                    }
                    else
                        Console.Write(" |");
                }
                Console.WriteLine();
            }
        }


        /// <summary>
        /// Выводит на консоль одномерный массив
        /// </summary>
        /// <param name="arr"></param>
        public static void PrintRA(int[] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(arr[i]);
                Console.Write(" | ");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Выводит на консоль двумерный массив
        /// </summary>
        /// <param name="arr"></param>
        public static void PrintRA(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write("| ");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Выводит на консоль трёхмерный массив
        /// </summary>
        /// <param name="arr"></param>
        public static void PrintRA(int[,,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine($"Page№ {(i + 1)} ");
                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write(arr[i, j, k]);
                        Console.Write(" | ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

}



