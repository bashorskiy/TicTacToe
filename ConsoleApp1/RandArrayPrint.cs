using System;

namespace TicTacToe
{
    public static class RandArrayPrint
    { 
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



