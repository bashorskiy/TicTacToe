using System;

namespace TicTacToe
{
    /// <summary>
    /// Генерирует и выводит на консоль массивы
    /// </summary>
    public class RandArrays
    {
        public static void PrintTic(int[,] arr, int minField, int maxField, ConsoleColor X_Color, ConsoleColor O_Color)
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
        public static void PrintTic(int[,] arr, int minField, int maxField)
            {
                for (int i = 0; i < arr.GetUpperBound(0); i++)
                {
                    if (i<10)
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
        /// Возвращает случайно сгенерированный одномерный массив
        /// </summary>
        /// <param name="rows"></param>
        /// <returns></returns>
        public static int[] GetRA(uint rows)
        {
                Random random = new Random();
                var result = new int[rows];
                for (int i = 0; i < rows; i++)
                {
                    result[i] = random.Next(10, 100);
                }
                return result;
        }
            /// <summary>
            /// Возвращает случайно сгенерированный одномерный массив c указанием
            /// максимально возможного значения каждого элемента
            /// </summary>
            /// <param name="rows"></param>
            /// <param name="max"></param>
            /// <returns></returns>
            public static int[] GetRA(uint rows, int max)
            {
                Random random = new Random();
                var result = new int[rows];
                for (int i = 0; i < rows; i++)
                {
                    result[i] = random.Next(max);
                }
                return result;
            }
            /// <summary>
            /// Возвращает случайно сгенерированный одномерный массив c указанием
            /// максимально возможного и минимально возможного значений каждого элемента
            /// </summary>
            /// <param name="rows"></param>
            /// <param name="min"></param>
            /// <param name="max"></param>
            /// <returns></returns>
            public static int[] GetRA(uint rows, int min, int max)
            {
                Random random = new Random();
                var result = new int[rows];
                for (int i = 0; i < rows; i++)
                {
                    result[i] = random.Next(min, max);
                }
                return result;
            }



            /// <summary>
            /// Возвращает случайно сгенерированный двумерный массив
            /// </summary>
            /// <param name="rows"></param>
            /// <param name="columns"></param>
            /// <returns></returns>
            public static int[,] GetRA2(uint rows, uint columns)
            {
                Random random = new Random();
                var result = new int[rows, columns];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        result[i, j] = random.Next(10, 100);
                    }
                }
                return result;
            }
            /// <summary>
            /// Возвращает случайно сгенерированный двумерный массив c указанием
            /// максимально возможного значения каждого элемента
            /// </summary>
            /// <param name="rows"></param>
            /// <param name="columns"></param>
            /// <param name="max"></param>
            /// <returns></returns>
            public static int[,] GetRA2(uint rows, uint columns, int max)
            {
                Random random = new Random();
                var result = new int[rows, columns];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        result[i, j] = random.Next(max);
                    }
                }
                return result;
            }
            /// <summary>
            /// Возвращает случайно сгенерированный двумерный массив c указанием
            /// максимально возможного и минимально возможного значений каждого элемента
            /// </summary>
            /// <param name="rows"></param>
            /// <param name="columns"></param>
            /// <param name="min"></param>
            /// <param name="max"></param>
            /// <returns></returns>
            public static int[,] GetRA2(uint rows, uint columns, int min, int max)
            {
                Random random = new Random();
                var result = new int[rows, columns];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        result[i, j] = random.Next(min, max);
                    }
                }
                return result;
            }


            /// <summary>
            /// Возвращает случайно сгенерированный трёхмерный массив
            /// </summary>
            /// <param name="rows"></param>
            /// <param name="columns"></param>
            /// <param name="pages"></param>
            /// <returns></returns>
            public static int[,,] GetRA3(uint rows, uint columns, uint pages)
            {
                Random random = new Random();
                var result = new int[rows, columns, pages];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        for (int k = 0; k < pages; k++)
                        {
                            result[i, j, k] = random.Next(10, 100);
                        }
                    }
                }
                return result;
            }
            /// <summary>
            ///  Возвращает случайно сгенерированный трёхмерный массив c указанием
            /// максимально возможного значения каждого элемента
            /// </summary>
            /// <param name="rows"></param>
            /// <param name="columns"></param>
            /// <param name="pages"></param>
            /// <param name="max"></param>
            /// <returns></returns>
            public static int[,,] GetRA3(uint rows, uint columns, uint pages, int max)
            {
                Random random = new Random();
                var result = new int[rows, columns, pages];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        for (int k = 0; k < pages; k++)
                        {
                            result[i, j, k] = random.Next(max);
                        }
                    }
                }
                return result;
            }
            /// <summary>
            ///  Возвращает случайно сгенерированный трёхмерный массив c указанием
            /// максимально возможного и минимально возможного значений каждого элемента
            /// </summary>
            /// <param name="rows"></param>
            /// <param name="columns"></param>
            /// <param name="pages"></param>
            /// <param name="min"></param>
            /// <param name="max"></param>
            /// <returns></returns>
            public static int[,,] GetRA3(uint rows, uint columns, uint pages, int min, int max)
            {
                Random random = new Random();
                var result = new int[rows, columns, pages];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        for (int k = 0; k < pages; k++)
                        {
                            result[i, j, k] = random.Next(min, max);
                        }
                    }
                }
                return result;
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



