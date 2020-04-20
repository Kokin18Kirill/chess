using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шахматы
{
    public static class Logik
    {
        public static int x=2, y=2;
        public static int[] RX = new int[16];
        public static int[] RY = new int[16];
        public static int[] BX = new int[16];
        public static int[] BY = new int[16];
        public static int X = 0,Y=0;
        public static void Figure_choice(ConsoleKeyInfo keyInfo, char[,] pole, int[,] pole2)
        {
            

            if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                if (x + 1 <= 9)
                {
                    x++;
                    Console.SetCursorPosition(x, y);
                }
            }
            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                if (y - 1 >= 2)
                {
                    y--;
                    Console.SetCursorPosition(x, y);
                }
            }
            if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                if (x - 1 >= 2)
                {
                    x--;
                    Console.SetCursorPosition(x, y);
                }
            }
            if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                if (y + 1 <= 9)
                {
                    y++;
                    Console.SetCursorPosition(x, y);
                }
            }
            if (keyInfo.Key == ConsoleKey.Enter)
            {
                //if ()// проверка на то кто ходит
               
                X = x-2;
                Y = y-2;
                Console.SetCursorPosition(x, y);
                if (pole2[y-2, x-2] == 0)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(' ');
                }
                if (pole2[y-2, x-2] == 1)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(' ');
                }
            }
            if (keyInfo.Key == ConsoleKey.Spacebar)
            {
                //if()// проверка на то кто ходит
                //проверка на фигуру
                Figura(pole, X, Y);
                Console.SetCursorPosition(x, y);
                if (pole2[y-2, x-2] == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(pole[Y,X]);
                    pole[y - 2, x - 2] = pole[Y, X];
                    pole[Y, X] = ' ';
                    X = 0;Y = 0;
                }
                if (pole2[y-2, x-2] == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(pole[Y, X]);
                    pole[y-2, x-2] = pole[Y, X];
                    pole[Y, X] = ' ';
                    X = 0; Y = 0;
                }
            }
        }

        public static void Figura(char[,] pole,int X,int Y)//int user
        {//проверка на играка
            switch (pole[Y, X])
            {
                case 'п':if (Math.Abs(Y - y)==2)
                    {
                        Console.SetCursorPosition(12, 2);
                        Console.WriteLine("вы не можете сделать такой ход");
                    };
                    break;
            }
        }
    }
}
