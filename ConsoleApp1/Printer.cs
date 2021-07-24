using System;

namespace TicTacToe
{
    class Printer
    {
        public static void PrintMenu(uint defaultSize, ConsoleColor X_currentForeground, ConsoleColor O_currentForeground)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\t \t________________________________________________________\n");
            Console.Write("\t \t| Добро пожаловать в Крестики-Нолики на свободном поле! | \n");
            Console.Write("\t \t________________________________________________________\n\n\n");
            Console.ResetColor();
            Console.Write("1. Начать игру \n" +
                         $"2. Выбрать размер поля и цвет символов \t");
            Console.Write($"\n\nСейчас: \t |Размер поля: {defaultSize - 2}х{defaultSize - 2}|\n\t\t |");
            Console.Write("цвет X:  " + (Console.ForegroundColor = X_currentForeground));
            Console.ResetColor();
            Console.Write("| \n\t\t |");
            Console.Write("цвет O: " + (Console.ForegroundColor = O_currentForeground));
            Console.ResetColor();
            Console.Write("|\n\n3. Выйти \n");
        }
        public static void PrintTicFieldNext(int[,] arr, ConsoleColor X_Color, ConsoleColor O_Color)
        {
            for (int i = 0; i < arr.GetUpperBound(0); i++)
            {
                if (i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("N ");
                    Console.ResetColor();
                }
                else if (i < 10)
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
                    if (i == 0 & j > 0 & j < 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($" {j} |");
                        Console.ResetColor();
                    }
                    else if (i == 0 & j >= 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"{j} |");
                        Console.ResetColor();
                    }
                    else if (arr[i, j] == 1) // вывод красных крестиков
                    {
                        Console.ForegroundColor = X_Color;
                        Console.Write(" X");
                        Console.ResetColor();
                        Console.Write(" |");
                    }
                    else if (arr[i, j] == 2) // вывод синих ноликов
                    {
                        Console.ForegroundColor = O_Color;
                        Console.Write(" O");
                        Console.ResetColor();
                        Console.Write(" |");
                    }
                    else if (j == 0)
                    {
                        Console.Write("|");
                    }
                    else
                        Console.Write("   |");
                }
                Console.WriteLine();
            }
        }
        public static void PrintError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\t\t\tНеверный пункт меню!\n");
            Console.ResetColor();
        }
    }
}



