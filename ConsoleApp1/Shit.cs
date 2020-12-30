using System;

namespace TicTacToe
{
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


