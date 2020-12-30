using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Settings
    {
        public static ConsoleColor ColorSet(ConsoleColor[] colors, ConsoleColor currentcolor)
        {
            Console.WriteLine($"Сейчас цвет этого символа: {Console.ForegroundColor = currentcolor}");
            Console.ResetColor();
            Console.WriteLine("Вот список всех доступных цветов:");
            
            for (int m = 0; m < colors.Length; m++)
            {
                if (colors[m] == currentcolor)
                {
                    Console.Write($"Сейчас цвет этого символа: {Console.ForegroundColor = currentcolor} ");
                    Console.ResetColor();
                    Console.WriteLine($"под номером {m}\n");
                }
                else
                    Console.WriteLine($"Нажмите [{m}], чтобы выбрать {Console.ForegroundColor = colors[m]}\n");
                    Console.ResetColor();
            }
            int numb = int.Parse(Console.ReadLine());
            ConsoleColor newcolor = colors[numb];
              return newcolor;
        }

        public static uint Size(uint defSize)
        {
            bool setSize = true;
            while (setSize)
            {            
                Console.WriteLine("\n1.Изменить размер поля" + $"\t \t\t(сейчас размер поля {defSize-2}х{defSize-2})" );
                Console.WriteLine("2.Выйти в главное меню ");
                string settingsPoint = Console.ReadLine();
                if (settingsPoint == "1")
                {
                    Console.WriteLine("\n\nВведите новый размер поля(одно целое число): \t ");
                    bool correctSize = uint.TryParse(Console.ReadLine(), out uint newsize);
                    if (correctSize&newsize>=5)

                    {
                        defSize = newsize+2;
                        setSize = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Такой размер, к сожалению, недопустим\n");
                        Console.ResetColor();
                    }
                }
                if (settingsPoint =="2")
                {
                    setSize = false;
                }
            }
            return defSize;
        }

        public static void Menu(uint defaultSize, ConsoleColor X_currentForeground, ConsoleColor O_currentForeground)
        {
            Console.Write("Что хотите выбрать? \n" +
                                          $"1. Размер поля (сейчас {defaultSize - 2}х{defaultSize - 2})\n");
            Console.Write($"2. Цвет крестиков (сейчас {Console.ForegroundColor = X_currentForeground})\n");
            Console.ResetColor();
            Console.Write($"3. Цвет ноликов (сейчас {Console.ForegroundColor = O_currentForeground})\n");
            Console.ResetColor();
            Console.WriteLine("4. Всё устраивает, хочу вернуться в меню");
        }
    }

    class Test
    {
        public static int[,] First(int[,] arr)
        {
            for (int i =8 ; i <12 ; i++)
            {
                for (int j = i; j < 12; j++)
                {
                    arr[i, j] = 1;
                }
            }
            return arr;
        }
    }

    class Program
    {
        

        static void Main()
        {
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            ConsoleColor X_currentForeground = ConsoleColor.Red;
            ConsoleColor O_currentForeground = ConsoleColor.Cyan;
            uint defaultSize = 17;
            bool game = true;
            bool settings;
            bool menu = true;

            while (menu)
            {
                Printer.PrintMenu(defaultSize, X_currentForeground, O_currentForeground);
                bool choiceNum = short.TryParse(Console.ReadLine(), out short choice);
                if (choice == 1 & choiceNum)
                {
                    while (game)
                    {
                        Game.Play(X_currentForeground, O_currentForeground, defaultSize);
                        game = false;
                    }
                }
                else if (choice == 2 & choiceNum)
                {
                    settings = true;
                    while (settings)
                    {
                        Settings.Menu(defaultSize, X_currentForeground, O_currentForeground);
                        string point = Console.ReadLine();

                        if (point == "1")
                        {
                            defaultSize = Settings.Size(defaultSize);
                            break;
                        }
                        if (point == "2")
                        {
                            X_currentForeground = Settings.ColorSet(colors, X_currentForeground);
                            break;
                        }
                        if (point == "3")
                        {
                            O_currentForeground = Settings.ColorSet(colors, O_currentForeground);
                            break;
                        }
                        if (point == "4")
                        {
                            break;
                        }
                        else
                        {
                            Printer.PrintError();
                        }
                    }
                }

                else if (choice == 3 & choiceNum)
                {
                    Console.WriteLine("Спасибо за игру! Пока!");
                    Console.ReadKey();
                    menu = false;
                }
                else
                {
                    Printer.PrintError();
                }
            }
        }
    }
}


