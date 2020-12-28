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

        public static void Play(ConsoleColor X_ColorMain, ConsoleColor O_ColorMain, uint fieldsize )
        {
                int[,] userfield = new int[fieldsize, fieldsize];
                string control = "y";
                while (control.Equals("y"))
                {
                    win = false;
                    player = true;
                    ResetArray(userfield);
                    Console.Clear();
                    //Test.First(userfield);
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
                                Console.WriteLine($"Введите координату Х в промежутке от {(userfield.GetLowerBound(0) + 5)}" + " до " + $"{(userfield.GetUpperBound(0) - 6)}");
                                x = int.Parse(Console.ReadLine());
                                Console.WriteLine($"Введите координату Y в промежутке от {(userfield.GetLowerBound(1) + 5)}" + " до " + $"{(userfield.GetUpperBound(1) - 6)}");
                                y = int.Parse(Console.ReadLine());

                                if (userfield[x, y] == 3& 
                                    x>= (userfield.GetLowerBound(0) + 5) & 
                                    x<=(userfield.GetUpperBound(0) - 6)& 
                                    y>= (userfield.GetLowerBound(0) + 5)& 
                                    y<=(userfield.GetUpperBound(1) - 6))
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
                        Printer.PrintTicField(userfield, 5, userfield.GetLength(0) - 7, X_ColorMain, O_ColorMain);
                        win = WinCheck(userfield,x,y,currentSymbolCode);
                        player = !player;
                    }
                    if(!player)
                    { Console.WriteLine("Первый игрок подебил!"); }
                    else
                    { Console.WriteLine("Второй игрок подебил!"); }
                    Console.WriteLine("Сыграете заново?\n\r y/n");
                    control = Console.ReadLine();
                }
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
            int vector_x, vector_y, innerCounter = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    if ((i != 0) | (j != 0))
                    {
                        if (field[x + i,y + j] == symbolCode)
                        {
                            innerCounter += 1;
                            
                            vector_x = i;
                            
                            vector_y = j;
                           
                            if (VectorWinCheck(field, x, y, vector_x, vector_y, innerCounter, symbolCode))
                            {
                                winFlag = true;
                                break;
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
            int vectModule = 1;
            while (count < limit)
            {
                if (field[x + vect_x * vectModule,y + vect_y * vectModule] == symbolNumber)
                {
                    count++;
                    vectModule ++;
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
                if (count >= limit)
                {
                    enough = true;
                }
            

            return enough;
        }

    }

}



