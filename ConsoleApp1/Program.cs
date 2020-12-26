using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main()
        {
            RandArrays.GetRA(5);
            Console.Write("новая колбаса ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ла ла ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("ла..");

        }
        static void Symbols(string sym, uint amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.Write(sym);
            }
            Console.WriteLine();
        }
        static int Index(int[,] array, int findy)
        {
            for (int i = 0; i < array.GetUpperBound(0); i++)
            {
                for (int j = 0; j < array.GetUpperBound(1); j++)
                {
                    if (array[i, j] == findy)
                    {
                        Console.Write(i + " ");
                        return j;
                    }
                }
            }
            return -1;
        }
    }


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

        /// <summary>
        /// Выводит на консоль одномерный массив
        /// </summary>
        /// <param name="arr"></param>
        public static void WriteRA(int[] arr)
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
        public static void WriteRA(int[,] arr)
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
        public static void WriteRA(int[,,] arr)
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

    public class Shit
    {
        static void Zarplata()
        {
            double perh = 182;
            double sum_all, sum_ne_rab = 0;
            double k = 1.2, nalog = 0.13;
            Console.WriteLine("обычные и ночные часы: (101 и 64)");
            double work_hours = double.Parse(Console.ReadLine());
            double night_hours = double.Parse(Console.ReadLine());

            Console.WriteLine("Были дни, когда не работал?");
            bool ne_rabotal = bool.Parse(Console.ReadLine());

            if (ne_rabotal)
            {
                Console.WriteLine("обычные и ночные часы, пока не работал: (6 и 16)");
                double non_work_hours = double.Parse(Console.ReadLine());
                double non_night_hours = double.Parse(Console.ReadLine());
                sum_ne_rab = (perh * non_work_hours + perh * k * non_night_hours);
            }
            sum_all = (perh * work_hours + perh * k * night_hours);
            sum_all = sum_all - (sum_all * nalog + sum_ne_rab);
            Console.WriteLine($"твои гиподеньги:  { (sum_all):F1}");
            Console.WriteLine($"твои гиподеньги c заебись премией:  {(sum_all * 2):F1}");
        }
        static void Calc(string[] args)
        {
            string str, str2;
            double a, b, result;
        start:
            Console.WriteLine("Введите число А");
            str = Console.ReadLine();
            Console.WriteLine("Введите число B");
            str2 = Console.ReadLine();

            try
            {
                a = Convert.ToDouble(str);
                b = Convert.ToDouble(str2);

                Console.WriteLine("Что вы хотите сделать с числом? \n 1.A+B \n 2.A-B \n 3.B-A \n 4.A*B \n 5.A/B \n 6.B/A ");
            returner:
                Console.WriteLine("Введите номер операции");
                str = Console.ReadLine();


                switch (str)
                {
                    case "1":
                        result = a + b;
                        Console.WriteLine("Сумма чисел равна " + result);
                        break;

                    case "2":
                        result = a - b;
                        Console.WriteLine("Разность чисел равна " + result);
                        break;

                    case "3":
                        result = b - a;
                        Console.WriteLine("Разность чисел равна " + result);
                        break;

                    case "4":
                        result = a * b;
                        Console.WriteLine("Произведение чисел равно " + result);
                        break;

                    case "5":
                        result = a / b;
                        Console.WriteLine("Частное чисел равно " + result);
                        break;

                    case "6":
                        result = b / a;
                        Console.WriteLine("Частное чисел равно " + result);
                        break;

                    default:
                        Console.WriteLine("Данной операции не существует");
                        goto returner;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка конвертации! Пожалуйста, повторите ввод");
                goto start;
            }
        }
        static void Triangles(string[] args)
        {
            int large_bord = 10;


            for (int i = 0; i <= large_bord; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    Console.Write("#");

                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int k = large_bord; k > 0; k--) // обратный треугольник
            {
                for (int l = k; l > 0; l--)
                {
                    Console.Write("#");

                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int k = large_bord; k >= 0; k--)
            {
                for (int l = k; l > 0; l--)
                {
                    Console.Write(" ");

                }
                for (int m = 10 - k; m > 0; m--)
                {
                    Console.Write("#");
                }

                Console.WriteLine();

            }
            Console.WriteLine();

            for (int k = large_bord; k >= 0; k--)  //обратный пробельный
            {
                for (int m = 10 - k; m > 0; m--)
                {
                    Console.Write(" ");
                }

                for (int l = k; l > 0; l--)
                {
                    Console.Write("#");

                }


                Console.WriteLine();

            }
            Console.WriteLine();
        }

        static void Keyboardarry()
        {
            Console.WriteLine("Пожалуйста, введите кол-во строк: ");
            int stroki = int.Parse(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите кол-во столбцов: ");
            int stolbi = int.Parse(Console.ReadLine());

            int[,] keyArray = new int[stroki, stolbi];

            for (int i = 0; i < keyArray.GetLength(0); i++)
            {
                Console.Write($"Введите элементы для {i}-ой строки, ");
                for (int j = 0; j < keyArray.GetLength(1); j++)
                {
                    Console.WriteLine($"для {j}-ого столбца");
                    keyArray[i, j] = int.Parse(Console.ReadLine());

                }
                Console.WriteLine();
            }


            for (int i = 0; i < keyArray.GetLength(0); i++)
            {
                Console.Write("| ");
                for (int j = 0; j < keyArray.GetLength(1); j++)
                {
                    Console.Write(keyArray[i, j]);

                    Console.Write(" | ");

                }
                Console.WriteLine();
            }
        }
    }

}

