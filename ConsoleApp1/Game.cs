using System;

namespace TicTacToe
{

    class Game
    {
        static readonly int limit = 5;
        static bool win;
        static int x, y;
        static int currentSymbolCode; // 1 = Х, 2=0, 3 = | |
        static bool player = true;

        public static int CoordX(int[,] userfield)
        {
            Console.Write($"Введите координату");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" X ");
            Console.ResetColor();
            Console.WriteLine($"в промежутке от {(userfield.GetLowerBound(0) + 1)}" + " до " + $"{(userfield.GetUpperBound(0) - 1)}");
            x = int.Parse(Console.ReadLine());
            return x;
        }
        public static int CoordY(int[,] userfield)
        {
            Console.Write($"Введите координату");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" Y ");
            Console.ResetColor();
            Console.WriteLine($"в промежутке от {(userfield.GetLowerBound(0) + 1)}" + " до " + $"{(userfield.GetUpperBound(0) - 1)}");
            y = int.Parse(Console.ReadLine());
            return y;
        }

        public static void ResetArray(int[,] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = 3;
                }
        }

        public static bool WinCheck(int[,] field, int x, int y, int symbolCode)
        {
            bool winFlag = false;
            int vector_x, vector_y, innerCounter = 1;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    if ((i != 0) | (j != 0))
                    {
                        if (field[x + i, y + j] == symbolCode)
                        {
                            innerCounter += 1;

                            vector_x = i;

                            vector_y = j;

                            if (VectorWinCheck(field, x, y, vector_x, vector_y, innerCounter, symbolCode))
                            {
                                winFlag = true;
                                break;
                            }
                            else
                            {
                                innerCounter = 1;
                            }
                        }
                    }
                }
            }
            return winFlag;
        }

        public static bool VectorWinCheck(int[,] field, int x, int y, int vect_x, int vect_y, int count, int symbolNumber)
        {
            bool enough = false;
            int vectModule = 2;
            while (count < limit)
            {
                if (field[x + vect_x * vectModule, y + vect_y * vectModule] == symbolNumber)
                {
                    count++;
                    vectModule++;
                }
                else
                {
                    break;
                }
            }

            vectModule = 1; // сбрасываем модуль

            while (count < limit)
            {
                if (field[x + (vect_x * (-vectModule)), y + (vect_y * (-vectModule))] == symbolNumber)
                {
                    count++;
                    vectModule++;
                }
                else
                {
                    break;
                }
            }
            if (count == limit)
            {
                enough = true;
            }

            return enough;
        }

        public static void Play(ConsoleColor X_ColorMain, ConsoleColor O_ColorMain, uint fieldsize)
        {
            int[,] userfield = new int[fieldsize, fieldsize];
            string control = "1";
            while (control.Equals("1"))
            {
                win = false;
                player = true;
                ResetArray(userfield);
                Console.Clear();             
                Printer.PrintTicFieldNext(userfield, X_ColorMain, O_ColorMain);
                while (!win)
                {
                    if (player)
                    {
                        Console.WriteLine("Ходит первый игрок!");
                        currentSymbolCode = 1;
                    }
                    else
                    {
                        Console.WriteLine("Ходит второй игрок!");
                        currentSymbolCode = 2;
                    }
                    while (true)
                    {
                        try
                        {
                            x = CoordX(userfield);
                            y = CoordY(userfield);

                            if (userfield[x, y] == 3 &
                                x >= (userfield.GetLowerBound(0) + 1) &
                                x <= (userfield.GetUpperBound(0) - 1) &
                                y >= (userfield.GetLowerBound(0) + 1) &
                                y <= (userfield.GetUpperBound(1) - 1))
                            {
                                userfield[x, y] = currentSymbolCode;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Извините, но сюда нельзя поставить ваш символ");
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Поле не предусмотрено для таких значений");
                            continue;
                        }
                    }
                    Printer.PrintTicFieldNext(userfield, X_ColorMain, O_ColorMain);
                    win = WinCheck(userfield, x, y, currentSymbolCode);
                    player = !player;
                }
                if (!player)
                {
                    Console.ForegroundColor = X_ColorMain;
                    Console.WriteLine("Первый игрок победил!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = O_ColorMain;
                    Console.WriteLine("Второй игрок победил!");
                    Console.ResetColor();
                }
                Console.WriteLine("Сыграете ещё раз или выйдете в меню?\n\r 1. Сыграть ещё раз \n 2. Выйти в меню");
                control = Console.ReadLine();
            }
        }
    }
}



