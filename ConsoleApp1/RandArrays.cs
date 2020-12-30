using System;

namespace TicTacToe
{
    /// <summary>
    /// Генерирует и выводит на консоль массивы
    /// </summary>
    public class RandArrays
    { 
   
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

           

           

    }

}



