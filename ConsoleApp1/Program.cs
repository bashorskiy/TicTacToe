using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Settings
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


       
    }
    class Test
    {
        public static int[,] First(int[,] arr)
        {
            for (int i = 5; i < 9; i++)
            {
                for (int j = i; j < i+1; j++)
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
            uint defaultSize = 30;
            bool game = true;
            bool settings = true;
            while (game) 
            {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("\t \t Добро пожаловать в Крестики-Нолики на свободном поле! \n \n" +
                                            "1. Начать игру \n" +
                                           $"2. Выбрать размер поля и цвет символов \t");
            Console.Write($"\n\nСейчас: \t |Размер поля: {defaultSize}х{defaultSize}|\n\t\t |");
            Console.Write("цвет X:  " + (Console.ForegroundColor = X_currentForeground));
            Console.ResetColor();
            Console.Write("| \n\t\t |");
            Console.Write("цвет O: " + (Console.ForegroundColor = O_currentForeground));
            Console.ResetColor();
            Console.Write("|\n3. Выйти \n");
            string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Game.Play(X_currentForeground, O_currentForeground, defaultSize);
                    game = false;
                    break;
                }
                if (choice == "2")
                settings = true;
                {
                    while (settings)
                    {
                        Console.Write("Что хотите выбрать? \n" +
                                          $"1. Размер поля (сейчас {defaultSize}х{defaultSize})\n");
                        Console.Write($"2. Цвет крестиков (сейчас {Console.ForegroundColor = X_currentForeground})\n");
                        Console.ResetColor();
                        Console.Write($"3. Цвет ноликов (сейчас {Console.ForegroundColor = O_currentForeground})\n");
                        Console.ResetColor();
                        Console.WriteLine("4. Всё устраивает, хочу вернуться в меню");
                        string point = Console.ReadLine();

                        if (point == "1")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\t\t\t\t WARNING\n\t К сожалению, размер поля должен быть больше или равен 16, \n\t  иначе игра не запустится (надеемся поправить в релизе)");
                            Console.ResetColor();
                            Console.WriteLine($" \n \t \t\t(сейчас размер поля {defaultSize}х{defaultSize})\n\nВведите новый размер поля: \t ");
                            bool correctSize = uint.TryParse(Console.ReadLine(), out uint newsize);
                            if (correctSize & newsize >= 16)
                            {
                                defaultSize = newsize;
                                
                            }
                            else
                            {
                                Console.WriteLine("Такой размер, к сожалению, недопустим");
                                
                            }
                        }
                        if (point == "2")
                        {
                            X_currentForeground = Settings.ColorSet(colors, X_currentForeground);
                            
                        }
                        if (point == "3")
                        {
                            O_currentForeground = Settings.ColorSet(colors, O_currentForeground);
                           
                        }
                        if (point == "4")
                        {
                            settings = false;      
                        }
                        else
                        {           
                            settings = false;
                        }
                    }
                }
                if (choice == "3")
                {
                    Console.WriteLine("Спасибо за игру! Пока!");
                    Console.ReadKey();
                    game = false;
                }
                else
                {
                    settings = false;
                }
     
                
            }
        }
    }

}


